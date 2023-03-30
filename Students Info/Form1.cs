using Students_Info.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Students_Info
{

    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
        int id = 0;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter("Display_Data", con);

            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.Fill(dt);

            DgvStudent.DataSource = dt;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (*.png; *.jpg; *.jpeg; *.bmp;) | *.png; *.jpg; *.jpeg; *.bmp; | All FIles(*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = ofd.FileName;
                PicStudent.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                return;
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.Text == "Save")
            {
                if (TxtRollNo.Text != "" && TxtName.Text != "" && TxtAge.Text != "" && CmbCategory.SelectedItem != null && TxtAddress.Text != "")
                {
                    string Gender = "";
                    //tring Query = "insert into StudentData values(@rollno,@name,@age,@gender,@dob,@category,@address,@picture)";
                    cmd = new SqlCommand("Studet_Add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@rollno", TxtRollNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", TxtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", TxtAge.Text.Trim());
                    if (RbtMale.Checked == true)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@dob", Dtpdob.Value);
                    cmd.Parameters.AddWithValue("@category", CmbCategory.SelectedItem);
                    cmd.Parameters.AddWithValue("@address", TxtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@picture", TxtPath.Text.Trim());

                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Inserted Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                        Clearcontrols();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            else
            {
                if (TxtRollNo.Text != "" || TxtName.Text != "" || TxtAge.Text != "" || CmbCategory.SelectedItem != null || TxtAddress.Text != "")
                {
                    string Gender = "";

                    cmd = new SqlCommand("Studens_Update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@rollno", TxtRollNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", TxtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", TxtAge.Text.Trim());
                    if (RbtMale.Checked == true)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(Dtpdob.Value));
                    cmd.Parameters.AddWithValue("@category", CmbCategory.SelectedItem);
                    cmd.Parameters.AddWithValue("@address", TxtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@picture", TxtPath.Text.Trim());

                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                        Clearcontrols();
                        BtnSave.Text = "Save";
                    }
                    else
                    {
                        MessageBox.Show("Failed To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Clearcontrols()
        {
            TxtRollNo.Text = String.Empty;
            TxtName.Text = String.Empty;
            TxtAge.Text = String.Empty;
            CmbCategory.SelectedItem = null;
            PicStudent.Image = Resources.upload;
            RbtMale.Checked = false;
            RbtFemale.Checked = false;
            TxtAddress.Text = string.Empty;
            Dtpdob.Value = DateTime.Now;
            BtnSave.Text = "Save";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clearcontrols();
        }




        private void DgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                id = Convert.ToInt32(DgvStudent.Rows[e.RowIndex].Cells[2].Value);
                TxtRollNo.Text = DgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtName.Text = DgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtAge.Text = DgvStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                string gender = DgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (gender == "Male")
                {
                    RbtMale.Checked = true;
                }
                else
                {
                    RbtFemale.Checked = true;
                }
                Dtpdob.Text = DgvStudent.Rows[e.RowIndex].Cells[7].Value.ToString();
                CmbCategory.Text = DgvStudent.Rows[e.RowIndex].Cells[8].Value.ToString();
                TxtAddress.Text = DgvStudent.Rows[e.RowIndex].Cells[9].Value.ToString();
                TxtPath.Text = DgvStudent.Rows[e.RowIndex].Cells[10].Value.ToString();
                PicStudent.Image = Image.FromFile(TxtPath.Text);
                BtnSave.Text = "Update";
            }

            if (e.ColumnIndex == 1)
            {

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete..?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    id = Convert.ToInt32(DgvStudent.Rows[e.RowIndex].Cells[2].Value);
                    cmd = new SqlCommand("Student_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);


                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Deleted Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                        Clearcontrols();
                        BtnSave.Text = "Save";
                    }
                    else
                    {
                        MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }

            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void TxtRollNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }
        }

        private void TxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {

                e.Handled = true;
            }
        }

        private void Showcsv_Click(object sender, EventArgs e)
        {
            Showcsv scv = new Showcsv();
            scv.Show();
        }

        private void BtnExportCsvFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the SaveFileDialog control
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save as CSV";

            // Show the SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Specify the file path and name where the CSV file will be saved
                string filePath = saveFileDialog.FileName;

                // Open the file for writing
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the headers for the columns that you want to export
                    for (int i = 3; i < DgvStudent.Columns.Count - 1; i++)
                    {
                        sw.Write(DgvStudent.Columns[i].HeaderText);
                        sw.Write(",");
                    }
                    sw.WriteLine();

                    // Write the data for each row in the DataGridView
                    foreach (DataGridViewRow row in DgvStudent.Rows)
                    {
                        // Skip any rows that are not visible or are the new row
                        if (!row.Visible || row.IsNewRow)
                        {
                            continue;
                        }

                        // Write the data for each cell in the row, skipping the first 3 and last column
                        for (int i = 3; i < row.Cells.Count - 1; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("CSV file exported successfully!");

            }
        }

        private void BtnGetCsv_Click(object sender, EventArgs e)
        {
            Showcsv scv = new Showcsv();
            scv.Show();
        }
    }
}
