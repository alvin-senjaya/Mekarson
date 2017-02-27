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
    public partial class HalamanUtamaApoteker : Form
    {
        ApotekMekarsonDB db;
        Karyawan KaryawanLogin;

        public HalamanUtamaApoteker()
        {
            InitializeComponent();
        }

        public HalamanUtamaApoteker(tbKaryawan a)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
            KaryawanLogin = new Karyawan();
            timer1.Start();

            KaryawanLogin.ID_Karyawan = a.ID_Karyawan;
            KaryawanLogin.Nama_Karyawan = a.Nama_Karyawan;
            KaryawanLogin.Password = a.Password;
            KaryawanLogin.Alamat_Karyawan = a.Alamat_Karyawan;
            KaryawanLogin.Jenis_Karyawan = a.Jenis_Karyawan;
            KaryawanLogin.No_Telepon = a.No_Telepon;
            KaryawanLogin.Status = a.Status;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void HalamanUtamaApoteker_Load(object sender, EventArgs e)
        {
            labelNamaUser.Text = "Welcome," + KaryawanLogin.Nama_Karyawan;
            cbFilterCari.SelectedIndex = 0;

            RefreshResep();
        }

        private void labelUbahPassword_Click(object sender, EventArgs e)
        {
            tbKaryawan UbahPassKaryawan = new tbKaryawan();
            UbahPassKaryawan.ID_Karyawan = KaryawanLogin.ID_Karyawan;

            UbahPassword UbahPassword = new UbahPassword(UbahPassKaryawan);
            UbahPassword.ShowDialog();
        }

        private void RefreshResep()
        {
            db = new ApotekMekarsonDB();
            dgvResep.DataSource = db.tbPenjualan_Reseps.Select(x => x);
        }

        private void dgvResep_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResep.SelectedRows.Count >= 1)
            {
                var DataResep = dgvResep.SelectedRows[0].Cells[0].Value;
                IQueryable<tbPenjualan_Resep> QueryResep = db.tbPenjualan_Reseps.Where(x => x.ID_Penjualan_Resep == DataResep.ToString());
                tbPenjualan_Resep selectedResep = QueryResep.FirstOrDefault();

                if (selectedResep != null)
                {
                    dgvDetailResep.DataSource = db.tbDetail_Penjualan_Reseps.Where(x => x.ID_Penjualan_Resep == selectedResep.ID_Penjualan_Resep).Select(x => new { x.ID_Detail_Penjualan, x.tbRacikan.Harga, x.Qty, x.Sub_Total });
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            IQueryable<tbPenjualan_Resep> resep;
            switch (cbFilterCari.SelectedIndex)
            {
                case 0: //ID Resep
                    resep = db.tbPenjualan_Reseps.Where(x => x.ID_Penjualan_Resep.Contains(tbCari.Text) && x.Tanggal_Penjualan >= dtpTanggalAwal.Value && x.Tanggal_Penjualan <= dtpTanggalAkhir.Value).Select(x =>x);
                    break;
                default: //Asal Resep
                    resep = db.tbPenjualan_Reseps.Where(x => x.Nama_Dokter.Contains(tbCari.Text) && x.Tanggal_Penjualan >= dtpTanggalAwal.Value && x.Tanggal_Penjualan <= dtpTanggalAkhir.Value).Select(x => x);
                    break;
            }
            dgvResep.DataSource = resep.ToList();
        }

        private void tambahBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbKaryawan kar = new tbKaryawan();
            kar = db.tbKaryawans.Where(x => x.ID_Karyawan == KaryawanLogin.ID_Karyawan && x.Password == KaryawanLogin.Password).FirstOrDefault();
            TambahPenjualanResep TambahPenjualanResep = new TambahPenjualanResep(kar);
            TambahPenjualanResep.ShowDialog();
            RefreshResep();
        }

        private void hapusResepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Apakah Anda yakin ingin menghapus data resep ini?", "Warning", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                PenjualanResep pr = new PenjualanResep();
                pr.ID_Penjualan_Resep = dgvResep.SelectedRows[0].Cells[0].Value.ToString();
                pr.HapusPenjualanResepMethod(pr);
                RefreshResep();
                MessageBox.Show("Data resep ini berhasil dihapus.");
            }
            else
                MessageBox.Show("Data resep batal dihapus.");
        }

        private void dgvResep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvResep.Columns[e.ColumnIndex].Name.ToLower().Contains("total_penjualan"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void dgvDetailResep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailResep.Columns[e.ColumnIndex].Name.ToLower().Contains("harga") || dgvDetailResep.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }
    }
}
