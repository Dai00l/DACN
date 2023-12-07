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
    public partial class frmQuanLyToaNha : Form
    {
        public frmQuanLyToaNha()
        {
            InitializeComponent();
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.HoTen;
           // LoadPhong(dtgvTang);
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tpQuanlyphong_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXembieudo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyThuePhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet3_Phong.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.toaNhaChoThue999DataSet3_Phong.Phong);
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet1.CoSoHaTangTang' table. You can move, or remove it, as needed.
            this.coSoHaTangTangTableAdapter.Fill(this.toaNhaChoThue999DataSet1.CoSoHaTangTang);
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet.Tang' table. You can move, or remove it, as needed.
            this.tangTableAdapter.Fill(this.toaNhaChoThue999DataSet.Tang);
            // Binding bd = new Binding("Text", Cons.Cons.LoginNhanVien, "Ten", true,DataSourceUpdateMode.OnPropertyChanged);









        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons.Cons.LoginNhanVien = null;
            
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmDangnhap frm = new frmDangnhap();
                
                //frm.ShowDialog();
                this.Close();

            }
        }

        private void tpPhong_Click(object sender, EventArgs e)
        {

        }

        private void ToaA_Click(object sender, EventArgs e)
        {

        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            frmQuanlykhachhang f = new frmQuanlykhachhang();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();     
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }
    }
}
