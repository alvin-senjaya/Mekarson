using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ApotekMekarson
{
    public partial class LaporanPenjualanResep : Form
    {
        public LaporanPenjualanResep()
        {
            InitializeComponent();
            reportViewerPenjualanResep.Visible = false;
        }

        private void LaporanPenjualanResep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ApotekMekarsonDataSet.ViewLaporanPenjualanResep' table. You can move, or remove it, as needed.
            this.ViewLaporanPenjualanResepTableAdapter.Fill(this.ApotekMekarsonDataSet.ViewLaporanPenjualanResep);

            this.reportViewerPenjualanResep.RefreshReport();
        }

        private void btnBuatLaporan_Click(object sender, EventArgs e)
        {
            reportViewerPenjualanResep.Visible = true;

            ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanResepTableAdapter adapter = new ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanResepTableAdapter();
            ApotekMekarsonDataSet.ViewLaporanPenjualanResepDataTable table = new ApotekMekarsonDataSet.ViewLaporanPenjualanResepDataTable();

            adapter.FillBy(table, dtpTanggalAwal.Value.ToShortDateString(), dtpTanggalAkhir.Value.ToShortDateString());

            ReportDataSource GetSource = new ReportDataSource("DataSetPenjualanResep", (DataTable)table);
            ReportParameter rp1 = new ReportParameter("TanggalAwal", this.dtpTanggalAwal.Value.ToString("dd/MM/yyyy"));
            ReportParameter rp2 = new ReportParameter("TanggalAkhir", this.dtpTanggalAkhir.Value.ToString("dd/MM/yyyy"));
            this.reportViewerPenjualanResep.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            this.reportViewerPenjualanResep.LocalReport.SetParameters(new ReportParameter[] { rp2 });

            this.reportViewerPenjualanResep.LocalReport.DataSources.Clear();

            this.reportViewerPenjualanResep.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPenjualanResep.LocalReport.Refresh();

            this.reportViewerPenjualanResep.RefreshReport();
        }
    }
}
