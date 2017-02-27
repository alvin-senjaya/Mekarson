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
    public partial class TambahDetailResep : Form
    {
        ApotekMekarsonDB db;
        string id_resep;
        int id_racikan = 0;
        int counter = 0;

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

        public TambahDetailResep()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
        }

        public TambahDetailResep(string idResep)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            id_resep = idResep;
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            var obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCari.Text) && (x.Jenis_Barang == "Generik (Racikan)" || x.Jenis_Barang == "Non-Generik (Racikan)")).Select(x => x.Nama_Obat);

            listBoxNamaObat.DataSource = obat.ToList();
        }

        private void listBoxNamaObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNamaObat.Text = listBoxNamaObat.SelectedItem.ToString();

            tbNoBatch.Text = db.tbObats.Where(x => x.Nama_Obat == listBoxNamaObat.SelectedItem.ToString()).Select(x => x.No_Batch).FirstOrDefault();
        }

        private void TambahDetailResep_Load(object sender, EventArgs e)
        {
            tbIDResep.Text = id_resep;
            listBoxNamaObat.DataSource = db.tbObats.Where(x => x.Jenis_Barang == "Generik (Racikan)" || x.Jenis_Barang == "Non-Generik (Racikan)").Select(x => x.Nama_Obat);

            RefreshObatRacikan();
            RefreshDetail();
        }

        private void btnBuatRacikanBaru_Click(object sender, EventArgs e)
        {
            if (tbHarga.Text == string.Empty)
            {
                MessageBox.Show("Harap isi field harga terlebih dahulu.");
            }
            else
            {
                Racikan racik = new Racikan();
                racik.Harga = Convert.ToDouble(tbHarga.Text);
                racik.TambahRacikanMethod(racik);
                tbIDRacikan.Text = ((db.tbRacikans.Select(x => x.Id_Racikan).Max())).ToString();
                tbSubTotal.Text = (Convert.ToDouble(tbHarga.Text) * (double)nudQtyDetail.Value).ToString();
                int.TryParse(tbIDRacikan.Text, out id_racikan);
                MessageBox.Show("Racikan baru telah ditambahkan. Silahkan memasukan data obat untuk racikan ini.");
            }
        }

        private void btnTambahRacikan_Click(object sender, EventArgs e)
        {
            var queryObatRacikan = db.tbObat_Racikans.Where(x => x.No_Batch == tbNoBatch.Text && x.Id_Racikan == id_racikan).FirstOrDefault();
            var query = db.tbRacikans.Where(x => x.Id_Racikan == id_racikan).FirstOrDefault();
            var selectedObat = db.tbObats.Where(x => x.Nama_Obat == listBoxNamaObat.SelectedItem.ToString()).FirstOrDefault();

            if (counter == 0 && selectedObat.Qty - nudQty.Value >= 0)
            {
                if (query != null)
                {
                    ObatRacikan or = new ObatRacikan();
                    or.No_Batch = tbNoBatch.Text;
                    or.ID_Racikan = id_racikan;
                    or.Tanggal_Dibuat = dtpTanggal.Value;
                    or.Qty = (int)nudQty.Value;
                    or.TambahObatRacikanMethod(or);
                    RefreshObatRacikan();
                    counter = 1;
                }
                else
                {
                    MessageBox.Show("Maaf ID Racikan tidak terdaftar, harap masukan dulu ID Racikan baru.");
                }
            }
            else if (counter == 1 && selectedObat.Qty - nudQty.Value >= 0)
            {
                if (queryObatRacikan == null)
                {
                    ObatRacikan or = new ObatRacikan();
                    or.No_Batch = tbNoBatch.Text;
                    or.ID_Racikan = id_racikan;
                    or.Tanggal_Dibuat = dtpTanggal.Value;
                    or.Qty = (int)nudQty.Value;
                    or.TambahObatRacikanMethod(or);
                    RefreshObatRacikan();
                    counter = 1;
                }
                else
                {
                    MessageBox.Show("Maaf obat ini sudah dimasukan kedalam racikan, harap pilih obat yang lain.");
                }
            }
            else
                MessageBox.Show("Maaf stok obat tidak mencukupi.");
        }

        public void RefreshObatRacikan()
        {
            db = new ApotekMekarsonDB();
            dgvObatRacikan.DataSource = db.tbObat_Racikans.Where(x => x.Id_Racikan == id_racikan).Select(x => x);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (dgvDetailPenjualanResep.Rows.Count > 0)
            {
                PenjualanResep Resep = new PenjualanResep();
                Resep.ID_Penjualan_Resep = id_resep;
                double TotalPenjualan = Resep.HitungPenjualanResepMethod(Resep);
                Resep.Total_Penjualan = (decimal)TotalPenjualan;
                Resep.UbahTotalPenjualan(Resep);
                MessageBox.Show("Data resep baru berhasil disimpan.");
                this.Close();
            }
            else
            {
                Racikan racik = new Racikan();
                racik.ID_Racikan = id_racikan;
                racik.HapusRacikanMethod(racik);
                PenjualanResep pr = new PenjualanResep();
                pr.ID_Penjualan_Resep = tbIDResep.Text;
                pr.HapusResepMethod(pr);
                MessageBox.Show("Data Batal disimpan.");
                this.Close();
            }
        }

        private void btnTambahDetail_Click(object sender, EventArgs e)
        {
            int QtyperObat = (int)nudQty.Value;
            string NoBatch = tbNoBatch.Text;

            DetailPenjualanResep dpr = new DetailPenjualanResep();
            dpr.Qty = (int)nudQtyDetail.Value;
            dpr.Sub_Total = Convert.ToDouble(tbSubTotal.Text);
            dpr.ID_penjualan_Resep = tbIDResep.Text;
            dpr.ID_Racikan = id_racikan;
            dpr.TambahDetailMethod(dpr,QtyperObat,NoBatch);
            RefreshDetail();
            MessageBox.Show("Detail resep berhasil ditambahkan.");
        }

        private void nudQtyDetail_ValueChanged(object sender, EventArgs e)
        {
            tbSubTotal.Text = (Convert.ToDouble(tbHarga.Text) * (double)nudQtyDetail.Value).ToString();
        }

        public void RefreshDetail()
        {
            db = new ApotekMekarsonDB();
            dgvDetailPenjualanResep.DataSource = db.tbDetail_Penjualan_Reseps.Where(x => x.ID_Penjualan_Resep == id_resep).Select(x => new { x.ID_Detail_Penjualan, x.Qty, x.Sub_Total, x.ID_Racikan });
        }

        private void btnHapusRacikan_Click(object sender, EventArgs e)
        {
            if (dgvObatRacikan.SelectedRows.Count >= 1)
            {
                tbObat_Racikan DataObatRacikan = (tbObat_Racikan)dgvObatRacikan.SelectedRows[0].DataBoundItem;

                IQueryable<tbObat_Racikan> queryObatRacikan = db.tbObat_Racikans.Where(x => x.No_Batch == DataObatRacikan.No_Batch && x.Id_Racikan == DataObatRacikan.Id_Racikan);

                tbObat_Racikan selectedData = queryObatRacikan.FirstOrDefault();

                if (selectedData != null)
                {
                    ObatRacikan DeleteObatRacikan = new ObatRacikan();
                    DeleteObatRacikan.No_Batch = selectedData.No_Batch;
                    DeleteObatRacikan.ID_Racikan = selectedData.Id_Racikan;

                    DeleteObatRacikan.HapusObatRacikanMethod(DeleteObatRacikan);
                    RefreshObatRacikan();
                }
            }
        }

        private void dgvDetailPenjualanResep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualanResep.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
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

        private void tbSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (tbSubTotal.Text == "")
            {
                tbSubTotal.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbSubTotal.Text != "")
                {
                    double d = Convert.ToDouble(skipComma(tbSubTotal.Text));
                    tbSubTotal.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbSubTotal.Text;
                    textWithoutcomma = skipComma(tbSubTotal.Text);
                }
            }
            tbSubTotal.Select(tbSubTotal.Text.Length, 0);
        }

        private void tbSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
