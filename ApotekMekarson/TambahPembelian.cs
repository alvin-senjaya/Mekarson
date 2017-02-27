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
    public partial class TambahPembelian : Form
    {
        ApotekMekarsonDB db;
        Pembelian newPembelian;
        DetailPembelian newDetail;
        Karyawan TransaksiKaryawan;

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

        public TambahPembelian()
        {
            InitializeComponent();
        }

        public TambahPembelian(tbKaryawan kar)
        {
            InitializeComponent();
            btnHapus.Visible = false;
            groupBoxDetailPembelian.Visible = false;
            GroupBoxDataDetailPembelian.Visible = false;
            RefreshDetailPembelian();

            db = new ApotekMekarsonDB();
            newPembelian = new Pembelian();
            newDetail = new DetailPembelian();
            TransaksiKaryawan = new Karyawan();

            TransaksiKaryawan.ID_Karyawan = kar.ID_Karyawan;
        }

        private void TambahPembelian_Load(object sender, EventArgs e)
        {
            var DataSupplier = db.tbSuppliers.Select(x => x.Nama_Supplier).ToList();
            foreach (var item in DataSupplier)
            {
                cbNamaSupplier.Items.Add(item);
            }
            cbNamaSupplier.SelectedIndex = 0;

            tbTotalPembelian.Text = "0";
            db = new ApotekMekarsonDB();
            newPembelian = new Pembelian();

            newPembelian.Status = "Belum Lunas";
            listBoxNamaObat.DataSource = db.tbObats.Select(x => x.Nama_Obat);
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {            
            newPembelian.No_Faktur = tbNoFaktur.Text;
            newPembelian.Tanggal_Pembelian = dtpTanggalPembelian.Value;
            newPembelian.Total_Pembelian = Convert.ToDouble(tbTotalPembelian.Text);
            newPembelian.Jatuh_Tempo = dtpJatuhTempo.Value;
            newPembelian.ID_Karyawan = TransaksiKaryawan.ID_Karyawan;

            int querySupplier = db.tbSuppliers.Where(x => x.Nama_Supplier.ToLower() == cbNamaSupplier.Text.ToLower()).Select(x => x.ID_Supplier).FirstOrDefault();

            string cekNoFaktur = db.tbPembelians.Where(x => x.No_faktur == tbNoFaktur.Text).Select(x => x.No_faktur).FirstOrDefault();
            if (tbNoFaktur.Text != string.Empty)
            {
                if (cekNoFaktur == null)
                {
                    newPembelian.ID_Supplier = querySupplier;
                    newPembelian.TambahPembelianMethod(newPembelian);

                    btnHapus.Visible = true;
                    groupBoxDetailPembelian.Visible = true;
                    GroupBoxDataDetailPembelian.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Faktur yang anda masukan sudah ada.");
                }
            }
            else
            {
                MessageBox.Show("Harap masukan isi field No Faktur.");
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbDetail_Pembelian queryDetail = db.tbDetail_Pembelians.Where(x => x.No_Faktur == newDetail.No_Faktur).FirstOrDefault();

            if (queryDetail != null)
            {
                newDetail.HapusSemuaDetailPembelianMethod(newDetail);
                newPembelian.HapusPembelianMethod(newPembelian);
            }
            else
            {
                newPembelian.HapusPembelianMethod(newPembelian);
            }
            MessageBox.Show("Data pembelian baru dibatalkan.");
            this.Close();
        }

        private void listBoxNamaObat_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNamaObat.Text = listBoxNamaObat.SelectedItem.ToString();
            tbSatuan.Text = db.tbObats.Where(x => x.Nama_Obat == listBoxNamaObat.SelectedItem.ToString()).Select(x => x.Satuan).FirstOrDefault();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            newDetail = new DetailPembelian();

            IQueryable<tbObat> query;
            query = db.tbObats.Where(x => x.Nama_Obat == listBoxNamaObat.SelectedItem.ToString());

            tbObat selectedObat = query.FirstOrDefault();

            if (selectedObat != null)
            {
                if (tbHarga.Text != string.Empty)
                {
                    newDetail.Qty = (int)nudQty.Value;
                    newDetail.Bonus = (int)nudBonus.Value;
                    newDetail.Harga = Convert.ToDouble(tbHarga.Text);
                    newDetail.Sub_Total = Convert.ToDouble(tbSubTotal.Text);
                    newDetail.No_Faktur = tbNoFaktur.Text;
                    newDetail.No_Batch = selectedObat.No_Batch;
                    newDetail.TambahDetailPembelianMethod(newDetail);
                    RefreshDetailPembelian();

                    newPembelian.Tanggal_Pembelian = dtpTanggalPembelian.Value;
                    newPembelian.Jatuh_Tempo = dtpJatuhTempo.Value;
                    newPembelian.Total_Pembelian = newPembelian.HitungTotalPembelian(newPembelian);
                    newPembelian.UbahPembelianMethod(newPembelian);

                    tbTotalPembelian.Text = newPembelian.Total_Pembelian.ToString(); 
                }
                else
                {
                    MessageBox.Show("Harap isi field harga.");
                }
            }
        }

        public void RefreshDetailPembelian()
        {
            db = new ApotekMekarsonDB();
            dgvDetailPembelian.DataSource = db.tbDetail_Pembelians.Where(x => x.No_Faktur == tbNoFaktur.Text).Select(x => new {x.Id_Detail_Pembelian,x.tbObat.Nama_Obat,x.Qty,x.Bonus,x.Harga,x.Sub_Total });
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
            if (tbHarga.Text != string.Empty)
            {
                tbSubTotal.Text = (Convert.ToDecimal(tbHarga.Text) * nudQty.Value).ToString();   
            }

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
            tbHarga.Select(tbHarga.Text.Length, 0);
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            if (tbHarga.Text != string.Empty)
            {
                tbSubTotal.Text = (Convert.ToDecimal(tbHarga.Text) * nudQty.Value).ToString();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDetailPembelian.SelectedRows.Count >= 1)
            {
                var DataDetailPembelian = dgvDetailPembelian.SelectedRows[0].Cells[0].Value;

                IQueryable<tbDetail_Pembelian> queryDetail = db.tbDetail_Pembelians.Where(x => x.Id_Detail_Pembelian == (int)DataDetailPembelian);

                tbDetail_Pembelian selectedData = queryDetail.FirstOrDefault();

                if (selectedData != null)
                {
                    DetailPembelian DeleteDetail = new DetailPembelian();
                    DeleteDetail.ID_Detail_Pembelian = selectedData.Id_Detail_Pembelian;

                    DeleteDetail.HapusDetailPembelianMethod(DeleteDetail);
                    RefreshDetailPembelian();
                    MessageBox.Show("Detail pembelian berhasil dihapus.");
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data pembelian baru berhasil disimpan.");
            this.Close();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            var obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCari.Text)).Select(x => x.Nama_Obat);

            listBoxNamaObat.DataSource = obat.ToList();
        }

        private void dgvDetailPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("harga") || dgvDetailPembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void tbTotalPembelian_TextChanged(object sender, EventArgs e)
        {
            if (tbTotalPembelian.Text == "")
            {
                tbTotalPembelian.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbTotalPembelian.Text != "" && tbTotalPembelian.Text != "0")
                {
                    double d = Convert.ToDouble(skipComma(tbTotalPembelian.Text));
                    tbTotalPembelian.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbTotalPembelian.Text;
                    textWithoutcomma = skipComma(tbTotalPembelian.Text);
                }
            }
            tbTotalPembelian.Select(tbTotalPembelian.Text.Length, 0);
        }

        private void tbTotalPembelian_KeyPress(object sender, KeyPressEventArgs e)
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
                if (tbSubTotal.Text != "" && tbSubTotal.Text != "0")
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
