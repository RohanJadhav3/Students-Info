
namespace Students_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtRollNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtpdob = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.DgvStudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.PicStudent = new System.Windows.Forms.PictureBox();
            this.BtnExportCsvFile = new System.Windows.Forms.Button();
            this.BtnGetCsv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 58);
            this.panel1.TabIndex = 0;
            // 
            // TxtRollNo
            // 
            this.TxtRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRollNo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRollNo.Location = new System.Drawing.Point(169, 91);
            this.TxtRollNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRollNo.Name = "TxtRollNo";
            this.TxtRollNo.Size = new System.Drawing.Size(247, 28);
            this.TxtRollNo.TabIndex = 0;
            this.TxtRollNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRollNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roll Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(16, 192);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(50, 21);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(169, 142);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(247, 28);
            this.TxtName.TabIndex = 1;
            // 
            // TxtAge
            // 
            this.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAge.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(169, 195);
            this.TxtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAge.MaxLength = 3;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(247, 28);
            this.TxtAge.TabIndex = 2;
            this.TxtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge_KeyPress);
            // 
            // RbtMale
            // 
            this.RbtMale.AutoSize = true;
            this.RbtMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtMale.Location = new System.Drawing.Point(169, 246);
            this.RbtMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtMale.Name = "RbtMale";
            this.RbtMale.Size = new System.Drawing.Size(63, 21);
            this.RbtMale.TabIndex = 3;
            this.RbtMale.TabStop = true;
            this.RbtMale.Text = "Male";
            this.RbtMale.UseVisualStyleBackColor = true;
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtFemale.Location = new System.Drawing.Point(246, 246);
            this.RbtFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtFemale.Name = "RbtFemale";
            this.RbtFemale.Size = new System.Drawing.Size(81, 21);
            this.RbtFemale.TabIndex = 4;
            this.RbtFemale.TabStop = true;
            this.RbtFemale.Text = "Female";
            this.RbtFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "DOB :";
            // 
            // Dtpdob
            // 
            this.Dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtpdob.Location = new System.Drawing.Point(169, 296);
            this.Dtpdob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtpdob.Name = "Dtpdob";
            this.Dtpdob.Size = new System.Drawing.Size(124, 28);
            this.Dtpdob.TabIndex = 5;
            this.Dtpdob.Value = new System.DateTime(2023, 3, 27, 12, 25, 18, 0);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(436, 455);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(89, 28);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(531, 455);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(69, 28);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(511, 345);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(320, 45);
            this.BtnBrowse.TabIndex = 8;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(707, 69);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(124, 28);
            this.TxtPath.TabIndex = 7;
            this.TxtPath.Visible = false;
            // 
            // DgvStudent
            // 
            this.DgvStudent.AllowUserToAddRows = false;
            this.DgvStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.id_Col,
            this.rollno,
            this.name,
            this.Student_Age,
            this.gender,
            this.dob,
            this.category,
            this.address,
            this.picture});
            this.DgvStudent.Location = new System.Drawing.Point(0, 522);
            this.DgvStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvStudent.Name = "DgvStudent";
            this.DgvStudent.ReadOnly = true;
            this.DgvStudent.RowHeadersVisible = false;
            this.DgvStudent.RowHeadersWidth = 51;
            this.DgvStudent.RowTemplate.Height = 24;
            this.DgvStudent.Size = new System.Drawing.Size(854, 268);
            this.DgvStudent.TabIndex = 11;
            this.DgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 63.57694F;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 51;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 63.57694F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 52;
            // 
            // id_Col
            // 
            this.id_Col.DataPropertyName = "id";
            this.id_Col.HeaderText = "id";
            this.id_Col.MinimumWidth = 6;
            this.id_Col.Name = "id_Col";
            this.id_Col.ReadOnly = true;
            this.id_Col.Visible = false;
            this.id_Col.Width = 69;
            // 
            // rollno
            // 
            this.rollno.DataPropertyName = "rollno";
            this.rollno.FillWeight = 427.8075F;
            this.rollno.HeaderText = "Roll No";
            this.rollno.MinimumWidth = 6;
            this.rollno.Name = "rollno";
            this.rollno.ReadOnly = true;
            this.rollno.Width = 90;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 63.57694F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 120;
            // 
            // Student_Age
            // 
            this.Student_Age.DataPropertyName = "Age";
            this.Student_Age.FillWeight = 63.57694F;
            this.Student_Age.HeaderText = "Age";
            this.Student_Age.MinimumWidth = 6;
            this.Student_Age.Name = "Student_Age";
            this.Student_Age.ReadOnly = true;
            this.Student_Age.Width = 52;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.FillWeight = 63.57694F;
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.FillWeight = 63.57694F;
            this.dob.HeaderText = "Dob";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 125;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 63.57694F;
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 120;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 63.57694F;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // picture
            // 
            this.picture.DataPropertyName = "picture";
            this.picture.FillWeight = 63.57694F;
            this.picture.HeaderText = "Picture";
            this.picture.MinimumWidth = 6;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            this.picture.Visible = false;
            this.picture.Width = 48;
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "General",
            "Sc/St",
            "Obc"});
            this.CmbCategory.Location = new System.Drawing.Point(169, 355);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(247, 29);
            this.CmbCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Category :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Address :";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(169, 415);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(247, 83);
            this.TxtAddress.TabIndex = 7;
            // 
            // PicStudent
            // 
            this.PicStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicStudent.Image = ((System.Drawing.Image)(resources.GetObject("PicStudent.Image")));
            this.PicStudent.Location = new System.Drawing.Point(511, 105);
            this.PicStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicStudent.Name = "PicStudent";
            this.PicStudent.Size = new System.Drawing.Size(320, 232);
            this.PicStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicStudent.TabIndex = 5;
            this.PicStudent.TabStop = false;
            // 
            // BtnExportCsvFile
            // 
            this.BtnExportCsvFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportCsvFile.Location = new System.Drawing.Point(606, 480);
            this.BtnExportCsvFile.Name = "BtnExportCsvFile";
            this.BtnExportCsvFile.Size = new System.Drawing.Size(111, 35);
            this.BtnExportCsvFile.TabIndex = 12;
            this.BtnExportCsvFile.Text = "Export Csv";
            this.BtnExportCsvFile.UseVisualStyleBackColor = true;
            this.BtnExportCsvFile.Click += new System.EventHandler(this.BtnExportCsvFile_Click);
            // 
            // BtnGetCsv
            // 
            this.BtnGetCsv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetCsv.Location = new System.Drawing.Point(723, 480);
            this.BtnGetCsv.Name = "BtnGetCsv";
            this.BtnGetCsv.Size = new System.Drawing.Size(119, 35);
            this.BtnGetCsv.TabIndex = 13;
            this.BtnGetCsv.Text = "Show Csv";
            this.BtnGetCsv.UseVisualStyleBackColor = true;
            this.BtnGetCsv.Click += new System.EventHandler(this.BtnGetCsv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 794);
            this.Controls.Add(this.BtnGetCsv);
            this.Controls.Add(this.BtnExportCsvFile);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.DgvStudent);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PicStudent);
            this.Controls.Add(this.Dtpdob);
            this.Controls.Add(this.RbtFemale);
            this.Controls.Add(this.RbtMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtRollNo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(872, 886);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtRollNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtpdob;
        private System.Windows.Forms.PictureBox PicStudent;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.DataGridView DgvStudent;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
        private System.Windows.Forms.Button BtnExportCsvFile;
        private System.Windows.Forms.Button BtnGetCsv;
    }
}

