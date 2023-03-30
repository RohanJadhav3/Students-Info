
namespace Students_Info
{
    partial class Showcsv
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
            this.Txtcsv = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.DgvShowCsv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowCsv)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtcsv
            // 
            this.Txtcsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtcsv.Location = new System.Drawing.Point(12, 12);
            this.Txtcsv.Name = "Txtcsv";
            this.Txtcsv.Size = new System.Drawing.Size(625, 22);
            this.Txtcsv.TabIndex = 0;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.Location = new System.Drawing.Point(654, 12);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(202, 32);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // DgvShowCsv
            // 
            this.DgvShowCsv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvShowCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShowCsv.Location = new System.Drawing.Point(12, 59);
            this.DgvShowCsv.Name = "DgvShowCsv";
            this.DgvShowCsv.RowHeadersVisible = false;
            this.DgvShowCsv.RowHeadersWidth = 51;
            this.DgvShowCsv.RowTemplate.Height = 24;
            this.DgvShowCsv.Size = new System.Drawing.Size(844, 596);
            this.DgvShowCsv.TabIndex = 2;
            // 
            // Showcsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 667);
            this.Controls.Add(this.DgvShowCsv);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.Txtcsv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(886, 714);
            this.MinimumSize = new System.Drawing.Size(886, 714);
            this.Name = "Showcsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV";
            this.Load += new System.EventHandler(this.Showcsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowCsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcsv;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.DataGridView DgvShowCsv;
    }
}