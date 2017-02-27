using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Racikan
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Racikan;
        private double _Harga;

        public double Harga
        {
            get { return _Harga; }
            set { _Harga = value; }
        }

        public int ID_Racikan
        {
            get { return _ID_Racikan; }
            set { _ID_Racikan = value; }
        }

        public void TambahRacikanMethod(Racikan racik)
        {
            db.SP_TambahRacikan((decimal)racik.Harga);
            db.SubmitChanges();
        }

        public void HapusRacikanMethod(Racikan racik)
        {
            db.SP_HapusRacikan(racik.ID_Racikan);
            db.SubmitChanges();
        }
    }
}
