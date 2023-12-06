using DACN.Cons;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACN
{
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // load_data2();
        }
        private void load_data2()
        {

        }
        private void ThemKh(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, DateTime ngaydangky, string idKh )
        {

            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                KHACHHANG kh = new KHACHHANG();
                {
                    kh.HoTen = hoTen;
                    kh.Email = eMail;
                    kh.GioiTinh = gioiTinh;
                    kh.SoDienThoai = sDt;
                    kh.DiaChi = diaChi;
                    kh.NgayDangKy= ngaydangky;
                    kh.IDKH = idKh;

                    

                }
                //db.Nhanviens.Add(nv);
                db.KHACHHANGs.Add( kh );
                db.SaveChanges();
                // Gọi hàm nạp dữ liệu từ cơ sở dữ liệu của frmQuanly
                //frmQuanly quanLyForm = Application.OpenForms.OfType<frmQuanly>().FirstOrDefault();
               // quanLyForm?.load_data();
               frmQuanlykhachhang quanlykhachhang= Application.OpenForms.OfType<frmQuanlykhachhang>().FirstOrDefault();
                quanlykhachhang.load_data2();
            }





        }





        private void btnThemKH_Click(object sender, EventArgs e)
        {

            string hoTen = txtNameKh.Text;
            string eMail = txtEmailKh.Text;
            string gioiTinh = txtGioitinhKh.Text;
            string sDt = txtSDTKh.Text;
            string diaChi = txtAddressKh.Text;
           

            DateTime ngaydangky = dtpNgaydangky.Value;
            string idKh = txtIDKh.Text;

            
            // Kiểm tra thông tin có hợp lệ không

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Thêm nhân viên vào cơ sở dữ liệu
            ThemKh(hoTen, eMail, gioiTinh, sDt, diaChi,  ngaydangky, idKh );

            // Thông báo thành công
            MessageBox.Show("Thêm nhân viên thành công");

            // Đóng form (tùy theo yêu cầu của bạn)
            this.Close();
        }
    }
}



