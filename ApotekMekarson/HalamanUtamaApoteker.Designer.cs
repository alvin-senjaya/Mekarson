namespace ApotekMekarson
{
    partial class HalamanUtamaApoteker
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvResep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetailResep = new System.Windows.Forms.DataGridView();
            this.labelNamaUser = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelUbahPassword = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterCari = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tambahBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusResepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailResep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvResep);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Resep :";
            // 
            // dgvResep
            // 
            this.dgvResep.AllowUserToAddRows = false;
            this.dgvResep.AllowUserToDeleteRows = false;
            this.dgvResep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvResep.Location = new System.Drawing.Point(6, 19);
            this.dgvResep.Name = "dgvResep";
            this.dgvResep.ReadOnly = true;
            this.dgvResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.Size = new System.Drawing.Size(1172, 289);
            this.dgvResep.TabIndex = 0;
            this.dgvResep.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResep_CellFormatting);
            this.dgvResep.SelectionChanged += new System.EventHandler(this.dgvResep_SelectionChanged);
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
            this.Column2.DataPropertyName = "tbKaryawan";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDetailResep);
            this.groupBox2.Location = new System.Drawing.Point(12, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1184, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Resep :";
            // 
            // dgvDetailResep
            // 
            this.dgvDetailResep.AllowUserToAddRows = false;
            this.dgvDetailResep.AllowUserToDeleteRows = false;
            this.dgvDetailResep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailResep.Location = new System.Drawing.Point(6, 19);
            this.dgvDetailResep.Name = "dgvDetailResep";
            this.dgvDetailResep.ReadOnly = true;
            this.dgvDetailResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailResep.Size = new System.Drawing.Size(1172, 258);
            this.dgvDetailResep.TabIndex = 0;
            this.dgvDetailResep.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetailResep_CellFormatting);
            // 
            // labelNamaUser
            // 
            this.labelNamaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamaUser.AutoSize = true;
            this.labelNamaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaUser.Location = new System.Drawing.Point(1047, 12);
            this.labelNamaUser.Name = "labelNamaUser";
            this.labelNamaUser.Size = new System.Drawing.Size(88, 17);
            this.labelNamaUser.TabIndex = 5;
            this.labelNamaUser.Text = "Nama User";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(1076, 32);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(46, 13);
            this.labelTanggal.TabIndex = 6;
            this.labelTanggal.Text = "Tanggal";
            // 
            // labelUbahPassword
            // 
            this.labelUbahPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUbahPassword.AutoSize = true;
            this.labelUbahPassword.Location = new System.Drawing.Point(1106, 49);
            this.labelUbahPassword.Name = "labelUbahPassword";
            this.labelUbahPassword.Size = new System.Drawing.Size(82, 13);
            this.labelUbahPassword.TabIndex = 7;
            this.labelUbahPassword.Text = "Ubah Password";
            this.labelUbahPassword.Click += new System.EventHandler(this.labelUbahPassword_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cari :";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(67, 86);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(157, 20);
            this.tbCari.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Berdasarkan :";
            // 
            // cbFilterCari
            // 
            this.cbFilterCari.FormattingEnabled = true;
            this.cbFilterCari.Items.AddRange(new object[] {
            "ID Penjualan Resep",
            "Asal Resep"});
            this.cbFilterCari.Location = new System.Drawing.Point(309, 86);
            this.cbFilterCari.Name = "cbFilterCari";
            this.cbFilterCari.Size = new System.Drawing.Size(121, 21);
            this.cbFilterCari.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tanggal :";
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.Location = new System.Drawing.Point(67, 109);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalAwal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "s/d";
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(302, 109);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalAkhir.TabIndex = 15;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(12, 135);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(64, 23);
            this.btnCari.TabIndex = 16;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBaruToolStripMenuItem,
            this.hapusResepToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(242, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tambahBaruToolStripMenuItem
            // 
            this.tambahBaruToolStripMenuItem.Name = "tambahBaruToolStripMenuItem";
            this.tambahBaruToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tambahBaruToolStripMenuItem.Text = "Tambah Baru";
            this.tambahBaruToolStripMenuItem.Click += new System.EventHandler(this.tambahBaruToolStripMenuItem_Click);
            // 
            // hapusResepToolStripMenuItem
            // 
            this.hapusResepToolStripMenuItem.Name = "hapusResepToolStripMenuItem";
            this.hapusResepToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.hapusResepToolStripMenuItem.Text = "Hapus Resep";
            this.hapusResepToolStripMenuItem.Click += new System.EventHandler(this.hapusResepToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApotekMekarson.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(538, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 145);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanUtamaApoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1208, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilterCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUbahPassword);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelNamaUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HalamanUtamaApoteker";
            this.Text = "HalamanUtamaApoteker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HalamanUtamaApoteker_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailResep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetailResep;
        private System.Windows.Forms.Label labelNamaUser;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelUbahPassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tambahBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusResepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}