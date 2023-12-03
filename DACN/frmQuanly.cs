using DACN.Cons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACN
{
    public partial class frmQuanly : Form
    {
        private ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
        DataGridViewRow row = new DataGridViewRow();
        SqlConnection conn = new SqlConnection("Data Source=VJNKDUCKBUILD\\SQLEXPRESS;Initial Catalog=ToaNhaChoThue88888;Integrated Security=True");
        public frmQuanly()
        {
            InitializeComponent();
            load_data();
        }

        private void XoaNv(int idChucVu, string idNv)
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                // Tìm nhân viên trong cơ sở dữ liệu
                var nv = db.Nhanviens.FirstOrDefault(n => n.IDNVien == idNv);

                if (nv != null)
                {
                    // Cập nhật ràng buộc khóa ngoại trong bảng NguoiDung
                    var nguoiDungList = db.NguoiDungs.Where(nd => nd.idNhanVien == idNv).ToList();
                    foreach (var nguoiDung in nguoiDungList)
                    {
                        nguoiDung.idNhanVien = null; // hoặc gán giá trị khác không tham chiếu đến nhân viên
                    }

                    // Xóa nhân viên
                    db.Nhanviens.Remove(nv);
                    db.SaveChanges();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                }
            }
        }

        private void CapNhatNv(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, int idChucVu, DateTime ngayVaolam, string idNv, string luong)
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                // Tìm nhân viên trong cơ sở dữ liệu
                var nv = db.Nhanviens.FirstOrDefault(n => n.IDNVien == idNv);

                if (nv != null)
                {
                    // Cập nhật thông tin nhân viên
                    nv.HoTen = hoTen;
                    nv.Email = eMail;
                    nv.GioiTinh = gioiTinh;
                    nv.SoDienThoai = sDt;
                    nv.DiaChi = diaChi;
                    nv.IDChucVu = idChucVu;
                    nv.NgayVaoLam = ngayVaolam;
                    nv.Luong = Convert.ToDecimal(luong);

                    // Lưu thay đổi vào cơ sở dữ liệu

                    db.Nhanviens.AddOrUpdate(nv);
                    db.SaveChangesAsync();
                    load_data();
                    //load_data();

                    // Thông báo thành công
                    MessageBox.Show("Cập nhật nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                }
            }
        }

        public partial class NguoiDung
        {
            // Các thuộc tính khác

            public int isActive { get; set; } // Thêm thuộc tính isActive
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }

        private void quảnLýThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyToaNha f = new frmQuanLyToaNha();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmQuanly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet2.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.toaNhaChoThue999DataSet2.Nhanvien);

        }

        private void tbNhansu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNv_Click(object sender, EventArgs e)
        {

            string idNv = txtIDNv.Text;

            // Lấy IDChucVu từ combobox hoặc từ nguồn dữ liệu khác
            int idChucVu = GetSelectedChucVuID(); // Hàm này cần được triển khai


            // Thêm nhân viên vào cơ sở dữ liệu
            XoaNv(idChucVu, idNv);

            // Thông báo thành công
            MessageBox.Show("Xóa nhân viên thành công");

            // Đóng form (tùy theo yêu cầu của bạn)
            //this.Close();
        }



        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dgvNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                txtIDNv.Text = dgvNhanVien.Rows[e.RowIndex].Cells["idEmployee"].Value?.ToString();
                txtName.Text = dgvNhanVien.Rows[e.RowIndex].Cells["nameEmployee"].Value?.ToString();
                txtAddress.Text = dgvNhanVien.Rows[e.RowIndex].Cells["addressEmployee"].Value?.ToString();
                txtEmail.Text = dgvNhanVien.Rows[e.RowIndex].Cells["emailEmployee"].Value?.ToString();
                txtGioitinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["genderEmployee"].Value?.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells["phoneEmployee"].Value?.ToString();
                dtpNgayvaolam.Text = dgvNhanVien.Rows[e.RowIndex].Cells["dateStart"].Value?.ToString();
                txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells["salary"].Value?.ToString();
                txtChucvu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["postitionEmployee"].Value?.ToString();
            }



            //int i;
            //i = dgvNhanVien.CurrentRow.Index;
            //txtIDNv.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            //txtName.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            //txtAddress.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            //txtEmail.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            //txtGioitinh.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            //txtSDT.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            //dtpNgayvaolam.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            //txtLuong.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            //string v = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            //txtLuong.Text = v;
            //txtChucvu.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private int GetSelectedChucVuID()
        {
            // Hàm này cần được triển khai để trả về ID của ChucVu được chọn từ combobox hoặc nguồn dữ liệu khác
            // Đây chỉ là một ví dụ đơn giản, bạn cần thay thế nó bằng logic phù hợp với ứng dụng của bạn
            // Ví dụ: return int.Parse(comboBoxChucVu.SelectedValue.ToString());
            return 1; // 1 là một giả định, bạn cần thay đổi nó để phù hợp với ứng dụng của bạn
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DateTime ngayVaolam = dtpNgayvaolam.Value;
            string hoTen = txtName.Text;
            string eMail = txtEmail.Text;
            string gioiTinh = txtGioitinh.Text;
            string sDt = txtSDT.Text;
            string diaChi = txtAddress.Text;
            string luong = txtLuong.Text;
            string idNv = txtIDNv.Text;

            // Lấy IDChucVu từ combobox hoặc từ nguồn dữ liệu khác
            int idChucVu = GetSelectedChucVuID(); // Hàm này cần được triển khai

            // Kiểm tra thông tin có hợp lệ không
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Cập nhật nhân viên trong cơ sở dữ liệu

            CapNhatNv(hoTen, eMail, gioiTinh, sDt, diaChi, idChucVu, ngayVaolam, idNv, luong);
            load_data();
            dgvNhanVien.Update();
            dgvNhanVien.Refresh();

        }
        public void load_data()
        {


            //Todo
            //List<Nhanvien> listEmployees = db.Nhanviens.ToList();
            List<Nhanvien> lstNhanVien = db.Nhanviens.ToList();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.Rows.Clear();
            foreach (var item in lstNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.IDNVien;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[2].Value = item.DiaChi;
                dgvNhanVien.Rows[index].Cells[3].Value = item.Email;
                // dgvNhanVien.Rows[index].Cells[].Value = item.NgaySinh.Value.ToShortDateString();
                if (item.GioiTinh == "1") // So sánh với chuỗi "1"
                {
                    dgvNhanVien.Rows[index].Cells[4].Value = "Nam";
                }
                else
                {
                    dgvNhanVien.Rows[index].Cells[4].Value = "Nữ";
                }

                dgvNhanVien.Rows[index].Cells[5].Value = item.SoDienThoai;
                dgvNhanVien.Rows[index].Cells[8].Value = item.IDChucVu;
                dgvNhanVien.Rows[index].Cells[7].Value = item.Luong;
                dgvNhanVien.Rows[index].Cells[6].Value = item.NgayVaoLam.Value.ToShortDateString();
                // dgvNhanVien.Rows[index].Cells[1].Value = item.TaiKhoan;
            }
        }

        private void txtGioitinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



