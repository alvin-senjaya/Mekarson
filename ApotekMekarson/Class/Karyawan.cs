using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMekarson.Class
{
    class Karyawan
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();

        private string _ID_Karyawan;
        private string _Nama_Karyawan;
        private string _Alamat_Karyawan;
        private string _Jenis_Karyawan;
        private string _Password;
        private string _no_telepon;
        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string No_Telepon
        {
            get { return _no_telepon; }
            set { _no_telepon = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Jenis_Karyawan
        {
            get { return _Jenis_Karyawan; }
            set { _Jenis_Karyawan = value; }
        }

        public string Alamat_Karyawan
        {
            get { return _Alamat_Karyawan; }
            set { _Alamat_Karyawan = value; }
        }

        public string Nama_Karyawan
        {
            get { return _Nama_Karyawan; }
            set { _Nama_Karyawan = value; }
        }

        public string ID_Karyawan
        {
            get { return _ID_Karyawan; }
            set { _ID_Karyawan = value; }
        }

        public void AddKaryawan(Karyawan kar)
        {
            db.SP_TambahKaryawan(kar.ID_Karyawan, kar.Nama_Karyawan, kar.Alamat_Karyawan, kar.No_Telepon, kar.Jenis_Karyawan, kar.Password, kar.Status);
            db.SubmitChanges();
        }

        public void UbahDataKaryawanMethod(Karyawan kar)
        {
            db.SP_UbahDataKaryawan(kar.ID_Karyawan, kar.Nama_Karyawan, kar.Alamat_Karyawan, kar.No_Telepon, kar.Jenis_Karyawan, kar.Status);
            db.SubmitChanges();
        }

        public void UbahPasswordMethod(Karyawan kar)
        {
            db.SP_UpdatePassword(kar.ID_Karyawan, kar.Password);
            db.SubmitChanges();
        }
    }
}
