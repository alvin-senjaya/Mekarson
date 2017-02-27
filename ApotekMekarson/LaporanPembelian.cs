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
    public partial class LaporanPembelian : Form
    {
        public LaporanPembelian()
        {
            InitializeComponent();
            reportViewerPembelian.Visible = false;
        }

        private void LaporanPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ApotekMekarsonDataSet.ViewLaporanPembelian' table. You can move, or remove it, as needed.
            this.ViewLaporanPembelianTableAdapter.Fill(this.ApotekMekarsonDataSet.ViewLaporanPembelian);

            this.reportViewerPembelian.RefreshReport();
        }

        private void btnBuatLaporan_Click(object sender, EventArgs e)
        {
            reportViewerPembelian.Visible = true;

            ApotekMekarsonDataSetTableAdapters.ViewLaporanPembelianTableAdapter adapter = new ApotekMekarsonDataSetTableAdapters.ViewLaporanPembelianTableAdapter();
            ApotekMekarsonDataSet.ViewLaporanPembelianDataTable table = new ApotekMekarsonDataSet.ViewLaporanPembelianDataTable();

            adapter.FillBy(table, dtpTanggalAwal.Value.ToShortDateString(), dtpTanggalAkhir.Value.ToShortDateString());

            ReportDataSource GetSource = new ReportDataSource("DataLaporanPembelian", (DataTable)table);
            ReportParameter rp1 = new ReportParameter("TanggalAwal", this.dtpTanggalAwal.Value.ToString("dd/MM/yyyy"));
            ReportParameter rp2 = new ReportParameter("TanggalAkhir", this.dtpTanggalAkhir.Value.ToString("dd/MM/yyyy"));
            this.reportViewerPembelian.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            this.reportViewerPembelian.LocalReport.SetParameters(new ReportParameter[] { rp2 });

            this.reportViewerPembelian.LocalReport.DataSources.Clear();

            this.reportViewerPembelian.LocalReport.DataSources.Add(GetSource);

            this.reportViewerPembelian.LocalReport.Refresh();

            this.reportViewerPembelian.RefreshReport();
        }
    }
}
