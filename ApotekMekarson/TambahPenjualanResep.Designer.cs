namespace ApotekMekarson
{
    partial class TambahPenjualanResep
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDResep = new System.Windows.Forms.TextBox();
            this.dtpTanggalJual = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaDokter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuatBaru = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Resep :";
            // 
            // tbIDResep
            // 
            this.tbIDResep.Location = new System.Drawing.Point(120, 5);
            this.tbIDResep.Name = "tbIDResep";
            this.tbIDResep.ReadOnly = true;
            this.tbIDResep.Size = new System.Drawing.Size(134, 20);
            this.tbIDResep.TabIndex = 1;
            // 
            // dtpTanggalJual
            // 
            this.dtpTanggalJual.Location = new System.Drawing.Point(120, 31);
            this.dtpTanggalJual.Name = "dtpTanggalJual";
            this.dtpTanggalJual.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalJual.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Penjualan :";
            // 
            // tbNamaDokter
            // 
            this.tbNamaDokter.Location = new System.Drawing.Point(120, 57);
            this.tbNamaDokter.Name = "tbNamaDokter";
            this.tbNamaDokter.Size = new System.Drawing.Size(134, 20);
            this.tbNamaDokter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Dokter :";
            // 
            // btnBuatBaru
            // 
            this.btnBuatBaru.Location = new System.Drawing.Point(164, 83);
            this.btnBuatBaru.Name = "btnBuatBaru";
            this.btnBuatBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBuatBaru.TabIndex = 6;
            this.btnBuatBaru.Text = "Buat Baru";
            this.btnBuatBaru.UseVisualStyleBackColor = true;
            this.btnBuatBaru.Click += new System.EventHandler(this.btnBuatBaru_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(245, 83);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // TambahPenjualanResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(333, 123);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnBuatBaru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamaDokter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTanggalJual);
            this.Controls.Add(this.tbIDResep);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahPenjualanResep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahPenjualanResep";
            this.Load += new System.EventHandler(this.TambahPenjualanResep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDResep;
        private System.Windows.Forms.DateTimePicker dtpTanggalJual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaDokter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuatBaru;
        private System.Windows.Forms.Button btnBatal;
    }
}