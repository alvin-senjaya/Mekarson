using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApotekMekarson.Class;

namespace ApotekMekarson
{
    public partial class UbahPenjualan : Form
    {
        ApotekMekarsonDB db;
        tbPenjualan DataPenjualanLama;
        DetailPenjualan newDetail;
        Karyawan TransakasiKaryawan;
        Penjualan newPenjualan;
        List<int> ListIdDetailPenjualan;

        public string textWithcomma { get; set; }
        public string textWithoutcomma { get; set; }

        public string skipComma(string str)
        {
            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }

        public UbahPenjualan()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            newDetail = new DetailPenjualan();
        }

        public UbahPenjualan(tbKaryawan kar, string id_penjualan)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            TransakasiKaryawan = new Karyawan();
            newDetail = new DetailPenjualan();
            DataPenjualanLama = new tbPenjualan();

            TransakasiKaryawan.ID_Karyawan = kar.ID_Karyawan;
            DataPenjualanLama = db.tbPenjualans.Where(x => x.Id_Penjualan == id_penjualan).Select(x => x).FirstOrDefault();

            if (DataPenjualanLama != null)
            {
                tbIdPenjualan.Text = DataPenjualanLama.Id_Penjualan;
                dtpTanggalPenjualan.Value = (DateTime)DataPenjualanLama.Tanggal_Penjualan;
                tbTotal.Text = DataPenjualanLama.Total_Penjualan.ToString();
            }

            dgvDetailPenjualan.DataSource = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == id_penjualan).Select(x => new { x.Id_Detail_Penjualan, x.No_Batch, x.tbObat.Nama_Obat, x.Qty, x.tbObat.Harga_Jual, x.Sub_Total });
        }

        private void UbahPenjualan_Load(object sender, EventArgs e)
        {
            db = new ApotekMekarsonDB();
            listBoxObat.DataSource = db.tbObats.Select(x => x.Nama_Obat);

            newPenjualan = new Penjualan();
            ListIdDetailPenjualan = new List<int>();
            ListIdDetailPenjualan.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            IQueryable<tbObat> query;
            newDetail = new DetailPenjualan();
            query = db.tbObats.Where(x => x.Nama_Obat == listBoxObat.SelectedItem.ToString());

            tbObat selectedObat = query.FirstOrDefault();

            if (selectedObat != null)
            {
                if (selectedObat.Qty - (int)nudQty.Value > 0)
                {
                    newDetail.Qty = (int)nudQty.Value;
                    newDetail.Sub_Total = (double)(selectedObat.Harga_Jual * (int)nudQty.Value);
                    newDetail.ID_Penjualan = tbIdPenjualan.Text;
                    newDetail.No_Batch = selectedObat.No_Batch;

                    newDetail.TambahDetailMethod(newDetail);
                    RefreshDetail();

                    ListIdDetailPenjualan.Add((int)dgvDetailPenjualan.Rows[dgvDetailPenjualan.Rows.Count - 1].Cells[0].Value);

                    newPenjualan.ID_Penjualan = tbIdPenjualan.Text;
                    newPenjualan.Tanggal_Penjualan = dtpTanggalPenjualan.Value;
                    newPenjualan.Total_Penjualan = newPenjualan.HitungPenjualan(newPenjualan);
                    newPenjualan.ID_Karyawan = TransakasiKaryawan.ID_Karyawan;
                    newPenjualan.UbahPenjualan(newPenjualan);

                    tbTotal.Text = newPenjualan.Total_Penjualan.ToString();
                }
                else
                {
                    MessageBox.Show("Mohon maaf jumlah barang yang tersedia tidak mencukupi, sisa barang = " + selectedObat.Qty.ToString());
                }
            }
        }

        private void RefreshDetail()
        {
            db = new ApotekMekarsonDB();
            dgvDetailPenjualan.DataSource = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == tbIdPenjualan.Text).Select(x => new { x.Id_Detail_Penjualan, x.No_Batch, x.tbObat.Nama_Obat, x.Qty, x.tbObat.Harga_Jual, x.Sub_Total });
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDetailPenjualan.SelectedRows.Count >= 1)
            {
                var DataDetailPenjualan = dgvDetailPenjualan.SelectedRows[0].Cells[0].Value;

                IQueryable<tbDetail_Penjualan> queryDetail = db.tbDetail_Penjualans.Where(x => x.Id_Detail_Penjualan == (int)DataDetailPenjualan);

                tbDetail_Penjualan selectedData = queryDetail.FirstOrDefault();

                if (selectedData != null)
                {
                    DetailPenjualan DeleteDetail = new DetailPenjualan();
                    DeleteDetail.ID_detail_Penjualan = selectedData.Id_Detail_Penjualan;

                    ListIdDetailPenjualan.Remove(DeleteDetail.ID_detail_Penjualan);
                    DeleteDetail.HapusDetailMethod(DeleteDetail);
                    RefreshDetail();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data penjualan berhasil dirubah.");
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbDetail_Penjualan queryDetail = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == newDetail.ID_Penjualan).FirstOrDefault();
            DetailPenjualan deletePenjualan = new DetailPenjualan();

            if (queryDetail != null)
            {
                foreach (var item in ListIdDetailPenjualan)
                {
                    deletePenjualan.ID_detail_Penjualan = item;
                    deletePenjualan.HapusDetailMethod(deletePenjualan);
                }
            }

            this.Close();
            MessageBox.Show("Perubahan transaksi penjualan dibatalkan.");
        }

        private void listBoxObat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbNamaObat.Text = listBoxObat.SelectedItem.ToString();

            tbHarga.Text = db.tbObats.Where(x => x.Nama_Obat == listBoxObat.SelectedItem.ToString()).Select(x => x.Harga_Jual).FirstOrDefault().ToString();
        }

        private void tbCari_TextChanged_1(object sender, EventArgs e)
        {
            var obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCari.Text)).Select(x => x.Nama_Obat);

            listBoxObat.DataSource = obat.ToList();
        }

        private void dgvDetailPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("harga") || dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            if (tbHarga.Text == "")
            {
                tbHarga.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbHarga.Text != "" && tbHarga.Text != "0")
                {
                    double d = Convert.ToDouble(skipComma(tbHarga.Text));
                    tbHarga.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbHarga.Text;
                    textWithoutcomma = skipComma(tbHarga.Text);
                }
            }
            tbTotal.Select(tbTotal.Text.Length, 0);
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            if (tbTotal.Text == "")
            {
                tbHarga.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbTotal.Text != "" && tbTotal.Text != "0")
                {
                    double d = Convert.ToDouble(skipComma(tbTotal.Text));
                    tbTotal.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbTotal.Text;
                    textWithoutcomma = skipComma(tbTotal.Text);
                }
            }
            tbTotal.Select(tbTotal.Text.Length, 0);
        }

        private void tbTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
