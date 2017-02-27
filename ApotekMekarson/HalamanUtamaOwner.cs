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
    public partial class HalamanUtamaOwner : Form
    {
        ApotekMekarsonDB db;
        Karyawan KaryawanLogin;

        public HalamanUtamaOwner()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
        }

        public HalamanUtamaOwner(tbKaryawan a)
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

        private void HalamanUtamaOwner_Load(object sender, EventArgs e)
        {
            panelPeringatanObat.Visible = true;
            panelRetur.Visible = false;
            panelKaryawan.Visible = false;
            panelSupplier.Visible = false;
            panelObat.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;

            RefreshKaryawan();
            RefreshSupplier();
            RefreshObat();
            RefreshPenjualan();
            RefreshPembelian();
            RefreshRetur();

            dgvStokMinim.DataSource = db.tbObats.Where(x => x.Qty <= x.Stok_Minim);
            dgvJatuhTempo.DataSource = db.tbPembelians.Where(x => x.Jatuh_Tempo == DateTime.Now).OrderBy(x => x.Jatuh_Tempo).Select(x => new {x.No_faktur,x.tbSupplier.Nama_Supplier,x.tbKaryawan.Nama_Karyawan,x.Tanggal_Pembelian,x.Jatuh_Tempo });

            labelNamaUser.Text = "Welcome," + KaryawanLogin.Nama_Karyawan;
            cbKunciPencarianKaryawan.SelectedIndex = 0;
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelObat.Visible = false;
            panelRetur.Visible = false;
            panelPeringatanObat.Visible = false;
            panelSupplier.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;
            panelKaryawan.Visible = true;
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelObat.Visible = false;
            panelRetur.Visible = false;
            panelPeringatanObat.Visible = false;
            panelKaryawan.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelSupplier.Visible = false;
            panelPembelian.Visible = true;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelObat.Visible = false;
            panelRetur.Visible = false;
            panelPeringatanObat.Visible = false;
            panelKaryawan.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;
            panelSupplier.Visible = true;
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelKaryawan.Visible = false;
            panelRetur.Visible = false;
            panelSupplier.Visible = false;
            panelPeringatanObat.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;
            panelObat.Visible = true;

            RefreshObat();
        }

        private void nonResepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelKaryawan.Visible = false;
            panelRetur.Visible = false;
            panelSupplier.Visible = false;
            panelPeringatanObat.Visible = false;
            panelObat.Visible = false;
            panelPembelian.Visible = false;
            panelPenjualanNonResep.Visible = true;
        }

        private void PeringatanObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelKaryawan.Visible = false;
            panelRetur.Visible = false;
            panelObat.Visible = false;
            panelSupplier.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;
            panelPeringatanObat.Visible = true;

            dgvStokMinim.DataSource = db.tbObats.Where(x => x.Qty <= x.Stok_Minim);
            dgvJatuhTempo.DataSource = db.tbPembelians.Where(x => x.Jatuh_Tempo == DateTime.Now).OrderBy(x => x.Jatuh_Tempo).Select(x => new { x.No_faktur, x.tbSupplier.Nama_Supplier, x.tbKaryawan.Nama_Karyawan, x.Tanggal_Pembelian, x.Jatuh_Tempo });
        }

        private void ReturtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelKaryawan.Visible = false;
            panelObat.Visible = false;
            panelSupplier.Visible = false;
            panelPenjualanNonResep.Visible = false;
            panelPembelian.Visible = false;
            panelPeringatanObat.Visible = false;
            panelRetur.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void RefreshKaryawan()
        {
            db = new ApotekMekarsonDB();
            if (checkBoxAkitf.Checked)
                dgvKaryawan.DataSource = db.tbKaryawans.Where(x => x.Status == "Aktif");
            else
                dgvKaryawan.DataSource = db.tbKaryawans.Select(x => x);
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
            dgvPenjualan.DataSource = db.tbPenjualans.Select(x => new {x.Id_Penjualan,x.tbKaryawan.Nama_Karyawan,x.Tanggal_Penjualan,x.Total_Penjualan,x.ID_Karyawan });
        }

        private void dgvPenjualan_SelectionChanged(object sender, EventArgs e)
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

        private void RefreshPembelian()
        {
            db = new ApotekMekarsonDB();
            dgvPembelian.DataSource = db.tbPembelians.Select(x => new {x.No_faktur,x.tbKaryawan.Nama_Karyawan,x.tbSupplier.Nama_Supplier,x.Tanggal_Pembelian,x.Jatuh_Tempo,x.Total_Pembelian,x.Status,x.ID_Karyawan,x.ID_Supplier });
        }

        private void dgvPembelian_SelectionChanged(object sender, EventArgs e)
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
                int idRetur = 0;
                var DataRetur = dgvRetur.SelectedRows[0].Cells[0].Value;
                int.TryParse(DataRetur.ToString(), out idRetur);

                IQueryable<tbRetur> QueryRetur = db.tbReturs.Where(x => x.ID_Retur == idRetur);
                tbRetur selectedRetur = QueryRetur.FirstOrDefault();

                if (selectedRetur != null)
                {
                    dgvDetailRetur.DataSource = db.tbDetail_Returs.Where(x => x.ID_Retur == selectedRetur.ID_Retur).Select(x => new {x.Id_Detail_Retur,x.No_Batch,x.tbObat.Nama_Obat,x.Qty,x.IdDetailPembelian });
                }
            }
        }

        private void tbCariKaryawan_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbKaryawan> kar;

            if (checkBoxAkitf.Checked)
            {
                switch (cbKunciPencarianKaryawan.SelectedIndex)
                {
                    case 0: //ID Karyawan
                        kar = db.tbKaryawans.Where(x => x.ID_Karyawan.Contains(tbCariKaryawan.Text) && x.Status == "Aktif");
                        break;
                    case 1: //Nama Karyawan
                        kar = db.tbKaryawans.Where(x => x.Nama_Karyawan.Contains(tbCariKaryawan.Text) && x.Status == "Aktif");
                        break;
                    default: //Alamat Karyawan
                        kar = db.tbKaryawans.Where(x => x.Alamat_Karyawan.Contains(tbCariKaryawan.Text) && x.Status == "Aktif");
                        break;
                }
            }
            else
            {
                switch (cbKunciPencarianKaryawan.SelectedIndex)
                {
                    case 0: //ID Karyawan
                        kar = db.tbKaryawans.Where(x => x.ID_Karyawan.Contains(tbCariKaryawan.Text));
                        break;
                    case 1: //Nama Karyawan
                        kar = db.tbKaryawans.Where(x => x.Nama_Karyawan.Contains(tbCariKaryawan.Text));
                        break;
                    default: //Alamat Karyawan
                        kar = db.tbKaryawans.Where(x => x.Alamat_Karyawan.Contains(tbCariKaryawan.Text));
                        break;
                }
            }

            dgvKaryawan.DataSource = kar.ToList();
        }

        private void tbCariSupplier_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbSupplier> sup;
            sup = db.tbSuppliers.Where(x => x.Nama_Supplier.Contains(tbCariSupplier.Text));

            dgvSupplier.DataSource = sup.ToList();
        }

        private void checkBoxAkitf_CheckedChanged(object sender, EventArgs e)
        {
            RefreshKaryawan();
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            TambahKaryawan TambahKaryawan = new TambahKaryawan();
            TambahKaryawan.ShowDialog();
            RefreshKaryawan();
        }

        private void labelUbahPassword_Click(object sender, EventArgs e)
        {
            tbKaryawan UbahPassKaryawan = new tbKaryawan();
            UbahPassKaryawan.ID_Karyawan = KaryawanLogin.ID_Karyawan;

            UbahPassword UbahPassword = new UbahPassword(UbahPassKaryawan);
            UbahPassword.ShowDialog();
            RefreshKaryawan();
        }

        private void btnResetPasswordKaryawan_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count >= 1)
            {
                tbKaryawan karyawanData = (tbKaryawan)dgvKaryawan.SelectedRows[0].DataBoundItem;

                IQueryable<tbKaryawan> queryKaryawan = db.tbKaryawans.Where(x => x.ID_Karyawan == karyawanData.ID_Karyawan);

                tbKaryawan selectedKaryawan = queryKaryawan.FirstOrDefault();

                if (selectedKaryawan != null)
                {
                    MD5CryptoServiceProvider encrypt = new MD5CryptoServiceProvider();
                    byte[] chiper = System.Text.Encoding.UTF8.GetBytes("apotekmekarson");
                    chiper = encrypt.ComputeHash(chiper);
                    System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
                    foreach (byte item in chiper)
                    {
                        stringBuilder.Append(item.ToString("x2").ToLower());
                    }
                    string hasil = stringBuilder.ToString();

                    selectedKaryawan.Password = hasil;
                    MessageBox.Show("Password berhasil direset.");
                    db.SubmitChanges();
                }
            }
            RefreshKaryawan();
        }

        private void btnUbahKaryawan_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count >= 1)
            {
                tbKaryawan p = (tbKaryawan)dgvKaryawan.SelectedRows[0].DataBoundItem;

                IQueryable<tbKaryawan> ps = db.tbKaryawans.Where(x => x.ID_Karyawan == p.ID_Karyawan);

                tbKaryawan selectedKaryawan = ps.FirstOrDefault();

                if (selectedKaryawan != null)
                {
                    UbahDataKaryawan UbahDataKaryawan = new UbahDataKaryawan(selectedKaryawan);
                    UbahDataKaryawan.ShowDialog();                    
                    RefreshKaryawan();
                }
            }
        }

        private void btnTambahSupplier_Click(object sender, EventArgs e)
        {
            TambahSupplier TambahSupplier = new TambahSupplier();
            TambahSupplier.ShowDialog();
            RefreshSupplier();
        }

        private void btnUbahSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count >= 1)
            {
                tbSupplier sup = (tbSupplier)dgvSupplier.SelectedRows[0].DataBoundItem;

                IQueryable<tbSupplier> ps = db.tbSuppliers.Where(x => x.ID_Supplier == sup.ID_Supplier);

                tbSupplier selectedSupplier = ps.FirstOrDefault();

                if (selectedSupplier != null)
                {
                    UbahSupplier UbahSupplier = new UbahSupplier(selectedSupplier);
                    UbahSupplier.ShowDialog();
                    RefreshSupplier();
                }
            }
        }

        private void btnHapusSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count >= 1)
            {
                tbSupplier sup = (tbSupplier)dgvSupplier.SelectedRows[0].DataBoundItem;

                var tes = db.tbPembelians.Where(x => x.ID_Supplier == sup.ID_Supplier).FirstOrDefault();

                if (tes != null)
                {
                    MessageBox.Show("Mohon maaf, data supplier yang telah memiliki record pembelian tidak dapat dihapus.");
                }
                else
                {
                    DialogResult mbox = MessageBox.Show("Apakah Anda yakin ingin menghapus data supplier ini ?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mbox == DialogResult.Yes)
                    {
                        Supplier DeletedSupplier = new Supplier();
                        DeletedSupplier.ID_Supplier = sup.ID_Supplier;
                        DeletedSupplier.Nama_Supplier = sup.Nama_Supplier;
                        DeletedSupplier.Alamat_Supplier = sup.Alamat_Supplier;
                        DeletedSupplier.No_Telepon = sup.No_Telepon;

                        DeletedSupplier.HapusSupplierMethod(DeletedSupplier);
                        RefreshSupplier();
                    }
                }
            }
        }

        private void tbCariObat_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbObat> obat;

            obat = db.tbObats.Where(x => x.Nama_Obat.Contains(tbCariObat.Text));

            dgvObat.DataSource = obat.ToList();
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            TambahObat TambahObat = new TambahObat();
            TambahObat.ShowDialog();
            RefreshObat();
        }

        private void btnUbahObat_Click(object sender, EventArgs e)
        {
            if (dgvObat.SelectedRows.Count >= 1)
            {
                tbObat obt = (tbObat)dgvObat.SelectedRows[0].DataBoundItem;

                IQueryable<tbObat> ps = db.tbObats.Where(x => x.No_Batch == obt.No_Batch);

                tbObat selectedObat = ps.FirstOrDefault();

                if (selectedObat != null)
                {
                    UbahObat UbahObat = new UbahObat(selectedObat);
                    UbahObat.ShowDialog();
                    RefreshObat();
                }
            }
        }

        private void btnHapusObat_Click(object sender, EventArgs e)
        {
            if (dgvObat.SelectedRows.Count >= 1)
            {
                tbObat obt = (tbObat)dgvObat.SelectedRows[0].DataBoundItem;

                var tes = db.tbDetail_Penjualans.Where(x => x.No_Batch == obt.No_Batch).FirstOrDefault();

                if (tes != null)
                {
                    MessageBox.Show("Mohon maaf, data obat yang telah memiliki record penjualan tidak dapat dihapus.");
                }
                else
                {
                    DialogResult mbox =  MessageBox.Show("Apakah Anda yakin ingin menghapus data obat ini ?","Peringatan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (mbox == DialogResult.Yes)
                    {
                        Obat DeletedObat = new Obat();
                        DeletedObat.No_Batch = obt.No_Batch;
                        DeletedObat.Nama_Obat = obt.Nama_Obat;
                        DeletedObat.Qty = (int)obt.Qty;
                        DeletedObat.Stok_Minim = (int)obt.Stok_Minim;
                        DeletedObat.Harga_Beli = (int)obt.Harga_Beli;
                        DeletedObat.Harga_Jual = (int)obt.Harga_Jual;
                        DeletedObat.Jenis_Barang = obt.Jenis_Barang;
                        DeletedObat.Satuan = obt.Satuan;
                        DeletedObat.Nama_Supplier = obt.Nama_Supplier;
                        DeletedObat.Keterangan = obt.Keterangan;

                        DeletedObat.HapusObatMethod(DeletedObat);
                        MessageBox.Show("Data obat berhasil dihapus.");
                        RefreshObat();   
                    }
                }
            }
        }

        private void btnCariPenjualan_Click(object sender, EventArgs e)
        {
            dgvPenjualan.DataSource = db.tbPenjualans.Where(x => x.Tanggal_Penjualan >= dtpTanggalAwal.Value && x.Tanggal_Penjualan <= dtpTanggalAkhir.Value).Select(x => new {x.Id_Penjualan,x.tbKaryawan.Nama_Karyawan,x.Tanggal_Penjualan,x.Total_Penjualan });
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

        private void btnUbahDetailPenjualan_Click(object sender, EventArgs e)
        {
            tbKaryawan KaryawanTransaksi = new tbKaryawan();

            var selectedPenjualan = dgvPenjualan.SelectedRows[0].Cells[0].Value.ToString();
            KaryawanTransaksi.ID_Karyawan = KaryawanLogin.ID_Karyawan;

            UbahPenjualan UbahPenjualan = new UbahPenjualan(KaryawanTransaksi,selectedPenjualan);
            UbahPenjualan.ShowDialog();
            RefreshPenjualan();
            RefreshObat();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPenjualan.SelectedRows.Count >= 1)
            {
                var penjualan = dgvPenjualan.SelectedRows[0].Cells[0].Value;

                var queryDetail = db.tbDetail_Penjualans.Where(x => x.ID_Penjualan == penjualan.ToString()).FirstOrDefault();

                if (queryDetail != null)
                {
                    MessageBox.Show("Mohon maaf, data penjualan yang telah memiliki detail penjualan tidak dapat dihapus. Silahkan hapus detail penjualan terlebih dahulu.");
                }
                else
                {
                    Penjualan DeletedPenjualan = new Penjualan();
                    DeletedPenjualan.ID_Penjualan = penjualan.ToString();

                    DeletedPenjualan.DeletePenjualan(DeletedPenjualan);
                    MessageBox.Show("Data penjualan berhasil dihapus.");
                    RefreshPenjualan();
                }
            }
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

        private void btnHapusPembelian_Click(object sender, EventArgs e)
        {
            if (dgvPembelian.SelectedRows.Count >= 1)
            {
                var pembelian = dgvPembelian.SelectedRows[0].Cells[0].Value;

                var queryDetail = db.tbDetail_Pembelians.Where(x => x.No_Faktur == pembelian.ToString()).FirstOrDefault();
                var queryRetur = db.tbReturs.Where(x => x.No_Faktur == pembelian.ToString()).FirstOrDefault();

                if (queryDetail != null || queryRetur != null)
                {
                    MessageBox.Show("Mohon maaf, data pembelian yang telah memiliki detail pembelian dan data retur tidak dapat dihapus. Silahkan hapus detail pembelian dan data retur terlebih dahulu.");
                }
                else
                {
                    DialogResult mbox = MessageBox.Show("Apakah anda yakin ingin menghapus data pembelian ini ?","Peringatan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (mbox == DialogResult.Yes)
                    {
                        Pembelian DeletedPembelian = new Pembelian();
                        DeletedPembelian.No_Faktur = pembelian.ToString();

                        DeletedPembelian.HapusPembelianMethod(DeletedPembelian);
                        MessageBox.Show("Data pembelian berhasil dihapus.");
                        RefreshPembelian();
                    }
                }
            }
        }

        private void btnUbahDetailPembelian_Click(object sender, EventArgs e)
        {
            tbKaryawan KaryawanTransaksi = new tbKaryawan();

            var selectedPembelian = dgvPembelian.SelectedRows[0].Cells[0].Value.ToString();
            KaryawanTransaksi.ID_Karyawan = KaryawanLogin.ID_Karyawan;

            UbahPembelian UbahPembelian = new UbahPembelian(KaryawanTransaksi, selectedPembelian);
            UbahPembelian.ShowDialog();
            RefreshPembelian();
            RefreshObat();
        }

        private void btnCariPembelian_Click(object sender, EventArgs e)
        {
            dgvPembelian.DataSource = db.tbPembelians.Where(x => x.Tanggal_Pembelian >= dtpTanggalAwalPembelian.Value && x.Tanggal_Pembelian <= dtpTanggalAkhirPembelian.Value).Select(x => new { x.No_faktur, x.tbKaryawan.Nama_Karyawan, x.tbSupplier.Nama_Supplier, x.Tanggal_Pembelian, x.Jatuh_Tempo, x.Total_Pembelian, x.Status, x.ID_Karyawan, x.ID_Supplier});
        }

        private void btnReturBarang_Click(object sender, EventArgs e)
        {
            PilihSupplierMenu PilihSupplierMenu = new PilihSupplierMenu();
            PilihSupplierMenu.ShowDialog();
            RefreshRetur();
            RefreshObat();
        }

        private void btnHapusRetur_Click(object sender, EventArgs e)
        {
            int JumlahRows = dgvDetailRetur.Rows.Count;

            DialogResult dialogresult = MessageBox.Show("Apakah Anda yakin ingin menghapus data retur ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                for (int i = 0; i < JumlahRows; i++)
                {
                    int IdDetailRetur = (int)dgvDetailRetur.Rows[i].Cells[0].Value;
                    string NoBatch = dgvDetailRetur.Rows[i].Cells["No_Batch"].Value.ToString();
                    int IdDetailPembelian = (int)dgvDetailRetur.Rows[i].Cells["IdDetailPembelian"].Value;
                    int Qty = (int)dgvDetailRetur.Rows[i].Cells["Qty"].Value;

                    DetailRetur DetailRetur = new DetailRetur();
                    DetailRetur.ID_Detail_Retur = IdDetailRetur;
                    DetailRetur.No_Batch = NoBatch;
                    DetailRetur.Id_Detail_Pembelian = IdDetailPembelian;
                    DetailRetur.Qty = Qty;
                    DetailRetur.HapusDetailMethod(DetailRetur);
                }
                int ID_Retur = 0;
                int.TryParse(dgvRetur.SelectedRows[0].Cells[0].Value.ToString(), out ID_Retur);
                Retur retur = new Retur();
                retur.ID_Retur = ID_Retur;
                retur.HapusReturMethod(retur);
                MessageBox.Show("Data retur berhasil dihapus.");
                RefreshRetur();
            }
        }

        private void btnLunas_Click(object sender, EventArgs e)
        {
            db = new ApotekMekarsonDB();
            Pembelian pembelian = new Pembelian();
            string status;

            pembelian.No_Faktur = dgvPembelian.SelectedRows[0].Cells[0].Value.ToString();
            status = dgvPembelian.SelectedRows[0].Cells["Status"].Value.ToString();

            DialogResult mbox = MessageBox.Show("Apakah Anda yakin ingin mengubah status pembelian dengan no faktur : "+pembelian.No_Faktur,"Peringatan",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (mbox == DialogResult.Yes)
            {
                if (status == "Lunas")
                {
                    pembelian.Status = "Belum Lunas";
                }
                else
                {
                    pembelian.Status = "Lunas";
                }

                pembelian.UbahStatusMethod(pembelian);
                RefreshPembelian();
            }
        }

        private void btnCariRetur_Click(object sender, EventArgs e)
        {
            dgvRetur.DataSource = db.tbReturs.Where(x => x.Tanggal_Retur >= dtpTanggalReturAwal.Value && x.Tanggal_Retur <= dtpTanggalReturAkhir.Value).Select(x => new { x.ID_Retur,x.Tanggal_Retur,x.No_Faktur });
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanPenjualan lp = new LaporanPenjualan();
            lp.ShowDialog();
        }

        private void laporanPenjualanResepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanPenjualanResep lpr = new LaporanPenjualanResep();
            lpr.ShowDialog();
        }

        private void laporanPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanPembelian lpm = new LaporanPembelian();
            lpm.ShowDialog();
        }

        private void laporanInventoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanInventori li = new LaporanInventori();
            li.ShowDialog();
        }

        private void dgvObat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >0)
            {
                if (dgvObat.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual") || dgvObat.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_beli"))
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

        private void dgvStokMinim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvStokMinim.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_beli") || dgvStokMinim.Columns[e.ColumnIndex].Name.ToLower().Contains("harga_jual"))
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
