using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Info
{
    public partial class Showcsv : Form
    {
        public Showcsv()
        {
            InitializeComponent();
        }

        private void Showcsv_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog control
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Select a CSV File";

            // Show the OpenFileDialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a DataTable to hold the CSV data
                DataTable dataTable = new DataTable();

                // Read the contents of the CSV file into the DataTable
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    string[] headers = streamReader.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!streamReader.EndOfStream)
                    {
                        string[] rows = streamReader.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                // Assign the DataTable as the DataSource of the DataGridView
                DgvShowCsv.DataSource = dataTable;
            }
        }
    }
}
