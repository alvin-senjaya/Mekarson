using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class DetailPenjualanResep
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Detail_Penjualan;
        private int _Qty;
        private double _Sub_Total;
        private string _ID_Penjualan_Resep;
        private int _ID_Racikan;

        public int ID_Racikan
        {
            get { return _ID_Racikan; }
            set { _ID_Racikan = value; }
        }

        public string ID_penjualan_Resep
        {
            get { return _ID_Penjualan_Resep; }
            set { _ID_Penjualan_Resep = value; }
        }

        public double Sub_Total
        {
            get { return _Sub_Total; }
            set { _Sub_Total = value; }
        }

        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public int ID_Detail_Penjualan
        {
            get { return _ID_Detail_Penjualan; }
            set { _ID_Detail_Penjualan = value; }
        }

        public void TambahDetailMethod(DetailPenjualanResep dpr, int QtyperObat, string NoBatch)
        {
            db.SP_TambahDetailPenjualanResep(dpr.Qty, (decimal)dpr.Sub_Total, dpr.ID_penjualan_Resep, dpr.ID_Racikan, NoBatch,QtyperObat);
            db.SubmitChanges();
        }
    }
}
