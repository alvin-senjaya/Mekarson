using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class DetailRetur
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Detail_Retur;
        private int _Qty;
        private int _ID_Retur;
        private string _No_Batch;
        private int _Id_Detail_Pembelian;

        public int Id_Detail_Pembelian
        {
            get { return _Id_Detail_Pembelian; }
            set { _Id_Detail_Pembelian = value; }
        }

        public string No_Batch
        {
            get { return _No_Batch; }
            set { _No_Batch = value; }
        }

        public int ID_Retur
        {
            get { return _ID_Retur; }
            set { _ID_Retur = value; }
        }

        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public int ID_Detail_Retur
        {
            get { return _ID_Detail_Retur; }
            set { _ID_Detail_Retur = value; }
        }

        public void TambahDetailMethod(DetailRetur Detail)
        {
            db.SP_TambahDetailRetur(Detail.Qty, Detail.ID_Retur, Detail.No_Batch, Detail.Id_Detail_Pembelian);
            db.SubmitChanges();
        }

        public void HapusDetailMethod(DetailRetur Detail)
        {
            db.SP_HapusDetailRetur(Detail._ID_Detail_Retur,Detail.Qty,Detail.No_Batch,Detail.Id_Detail_Pembelian);
            db.SubmitChanges();
        }
    }
}
