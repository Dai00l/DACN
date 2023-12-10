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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DACN
{
    public partial class frmThemNhanVien : Form
    {
        

        public frmThemNhanVien()
        {
            InitializeComponent();
           // maNV = ma;
            this.StartPosition = FormStartPosition.CenterScreen;
           load_data();
        }
        private void load_data()
        {

        }
        private void ThemNv(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, int idChucVu, DateTime ngayVaolam, string idNv, string luong)
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                Nhanvien nv = new Nhanvien();
                {
                    nv.HoTen = hoTen;
                    nv.Email = eMail;
                    nv.GioiTinh = gioiTinh;
                    nv.SoDienThoai = sDt;
                    nv.DiaChi = diaChi;
                    nv.IDChucVu = idChucVu;
                    nv.NgayVaoLam = ngayVaolam;
                    nv.IDNVien = idNv;

                    nv.Luong = Convert.ToDecimal(luong);

                }
                db.Nhanviens.Add(nv);
                db.SaveChanges();
                // Gọi hàm nạp dữ liệu từ cơ sở dữ liệu của frmQuanly
                frmQuanly quanLyForm = Application.OpenForms.OfType<frmQuanly>().FirstOrDefault();
                //quanLyForm?.load_data();


            }
        }


        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

      

        private void btnCapNhatNV_Click_1(object sender, EventArgs e)
        {
            string hoTen = txtName.Text;
            string eMail = txtEmail.Text;
            string gioiTinh = txtGioitinh.Text;
            string sDt = txtSDT.Text;
            string diaChi = txtAddress.Text;
            string luong = txtLuong.Text;

            DateTime ngayVaolam = dtpNgayvaolam.Value;
            string idNv = txtIDNv.Text;

            // Lấy IDChucVu từ combobox hoặc từ nguồn dữ liệu khác
            int idChucVu = GetSelectedChucVuID(); // Hàm này cần được triển khai

            // Kiểm tra thông tin có hợp lệ không

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Thêm nhân viên vào cơ sở dữ liệu
            ThemNv(hoTen, eMail, gioiTinh, sDt, diaChi, idChucVu, ngayVaolam, idNv , luong);

            // Thông báo thành công
            MessageBox.Show("Thêm nhân viên thành công");

            // Đóng form (tùy theo yêu cầu của bạn)
            this.Close();
        }
        private int GetSelectedChucVuID()
        {
            // Hàm này cần được triển khai để trả về ID của ChucVu được chọn từ combobox hoặc nguồn dữ liệu khác
            // Đây chỉ là một ví dụ đơn giản, bạn cần thay thế nó bằng logic phù hợp với ứng dụng của bạn
            // Ví dụ: return int.Parse(comboBoxChucVu.SelectedValue.ToString());
            return 1; // 1 là một giả định, bạn cần thay đổi nó để phù hợp với ứng dụng của bạn
        }

        private void frmThemNhanVien_Load_1(object sender, EventArgs e)
        {

        }
    }
}

