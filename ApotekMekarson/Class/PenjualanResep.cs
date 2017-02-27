using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class PenjualanResep
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _ID_Penjualan_Resep;
        private DateTime _Tanggal_Penjualan;
        private decimal _Total_Penjualan;
        private string _Apoteker;
        private string _Nama_Dokter;
        private string _ID_Karyawan;

        public string ID_Karyawan
        {
            get { return _ID_Karyawan; }
            set { _ID_Karyawan = value; }
        }

        public string Nama_Dokter
        {
            get { return _Nama_Dokter; }
            set { _Nama_Dokter = value; }
        }

        public string Apoteker
        {
            get { return _Apoteker; }
            set { _Apoteker = value; }
        }

        public decimal Total_Penjualan
        {
            get { return _Total_Penjualan; }
            set { _Total_Penjualan = value; }
        }

        public DateTime Tanggal_Penjualan
        {
            get { return _Tanggal_Penjualan; }
            set { _Tanggal_Penjualan = value; }
        }

        public string ID_Penjualan_Resep
        {
            get { return _ID_Penjualan_Resep; }
            set { _ID_Penjualan_Resep = value; }
        }

        public void TambahPenjualanResepMethod(PenjualanResep pr)
        {
            db.SP_TambahPenjualanResep(pr.ID_Penjualan_Resep, pr.Tanggal_Penjualan, pr.Total_Penjualan ,pr.Apoteker, pr.Nama_Dokter, pr.ID_Karyawan);
            db.SubmitChanges();
        }

        public string BuatIDPenjualanResep()
        {
            return db.FC_BuatIDPenjualanResep();
        }

        public void HapusPenjualanResepMethod(PenjualanResep pr)
        {
            db.SP_HapusPenjualanResep(pr.ID_Penjualan_Resep);
            db.SubmitChanges();
        }

        public void HapusResepMethod(PenjualanResep pr)
        {
            db.SP_HapusResep(pr.ID_Penjualan_Resep);
            db.SubmitChanges();
        }

        public double HitungPenjualanResepMethod(PenjualanResep pr)
        {
            return (double)db.FC_HitungTotalPenjualanResep(pr._ID_Penjualan_Resep);
        }

        public void UbahTotalPenjualan(PenjualanResep pr)
        {
            db.SP_UbahTotalPenjualan(pr.Total_Penjualan, pr.ID_Penjualan_Resep);
            db.SubmitChanges();
        }
    }
}
