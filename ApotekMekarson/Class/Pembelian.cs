using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Pembelian
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _No_Faktur;
        private DateTime _Tanggal_Pembelian;
        private double _Total_Pembelian;
        private DateTime _Jatuh_Tempo;
        private string _Status;
        private int _ID_Supplier;
        private string _ID_Karyawan;

        public string ID_Karyawan
        {
            get { return _ID_Karyawan; }
            set { _ID_Karyawan = value; }
        }

        public int ID_Supplier
        {
            get { return _ID_Supplier; }
            set { _ID_Supplier = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public DateTime Jatuh_Tempo
        {
            get { return _Jatuh_Tempo; }
            set { _Jatuh_Tempo = value; }
        }

        public double Total_Pembelian
        {
            get { return _Total_Pembelian; }
            set { _Total_Pembelian = value; }
        }

        public DateTime Tanggal_Pembelian
        {
            get { return _Tanggal_Pembelian; }
            set { _Tanggal_Pembelian = value; }
        }

        public string No_Faktur
        {
            get { return _No_Faktur; }
            set { _No_Faktur = value; }
        }

        public void HapusPembelianMethod(Pembelian pembelian)
        {
            db.SP_HapusPembelian(pembelian.No_Faktur);
            db.SubmitChanges();
        }

        public void TambahPembelianMethod(Pembelian pembelian)
        {
            db.SP_TambahPembelian(pembelian.No_Faktur, (DateTime)pembelian.Tanggal_Pembelian, (Decimal)pembelian.Total_Pembelian, (DateTime)pembelian.Jatuh_Tempo, pembelian.Status, pembelian.ID_Supplier, pembelian.ID_Karyawan);
            db.SubmitChanges();
        }

        public void UbahPembelianMethod(Pembelian pembelian)
        {
            db.SP_UbahPembelian(pembelian.No_Faktur, (DateTime)pembelian.Tanggal_Pembelian, (Decimal)pembelian.Total_Pembelian, (DateTime)pembelian.Jatuh_Tempo, pembelian.Status, pembelian.ID_Supplier, pembelian.ID_Karyawan);
            db.SubmitChanges();
        }

        public double HitungTotalPembelian(Pembelian pembelian)
        {
            return (double)db.FC_HitungTotalPembelian(pembelian.No_Faktur);
        }

        public void UbahStatusMethod(Pembelian pembelian)
        {
            db.SP_UbahStatus(pembelian.No_Faktur, pembelian.Status);
            db.SubmitChanges();
        }
    }
}
