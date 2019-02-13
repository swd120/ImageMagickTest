namespace ImageMagickTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.magickCacheDirectoryWatcher = new System.IO.FileSystemWatcher();
			this.label1 = new System.Windows.Forms.Label();
			this.cacheFileCountValueLabel = new System.Windows.Forms.Label();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.TestBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.useContructorRdo = new System.Windows.Forms.RadioButton();
			this.useReadRdo = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.indexOutBoundRdo = new System.Windows.Forms.RadioButton();
			this.InBoundsRdo = new System.Windows.Forms.RadioButton();
			this.imageCountValueLbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.frameCountOutBoundsRdo = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.magickCacheDirectoryWatcher)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// magickCacheDirectoryWatcher
			// 
			this.magickCacheDirectoryWatcher.EnableRaisingEvents = true;
			this.magickCacheDirectoryWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
			this.magickCacheDirectoryWatcher.SynchronizingObject = this;
			this.magickCacheDirectoryWatcher.Changed += new System.IO.FileSystemEventHandler(this.magickCacheDirectoryWatcher_Changed);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cache File Count:";
			// 
			// cacheFileCountValueLabel
			// 
			this.cacheFileCountValueLabel.AutoSize = true;
			this.cacheFileCountValueLabel.Location = new System.Drawing.Point(109, 9);
			this.cacheFileCountValueLabel.Name = "cacheFileCountValueLabel";
			this.cacheFileCountValueLabel.Size = new System.Drawing.Size(0, 13);
			this.cacheFileCountValueLabel.TabIndex = 1;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// TestBtn
			// 
			this.TestBtn.Location = new System.Drawing.Point(15, 162);
			this.TestBtn.Name = "TestBtn";
			this.TestBtn.Size = new System.Drawing.Size(75, 23);
			this.TestBtn.TabIndex = 2;
			this.TestBtn.Text = "Test";
			this.TestBtn.UseVisualStyleBackColor = true;
			this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.useReadRdo);
			this.groupBox1.Controls.Add(this.useContructorRdo);
			this.groupBox1.Location = new System.Drawing.Point(15, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Read Method";
			// 
			// useContructorRdo
			// 
			this.useContructorRdo.AutoSize = true;
			this.useContructorRdo.Checked = true;
			this.useContructorRdo.Location = new System.Drawing.Point(18, 33);
			this.useContructorRdo.Name = "useContructorRdo";
			this.useContructorRdo.Size = new System.Drawing.Size(101, 17);
			this.useContructorRdo.TabIndex = 0;
			this.useContructorRdo.TabStop = true;
			this.useContructorRdo.Text = "Use Constructor";
			this.useContructorRdo.UseVisualStyleBackColor = true;
			// 
			// useReadRdo
			// 
			this.useReadRdo.AutoSize = true;
			this.useReadRdo.Location = new System.Drawing.Point(18, 57);
			this.useReadRdo.Name = "useReadRdo";
			this.useReadRdo.Size = new System.Drawing.Size(73, 17);
			this.useReadRdo.TabIndex = 1;
			this.useReadRdo.Text = "Use Read";
			this.useReadRdo.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.frameCountOutBoundsRdo);
			this.groupBox2.Controls.Add(this.indexOutBoundRdo);
			this.groupBox2.Controls.Add(this.InBoundsRdo);
			this.groupBox2.Location = new System.Drawing.Point(232, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 123);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Image Selection";
			// 
			// indexOutBoundRdo
			// 
			this.indexOutBoundRdo.AutoSize = true;
			this.indexOutBoundRdo.Location = new System.Drawing.Point(18, 57);
			this.indexOutBoundRdo.Name = "indexOutBoundRdo";
			this.indexOutBoundRdo.Size = new System.Drawing.Size(122, 17);
			this.indexOutBoundRdo.TabIndex = 1;
			this.indexOutBoundRdo.Text = "Index Out of Bounds";
			this.indexOutBoundRdo.UseVisualStyleBackColor = true;
			// 
			// InBoundsRdo
			// 
			this.InBoundsRdo.AutoSize = true;
			this.InBoundsRdo.Checked = true;
			this.InBoundsRdo.Location = new System.Drawing.Point(18, 33);
			this.InBoundsRdo.Name = "InBoundsRdo";
			this.InBoundsRdo.Size = new System.Drawing.Size(73, 17);
			this.InBoundsRdo.TabIndex = 0;
			this.InBoundsRdo.TabStop = true;
			this.InBoundsRdo.Text = "In Bounds";
			this.InBoundsRdo.UseVisualStyleBackColor = true;
			// 
			// imageCountValueLbl
			// 
			this.imageCountValueLbl.AutoSize = true;
			this.imageCountValueLbl.Location = new System.Drawing.Point(287, 9);
			this.imageCountValueLbl.Name = "imageCountValueLbl";
			this.imageCountValueLbl.Size = new System.Drawing.Size(0, 13);
			this.imageCountValueLbl.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(190, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Image Count:";
			// 
			// frameCountOutBoundsRdo
			// 
			this.frameCountOutBoundsRdo.AutoSize = true;
			this.frameCountOutBoundsRdo.Location = new System.Drawing.Point(18, 83);
			this.frameCountOutBoundsRdo.Name = "frameCountOutBoundsRdo";
			this.frameCountOutBoundsRdo.Size = new System.Drawing.Size(153, 17);
			this.frameCountOutBoundsRdo.TabIndex = 2;
			this.frameCountOutBoundsRdo.Text = "FrameCount Out of Bounds";
			this.frameCountOutBoundsRdo.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 238);
			this.Controls.Add(this.imageCountValueLbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TestBtn);
			this.Controls.Add(this.cacheFileCountValueLabel);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.magickCacheDirectoryWatcher)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.FileSystemWatcher magickCacheDirectoryWatcher;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label cacheFileCountValueLabel;
		private System.Windows.Forms.Button TestBtn;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton indexOutBoundRdo;
		private System.Windows.Forms.RadioButton InBoundsRdo;
		private System.Windows.Forms.RadioButton useReadRdo;
		private System.Windows.Forms.RadioButton useContructorRdo;
		private System.Windows.Forms.Label imageCountValueLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton frameCountOutBoundsRdo;
	}
}

