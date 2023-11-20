using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.HoTen;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons.Cons.LoginNhanVien = null;
            this.Close();
        }
    }
}
