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
    public partial class TambahPenjualanResep : Form
    {
        Karyawan KaryawanLogin;
        PenjualanResep Resep;

        public TambahPenjualanResep()
        {
            InitializeComponent();
        }

        public TambahPenjualanResep(tbKaryawan a)
        {
            InitializeComponent();
            KaryawanLogin = new Karyawan();
            Resep = new PenjualanResep();

            KaryawanLogin.ID_Karyawan = a.ID_Karyawan;
            KaryawanLogin.Nama_Karyawan = a.Nama_Karyawan;
            KaryawanLogin.Password = a.Password;
            KaryawanLogin.Alamat_Karyawan = a.Alamat_Karyawan;
            KaryawanLogin.Jenis_Karyawan = a.Jenis_Karyawan;
            KaryawanLogin.No_Telepon = a.No_Telepon;
            KaryawanLogin.Status = a.Status;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuatBaru_Click(object sender, EventArgs e)
        {
            if (tbNamaDokter.Text != string.Empty)
            {
                Resep.ID_Penjualan_Resep = tbIDResep.Text;
                Resep.Tanggal_Penjualan = dtpTanggalJual.Value;
                Resep.Nama_Dokter = tbNamaDokter.Text;
                Resep.Total_Penjualan = 0;
                Resep.Apoteker = KaryawanLogin.Nama_Karyawan;
                Resep.ID_Karyawan = KaryawanLogin.ID_Karyawan;
                Resep.TambahPenjualanResepMethod(Resep);

                string id = tbIDResep.Text;

                TambahDetailResep tdr = new TambahDetailResep(id);
                tdr.ShowDialog();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Mohon isi nama dokter terlebih dahulu.");
            }
        }

        private void TambahPenjualanResep_Load(object sender, EventArgs e)
        {
            tbIDResep.Text = Resep.BuatIDPenjualanResep();
        }
    }
}
