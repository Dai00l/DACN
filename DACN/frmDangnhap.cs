using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DACN
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txtTaikhoan.Text == "") || (txtMatkhau.Text == ""))
            {
                MessageBox.Show("Vui long nhập thông tin !!!!");
            }
            else
            {
                Form f = nextForm(txtTaikhoan.Text, txtMatkhau.Text);

                if (f == null)
                    return;

                f.FormClosed += f_FormClosed;



                f.StartPosition = FormStartPosition.CenterScreen; // set vị trí

                f.Show(); // show form

                this.Hide(); //ẩn

                ClearTextBox();
            }
            
        }






        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        void ClearTextBox()
        {
            txtTaikhoan.Clear();
            txtMatkhau.Clear();


        }





        Form nextForm(string id, string pass)
        {
            Form f = new Form();

            int Machucvu = (int )Cons.Machucvu.TiepTan ;


            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var t = db.NguoiDungs.Where(p => p.ID.Equals(id) && p.Matkhau.Equals(pass));



                NguoiDung n = t.Count() == 1? t.Single():null;
                if ( n != null   )
                {
                    Nhanvien nv = db.Nhanviens.Where(p=> n.ID.Equals(p.IDNVien)).Single();
                    Machucvu = (int) nv.ChucVu.MaChucVu; ///ROLL MA CHUC VU
                    Cons.Cons.LoginNhanVien = nv;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu của bạn chưa đúng");
                    return null;
                }
            }


            //1 la Tiep Tan
            //2 la quan ly
            //3 la ke toa
            switch(Machucvu)
            {
                case (int)Cons.Machucvu.TiepTan :
                    f = new frmQuanLyToaNha(id);
                    break;

                case (int)Cons.Machucvu.KeToan:
                    f = new frmThongKe();
                    break;

                case (int)Cons.Machucvu.Quanly:
                    f = new frmQuanly(id);
                    break;
            }
            return f;
        }






       

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
                this.Close();
                

            }
            
        }
    }
}
