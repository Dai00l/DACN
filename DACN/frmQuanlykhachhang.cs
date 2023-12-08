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
    public partial class frmQuanlykhachhang : Form
    {
        private ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
        DataGridViewRow row = new DataGridViewRow();
        public frmQuanlykhachhang()
        {
            InitializeComponent();
            load_data2();
        }

        private void frmQuanlykhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet3.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.toaNhaChoThue999DataSet3.KHACHHANG);

        }
        public void load_data2()
        {
            var lstKHACHHANG = db.KHACHHANGs.ToList();
            dgvKH.DataSource = null;
            dgvKH.Rows.Clear();




            foreach (var item in lstKHACHHANG)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.IDKH;

                dgvKH.Rows[index].Cells[1].Value = item.HoTen;
                dgvKH.Rows[index].Cells[2].Value = item.DiaChi;
                dgvKH.Rows[index].Cells[3].Value = item.Email;
                // dgvNhanVien.Rows[index].Cells[].Value = item.NgaySinh.Value.ToShortDateString();
                //if (item.GioiTinh == "1") // So sánh với chuỗi "1"
                //{
                //    dgvKH.Rows[index].Cells[5].Value = "Nam";
                //}
                //else
                //{
                //    dgvKH.Rows[index].Cells[5].Value = "Nữ";
                //}
                dgvKH.Rows[index].Cells[5].Value = item.GioiTinh;

                dgvKH.Rows[index].Cells[4].Value = item.SoDienThoai;

                dgvKH.Rows[index].Cells[6].Value = item.NgayDangKy.Value.ToShortDateString();

            }
        }
        private void XoaKh(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, string idKh, DateTime ngaydangky)
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                // Tìm nhân viên trong cơ sở dữ liệu
                var kh = db.KHACHHANGs.FirstOrDefault(n => n.IDKH == idKh);

                if (kh != null)
                {

                    // Xóa nhân viên
                    db.KHACHHANGs.Remove(kh);
                    db.SaveChanges();
                    load_data2();
                    // Thông báo thành công
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                }
            }
        }

        private void CapnhatKH(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, string idKh, DateTime ngaydangky)
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                
                var nguonDuLieu = db.KHACHHANGs;
                // Tìm nhân viên trong cơ sở dữ liệu
                var kh = db.KHACHHANGs.FirstOrDefault(n => n.IDKH == idKh);

                if (kh != null)
                {

                    kh.HoTen = hoTen;
                    kh.Email = eMail;
                    kh.GioiTinh = gioiTinh;
                    kh.SoDienThoai = sDt;
                    kh.DiaChi = diaChi;
                    kh.NgayDangKy = ngaydangky;
                    kh.IDKH = idKh;

                    db.SaveChanges();
                    
                    load_data2();
                    dgvKH.DataSource = nguonDuLieu.ToList();
                    MessageBox.Show("Cập nhật nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                }
            }
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtNameKH.Text;
                string eMail = txtEmailKH.Text;
                string gioiTinh = txtGioitinhKH.Text;
                string sDt = txtSDTKH.Text;
                string diaChi = txtAddressKH.Text;


                DateTime ngaydangky = dtpNgaydangky.Value;
                string idKh = txtID_KH.Text;
                XoaKh(hoTen, eMail, gioiTinh, sDt, diaChi, idKh, ngaydangky);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa khách hàng:\n " + ex.Message, "Lỗi");
            }
            

        }

        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            string hoTen = txtNameKH.Text;
            string eMail = txtEmailKH.Text;
            string gioiTinh = txtGioitinhKH.Text;
            string sDt = txtSDTKH.Text;
            string diaChi = txtAddressKH.Text;


            DateTime ngaydangky = dtpNgaydangky.Value;
            string idKh = txtID_KH.Text;


            // Kiểm tra thông tin có hợp lệ không
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Cập nhật nhân viên trong cơ sở dữ liệu
            CapnhatKH(hoTen, eMail, gioiTinh, sDt, diaChi, idKh, ngaydangky);

            dgvKH.Refresh();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                txtID_KH.Text = dgvKH.Rows[e.RowIndex].Cells["idKH"].Value?.ToString();
                txtNameKH.Text = dgvKH.Rows[e.RowIndex].Cells["nameKH"].Value?.ToString();
                txtAddressKH.Text = dgvKH.Rows[e.RowIndex].Cells["diachiKH"].Value?.ToString();
                txtEmailKH.Text = dgvKH.Rows[e.RowIndex].Cells["emailKH"].Value?.ToString();
                txtGioitinhKH.Text = dgvKH.Rows[e.RowIndex].Cells["sexKH"].Value?.ToString();
                txtSDTKH.Text = dgvKH.Rows[e.RowIndex].Cells["sdtKH"].Value?.ToString();
                dtpNgaydangky.Text = dgvKH.Rows[e.RowIndex].Cells["ngayDK"].Value?.ToString();

            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                txtID_KH.Text = dgvKH.Rows[e.RowIndex].Cells["idKH"].Value?.ToString();
                txtNameKH.Text = dgvKH.Rows[e.RowIndex].Cells["nameKH"].Value?.ToString();
                txtAddressKH.Text = dgvKH.Rows[e.RowIndex].Cells["diachiKH"].Value?.ToString();
                txtEmailKH.Text = dgvKH.Rows[e.RowIndex].Cells["emailKH"].Value?.ToString();
                txtGioitinhKH.Text = dgvKH.Rows[e.RowIndex].Cells["sexKH"].Value?.ToString();
                txtSDTKH.Text = dgvKH.Rows[e.RowIndex].Cells["sdtKH"].Value?.ToString();
                dtpNgaydangky.Text = dgvKH.Rows[e.RowIndex].Cells["ngayDK"].Value?.ToString();

            }
        }
    }
}
