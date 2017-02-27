namespace ApotekMekarson
{
    partial class LaporanPembelian
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewLaporanPembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApotekMekarsonDataSet = new ApotekMekarson.ApotekMekarsonDataSet();
            this.btnBuatLaporan = new System.Windows.Forms.Button();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerPembelian = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewLaporanPembelianTableAdapter = new ApotekMekarson.ApotekMekarsonDataSetTableAdapters.ViewLaporanPembelianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanPembelianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewLaporanPembelianBindingSource
            // 
            this.ViewLaporanPembelianBindingSource.DataMember = "ViewLaporanPembelian";
            this.ViewLaporanPembelianBindingSource.DataSource = this.ApotekMekarsonDataSet;
            // 
            // ApotekMekarsonDataSet
            // 
            this.ApotekMekarsonDataSet.DataSetName = "ApotekMekarsonDataSet";
            this.ApotekMekarsonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuatLaporan
            // 
            this.btnBuatLaporan.Location = new System.Drawing.Point(549, 29);
            this.btnBuatLaporan.Name = "btnBuatLaporan";
            this.btnBuatLaporan.Size = new System.Drawing.Size(99, 23);
            this.btnBuatLaporan.TabIndex = 12;
            this.btnBuatLaporan.Text = "Buat Laporan";
            this.btnBuatLaporan.UseVisualStyleBackColor = true;
            this.btnBuatLaporan.Click += new System.EventHandler(this.btnBuatLaporan_Click);
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(375, 31);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(168, 20);
            this.dtpTanggalAkhir.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sampai Tanggal :";
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwal.Location = new System.Drawing.Point(92, 31);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(181, 20);
            this.dtpTanggalAwal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dari Tanggal :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Periode :";
            // 
            // reportViewerPembelian
            // 
            reportDataSource1.Name = "DataLaporanPembelian";
            reportDataSource1.Value = this.ViewLaporanPembelianBindingSource;
            this.reportViewerPembelian.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPembelian.LocalReport.ReportEmbeddedResource = "ApotekMekarson.ReportPembelian.rdlc";
            this.reportViewerPembelian.Location = new System.Drawing.Point(15, 57);
            this.reportViewerPembelian.Name = "reportViewerPembelian";
            this.reportViewerPembelian.ShowFindControls = false;
            this.reportViewerPembelian.Size = new System.Drawing.Size(999, 429);
            this.reportViewerPembelian.TabIndex = 13;
            // 
            // ViewLaporanPembelianTableAdapter
            // 
            this.ViewLaporanPembelianTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 498);
            this.Controls.Add(this.reportViewerPembelian);
            this.Controls.Add(this.btnBuatLaporan);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LaporanPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPembelian";
            this.Load += new System.EventHandler(this.LaporanPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanPembelianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuatLaporan;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPembelian;
        private System.Windows.Forms.BindingSource ViewLaporanPembelianBindingSource;
        private ApotekMekarsonDataSet ApotekMekarsonDataSet;
        private ApotekMekarsonDataSetTableAdapters.ViewLaporanPembelianTableAdapter ViewLaporanPembelianTableAdapter;
    }
}