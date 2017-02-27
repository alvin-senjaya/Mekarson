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
    public partial class UbahDataKaryawan : Form
    {
        ApotekMekarsonDB db;
        Karyawan KaryawanUpdated;

        public UbahDataKaryawan()
        {
            InitializeComponent();
        }

        public UbahDataKaryawan(tbKaryawan ubahKar)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            KaryawanUpdated = new Karyawan();

            KaryawanUpdated.ID_Karyawan = ubahKar.ID_Karyawan;
            tbNama.Text = ubahKar.Nama_Karyawan;
            tbAlamat.Text = ubahKar.Alamat_Karyawan;
            tbNoTelepon.Text = ubahKar.No_Telepon;
            cbJenisKaryawan.SelectedItem = ubahKar.Jenis_Karyawan;
            cbStatus.SelectedItem = ubahKar.Status;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != string.Empty && tbAlamat.Text != string.Empty && tbNoTelepon.Text != string.Empty)
            {
                Regex regexObj = new Regex(@"^\(?([0-9]*)\)?[-. ]?([0-9]*)[-. ]?([0-9]*)?[-. ]?([0-9]*)$");

                if (regexObj.IsMatch(tbNoTelepon.Text))
                {
                    KaryawanUpdated.Nama_Karyawan = tbNama.Text;
                    KaryawanUpdated.Alamat_Karyawan = tbAlamat.Text;
                    KaryawanUpdated.No_Telepon = tbNoTelepon.Text;
                    KaryawanUpdated.Jenis_Karyawan = cbJenisKaryawan.SelectedItem.ToString();
                    KaryawanUpdated.Status = cbStatus.SelectedItem.ToString();

                    KaryawanUpdated.UbahDataKaryawanMethod(KaryawanUpdated);
                    MessageBox.Show("Data Karyawan berhasil diubah.");
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

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
