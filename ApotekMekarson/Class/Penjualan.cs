using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Penjualan
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _ID_Penjualan;
        private DateTime _Tanggal_Penjualan;
        private double _Total_Penjualan;
        private string _ID_Karyawan;

        public string ID_Karyawan
        {
            get { return _ID_Karyawan; }
            set { _ID_Karyawan = value; }
        }

        public double Total_Penjualan
        {
            get { return _Total_Penjualan; }
            set { _Total_Penjualan = value; }
        }

        public DateTime Tanggal_Penjualan
        {
            get { return _Tanggal_Penjualan; }
            set { _Tanggal_Penjualan = value; }
        }

        public string ID_Penjualan
        {
            get { return _ID_Penjualan; }
            set { _ID_Penjualan = value; }
        }

        public string BuatIDPenjualanBaru()
        {
            return db.FC_BuatIDPenjualanBaru();
        }

        public void TambahPenjualan(Penjualan penjualan)
        {
            db.SP_TambahPenjualan(penjualan.ID_Penjualan, penjualan.Tanggal_Penjualan, (decimal)penjualan.Total_Penjualan, penjualan.ID_Karyawan);
            db.SubmitChanges();
        }

        public void DeletePenjualan(Penjualan penjualan)
        {
            db.SP_DeletePenjualan(penjualan.ID_Penjualan);
            db.SubmitChanges();
        }

        public void UbahPenjualan(Penjualan penjualan)
        {
            db.SP_UbahPenjualan(penjualan.ID_Penjualan, penjualan.Tanggal_Penjualan, (decimal)penjualan.Total_Penjualan, penjualan.ID_Karyawan);
            db.SubmitChanges();
        }

        public double HitungPenjualan(Penjualan penjualan)
        {
            return (double)db.FC_HitungTotalPenjualan(penjualan.ID_Penjualan);
        }
    }
}
