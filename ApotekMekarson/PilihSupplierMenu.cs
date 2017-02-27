using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApotekMekarson
{
    public partial class PilihSupplierMenu : Form
    {
        ApotekMekarsonDB db = new ApotekMekarsonDB();
        public PilihSupplierMenu()
        {
            InitializeComponent();

            var DataSupplier = db.tbSuppliers.Select(x => x.Nama_Supplier).ToList();
            foreach (var item in DataSupplier)
            {
                cbNamaSupplier.Items.Add(item);
            }
            cbNamaSupplier.SelectedIndex = 0;
            
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            TambahRetur TambahRetur = new TambahRetur(cbNamaSupplier.Text);
            TambahRetur.ShowDialog();
            this.Close();
        }
    }
}
