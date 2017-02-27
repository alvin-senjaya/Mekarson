using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekMekarson
{
    public partial class UbahObat : Form
    {
        ApotekMekarsonDB db;
        Obat obatUpdated;

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

        public UbahObat()
        {
            InitializeComponent();
        }

        public UbahObat(tbObat obat)
        {
            InitializeComponent();

            db = new ApotekMekarsonDB();
            obatUpdated = new Obat();

            tbNoBatch.Text = obat.No_Batch;
            tbNamaObat.Text = obat.Nama_Obat;
            cbSatuan.SelectedItem = obat.Satuan;
            cbJenisObat.SelectedItem = obat.Jenis_Barang;
            tbHargaBeli.Text = obat.Harga_Beli.ToString();
            tbHargaJual.Text = obat.Harga_Jual.ToString();
            nudJumlah.Value = (decimal)obat.Qty;
            nudStokMinimal.Value = (decimal)obat.Stok_Minim;
            cbNamaSupplier.Text = obat.Nama_Supplier;
            tbKeterangan.Text = obat.Keterangan;

            tbNoBatch.ReadOnly = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            ApotekMekarsonDB db = new ApotekMekarsonDB();
            double hargaBeli = 0;
            double hargaJual = 0;
            var namaSupplier = db.tbSuppliers.Where(x => x.Nama_Supplier == cbNamaSupplier.Text).FirstOrDefault();
            var noBatch = db.tbObats.Where(x => x.No_Batch == tbNoBatch.Text).FirstOrDefault();
            if (tbNoBatch.Text != string.Empty && tbNamaObat.Text != string.Empty && tbHargaBeli.Text != string.Empty && tbHargaJual.Text != string.Empty && cbNamaSupplier.Text != string.Empty && tbKeterangan.Text != string.Empty)
            {
                if (double.TryParse(tbHargaBeli.Text, out hargaBeli) && double.TryParse(tbHargaJual.Text, out hargaJual))
                {
                    if (hargaJual > hargaBeli)
                    {
                        if (namaSupplier != null)
                        {
                            obatUpdated.No_Batch = tbNoBatch.Text;
                            obatUpdated.Nama_Obat = tbNamaObat.Text;
                            obatUpdated.Satuan = cbSatuan.SelectedItem.ToString();
                            obatUpdated.Jenis_Barang = cbJenisObat.SelectedItem.ToString();
                            obatUpdated.Harga_Beli = Convert.ToDecimal(tbHargaBeli.Text);
                            obatUpdated.Harga_Jual = Convert.ToDecimal(tbHargaJual.Text);
                            obatUpdated.Nama_Supplier = cbNamaSupplier.Text;
                            obatUpdated.Keterangan = tbKeterangan.Text;
                            obatUpdated.Qty = (int)nudJumlah.Value;
                            obatUpdated.Stok_Minim = (int)nudStokMinimal.Value;

                            obatUpdated.UbahObatMethod(obatUpdated);
                            MessageBox.Show("Data obat berhasil diubah.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nama supplier tidak terdaftar.");
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
                MessageBox.Show("Harap isi semua field dengan benar.");
            }
        }

        private void UbahObat_Load(object sender, EventArgs e)
        {
            var DataSupplier = db.tbSuppliers.Select(x => x.Nama_Supplier).ToList();
            foreach (var item in DataSupplier)
            {
                cbNamaSupplier.Items.Add(item);
            }
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
