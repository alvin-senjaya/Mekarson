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
using System.Security.Cryptography;

namespace ApotekMekarson
{
    public partial class UbahPassword : Form
    {
        ApotekMekarsonDB db;
        Karyawan a;

        public UbahPassword()
        {
            InitializeComponent();
        }

        public UbahPassword(tbKaryawan kar)
        {
            InitializeComponent();
            a = new Karyawan();
            db = new ApotekMekarsonDB();

            a.ID_Karyawan = kar.ID_Karyawan;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbPassLama.Text != string.Empty)
            {
                MD5CryptoServiceProvider encrypt = new MD5CryptoServiceProvider();
                byte[] chiper = System.Text.Encoding.UTF8.GetBytes(tbPassLama.Text);
                chiper = encrypt.ComputeHash(chiper);
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
                foreach (byte item in chiper)
                {
                    stringBuilder.Append(item.ToString("x2").ToLower());
                }
                string hasilPassLama = stringBuilder.ToString();

                if (db.tbKaryawans.Where(x => x.ID_Karyawan == a.ID_Karyawan && x.Password == hasilPassLama).FirstOrDefault() != null)
                {
                    if (tbPassBaru.Text != string.Empty && tbKonfPassBaru.Text != string.Empty)
                    {
                        if (tbPassBaru.Text == tbKonfPassBaru.Text)
                        {
                            stringBuilder.Clear();
                            chiper = System.Text.Encoding.UTF8.GetBytes(tbPassBaru.Text);
                            chiper = encrypt.ComputeHash(chiper);
                            foreach (byte item in chiper)
                            {
                                stringBuilder.Append(item.ToString("x2").ToLower());
                            }
                            string hasilPassBaru = stringBuilder.ToString();

                            a.Password = hasilPassBaru;
                            a.UbahPasswordMethod(a);
                            MessageBox.Show("Perubahan password berhasil");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Password baru dan konfirmasi password baru tidak sesuai");
                    }
                    else
                    {
                        MessageBox.Show("Password baru dan Konfrimasi password baru tidak boleh kosong.");
                    }
                }
                else
                {
                    MessageBox.Show("Password lama tidak sesuai.");
                }
            }
        }
    }
}
