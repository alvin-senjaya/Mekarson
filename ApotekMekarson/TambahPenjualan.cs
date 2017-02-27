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
    public partial class TambahPenjualan : Form
    {
        ApotekMekarsonDB db;
        Penjualan newPenjualan;
        DetailPenjualan newDetail;
        Karyawan TransakasiKaryawan;

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

        public TambahPenjualan()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            newDetail = new DetailPenjualan();
        }

        public TambahPenjualan(tbKaryawan kar)
        {
            InitializeComponent();
            TransakasiKaryawan = new Karyawan();
            newDetail = new DetailPenjualan();

            TransakasiKaryawan.ID_Karyawan = kar.ID_Karyawan;
        }

        private void TambahPenjualan_Load(object sender, EventArgs e)
        {
            db = new ApotekMekarsonDB();
            listBoxObat.DataSource = db.tbObats.Select(x => x.Nama_Obat);
            newPenjualan = new Penjualan();

            tbIdPenjualan.Text = newPenjualan.BuatIDPenjualanBaru();
            tbTotal.Text = "0";

            newPenjualan.ID_Penjualan = tbIdPenjualan.Text;
            newPenjualan.Tanggal_Penjualan = DateTime.Now;
            newPenjualan.Total_Penjualan = Convert.ToDouble(tbTotal.Text);
            newPenjualan.ID_Karyawan = TransakasiKaryawan.ID_Karyawan;
            newPenjualan.TambahPenjualan(newPenjualan);
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
                    newDetail.No_Batch = selectedObat.No_Batch.ToString();
                    newDetail.TambahDetailMethod(newDetail);
                    RefreshDetail();

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

        private void listBoxObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNamaObat.Text = listBoxObat.SelectedItem.ToString();

            decimal a = (decimal)db.tbObats.Where(x => x.Nama_Obat == listBoxObat.SelectedItem.ToString()).Select(x => x.Harga_Jual).FirstOrDefault();

            tbHarga.Text = a.ToString("0");
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data penjualan baru berhasil disimpan.");
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbDetail_Penjualan queryDetail = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == newDetail.ID_Penjualan).FirstOrDefault();

            if (queryDetail != null)
            {
                newDetail.HapusSemuaDetail(newDetail);
                newPenjualan.DeletePenjualan(newPenjualan);
            }
            else
            {
                newPenjualan.DeletePenjualan(newPenjualan);
            } 
            this.Close();
            MessageBox.Show("Transaksi penjualan baru dibatalkan.");
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

                    DeleteDetail.HapusDetailMethod(DeleteDetail);
                    RefreshDetail();
                }
            }
        }

        private void RefreshDetail()
        {
            db = new ApotekMekarsonDB();
            dgvDetailPenjualan.DataSource = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == tbIdPenjualan.Text).Select(x => new {x.Id_Detail_Penjualan,x.No_Batch,x.tbObat.Nama_Obat,x.Qty,x.tbObat.Harga_Jual,x.Sub_Total });
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            var obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCari.Text)).Select(x => x.Nama_Obat) ;

            listBoxObat.DataSource = obat.ToList();
        }

        private void dgvDetailPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual") || dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
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
                if (tbHarga.Text != "")
                {
                    double d = Convert.ToDouble(skipComma(tbHarga.Text));
                    tbHarga.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbHarga.Text;
                    textWithoutcomma = skipComma(tbHarga.Text);
                }
            }
            tbHarga.Select(tbHarga.Text.Length, 0);
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
    }
}
