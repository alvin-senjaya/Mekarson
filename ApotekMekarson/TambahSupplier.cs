using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ApotekMekarson.Class;

namespace ApotekMekarson
{
    public partial class TambahSupplier : Form
    {
        public TambahSupplier()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ApotekMekarsonDB db = new ApotekMekarsonDB();
            Supplier newSupplier = new Supplier();
            var namaSupplier = db.tbSuppliers.Where(x => x.Nama_Supplier == tbNama.Text).FirstOrDefault();

            if (tbNama.Text != string.Empty && tbAlamat.Text != string.Empty && tbNoTelepon.Text != string.Empty)
            {
                Regex regexObj = new Regex(@"^\(?([0-9]*)\)?[-. ]?([0-9]*)[-. ]?([0-9]*)?[-. ]?([0-9]*)$");

                if (regexObj.IsMatch(tbNoTelepon.Text))
                {
                    if (namaSupplier == null)
                    {
                        newSupplier.Nama_Supplier = tbNama.Text;
                        newSupplier.Alamat_Supplier = tbAlamat.Text;
                        newSupplier.No_Telepon = tbNoTelepon.Text;

                        newSupplier.TambahSupplierMethod(newSupplier);
                        MessageBox.Show("Supplier baru berhasil ditambahkan.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama supplier telah terdaftar.");
                    }
                }
                else
                {
                    MessageBox.Show("No Telepon mengandung simbol yang tidak diperbolehkan.");
                }
            }
            else
                MessageBox.Show("Harap isi semua field.");
        }
    }
}
