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
    public partial class LaporanPenjualan : Form
    {
        public LaporanPenjualan()
        {
            InitializeComponent();
            reportViewerPenjualan.Visible = false;
        }

        private void LaporanPenjualan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ApotekMekarsonDataSet.ViewLaporanPenjualan' table. You can move, or remove it, as needed.
            this.ViewLaporanPenjualanTableAdapter.Fill(this.ApotekMekarsonDataSet.ViewLaporanPenjualan);

            this.reportViewerPenjualan.RefreshReport();
        }

        private void btnBuatLaporan_Click(object sender, EventArgs e)
        {
            reportViewerPenjualan.Visible = true;

            ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanTableAdapter adapter = new ApotekMekarsonDataSetTableAdapters.ViewLaporanPenjualanTableAdapter();
            ApotekMekarsonDataSet.ViewLaporanPenjualanDataTable table = new ApotekMekarsonDataSet.ViewLaporanPenjualanDataTable();

            adapter.FillBy(table, dtpTanggalAwal.Value.ToShortDateString(), dtpTanggalAkhir.Value.ToShortDateString());

            ReportDataSource GetSource = new ReportDataSource("DataLaporanPenjualan", (DataTable)table);
            ReportParameter rp1 = new ReportParameter("TanggalAwal",this.dtpTanggalAwal.Value.ToString("dd/MM/yyyy"));
            ReportParameter rp2 = new ReportParameter("TanggalAkhir",this.dtpTanggalAkhir.Value.ToString("dd/MM/yyyy"));
            this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            this.reportViewerPenjualan.LocalReport.SetParameters(new ReportParameter[] { rp2 });

            this.reportViewerPenjualan.LocalReport.DataSources.Clear();

            this.reportViewerPenjualan.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPenjualan.LocalReport.Refresh();

            this.reportViewerPenjualan.RefreshReport();
        }
    }
}
