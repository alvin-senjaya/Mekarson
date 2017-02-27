using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson.Class
{
    class DetailPenjualan
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_detail_Penjualan;
        private int _Qty;
        private double _Sub_Total;
        private string _ID_Penjualan;
        private string _No_Batch;

        public string No_Batch
        {
            get { return _No_Batch; }
            set { _No_Batch = value; }
        }

        public string ID_Penjualan
        {
            get { return _ID_Penjualan; }
            set { _ID_Penjualan = value; }
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

        public int ID_detail_Penjualan
        {
            get { return _ID_detail_Penjualan; }
            set { _ID_detail_Penjualan = value; }
        }

        public void TambahDetailMethod(DetailPenjualan dp)
        {
            db.SP_TambahDetailPenjualan(dp.Qty, (decimal)dp.Sub_Total, dp.ID_Penjualan, dp.No_Batch);
            db.SubmitChanges();
        }

        public void HapusSemuaDetail(DetailPenjualan dp)
        {
            db.SP_HapusSemuaDetailPenjualan(dp.ID_Penjualan);
            db.SubmitChanges();
        }

        public void HapusDetailMethod(DetailPenjualan dp)
        {
            db.SP_HapusDetail(dp.ID_detail_Penjualan);
            db.SubmitChanges();
        }
    }
}
