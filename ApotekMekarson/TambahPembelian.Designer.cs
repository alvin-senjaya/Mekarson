namespace ApotekMekarson
{
    partial class TambahPembelian
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
            this.cbNamaSupplier = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotalPembelian = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnBuat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJatuhTempo = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalPembelian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoFaktur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDetailPembelian = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSatuan = new System.Windows.Forms.TextBox();
            this.nudBonus = new System.Windows.Forms.NumericUpDown();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxNamaObat = new System.Windows.Forms.ListBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBoxDataDetailPembelian = new System.Windows.Forms.GroupBox();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetailPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.GroupBoxDataDetailPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNamaSupplier);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbTotalPembelian);
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnBuat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpJatuhTempo);
            this.groupBox1.Controls.Add(this.dtpTanggalPembelian);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNoFaktur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pembelian :";
            // 
            // cbNamaSupplier
            // 
            this.cbNamaSupplier.FormattingEnabled = true;
            this.cbNamaSupplier.Location = new System.Drawing.Point(118, 97);
            this.cbNamaSupplier.Name = "cbNamaSupplier";
            this.cbNamaSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbNamaSupplier.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Total Pembelian :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(115, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Rp.";
            // 
            // tbTotalPembelian
            // 
            this.tbTotalPembelian.Location = new System.Drawing.Point(140, 126);
            this.tbTotalPembelian.Name = "tbTotalPembelian";
            this.tbTotalPembelian.ReadOnly = true;
            this.tbTotalPembelian.Size = new System.Drawing.Size(118, 20);
            this.tbTotalPembelian.TabIndex = 10;
            this.tbTotalPembelian.TextChanged += new System.EventHandler(this.tbTotalPembelian_TextChanged);
            this.tbTotalPembelian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalPembelian_KeyPress);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(220, 164);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 44);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(118, 164);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(98, 44);
            this.btnBuat.TabIndex = 8;
            this.btnBuat.Text = "Buat Pembelian Baru";
            this.btnBuat.UseVisualStyleBackColor = true;
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nama Supplier :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jatuh Tempo :";
            // 
            // dtpJatuhTempo
            // 
            this.dtpJatuhTempo.Location = new System.Drawing.Point(118, 71);
            this.dtpJatuhTempo.Name = "dtpJatuhTempo";
            this.dtpJatuhTempo.Size = new System.Drawing.Size(200, 20);
            this.dtpJatuhTempo.TabIndex = 4;
            // 
            // dtpTanggalPembelian
            // 
            this.dtpTanggalPembelian.Location = new System.Drawing.Point(118, 45);
            this.dtpTanggalPembelian.Name = "dtpTanggalPembelian";
            this.dtpTanggalPembelian.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalPembelian.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Pembelian :";
            // 
            // tbNoFaktur
            // 
            this.tbNoFaktur.Location = new System.Drawing.Point(118, 19);
            this.tbNoFaktur.Name = "tbNoFaktur";
            this.tbNoFaktur.Size = new System.Drawing.Size(169, 20);
            this.tbNoFaktur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur :";
            // 
            // groupBoxDetailPembelian
            // 
            this.groupBoxDetailPembelian.Controls.Add(this.label10);
            this.groupBoxDetailPembelian.Controls.Add(this.tbSatuan);
            this.groupBoxDetailPembelian.Controls.Add(this.nudBonus);
            this.groupBoxDetailPembelian.Controls.Add(this.btnSelesai);
            this.groupBoxDetailPembelian.Controls.Add(this.label15);
            this.groupBoxDetailPembelian.Controls.Add(this.label14);
            this.groupBoxDetailPembelian.Controls.Add(this.btnTambah);
            this.groupBoxDetailPembelian.Controls.Add(this.label13);
            this.groupBoxDetailPembelian.Controls.Add(this.tbSubTotal);
            this.groupBoxDetailPembelian.Controls.Add(this.label12);
            this.groupBoxDetailPembelian.Controls.Add(this.tbHarga);
            this.groupBoxDetailPembelian.Controls.Add(this.label9);
            this.groupBoxDetailPembelian.Controls.Add(this.nudQty);
            this.groupBoxDetailPembelian.Controls.Add(this.label8);
            this.groupBoxDetailPembelian.Controls.Add(this.tbNamaObat);
            this.groupBoxDetailPembelian.Controls.Add(this.label7);
            this.groupBoxDetailPembelian.Controls.Add(this.listBoxNamaObat);
            this.groupBoxDetailPembelian.Controls.Add(this.tbCari);
            this.groupBoxDetailPembelian.Controls.Add(this.label6);
            this.groupBoxDetailPembelian.Controls.Add(this.label5);
            this.groupBoxDetailPembelian.Location = new System.Drawing.Point(344, 12);
            this.groupBoxDetailPembelian.Name = "groupBoxDetailPembelian";
            this.groupBoxDetailPembelian.Size = new System.Drawing.Size(489, 317);
            this.groupBoxDetailPembelian.TabIndex = 1;
            this.groupBoxDetailPembelian.TabStop = false;
            this.groupBoxDetailPembelian.Text = "Detail Pembelian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Satuan :";
            // 
            // tbSatuan
            // 
            this.tbSatuan.Location = new System.Drawing.Point(314, 48);
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.ReadOnly = true;
            this.tbSatuan.Size = new System.Drawing.Size(100, 20);
            this.tbSatuan.TabIndex = 21;
            // 
            // nudBonus
            // 
            this.nudBonus.Location = new System.Drawing.Point(314, 101);
            this.nudBonus.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudBonus.Name = "nudBonus";
            this.nudBonus.Size = new System.Drawing.Size(45, 20);
            this.nudBonus.TabIndex = 20;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(402, 179);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 39);
            this.btnSelesai.TabIndex = 19;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Rp.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Rp.";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(321, 179);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 39);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Sub Total :";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(336, 153);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(100, 20);
            this.tbSubTotal.TabIndex = 15;
            this.tbSubTotal.TextChanged += new System.EventHandler(this.tbSubTotal_TextChanged);
            this.tbSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubTotal_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Harga :";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(336, 127);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(100, 20);
            this.tbHarga.TabIndex = 13;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bonus :";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(314, 75);
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
            this.nudQty.Size = new System.Drawing.Size(45, 20);
            this.nudQty.TabIndex = 7;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty :";
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(314, 19);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.ReadOnly = true;
            this.tbNamaObat.Size = new System.Drawing.Size(163, 20);
            this.tbNamaObat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nama Obat :";
            // 
            // listBoxNamaObat
            // 
            this.listBoxNamaObat.FormattingEnabled = true;
            this.listBoxNamaObat.Location = new System.Drawing.Point(11, 58);
            this.listBoxNamaObat.Name = "listBoxNamaObat";
            this.listBoxNamaObat.Size = new System.Drawing.Size(203, 251);
            this.listBoxNamaObat.TabIndex = 3;
            this.listBoxNamaObat.SelectedIndexChanged += new System.EventHandler(this.listBoxNamaObat_SelectedIndexChanged);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(45, 19);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(169, 20);
            this.tbCari.TabIndex = 2;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cari :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "List Obat :";
            // 
            // GroupBoxDataDetailPembelian
            // 
            this.GroupBoxDataDetailPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxDataDetailPembelian.Controls.Add(this.dgvDetailPembelian);
            this.GroupBoxDataDetailPembelian.Location = new System.Drawing.Point(12, 335);
            this.GroupBoxDataDetailPembelian.Name = "GroupBoxDataDetailPembelian";
            this.GroupBoxDataDetailPembelian.Size = new System.Drawing.Size(821, 361);
            this.GroupBoxDataDetailPembelian.TabIndex = 2;
            this.GroupBoxDataDetailPembelian.TabStop = false;
            this.GroupBoxDataDetailPembelian.Text = "Data Detail Pembelian";
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.AllowUserToAddRows = false;
            this.dgvDetailPembelian.AllowUserToDeleteRows = false;
            this.dgvDetailPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Location = new System.Drawing.Point(11, 19);
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.ReadOnly = true;
            this.dgvDetailPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailPembelian.Size = new System.Drawing.Size(798, 336);
            this.dgvDetailPembelian.TabIndex = 0;
            this.dgvDetailPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailPembelian_CellFormatting);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(12, 292);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 37);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // TambahPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(863, 708);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.GroupBoxDataDetailPembelian);
            this.Controls.Add(this.groupBoxDetailPembelian);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahPembelian";
            this.Text = "TambahPembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TambahPembelian_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetailPembelian.ResumeLayout(false);
            this.groupBoxDetailPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.GroupBoxDataDetailPembelian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJatuhTempo;
        private System.Windows.Forms.DateTimePicker dtpTanggalPembelian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoFaktur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.GroupBox groupBoxDetailPembelian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxNamaObat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GroupBoxDataDetailPembelian;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTotalPembelian;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.NumericUpDown nudBonus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSatuan;
        private System.Windows.Forms.ComboBox cbNamaSupplier;
    }
}