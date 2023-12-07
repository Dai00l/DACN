using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DACN
{
    public partial class frmDoiMatKhau : Form
    {
        private string ID;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void txtMKC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMKC.Text;
            string matKhauMoi = txtMKM.Text;
            string nhapLaiMatKhau = txtNL.Text;
            // Kiểm tra mật khẩu cũ và mật khẩu mới có hợp lệ không
           
        }
        private bool KiemTraMatKhauCu(string username, string matKhauCu)
    {
        // Kiểm tra mật khẩu cũ có chính xác không
        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
        {
            var user = db.NguoiDungs.FirstOrDefault(u => u.ID == username && u.Matkhau == matKhauCu);
            return user != null;
        }
    }

    private bool KiemTraMatKhauMoi(string matKhauMoi, string nhapLaiMatKhau)
    {
        // Kiểm tra mật khẩu mới và nhập lại có khớp nhau không
        return matKhauMoi == nhapLaiMatKhau;
    }

    private bool CapNhatMatKhau(string username, string matKhauMoi)
    {
        try
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.ID == username);

                if (user != null)
                {
                    user.Matkhau = matKhauMoi;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            // Xử lý lỗi cập nhật cơ sở dữ liệu
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    }
}
