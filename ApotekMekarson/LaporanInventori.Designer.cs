namespace ApotekMekarson
{
    partial class LaporanInventori
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
            this.ViewLaporanInventoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApotekMekarsonDataSet = new ApotekMekarson.ApotekMekarsonDataSet();
            this.reportViewerInventori = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewLaporanInventoriTableAdapter = new ApotekMekarson.ApotekMekarsonDataSetTableAdapters.ViewLaporanInventoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanInventoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewLaporanInventoriBindingSource
            // 
            this.ViewLaporanInventoriBindingSource.DataMember = "ViewLaporanInventori";
            this.ViewLaporanInventoriBindingSource.DataSource = this.ApotekMekarsonDataSet;
            // 
            // ApotekMekarsonDataSet
            // 
            this.ApotekMekarsonDataSet.DataSetName = "ApotekMekarsonDataSet";
            this.ApotekMekarsonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerInventori
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewLaporanInventoriBindingSource;
            this.reportViewerInventori.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInventori.LocalReport.ReportEmbeddedResource = "ApotekMekarson.ReportInventori.rdlc";
            this.reportViewerInventori.Location = new System.Drawing.Point(12, 12);
            this.reportViewerInventori.Name = "reportViewerInventori";
            this.reportViewerInventori.ShowFindControls = false;
            this.reportViewerInventori.Size = new System.Drawing.Size(1034, 540);
            this.reportViewerInventori.TabIndex = 0;
            // 
            // ViewLaporanInventoriTableAdapter
            // 
            this.ViewLaporanInventoriTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanInventori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 564);
            this.Controls.Add(this.reportViewerInventori);
            this.Name = "LaporanInventori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanInventori";
            this.Load += new System.EventHandler(this.LaporanInventori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewLaporanInventoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApotekMekarsonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventori;
        private System.Windows.Forms.BindingSource ViewLaporanInventoriBindingSource;
        private ApotekMekarsonDataSet ApotekMekarsonDataSet;
        private ApotekMekarsonDataSetTableAdapters.ViewLaporanInventoriTableAdapter ViewLaporanInventoriTableAdapter;
    }
}