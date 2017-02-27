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
    public partial class TambahObat : Form
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

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

        public TambahObat()
        {
            InitializeComponent();

            cbJenisObat.SelectedIndex = 0;
            cbSatuan.SelectedIndex = 0;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ApotekMekarsonDB db = new ApotekMekarsonDB();
            Obat newObat = new Obat();
            int hargaBeli = 0;
            int hargaJual = 0;
            var noBatch = db.tbObats.Where(x => x.No_Batch == tbNoBatch.Text).FirstOrDefault();
            var nama = db.tbObats.Where(x => x.Nama_Obat == tbNamaObat.Text).FirstOrDefault();

            if (tbNoBatch.Text != string.Empty && tbNamaObat.Text != string.Empty && tbHargaBeli.Text != string.Empty && tbHargaJual.Text != string.Empty && tbKeterangan.Text != string.Empty)
            {
                if (int.TryParse(tbHargaBeli.Text, out hargaBeli) && int.TryParse(tbHargaJual.Text, out hargaJual))
                {
                    if (hargaJual > hargaBeli)
                    {
                        if (noBatch == null)
                        {
                            if (nama == null)
                            {
                                newObat.No_Batch = tbNoBatch.Text;
                                newObat.Nama_Obat = tbNamaObat.Text;
                                newObat.Satuan = cbSatuan.SelectedItem.ToString();
                                newObat.Jenis_Barang = cbJenisObat.SelectedItem.ToString();
                                newObat.Harga_Beli = Convert.ToDecimal(tbHargaBeli.Text);
                                newObat.Harga_Jual = Convert.ToDecimal(tbHargaJual.Text);
                                newObat.Qty = (int)nudJumlah.Value;
                                newObat.Stok_Minim = (int)nudStokMinimal.Value;
                                newObat.Nama_Supplier = cbNamaSupplier.Text;
                                newObat.Keterangan = tbKeterangan.Text;

                                newObat.TambahObatMethod(newObat);
                                MessageBox.Show("Obat baru berhasil ditambahkan.");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Nama obat sudah ada.");
                        }
                        else
                        {
                            MessageBox.Show("No Batch " + noBatch.No_Batch.Trim() + " telah terdaftar, silahkaan masukan kode lain.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Harga jual harus lebih besar dari harga beli.");
                    }
                }
                else
                {
                    MessageBox.Show("Textbox Harga Beli dan Harga Jual hanya bisa diisi oleh angka.");
                }
            }
            else
            {
                MessageBox.Show("Harap isi semua field.");
            }
        }

        private void TambahObat_Load(object sender, EventArgs e)
        {
            var DataSupplier = db.tbSuppliers.Select(x => x.Nama_Supplier).ToList();

            foreach (var item in DataSupplier)
            {
                cbNamaSupplier.Items.Add(item);
            }

            cbNamaSupplier.SelectedIndex = 0;
        }

        private void tbHargaBeli_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaBeli.Text == "")
            {
                tbHargaBeli.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbHargaBeli.Text != "" && tbHargaBeli.Text != "0")
                {
                    double d = Convert.ToDouble(skipComma(tbHargaBeli.Text));
                    tbHargaBeli.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbHargaBeli.Text;
                    textWithoutcomma = skipComma(tbHargaBeli.Text);
                }
            }
            tbHargaBeli.Select(tbHargaBeli.Text.Length, 0);
        }

        private void tbHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbHargaJual_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaJual.Text == "")
            {
                tbHargaJual.Text = null;
                textWithcomma = "0";
                textWithoutcomma = "0";
            }
            else
            {
                if (tbHargaJual.Text != "" && tbHargaJual.Text != "0")
                {
                    double d = Convert.ToDouble(skipComma(tbHargaJual.Text));
                    tbHargaJual.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = tbHargaJual.Text;
                    textWithoutcomma = skipComma(tbHargaJual.Text);
                }
            }
            tbHargaJual.Select(tbHargaJual.Text.Length, 0);
        }

        private void tbHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
