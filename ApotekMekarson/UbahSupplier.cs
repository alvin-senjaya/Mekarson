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
    public partial class UbahSupplier : Form
    {
        ApotekMekarsonDB db;
        Supplier SupplierUpdated;

        public UbahSupplier()
        {
            InitializeComponent();
        }

        public UbahSupplier(tbSupplier sup)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            SupplierUpdated = new Supplier();

            SupplierUpdated.ID_Supplier = sup.ID_Supplier;
            tbNama.Text = sup.Nama_Supplier;
            tbAlamat.Text = sup.Alamat_Supplier;
            tbNoTelepon.Text = sup.No_Telepon;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            ApotekMekarsonDB db = new ApotekMekarsonDB();
            var namaSupplier = db.tbSuppliers.Where(x => x.Nama_Supplier == tbNama.Text).FirstOrDefault();
            if (tbNama.Text != string.Empty && tbAlamat.Text != string.Empty && tbNoTelepon.Text != string.Empty)
            {
                Regex regexObj = new Regex(@"^\(?([0-9]*)\)?[-. ]?([0-9]*)[-. ]?([0-9]*)?[-. ]?([0-9]*)$");

                if (regexObj.IsMatch(tbNoTelepon.Text))
                {
                        SupplierUpdated.Nama_Supplier = tbNama.Text;
                        SupplierUpdated.Alamat_Supplier = tbAlamat.Text;
                        SupplierUpdated.No_Telepon = tbNoTelepon.Text;

                        SupplierUpdated.UbahSupplierMethod(SupplierUpdated);
                        MessageBox.Show("Data Supplier berhasil diubah.");
                        this.Close();
                }
                else
                {
                    MessageBox.Show("No Telepon mengandung simbol yang tidak diperbolehkan.");
                }
            }
            else
                MessageBox.Show("Harap isi semua field dengan benar.");
        }
    }
}
