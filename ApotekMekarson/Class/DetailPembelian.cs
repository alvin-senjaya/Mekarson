using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson.Class
{
    class DetailPembelian
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Detail_Pembelian;
        private int _Qty;
        private int _Bonus;
        private double _Harga;
        private double _Sub_Total;
        private string _No_Faktur;
        private string _No_Batch;

        public string No_Batch
        {
            get { return _No_Batch; }
            set { _No_Batch = value; }
        }

        public string No_Faktur
        {
            get { return _No_Faktur; }
            set { _No_Faktur = value; }
        }

        public double Harga
        {
            get { return _Harga; }
            set { _Harga = value; }
        }

        public double Sub_Total
        {
            get { return _Sub_Total; }
            set { _Sub_Total = value; }
        }

        public int Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public int ID_Detail_Pembelian
        {
            get { return _ID_Detail_Pembelian; }
            set { _ID_Detail_Pembelian = value; }
        }

        public void TambahDetailPembelianMethod(DetailPembelian detailPembelian)
        {
            db.SP_TambahDetailPembelian(detailPembelian.Qty, detailPembelian.Bonus, (Decimal)detailPembelian.Harga, (Decimal)detailPembelian.Sub_Total, detailPembelian.No_Faktur, detailPembelian.No_Batch);
            db.SubmitChanges();
        }

        public void HapusDetailPembelianMethod(DetailPembelian detailPembelian)
        {
            db.SP_HapusDetailPembelian(detailPembelian.ID_Detail_Pembelian);
            db.SubmitChanges();
        }

        public void HapusSemuaDetailPembelianMethod(DetailPembelian detailPembelian)
        {
            db.SP_HapusSemuaDetailPembelian(detailPembelian.No_Faktur);
            db.SubmitChanges();
        }
    }
}
