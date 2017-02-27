using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class ObatRacikan
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _No_Batch;
        private int _ID_Racikan;
        private DateTime _Tanggal_Dibuat;
        private int _Qty;

        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public DateTime Tanggal_Dibuat
        {
            get { return _Tanggal_Dibuat; }
            set { _Tanggal_Dibuat = value; }
        }

        public int ID_Racikan
        {
            get { return _ID_Racikan; }
            set { _ID_Racikan = value; }
        }

        public string No_Batch
        {
            get { return _No_Batch; }
            set { _No_Batch = value; }
        }

        public void TambahObatRacikanMethod(ObatRacikan or)
        {
            db.SP_TambahObatRacikan(or.No_Batch, or.ID_Racikan, or.Tanggal_Dibuat, or.Qty);
            db.SubmitChanges();
        }

        public void HapusObatRacikanMethod(ObatRacikan or)
        {
            db.SP_HapusObatRacikan(or.No_Batch, or.ID_Racikan);
            db.SubmitChanges();
        }
    }
}
