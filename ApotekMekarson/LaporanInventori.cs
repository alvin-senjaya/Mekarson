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
    public partial class LaporanInventori : Form
    {
        public LaporanInventori()
        {
            InitializeComponent();
        }

        private void LaporanInventori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ApotekMekarsonDataSet.ViewLaporanInventori' table. You can move, or remove it, as needed.
            this.ViewLaporanInventoriTableAdapter.Fill(this.ApotekMekarsonDataSet.ViewLaporanInventori);

            this.reportViewerInventori.RefreshReport();
        }
    }
}
