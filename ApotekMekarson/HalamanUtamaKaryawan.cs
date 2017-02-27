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
    public partial class HalamanUtamaKaryawan : Form
    {
        ApotekMekarsonDB db;
        Karyawan KaryawanLogin;

        public HalamanUtamaKaryawan()
        {
            InitializeComponent();
        }

        public HalamanUtamaKaryawan(tbKaryawan a)
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

        private void HalamanUtamaKaryawan_Load(object sender, EventArgs e)
        {
            labelNamaUser.Text = "Welcome," + KaryawanLogin.Nama_Karyawan;

            dgvDataStokMinim.DataSource = db.tbObats.Where(x => x.Qty <= x.Stok_Minim);
            dgvPembelianJatuhTempo.DataSource = db.tbPembelians.Where(x => (DateTime.Now - x.Jatuh_Tempo.Value).TotalDays < 0).OrderBy(x => x.Jatuh_Tempo).Select(x => new { x.No_faktur, x.tbSupplier.Nama_Supplier, x.tbKaryawan.Nama_Karyawan, x.Tanggal_Pembelian, x.Jatuh_Tempo });

            RefreshSupplier();
            RefreshObat();
            RefreshPenjualan();
            RefreshPembelian();
            RefreshRetur();

            panelPeringatanObat.Visible = true;
            panelObat.Visible = false;
            panelSupplier.Visible = false;
            panelPenjualan.Visible = false;
            panelPembelian.Visible = false;
            panelRetur.Visible = false;
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelObat.Visible = true;
            panelPeringatanObat.Visible = false;
            panelSupplier.Visible = false;
            panelPenjualan.Visible = false;
            panelPembelian.Visible = false;
            panelRetur.Visible = false;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSupplier.Visible = true;
            panelPeringatanObat.Visible = false;
            panelPenjualan.Visible = false;
            panelObat.Visible = false;
            panelPembelian.Visible = false;
            panelRetur.Visible = false;
        }

        private void penjualanNonResepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPenjualan.Visible = true;
            panelPeringatanObat.Visible = false;
            panelSupplier.Visible = false;
            panelObat.Visible = false;
            panelPembelian.Visible = false;
            panelRetur.Visible = false;
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPembelian.Visible = true;
            panelPenjualan.Visible = false;
            panelPeringatanObat.Visible = false;
            panelSupplier.Visible = false;
            panelObat.Visible = false;
            panelRetur.Visible = false;
        }

        private void returToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRetur.Visible = true;
            panelPembelian.Visible = false;
            panelPenjualan.Visible = false;
            panelPeringatanObat.Visible = false;
            panelSupplier.Visible = false;
            panelObat.Visible = false;
        }

        private void peringatanObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPeringatanObat.Visible = true;
            panelRetur.Visible = false;
            panelPembelian.Visible = false;
            panelPenjualan.Visible = false;
            panelSupplier.Visible = false;
            panelObat.Visible = false;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void RefreshRetur()
        {
            db = new ApotekMekarsonDB();
            dgvRetur.DataSource = db.tbReturs.Select(x => x);
        }

        private void RefreshSupplier()
        {
            db = new ApotekMekarsonDB();
            dgvSupplier.DataSource = db.tbSuppliers.Select(x => x);
        }

        private void RefreshObat()
        {
            db = new ApotekMekarsonDB();
            dgvObat.DataSource = db.tbObats.Select(x => x);
        }

        private void RefreshPenjualan()
        {
            db = new ApotekMekarsonDB();
            dgvPenjualan.DataSource = db.tbPenjualans.Select(x => new { x.Id_Penjualan, x.tbKaryawan.Nama_Karyawan, x.Tanggal_Penjualan, x.Total_Penjualan, x.ID_Karyawan });
        }

        private void RefreshPembelian()
        {
            db = new ApotekMekarsonDB();
            dgvPembelian.DataSource = db.tbPembelians.Select(x => new { x.No_faktur, x.tbKaryawan.Nama_Karyawan, x.tbSupplier.Nama_Supplier, x.Tanggal_Pembelian, x.Jatuh_Tempo, x.Total_Pembelian, x.Status, x.ID_Karyawan, x.ID_Supplier });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tbKaryawan UbahPassKaryawan = new tbKaryawan();
            UbahPassKaryawan.ID_Karyawan = KaryawanLogin.ID_Karyawan;

            UbahPassword UbahPassword = new UbahPassword(UbahPassKaryawan);
            UbahPassword.ShowDialog();
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            TambahObat TambahObat = new TambahObat();
            TambahObat.ShowDialog();
            RefreshObat();       
        }

        private void btnTambahSupplier_Click(object sender, EventArgs e)
        {
            TambahSupplier TambahSupplier = new TambahSupplier();
            TambahSupplier.ShowDialog();
            RefreshSupplier();
        }

        private void btnTambahPenjualan_Click(object sender, EventArgs e)
        {
            tbKaryawan KaryawanTransaksi = new tbKaryawan();
            KaryawanTransaksi.ID_Karyawan = KaryawanLogin.ID_Karyawan;
            TambahPenjualan TambahPenjualan = new TambahPenjualan(KaryawanTransaksi);
            TambahPenjualan.ShowDialog();
 
            RefreshPenjualan();
            RefreshObat();
        }

        private void btnTambahPembelian_Click(object sender, EventArgs e)
        {
            tbKaryawan KaryawanTransaksi = new tbKaryawan();
            KaryawanTransaksi.ID_Karyawan = KaryawanLogin.ID_Karyawan;
            TambahPembelian TambahPembelian = new TambahPembelian(KaryawanTransaksi);
            TambahPembelian.ShowDialog();
            RefreshPembelian();
            RefreshObat();
        }

        private void btnReturBarang_Click(object sender, EventArgs e)
        {
            PilihSupplierMenu PilihSupplierMenu = new PilihSupplierMenu();
            PilihSupplierMenu.ShowDialog();
            RefreshRetur();
            RefreshObat();
        }

        private void dgvPenjualan_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPenjualan.SelectedRows.Count >= 1)
            {
                var DataPenjualan = dgvPenjualan.SelectedRows[0].Cells[0].Value;
                IQueryable<tbPenjualan> queryPenjualan = db.tbPenjualans.Where(x => x.Id_Penjualan == DataPenjualan.ToString());
                tbPenjualan selectedPenjualan = queryPenjualan.FirstOrDefault();

                if (selectedPenjualan != null)
                {
                    dgvDetailPenjualan.DataSource = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == selectedPenjualan.Id_Penjualan).Select(x => new { x.Id_Detail_Penjualan, x.No_Batch, x.tbObat.Nama_Obat, x.tbObat.Harga_Jual, x.Qty, x.Sub_Total });
                }
            }
        }

        private void dgvPembelian_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPembelian.SelectedRows.Count >= 1)
            {
                var DataPembelian = dgvPembelian.SelectedRows[0].Cells[0].Value;
                IQueryable<tbPembelian> QueryPembelian = db.tbPembelians.Where(x => x.No_faktur == DataPembelian.ToString());
                tbPembelian selectedPembelian = QueryPembelian.FirstOrDefault();

                if (selectedPembelian != null)
                {
                    dgvDetailPembelian.DataSource = db.tbDetail_Pembelians.Where(x => x.No_Faktur == selectedPembelian.No_faktur).Select(x => new { x.Id_Detail_Pembelian, x.No_Batch, x.tbObat.Nama_Obat, x.Qty, x.Bonus, x.Harga, x.Sub_Total });
                }
            }
        }

        private void dgvRetur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRetur.SelectedRows.Count >= 1)
            {
                var DataRetur = dgvRetur.SelectedRows[0].Cells[0].Value;
                int id = 0;
                int.TryParse(DataRetur.ToString(), out id);
                IQueryable<tbRetur> QueryRetur = db.tbReturs.Where(x => x.ID_Retur == id);
                tbRetur selectedRetur = QueryRetur.FirstOrDefault();

                if (selectedRetur != null)
                {
                    dgvDetailRetur.DataSource = db.tbDetail_Returs.Where(x => x.ID_Retur == selectedRetur.ID_Retur).Select(x => new { x.Id_Detail_Retur,x.No_Batch,x.tbObat.Nama_Obat,x.Qty });
                }
            }
        }

        private void dgvObat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvObat.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_beli") || dgvObat.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void dgvPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("total_penjualan"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void dgvDetailPenjualan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual") || dgvDetailPenjualan.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void dgvPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvPembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("total_pembelian"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void dgvDetailPembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailPembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("harga") || dgvDetailPembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void btnCariRetur_Click_1(object sender, EventArgs e)
        {
            dgvRetur.DataSource = db.tbReturs.Where(x => x.Tanggal_Retur >= dtpTanggalReturAwal.Value && x.Tanggal_Retur <= dtpTanggalReturAkhir.Value).Select(x => new { x.ID_Retur, x.Tanggal_Retur, x.No_Faktur });
        }

        private void dgvDataStokMinim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDataStokMinim.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_beli") || dgvDataStokMinim.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual"))
                {
                    if (e.Value.ToString() != "")
                    {
                        double d = double.Parse(e.Value.ToString());
                        e.Value = d.ToString("n0");
                    }
                }
            }
        }

        private void btnCariPembelian_Click_1(object sender, EventArgs e)
        {
            dgvPembelian.DataSource = db.tbPembelians.Where(x => x.Tanggal_Pembelian >= dtpTanggalAwalPembelian.Value && x.Tanggal_Pembelian <= dtpTanggalAkhirPembelian.Value).Select(x => new { x.No_faktur, x.tbKaryawan.Nama_Karyawan, x.tbSupplier.Nama_Supplier, x.Tanggal_Pembelian, x.Jatuh_Tempo, x.Total_Pembelian, x.Status, x.ID_Karyawan, x.ID_Supplier });
        }

        private void btnCariPenjualan_Click_1(object sender, EventArgs e)
        {
            dgvPenjualan.DataSource = db.tbPenjualans.Where(x => x.Tanggal_Penjualan >= dtpTanggalAwalPenjualan.Value && x.Tanggal_Penjualan <= dtpTanggalAkhirPenjualan.Value).Select(x => new { x.Id_Penjualan, x.tbKaryawan.Nama_Karyawan, x.Tanggal_Penjualan, x.Total_Penjualan, x.ID_Karyawan });
        }

        private void tbCariObat_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbObat> obat;

            obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCariObat.Text));

            dgvObat.DataSource = obat.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbSupplier > supplier;

            supplier = db.tbSuppliers.Where(x => x.Nama_Supplier.Contains(textBox1.Text));

            dgvSupplier.DataSource = supplier.ToList();
        }
    }
}
