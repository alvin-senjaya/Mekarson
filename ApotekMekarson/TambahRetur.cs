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
    public partial class TambahRetur : Form
    {
        ApotekMekarsonDB db;
        int idRetur = 0;
        int counter;
        string namaSupplier;

        public TambahRetur()
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();
        }

        public TambahRetur(string nSupplier)
        {
            InitializeComponent();
            db = new ApotekMekarsonDB();

            namaSupplier = nSupplier;
        }

        private void dgvPembelian_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPembelian.SelectedRows.Count >= 1)
            {
                var DataPembelian = dgvPembelian.SelectedRows[0].Cells[0].Value;
                IQueryable<tbPembelian> queryPembelian = db.tbPembelians.Where(x => x.No_faktur == DataPembelian.ToString());
                tbPembelian selectedPembelian = queryPembelian.FirstOrDefault();

                if (selectedPembelian != null)
                {
                    dgvDetailpembelian.DataSource = db.tbDetail_Pembelians.Where(x => x.No_Faktur == selectedPembelian.No_faktur).Select(x => new { x.Id_Detail_Pembelian, x.No_Batch, x.tbObat.Nama_Obat, x.Qty, x.Bonus, x.Harga, x.Sub_Total });
                    tbNoFaktur.Text = selectedPembelian.No_faktur;
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data retur berhasil disimpan.");
            this.Close();
        }

        private void TambahRetur_Load(object sender, EventArgs e)
        {
            dgvPembelian.DataSource = db.tbPembelians.Where(x=>x.tbSupplier.Nama_Supplier == namaSupplier).Select(x => new { x.No_faktur, x.tbKaryawan.Nama_Karyawan, x.tbSupplier.Nama_Supplier, x.Tanggal_Pembelian, x.Jatuh_Tempo, x.Total_Pembelian, x.Status, x.ID_Karyawan, x.ID_Supplier });
            cbFilterPencarian.SelectedIndex = 0;
            counter = 0;
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            IQueryable<tbPembelian> CariPembelian;
            switch (cbFilterPencarian.SelectedIndex)
            {
                case 0: //Nama Supplier
                    CariPembelian = db.tbPembelians.Where(x => x.tbSupplier.Nama_Supplier.Contains(tbCari.Text));
                    break;
                default: //No Faktur
                    CariPembelian = db.tbPembelians.Where(x => x.No_faktur.Contains(tbCari.Text));
                    break;
            }
            var selectedData = CariPembelian.Select(x => new { x.No_faktur, x.tbKaryawan.Nama_Karyawan, x.tbSupplier.Nama_Supplier, x.Tanggal_Pembelian, x.Jatuh_Tempo, x.Total_Pembelian, x.Status, x.ID_Karyawan, x.ID_Supplier });
            dgvPembelian.DataSource = selectedData.ToList();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {            
            db = new ApotekMekarsonDB();
            DetailRetur newDetailRetur = new DetailRetur();
            int qty = 0;
            int idDetailPembelian = 0;

            if (dgvDetailpembelian.SelectedRows.Count > 0)
            {
                int.TryParse(dgvDetailpembelian.SelectedRows[0].Cells[0].Value.ToString(), out idDetailPembelian);
                var query = db.tbDetail_Pembelians.Where(x => x.Id_Detail_Pembelian == idDetailPembelian).Select(x => x.Qty);
                qty = (int)query.FirstOrDefault();

                if (counter == 0)
                {
                    Retur newRetur = new Retur();

                    newRetur.Tanggal_Retur = DateTime.Now;
                    newRetur.No_Faktur = tbNoFaktur.Text;
                    newRetur.TambahReturMethod(newRetur);
                    counter ++;
                }

                if (qty - nudQty.Value >= 0 && counter != 0)
                {
                    newDetailRetur.Qty = (int)nudQty.Value;
                    newDetailRetur.No_Batch = tbNoBatch.Text;
                    newDetailRetur.ID_Retur = db.tbReturs.Select(x => x.ID_Retur).Max();
                    newDetailRetur.Id_Detail_Pembelian = idDetailPembelian;
                    newDetailRetur.TambahDetailMethod(newDetailRetur);
                    idRetur = db.tbReturs.Select(x => x.ID_Retur).Max();
                    MessageBox.Show("Data berhasil dimasukan.");
                    RefreshDetailRetur(idRetur);
                }
                else
                {
                    MessageBox.Show("Maaf jumlah yang anda masukan tidak sesuai.");
                }
            }
        }

        private void dgvDetailpembelian_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetailpembelian.SelectedRows.Count >= 1)
            {
                int idDetail = 0;
                var DetailPembelian = dgvDetailpembelian.SelectedRows[0].Cells[0].Value;
                int.TryParse(DetailPembelian.ToString(), out idDetail);
                IQueryable<tbDetail_Pembelian> queryDetail = db.tbDetail_Pembelians.Where(x => x.Id_Detail_Pembelian == idDetail);
                tbDetail_Pembelian selectedDetail = queryDetail.FirstOrDefault();

                if (selectedDetail != null)
                {
                    tbNoBatch.Text = selectedDetail.No_Batch;
                    tbNamaObat.Text = selectedDetail.tbObat.Nama_Obat;
                }

            }
        }

        private void RefreshDetailRetur(int idRetur)
        {
            db = new ApotekMekarsonDB();
            dgvDetailRetur.DataSource = db.tbDetail_Returs.Where(x => x.ID_Retur == idRetur).Select(x => new { x.Id_Detail_Retur, x.No_Batch, x.tbObat.Nama_Obat, x.Qty });
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDetailRetur.SelectedRows.Count >= 1)
            {
                var DataDetailRetur = dgvDetailRetur.SelectedRows[0].Cells[0].Value;

                IQueryable<tbDetail_Retur> queryDetail = db.tbDetail_Returs.Where(x => x.Id_Detail_Retur == (int)DataDetailRetur);

                tbDetail_Retur selectedData = queryDetail.FirstOrDefault();

                if (selectedData != null)
                {
                    DetailRetur DeleteRetur = new DetailRetur();
                    DeleteRetur.ID_Detail_Retur = selectedData.Id_Detail_Retur;
                    DeleteRetur.Qty = (int)selectedData.Qty;
                    DeleteRetur.No_Batch = selectedData.No_Batch;
                    DeleteRetur.Id_Detail_Pembelian = (int)selectedData.IdDetailPembelian;

                    DeleteRetur.HapusDetailMethod(DeleteRetur);
                    RefreshDetailRetur(idRetur);
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

        private void dgvDetailpembelian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (dgvDetailpembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("harga") || dgvDetailpembelian.Columns[e.ColumnIndex].Name.ToLower().Contains("sub_total"))
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
