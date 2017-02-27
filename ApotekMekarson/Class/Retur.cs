using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Retur
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Retur;
        private string _Nama_Barang;
        private DateTime _Tanggal_Retur;
        private string _No_Faktur;

        public string No_Faktur
        {
            get { return _No_Faktur; }
            set { _No_Faktur = value; }
        }

        public DateTime Tanggal_Retur
        {
            get { return _Tanggal_Retur; }
            set { _Tanggal_Retur = value; }
        }

        public string Nama_Barang
        {
            get { return _Nama_Barang; }
            set { _Nama_Barang = value; }
        }

        public int ID_Retur
        {
            get { return _ID_Retur; }
            set { _ID_Retur = value; }
        }

        public void TambahReturMethod(Retur retur)
        {
            db.SP_TambahRetur((DateTime)retur.Tanggal_Retur, retur.No_Faktur);
            db.SubmitChanges();
        }

        public void HapusReturMethod(Retur retur)
        {
            db.SP_HapusRetur(retur.ID_Retur);
            db.SubmitChanges();
        }
    }
}
