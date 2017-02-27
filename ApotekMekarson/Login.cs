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
    public partial class Login : Form
    {
        ApotekMekarsonDB db;
        tbKaryawan kar;

        public Login()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            kar = new tbKaryawan();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider encrypt = new MD5CryptoServiceProvider();
            byte[] chiper = System.Text.Encoding.UTF8.GetBytes(tbPassword.Text);
            chiper = encrypt.ComputeHash(chiper);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (byte item in chiper)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }
            string hasil = stringBuilder.ToString();

            kar = db.tbKaryawans.Where(x => x.ID_Karyawan == tbUsername.Text && x.Password == hasil).FirstOrDefault();

            if (kar != null && kar.Jenis_Karyawan == "Owner" && kar.Status == "Aktif")
            {
                HalamanUtamaOwner HalamanUtamaOwner = new HalamanUtamaOwner(kar);
                HalamanUtamaOwner.ShowDialog();
            }
            else if (kar != null && kar.Jenis_Karyawan == "Karyawan" && kar.Status == "Aktif")
            {
                HalamanUtamaKaryawan HalamanUtamaKaryawan = new HalamanUtamaKaryawan(kar);
                HalamanUtamaKaryawan.ShowDialog();
            }
            else if (kar != null && kar.Jenis_Karyawan == "Apoteker" && kar.Status == "Aktif")
            {
                HalamanUtamaApoteker HalamanUtamaApoteker = new HalamanUtamaApoteker(kar);
                HalamanUtamaApoteker.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username atau password tidak dikenali.");
            }
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
}
