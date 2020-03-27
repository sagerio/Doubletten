using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Doubletten
{
	public partial class Form1 : Form
	{
		private readonly Hashtable table = new Hashtable();
		private List<string> files = new List<string>();
		private readonly MD5 md5 = MD5.Create();
		private DataTable dataTable;
		int gesamt = 0;

		//public Containers Containers { get; set; } = new Containers();

		public Form1()
		{
			InitializeComponent();
			progressBar.Value = 0;
			gesamt = 0;
			#if DEBUG
				txtPath.Text = @"C:\Users\rsage\Downloads";
				btnScan.Enabled = true;
			#endif
			createDataTable();
		}


		private void btnDirectory_Click(object sender, EventArgs e)
		{
			var dialog = new FolderBrowserDialog();
			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtPath.Text = dialog.SelectedPath;
				btnScan.Enabled = true;
			}
		}


		private void btnScan_Click(object sender, EventArgs e)
		{
			if ( !this.backgroundWorker.IsBusy )
			{
				btnDirectory.Enabled = btnScan.Enabled = false;
				UseWaitCursor = btnStop.Enabled = true;
				Cursor.Current = Cursors.WaitCursor;
				backgroundWorker.RunWorkerAsync();
			}
		}

		private async void Fire()
		{
			MessageBox.Show( (await Test()).ToString() );
		}

		private async Task<int> Test()
		{
			await Task.Delay(3000);
			return 5;
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			files = Directory.GetFiles(txtPath.Text, "*.*", SearchOption.AllDirectories).ToList();
			gesamt = files.Count;
			int counter = 0;
			int duplicates = 0;
			foreach (string f in files)
			{
				using (FileStream stream = File.OpenRead(f))
				{
					string md5hash = Bytes2String(md5.ComputeHash(stream));
					if (table.ContainsKey(md5hash))
					{
						duplicates += 1;
						string file = table[md5hash] as string;
						dataTable.Rows.Add(new object[] {file, f, md5hash});
						//Containers.Add( new Container() {
						//	file1 = file,
						//	file2 = f,
						//	hash = md5hash
						//});
					}
					else
					{
						table.Add(md5hash, f);
					}
					stream.Close();
				}
				backgroundWorker.ReportProgress( (++counter / gesamt) * 100 );
				if ( backgroundWorker.CancellationPending )
				{
					return;
				}
			}
			e.Result = duplicates;
		}


		private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBar.Value = e.ProgressPercentage;
		}


		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnDirectory.Enabled = btnScan.Enabled = Enabled = true;
			UseWaitCursor = btnStop.Enabled = false;
			Cursor.Current = Cursors.Default;
			lblTotal.Text = $"{gesamt} files total";
			lblDuplicates.Text = $"{e.Result ?? 0} duplicates";
		}


		private string Bytes2String(byte[] arr) => BitConverter.ToString(arr).Replace("-", "").ToLower();


		private void createDataTable()
		{
			dataTable = new DataTable();

			// Add columns to the DataTable.
			dataTable.Columns.Add("File 1", Type.GetType("System.String"));
			dataTable.Columns.Add("File 2", Type.GetType("System.String"));
			dataTable.Columns.Add("Hash", Type.GetType("System.String"));

			// Make all columns required.
			for (int i = 0; i < dataTable.Columns.Count; i++)
			{
				dataTable.Columns[i].AllowDBNull = false;
			}

			DataColumn[] unique_cols = { dataTable.Columns["Hash"] };
			dataTable.Constraints.Add(new UniqueConstraint(unique_cols));

			// Add items to the table.
			//dataTable.Rows.Add(new object[]
			//		{"Rod", "Stephens", "Nerd"});
			//dataTable.Rows.Add(new object[]
			//		{"Sergio", "Aragones", "Cartoonist"});
			//dataTable.Rows.Add(new object[]
			//		{"Eoin", "Colfer", "Author"});
			//dataTable.Rows.Add(new object[]
			//		{"Terry", "Pratchett", "AnotherAuthor"});

			// Make the DataGridView use the DataTable as its data source.
			dataGridView.DataSource = dataTable;
		}


		private void btnStop_Click(object sender, EventArgs e)
		{
			Fire();
  		//backgroundWorker.CancelAsync();
		}

	}
}
