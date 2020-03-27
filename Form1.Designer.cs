namespace Doubletten
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPath = new System.Windows.Forms.TextBox();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblDuplicates = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.file1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.file2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnStop = new Doubletten.MyButton();
			this.btnScan = new Doubletten.MyButton();
			this.btnDirectory = new Doubletten.MyButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(145, 18);
			this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(756, 25);
			this.txtPath.TabIndex = 1;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar.Location = new System.Drawing.Point(0, 478);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(944, 23);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 4;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(6, 25);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 17);
			this.lblTotal.TabIndex = 5;
			// 
			// lblDuplicates
			// 
			this.lblDuplicates.AutoSize = true;
			this.lblDuplicates.Location = new System.Drawing.Point(6, 25);
			this.lblDuplicates.Name = "lblDuplicates";
			this.lblDuplicates.Size = new System.Drawing.Size(0, 17);
			this.lblDuplicates.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTotal);
			this.groupBox1.Location = new System.Drawing.Point(14, 125);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(112, 56);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files total";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblDuplicates);
			this.groupBox2.Location = new System.Drawing.Point(14, 211);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(112, 56);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Duplicates";
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file1,
            this.file2,
            this.hash});
			this.dataGridView.Location = new System.Drawing.Point(145, 53);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(756, 419);
			this.dataGridView.TabIndex = 9;
			// 
			// file1
			// 
			this.file1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.file1.DataPropertyName = "File 1";
			this.file1.HeaderText = "File 1";
			this.file1.Name = "file1";
			this.file1.ReadOnly = true;
			this.file1.Width = 250;
			// 
			// file2
			// 
			this.file2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.file2.DataPropertyName = "File 2";
			this.file2.HeaderText = "File 2";
			this.file2.Name = "file2";
			this.file2.ReadOnly = true;
			this.file2.Width = 250;
			// 
			// hash
			// 
			this.hash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.hash.DataPropertyName = "hash";
			this.hash.HeaderText = "Hash";
			this.hash.Name = "hash";
			this.hash.ReadOnly = true;
			this.hash.Width = 62;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(14, 288);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(112, 56);
			this.btnStop.TabIndex = 10;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnScan
			// 
			this.btnScan.Enabled = false;
			this.btnScan.Location = new System.Drawing.Point(14, 53);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(112, 56);
			this.btnScan.TabIndex = 2;
			this.btnScan.Text = "Scan";
			this.btnScan.UseVisualStyleBackColor = true;
			this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
			// 
			// btnDirectory
			// 
			this.btnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDirectory.Location = new System.Drawing.Point(907, 17);
			this.btnDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDirectory.Name = "btnDirectory";
			this.btnDirectory.Size = new System.Drawing.Size(25, 25);
			this.btnDirectory.TabIndex = 0;
			this.btnDirectory.Text = "...";
			this.btnDirectory.UseVisualStyleBackColor = true;
			this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btnScan);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnDirectory);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doubletten";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MyButton btnDirectory;
		private System.Windows.Forms.TextBox txtPath;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private MyButton btnScan;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblDuplicates;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn file1;
		private System.Windows.Forms.DataGridViewTextBoxColumn file2;
		private System.Windows.Forms.DataGridViewTextBoxColumn hash;
		private MyButton btnStop;
	}
}

