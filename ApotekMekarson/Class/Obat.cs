using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Obat
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _No_Batch;
        private string _Nama_Obat;
        private int _Qty;
        private int _Stok_Minim;
        private decimal _Harga_Beli;
        private decimal _Harga_Jual;
        private string _Jenis_Barang;
        private string _Satuan;
        private string _Nama_Supplier;
        private string _Keterangan;

        public string Nama_Supplier
        {
            get { return _Nama_Supplier; }
            set { _Nama_Supplier = value; }
        }

        public string Keterangan
        {
            get { return _Keterangan; }
            set { _Keterangan = value; }
        }

        public string Satuan
        {
            get { return _Satuan; }
            set { _Satuan = value; }
        }

        public string Jenis_Barang
        {
            get { return _Jenis_Barang; }
            set { _Jenis_Barang = value; }
        }

        public decimal Harga_Jual
        {
            get { return _Harga_Jual; }
            set { _Harga_Jual = value; }
        }

        public decimal Harga_Beli
        {
            get { return _Harga_Beli; }
            set { _Harga_Beli = value; }
        }

        public int Stok_Minim
        {
            get { return _Stok_Minim; }
            set { _Stok_Minim = value; }
        }

        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public string Nama_Obat
        {
            get { return _Nama_Obat; }
            set { _Nama_Obat = value; }
        }

        public string No_Batch
        {
            get { return _No_Batch; }
            set { _No_Batch = value; }
        }

        public void TambahObatMethod(Obat obt)
        {
            db.SP_TambahDataObat(obt.No_Batch, obt.Nama_Obat, obt.Qty, obt.Stok_Minim, obt.Harga_Beli, obt.Harga_Jual, obt.Jenis_Barang, obt.Satuan, obt.Nama_Supplier, obt.Keterangan);
            db.SubmitChanges();
        }

        public void UbahObatMethod(Obat obt)
        {
            db.SP_UbahDataObat(obt.No_Batch, obt.Nama_Obat, obt.Qty, obt.Stok_Minim, obt.Harga_Beli, obt.Harga_Jual, obt.Jenis_Barang, obt.Satuan, obt.Nama_Supplier, obt.Keterangan);
            db.SubmitChanges();
        }

        public void HapusObatMethod(Obat obt)
        {
            tbObat ObatDeleted = new tbObat();

            ObatDeleted.No_Batch = obt.No_Batch;
            ObatDeleted.Nama_Obat = obt.Nama_Obat;
            ObatDeleted.Qty = (int)obt.Qty;
            ObatDeleted.Stok_Minim = (int)obt.Stok_Minim;
            ObatDeleted.Harga_Beli = (int)obt.Harga_Beli;
            ObatDeleted.Harga_Jual = (int)obt.Harga_Jual;
            ObatDeleted.Jenis_Barang = obt.Jenis_Barang;
            ObatDeleted.Satuan = obt.Satuan;
            ObatDeleted.Nama_Supplier = obt.Nama_Supplier;
            ObatDeleted.Keterangan = obt.Keterangan;

            db.tbObats.Attach(ObatDeleted);
            db.tbObats.DeleteOnSubmit(ObatDeleted);
            db.SubmitChanges();
        }
    }
}
