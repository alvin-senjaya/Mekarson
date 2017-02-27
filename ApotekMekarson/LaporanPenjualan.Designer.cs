namespace ApotekMekarson
{
    partial class LaporanPenjualan
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
            this.ViewLaporanPenjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApotekMekarsonDataSet = new ApotekMekarson.ApotekMekarsonDataSet();
            this.reportViewerPenjualan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.btnBuatLaporan = new System.Windows.Forms.Button();
            this.ViewLaporanPenjualanTableAdapter = new ApotekMekarson.ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanPenjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewLaporanPenjualanBindingSource
            // 
            this.ViewLaporanPenjualanBindingSource.DataMember = "ViewLaporanPenjualan";
            this.ViewLaporanPenjualanBindingSource.DataSource = this.ApotekMekarsonDataSet;
            // 
            // ApotekMekarsonDataSet
            // 
            this.ApotekMekarsonDataSet.DataSetName = "ApotekMekarsonDataSet";
            this.ApotekMekarsonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerPenjualan
            // 
            reportDataSource1.Name = "DataLaporanPenjualan";
            reportDataSource1.Value = this.ViewLaporanPenjualanBindingSource;
            this.reportViewerPenjualan.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPenjualan.LocalReport.ReportEmbeddedResource = "ApotekMekarson.ReportPenjualan.rdlc";
            this.reportViewerPenjualan.Location = new System.Drawing.Point(12, 71);
            this.reportViewerPenjualan.Name = "reportViewerPenjualan";
            this.reportViewerPenjualan.ShowFindControls = false;
            this.reportViewerPenjualan.Size = new System.Drawing.Size(835, 426);
            this.reportViewerPenjualan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dari Tanggal :";
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwal.Location = new System.Drawing.Point(92, 31);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(181, 20);
            this.dtpTanggalAwal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sampai Tanggal :";
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(375, 31);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(168, 20);
            this.dtpTanggalAkhir.TabIndex = 5;
            // 
            // btnBuatLaporan
            // 
            this.btnBuatLaporan.Location = new System.Drawing.Point(549, 29);
            this.btnBuatLaporan.Name = "btnBuatLaporan";
            this.btnBuatLaporan.Size = new System.Drawing.Size(99, 23);
            this.btnBuatLaporan.TabIndex = 6;
            this.btnBuatLaporan.Text = "Buat Laporan";
            this.btnBuatLaporan.UseVisualStyleBackColor = true;
            this.btnBuatLaporan.Click += new System.EventHandler(this.btnBuatLaporan_Click);
            // 
            // ViewLaporanPenjualanTableAdapter
            // 
            this.ViewLaporanPenjualanTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 509);
            this.Controls.Add(this.btnBuatLaporan);
            this.Controls.Add(this.dtpTanggalAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggalAwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerPenjualan);
            this.Name = "LaporanPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPenjualan";
            this.Load += new System.EventHandler(this.LaporanPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanPenjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPenjualan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Button btnBuatLaporan;
        private System.Windows.Forms.BindingSource ViewLaporanPenjualanBindingSource;
        private ApotekMekarsonDataSet ApotekMekarsonDataSet;
        private ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanTableAdapter ViewLaporanPenjualanTableAdapter;
    }
}