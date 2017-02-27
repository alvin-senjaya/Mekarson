using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson
{
    class Supplier
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private int _ID_Supplier;
        private string _Nama_Supplier;
        private string _Alamat_Supplier;
        private string _No_Telepon;

        public string No_Telepon
        {
            get { return _No_Telepon; }
            set { _No_Telepon = value; }
        }

        public string Alamat_Supplier
        {
            get { return _Alamat_Supplier; }
            set { _Alamat_Supplier = value; }
        }

        public string Nama_Supplier
        {
            get { return _Nama_Supplier; }
            set { _Nama_Supplier = value; }
        }

        public int ID_Supplier
        {
            get { return _ID_Supplier; }
            set { _ID_Supplier = value; }
        }

        public void TambahSupplierMethod(Supplier sup)
        {
            db.SP_TambahDataSupplier(sup.Nama_Supplier, sup.Alamat_Supplier, sup.No_Telepon);
            db.SubmitChanges();
        }

        public void UbahSupplierMethod(Supplier sup)
        {
            db.SP_UbahSupplier(sup.ID_Supplier, sup.Nama_Supplier, sup.Alamat_Supplier, sup.No_Telepon);
            db.SubmitChanges();
        }

        public void HapusSupplierMethod(Supplier sup)
        {
            tbSupplier SupplierDeleted = new tbSupplier();

            SupplierDeleted.ID_Supplier = sup.ID_Supplier;
            SupplierDeleted.Nama_Supplier = sup.Nama_Supplier;
            SupplierDeleted.Alamat_Supplier = sup.Alamat_Supplier;
            SupplierDeleted.No_Telepon = sup.No_Telepon;

            db.tbSuppliers.Attach(SupplierDeleted);
            db.tbSuppliers.DeleteOnSubmit(SupplierDeleted);
            db.SubmitChanges();
        }
    }
}
