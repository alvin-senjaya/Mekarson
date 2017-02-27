namespace ApotekMekarson
{
    partial class TambahObat
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
            this.nudStokMinimal = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.tbHargaJual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.cbJenisObat = new System.Windows.Forms.ComboBox();
            this.cbSatuan = new System.Windows.Forms.ComboBox();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.tbNoBatch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokMinimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNamaSupplier);
            this.groupBox1.Controls.Add(this.nudStokMinimal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.tbKeterangan);
            this.groupBox1.Controls.Add(this.nudJumlah);
            this.groupBox1.Controls.Add(this.tbHargaJual);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbHargaBeli);
            this.groupBox1.Controls.Add(this.cbJenisObat);
            this.groupBox1.Controls.Add(this.cbSatuan);
            this.groupBox1.Controls.Add(this.tbNamaObat);
            this.groupBox1.Controls.Add(this.tbNoBatch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Obat Baru :";
            // 
            // cbNamaSupplier
            // 
            this.cbNamaSupplier.FormattingEnabled = true;
            this.cbNamaSupplier.Location = new System.Drawing.Point(110, 222);
            this.cbNamaSupplier.Name = "cbNamaSupplier";
            this.cbNamaSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbNamaSupplier.TabIndex = 26;
            // 
            // nudStokMinimal
            // 
            this.nudStokMinimal.Location = new System.Drawing.Point(110, 196);
            this.nudStokMinimal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudStokMinimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStokMinimal.Name = "nudStokMinimal";
            this.nudStokMinimal.Size = new System.Drawing.Size(57, 20);
            this.nudStokMinimal.TabIndex = 25;
            this.nudStokMinimal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Stok Minimal :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nama Supplier :";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(234, 327);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 46);
            this.btnBatal.TabIndex = 23;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(153, 327);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 46);
            this.btnTambah.TabIndex = 22;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Location = new System.Drawing.Point(109, 248);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(200, 64);
            this.tbKeterangan.TabIndex = 21;
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(110, 170);
            this.nudJumlah.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(57, 20);
            this.nudJumlah.TabIndex = 17;
            this.nudJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbHargaJual
            // 
            this.tbHargaJual.Location = new System.Drawing.Point(130, 144);
            this.tbHargaJual.Name = "tbHargaJual";
            this.tbHargaJual.Size = new System.Drawing.Size(100, 20);
            this.tbHargaJual.TabIndex = 15;
            this.tbHargaJual.TextChanged += new System.EventHandler(this.tbHargaJual_TextChanged);
            this.tbHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaJual_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rp.";
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.Location = new System.Drawing.Point(130, 118);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.Size = new System.Drawing.Size(100, 20);
            this.tbHargaBeli.TabIndex = 12;
            this.tbHargaBeli.TextChanged += new System.EventHandler(this.tbHargaBeli_TextChanged);
            this.tbHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaBeli_KeyPress);
            // 
            // cbJenisObat
            // 
            this.cbJenisObat.FormattingEnabled = true;
            this.cbJenisObat.Items.AddRange(new object[] {
            "Generik (Racikan)",
            "Generik (Non-Racikan)",
            "Non-Generik (Racikan)",
            "Non-Generik (Non-Racikan)"});
            this.cbJenisObat.Location = new System.Drawing.Point(109, 91);
            this.cbJenisObat.Name = "cbJenisObat";
            this.cbJenisObat.Size = new System.Drawing.Size(121, 21);
            this.cbJenisObat.TabIndex = 9;
            // 
            // cbSatuan
            // 
            this.cbSatuan.FormattingEnabled = true;
            this.cbSatuan.Items.AddRange(new object[] {
            "Botol",
            "Tablet",
            "Kapsul"});
            this.cbSatuan.Location = new System.Drawing.Point(109, 64);
            this.cbSatuan.Name = "cbSatuan";
            this.cbSatuan.Size = new System.Drawing.Size(121, 21);
            this.cbSatuan.TabIndex = 7;
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(109, 38);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(152, 20);
            this.tbNamaObat.TabIndex = 3;
            // 
            // tbNoBatch
            // 
            this.tbNoBatch.Location = new System.Drawing.Point(109, 13);
            this.tbNoBatch.Name = "tbNoBatch";
            this.tbNoBatch.Size = new System.Drawing.Size(100, 20);
            this.tbNoBatch.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Keterangan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Jumlah :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Harga Beli :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Harga Jual :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jenis Obat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satuan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Obat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Batch :";
            // 
            // TambahObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(349, 409);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahObat";
            this.Load += new System.EventHandler(this.TambahObat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokMinimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.TextBox tbHargaJual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.ComboBox cbJenisObat;
        private System.Windows.Forms.ComboBox cbSatuan;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.TextBox tbNoBatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStokMinimal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbNamaSupplier;

    }
}