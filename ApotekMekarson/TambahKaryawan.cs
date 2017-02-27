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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ApotekMekarson
{
    public partial class TambahKaryawan : Form
    {
        ApotekMekarsonDB db;

        public TambahKaryawan()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
        }

        private void TambahKaryawan_Load(object sender, EventArgs e)
        {
            cbJenisKaryawan.SelectedIndex = 0;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Karyawan newKaryawan = new Karyawan();

            int counter = 0;

            if (tbUsername.Text != string.Empty)
            {
                if (db.tbKaryawans.Where(x => x.ID_Karyawan == tbUsername.Text).FirstOrDefault() == null)
                {
                    counter++;
                    newKaryawan.ID_Karyawan = tbUsername.Text;
                }
                else
                {
                    MessageBox.Show("Username telah terpakai.");
                }
            }
            else
            {
                counter = 0;
            }

            if (tbNama.Text != string.Empty)
            {
                counter++;
                newKaryawan.Nama_Karyawan = tbNama.Text;
            }
            else
            {
                counter = 0;
            }

            if (tbAlamat.Text != string.Empty)
            {
                counter++;
                newKaryawan.Alamat_Karyawan = tbAlamat.Text;
            }
            else
            {
                counter = 0;
            }

            if (tbNoTelepon.Text != string.Empty)
            {
                Regex regexObj = new Regex(@"^\(?([0-9]*)\)?[-. ]?([0-9]*)[-. ]?([0-9]*)?[-. ]?([0-9]*)$");

                if (regexObj.IsMatch(tbNoTelepon.Text))
                {
                    counter++;
                    newKaryawan.No_Telepon = tbNoTelepon.Text;
                }
                else
                {
                    MessageBox.Show("No Telepon mengandung simbol yang tidak diperbolehkan.");
                }
            }
            else
            {
                counter = 0;
            }

            MD5CryptoServiceProvider encrypt = new MD5CryptoServiceProvider();
            byte[] chiper = System.Text.Encoding.UTF8.GetBytes("apotekmekarson");
            chiper = encrypt.ComputeHash(chiper);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (byte item in chiper)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }
            string hasil = stringBuilder.ToString();

            newKaryawan.Password = hasil;
            newKaryawan.Status = "Aktif";

            newKaryawan.Jenis_Karyawan = cbJenisKaryawan.SelectedItem.ToString();

            if (counter == 4)
            {
                newKaryawan.AddKaryawan(newKaryawan);
                MessageBox.Show("Data pegawai berhasil ditambah.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Harap isi semua field dengan benar.");
            }
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
