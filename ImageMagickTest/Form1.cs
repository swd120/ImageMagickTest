using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using ImageMagick;

namespace ImageMagickTest
{
	public partial class Form1 : Form
	{
		private string testFile;
		private string magickCacheDirectory;

		public Form1()
		{
			InitializeComponent();
			this.magickCacheDirectory = Path.Combine(Directory.GetCurrentDirectory(), "MagickTemp");
			this.testFile = Path.Combine(Directory.GetCurrentDirectory(), "TestFile.tif");
			Directory.CreateDirectory(magickCacheDirectory);
			magickCacheDirectoryWatcher.Path = magickCacheDirectory;
			MagickNET.SetTempDirectory(magickCacheDirectory);
		}

		private void magickCacheDirectoryWatcher_Changed(object sender, FileSystemEventArgs e)
		{
			cacheFileCountValueLabel.Text = Directory.GetFiles(this.magickCacheDirectory).Length.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void TestBtn_Click(object sender, EventArgs e)
		{
			TestBtn.Enabled = false;
			TestBtn.Text = "Processing...";

			var model = new WorkModel
			{
				TestFilePath = this.testFile,
				IndexOutBounds = indexOutBoundRdo.Checked,
				FrameCountOutBounds = frameCountOutBoundsRdo.Checked,
				UseConstructor = useContructorRdo.Checked
			};

			backgroundWorker.RunWorkerAsync(model);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var model = (WorkModel)e.Argument;

			var readSettings = new MagickReadSettings
			{
				FrameCount = model.FrameCountOutBounds ? 10 : 5,
				FrameIndex = model.IndexOutBounds ? 100 : 90
			};

			var result = new WorkResult();

			if (model.UseConstructor)
			{
				using (var collection = new MagickImageCollection(model.TestFilePath, readSettings))
				{
					result.ImageCount = collection.Count;
				}
			}
			else
			{
				using (var collection = new MagickImageCollection())
				{
					collection.Read(model.TestFilePath, readSettings);
					result.ImageCount = collection.Count;
				}
			}

			e.Result = result;
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			TestBtn.Enabled = true;
			TestBtn.Text = "Test";
			var resultModel = (WorkResult)e.Result;
			imageCountValueLbl.Text = resultModel.ImageCount.ToString();
			cacheFileCountValueLabel.Text = Directory.GetFiles(this.magickCacheDirectory).Length.ToString();
		}
	}
}
