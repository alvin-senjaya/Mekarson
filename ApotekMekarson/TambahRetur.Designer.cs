namespace ApotekMekarson
{
    partial class TambahRetur
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.tbNoBatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoFaktur = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvDetailRetur = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterPencarian = new System.Windows.Forms.ComboBox();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetailpembelian = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailpembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSelesai);
            this.groupBox3.Controls.Add(this.btnTambah);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nudQty);
            this.groupBox3.Controls.Add(this.tbNamaObat);
            this.groupBox3.Controls.Add(this.tbNoBatch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbNoFaktur);
            this.groupBox3.Location = new System.Drawing.Point(12, 514);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Retur :";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(193, 122);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 4;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(112, 123);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Obat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Batch :";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(84, 97);
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(38, 20);
            this.nudQty.TabIndex = 4;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(84, 71);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(184, 20);
            this.tbNamaObat.TabIndex = 3;
            // 
            // tbNoBatch
            // 
            this.tbNoBatch.Location = new System.Drawing.Point(84, 45);
            this.tbNoBatch.Name = "tbNoBatch";
            this.tbNoBatch.Size = new System.Drawing.Size(184, 20);
            this.tbNoBatch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Faktur :";
            // 
            // tbNoFaktur
            // 
            this.tbNoFaktur.Location = new System.Drawing.Point(84, 19);
            this.tbNoFaktur.Name = "tbNoFaktur";
            this.tbNoFaktur.ReadOnly = true;
            this.tbNoFaktur.Size = new System.Drawing.Size(184, 20);
            this.tbNoFaktur.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.dgvDetailRetur);
            this.groupBox4.Location = new System.Drawing.Point(328, 514);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 257);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detail Retur :";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(6, 19);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 23);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus Detail";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvDetailRetur
            // 
            this.dgvDetailRetur.AllowUserToAddRows = false;
            this.dgvDetailRetur.AllowUserToDeleteRows = false;
            this.dgvDetailRetur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailRetur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailRetur.Location = new System.Drawing.Point(6, 48);
            this.dgvDetailRetur.Name = "dgvDetailRetur";
            this.dgvDetailRetur.ReadOnly = true;
            this.dgvDetailRetur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailRetur.Size = new System.Drawing.Size(441, 203);
            this.dgvDetailRetur.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cari :";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(46, 6);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(153, 20);
            this.tbCari.TabIndex = 5;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Berdasarkan :";
            // 
            // cbFilterPencarian
            // 
            this.cbFilterPencarian.FormattingEnabled = true;
            this.cbFilterPencarian.Items.AddRange(new object[] {
            "Nama Supplier",
            "No Faktur"});
            this.cbFilterPencarian.Location = new System.Drawing.Point(284, 6);
            this.cbFilterPencarian.Name = "cbFilterPencarian";
            this.cbFilterPencarian.Size = new System.Drawing.Size(121, 21);
            this.cbFilterPencarian.TabIndex = 7;
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.AllowUserToAddRows = false;
            this.dgvPembelian.AllowUserToDeleteRows = false;
            this.dgvPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPembelian.Location = new System.Drawing.Point(6, 19);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.ReadOnly = true;
            this.dgvPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPembelian.Size = new System.Drawing.Size(757, 222);
            this.dgvPembelian.TabIndex = 0;
            this.dgvPembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPembelian_CellFormatting);
            this.dgvPembelian.SelectionChanged += new System.EventHandler(this.dgvPembelian_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_Karyawan";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID_Supplier";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPembelian);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pembelian :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDetailpembelian);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 207);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Pembelian :";
            // 
            // dgvDetailpembelian
            // 
            this.dgvDetailpembelian.AllowUserToAddRows = false;
            this.dgvDetailpembelian.AllowUserToDeleteRows = false;
            this.dgvDetailpembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailpembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailpembelian.Location = new System.Drawing.Point(6, 19);
            this.dgvDetailpembelian.Name = "dgvDetailpembelian";
            this.dgvDetailpembelian.ReadOnly = true;
            this.dgvDetailpembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailpembelian.Size = new System.Drawing.Size(757, 182);
            this.dgvDetailpembelian.TabIndex = 0;
            this.dgvDetailpembelian.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailpembelian_CellFormatting);
            this.dgvDetailpembelian.SelectionChanged += new System.EventHandler(this.dgvDetailpembelian_SelectionChanged);
            // 
            // TambahRetur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(793, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbFilterPencarian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahRetur";
            this.Text = "TambahRetur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TambahRetur_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRetur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailpembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.TextBox tbNoBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoFaktur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvDetailRetur;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFilterPencarian;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetailpembelian;
    }
}