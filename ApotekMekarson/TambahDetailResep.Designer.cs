namespace ApotekMekarson
{
    partial class TambahDetailResep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapusRacikan = new System.Windows.Forms.Button();
            this.btnTambahRacikan = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNoBatch = new System.Windows.Forms.TextBox();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuatRacikanBaru = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbIDRacikan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNamaObat = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvObatRacikan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.dgvDetailPenjualanResep = new System.Windows.Forms.DataGridView();
            this.btnTambahDetail = new System.Windows.Forms.Button();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudQtyDetail = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIDResep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObatRacikan)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualanResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbCari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxNamaObat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Racikan :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapusRacikan);
            this.groupBox3.Controls.Add(this.btnTambahRacikan);
            this.groupBox3.Controls.Add(this.nudQty);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpTanggal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbNoBatch);
            this.groupBox3.Controls.Add(this.tbNamaObat);
            this.groupBox3.Location = new System.Drawing.Point(245, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 145);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Obat Racikan :";
            // 
            // btnHapusRacikan
            // 
            this.btnHapusRacikan.Location = new System.Drawing.Point(166, 116);
            this.btnHapusRacikan.Name = "btnHapusRacikan";
            this.btnHapusRacikan.Size = new System.Drawing.Size(134, 23);
            this.btnHapusRacikan.TabIndex = 21;
            this.btnHapusRacikan.Text = "Hapus Racikan";
            this.btnHapusRacikan.UseVisualStyleBackColor = true;
            this.btnHapusRacikan.Click += new System.EventHandler(this.btnHapusRacikan_Click);
            // 
            // btnTambahRacikan
            // 
            this.btnTambahRacikan.Location = new System.Drawing.Point(38, 116);
            this.btnTambahRacikan.Name = "btnTambahRacikan";
            this.btnTambahRacikan.Size = new System.Drawing.Size(122, 23);
            this.btnTambahRacikan.TabIndex = 20;
            this.btnTambahRacikan.Text = "Tambah Racikan";
            this.btnTambahRacikan.UseVisualStyleBackColor = true;
            this.btnTambahRacikan.Click += new System.EventHandler(this.btnTambahRacikan_Click);
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(101, 91);
            this.nudQty.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(43, 20);
            this.nudQty.TabIndex = 19;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Qty :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tanggal Dibuat :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(100, 65);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggal.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "No Batch :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nama Obat :";
            // 
            // tbNoBatch
            // 
            this.tbNoBatch.Location = new System.Drawing.Point(100, 16);
            this.tbNoBatch.Name = "tbNoBatch";
            this.tbNoBatch.Size = new System.Drawing.Size(121, 20);
            this.tbNoBatch.TabIndex = 13;
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(100, 39);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(121, 20);
            this.tbNamaObat.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuatRacikanBaru);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.tbIDRacikan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(245, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Racikan :";
            // 
            // btnBuatRacikanBaru
            // 
            this.btnBuatRacikanBaru.Location = new System.Drawing.Point(9, 81);
            this.btnBuatRacikanBaru.Name = "btnBuatRacikanBaru";
            this.btnBuatRacikanBaru.Size = new System.Drawing.Size(223, 23);
            this.btnBuatRacikanBaru.TabIndex = 8;
            this.btnBuatRacikanBaru.Text = "Buat Racikan Baru";
            this.btnBuatRacikanBaru.UseVisualStyleBackColor = true;
            this.btnBuatRacikanBaru.Click += new System.EventHandler(this.btnBuatRacikanBaru_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Racikan :";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(100, 49);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(100, 20);
            this.tbHarga.TabIndex = 7;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            // 
            // tbIDRacikan
            // 
            this.tbIDRacikan.Location = new System.Drawing.Point(79, 23);
            this.tbIDRacikan.Name = "tbIDRacikan";
            this.tbIDRacikan.ReadOnly = true;
            this.tbIDRacikan.Size = new System.Drawing.Size(100, 20);
            this.tbIDRacikan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga :";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(43, 15);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(196, 20);
            this.tbCari.TabIndex = 2;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari :";
            // 
            // listBoxNamaObat
            // 
            this.listBoxNamaObat.FormattingEnabled = true;
            this.listBoxNamaObat.Location = new System.Drawing.Point(6, 41);
            this.listBoxNamaObat.Name = "listBoxNamaObat";
            this.listBoxNamaObat.Size = new System.Drawing.Size(233, 238);
            this.listBoxNamaObat.TabIndex = 0;
            this.listBoxNamaObat.SelectedIndexChanged += new System.EventHandler(this.listBoxNamaObat_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvObatRacikan);
            this.groupBox4.Location = new System.Drawing.Point(12, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 345);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Obat Racikan :";
            // 
            // dgvObatRacikan
            // 
            this.dgvObatRacikan.AllowUserToAddRows = false;
            this.dgvObatRacikan.AllowUserToDeleteRows = false;
            this.dgvObatRacikan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObatRacikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObatRacikan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvObatRacikan.Location = new System.Drawing.Point(9, 19);
            this.dgvObatRacikan.Name = "dgvObatRacikan";
            this.dgvObatRacikan.ReadOnly = true;
            this.dgvObatRacikan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObatRacikan.Size = new System.Drawing.Size(547, 320);
            this.dgvObatRacikan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tbObat";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tbRacikan";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnSelesai);
            this.groupBox5.Controls.Add(this.dgvDetailPenjualanResep);
            this.groupBox5.Controls.Add(this.btnTambahDetail);
            this.groupBox5.Controls.Add(this.tbSubTotal);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.nudQtyDetail);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbIDResep);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(581, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 642);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detail Penjualan Resep :";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(125, 96);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // dgvDetailPenjualanResep
            // 
            this.dgvDetailPenjualanResep.AllowUserToAddRows = false;
            this.dgvDetailPenjualanResep.AllowUserToDeleteRows = false;
            this.dgvDetailPenjualanResep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPenjualanResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPenjualanResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPenjualanResep.Location = new System.Drawing.Point(9, 125);
            this.dgvDetailPenjualanResep.Name = "dgvDetailPenjualanResep";
            this.dgvDetailPenjualanResep.ReadOnly = true;
            this.dgvDetailPenjualanResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPenjualanResep.Size = new System.Drawing.Size(547, 511);
            this.dgvDetailPenjualanResep.TabIndex = 8;
            this.dgvDetailPenjualanResep.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPenjualanResep_CellFormatting);
            // 
            // btnTambahDetail
            // 
            this.btnTambahDetail.Location = new System.Drawing.Point(40, 96);
            this.btnTambahDetail.Name = "btnTambahDetail";
            this.btnTambahDetail.Size = new System.Drawing.Size(79, 23);
            this.btnTambahDetail.TabIndex = 7;
            this.btnTambahDetail.Text = "Tambah Detail";
            this.btnTambahDetail.UseVisualStyleBackColor = true;
            this.btnTambahDetail.Click += new System.EventHandler(this.btnTambahDetail_Click);
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(92, 68);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(108, 20);
            this.tbSubTotal.TabIndex = 6;
            this.tbSubTotal.TextChanged += new System.EventHandler(this.tbSubTotal_TextChanged);
            this.tbSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubTotal_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Rp.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sub Total :";
            // 
            // nudQtyDetail
            // 
            this.nudQtyDetail.Location = new System.Drawing.Point(70, 45);
            this.nudQtyDetail.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudQtyDetail.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtyDetail.Name = "nudQtyDetail";
            this.nudQtyDetail.Size = new System.Drawing.Size(46, 20);
            this.nudQtyDetail.TabIndex = 3;
            this.nudQtyDetail.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtyDetail.ValueChanged += new System.EventHandler(this.nudQtyDetail_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Qty :";
            // 
            // tbIDResep
            // 
            this.tbIDResep.Location = new System.Drawing.Point(70, 19);
            this.tbIDResep.Name = "tbIDResep";
            this.tbIDResep.ReadOnly = true;
            this.tbIDResep.Size = new System.Drawing.Size(130, 20);
            this.tbIDResep.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Resep :";
            // 
            // TambahDetailResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1158, 788);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TambahDetailResep";
            this.Text = "TambahDetailResep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TambahDetailResep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObatRacikan)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualanResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxNamaObat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTambahRacikan;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNoBatch;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuatRacikanBaru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbIDRacikan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvObatRacikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.DataGridView dgvDetailPenjualanResep;
        private System.Windows.Forms.Button btnTambahDetail;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudQtyDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIDResep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHapusRacikan;
    }
}