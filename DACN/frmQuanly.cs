using DACN.Cons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACN
{
    public partial class frmQuanly : Form
    {
        private ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
        DataGridViewRow row = new DataGridViewRow();
        string idNV;
        public frmQuanly(string idNhanVien)
        {
            this.idNV = idNhanVien;
            InitializeComponent();
            ReloadBangNhanVien();
            //load_data();
            LoadChiNV();
            LoadChucVu();
            LoadNhanVien();
            LoadDV();
        }

        public void ReloadBangNhanVien()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd1 = new SqlCommand("select nv.IDNVien, nv.HoTen, nv.DiaChi, nv.Email, nv.GioiTinh, nv.SoDienThoai, nv.NgayVaoLam, nv.Luong, cv.TenChucVu\r\nfrom Nhanvien nv \r\ninner join ChucVu cv on nv.IDChucVu = cv.ID", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd1;
                dt.Clear();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
            }
        }

        public void LoadChiNV()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select c.MaChi, c.NoiDung, nv.HoTen, c.SoTien from Chi c inner join Nhanvien nv on  c.idNhanVien = nv.IDNVien", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dgvChiLuongNV.DataSource = dt;
        }

        public void LoadDV()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select * from DV", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void LoadChucVu()
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var listChucVu = db.ChucVus;

                txtChucvu.DataSource = listChucVu.ToList();
                txtChucvu.DisplayMember = "TenChucVu"; 
                txtChucvu.ValueMember = "ID";
            }
        }

        public void LoadNhanVien()
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var listNhanVien = db.Nhanviens;

                cmbNV.DataSource = listNhanVien.ToList();
                cmbNV.DisplayMember = "HoTen";
                cmbNV.ValueMember = "IDNVien";
            }
        }

        //private int GetSelectedRow(string nhanVienId)
        //{
        //    for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
        //    {
        //        if (dgvNhanVien.Rows[i].Cells[0].Value.ToString() == nhanVienId)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //private void InsertUpdate(int selectedRow)
        //{
           
        //    dgvNhanVien.Rows[selectedRow].Cells[0].Value = txtIDNv.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[1].Value = txtName.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[2].Value = txtAddress.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[3].Value = txtEmail.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[4].Value = txtGioitinh.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[8].Value = txtSDT.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[5].Value = dtpNgayvaolam.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[6].Value = txtLuong.Text;
        //    dgvNhanVien.Rows[selectedRow].Cells[7].Value = txtChucvu.Text;
            
        //}



        //public void load_data()
        //{
        //    var lstNhanVien = db.Nhanviens.ToList();
        //    dgvNhanVien.DataSource = null;
        //    dgvNhanVien.Rows.Clear();




        //    foreach (var item in lstNhanVien)
        //    {
        //        int index = dgvNhanVien.Rows.Add();
        //        dgvNhanVien.Rows[index].Cells[0].Value = item.IDNVien;

        //        dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
        //        dgvNhanVien.Rows[index].Cells[2].Value = item.DiaChi;
        //        dgvNhanVien.Rows[index].Cells[3].Value = item.Email;
        //        // dgvNhanVien.Rows[index].Cells[].Value = item.NgaySinh.Value.ToShortDateString();
        //        if (item.GioiTinh == "1") // So sánh với chuỗi "1"
        //        {
        //            dgvNhanVien.Rows[index].Cells[4].Value = "Nam";
        //        }
        //        else
        //        {
        //            dgvNhanVien.Rows[index].Cells[4].Value = "Nữ";
        //        }

        //        dgvNhanVien.Rows[index].Cells[5].Value = item.SoDienThoai;
        //        dgvNhanVien.Rows[index].Cells[8].Value = item.IDChucVu;
        //        dgvNhanVien.Rows[index].Cells[7].Value = item.Luong;
        //        dgvNhanVien.Rows[index].Cells[6].Value = item.NgayVaoLam.Value.ToShortDateString();
        //        // dgvNhanVien.Rows[index].Cells[1].Value = item.TaiKhoan;
        //    }
        //    dgvNhanVien.DataSource = lstNhanVien;
        //}

        private void XoaNv(string idNv)
        {
            try
            {
                using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                {
                    // Tìm nhân viên trong cơ sở dữ liệu
                    var nv = db.Nhanviens.FirstOrDefault(n => n.IDNVien == idNv);
                    var nd = db.NguoiDungs.FirstOrDefault(n=> n.idNhanVien == idNv);

                    if (nv != null)
                    {
                        // Cập nhật ràng buộc khóa ngoại trong bảng NguoiDung
                        var nguoiDungList = db.NguoiDungs.Where(a => a.idNhanVien == idNv).ToList();
                        foreach (var nguoiDung in nguoiDungList)
                        {
                            nguoiDung.idNhanVien = null; // hoặc gán giá trị khác không tham chiếu đến nhân viên
                        }

                        // Xóa nhân viên
                        db.Nhanviens.Remove(nv);
                        db.NguoiDungs.Remove(nd);
                        db.SaveChanges();
                        //load_data();
                        // Thông báo thành công
                        MessageBox.Show("Xóa nhân viên thành công");
                        ReloadBangNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Không thể xóa nhân viên!", "Lỗi");
            }
            
        }

        private void CapNhatNv(string hoTen, string eMail, string gioiTinh, string sDt, string diaChi, int idChucVu, DateTime ngayVaolam, string idNv, string luong)
        {
            try
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

                        db.SaveChanges();
                        //load_data();

                        // Thông báo thành công
                        //int selectedRow = GetSelectedRow(txtIDNv.Text);
                        //InsertUpdate(selectedRow);
                        MessageBox.Show("Cập nhật nhân viên thành công");
                        ReloadBangNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi: "+ex.Message, "Lỗi");
            }
            
        }

        //public partial class NguoiDung
        //{
        //    // Các thuộc tính khác

        //    public int isActive { get; set; } // Thêm thuộc tính isActive
        //}


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
            frmQuanLyToaNha f = new frmQuanLyToaNha(idNV);
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Equals("")
                    || txtEmail.Text.Equals("")
                    || txtLuong.Text.Equals("")
                    || txtGioitinh.Text.Equals("")
                    || txtSDT.Text.Equals("")
                    || txtAddress.Text.Equals("")
                    || txtChucvu.Text.Equals("")
                    || dtpNgayvaolam.Text.Equals("")
                    || txtIDNv.Text.Equals("")
                    || txtMatKhau.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên cần thêm", "Cảnh báo");
                }
                else
                {
                    string tenNV = txtName.Text;
                    string email = txtEmail.Text;
                    double luong = Convert.ToDouble(txtLuong.Text);
                    string gioiTinh = txtGioitinh.Text;
                    string sdt = txtSDT.Text;
                    string diaChi = txtAddress.Text;
                    int maCV = Convert.ToInt32(txtChucvu.SelectedValue);
                    DateTime ngayVaoLam = dtpNgayvaolam.Value;
                    string maNVCanThem = txtIDNv.Text;
                    string matKhau = txtMatKhau.Text;

                    bool isAdded = true;
                    foreach (DataGridViewRow row in dgvNhanVien.Rows)
                    {
                        string maPhong = (string)row.Cells["idEmployee"].Value;


                        if (maPhong == maNVCanThem)

                        {
                            isAdded = false;

                        }
                    }
                    if (isAdded)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            Nhanvien nv = new Nhanvien();
                            {
                                nv.HoTen = tenNV;
                                nv.Email = email;
                                nv.Luong = (decimal?)luong;
                                nv.GioiTinh = gioiTinh;
                                nv.SoDienThoai = sdt;
                                nv.DiaChi = diaChi;
                                nv.IDChucVu = maCV;
                                nv.NgayVaoLam = ngayVaoLam;
                                nv.IDNVien = maNVCanThem;

                                db.Nhanviens.Add(nv);
                                db.SaveChanges();

                                ReloadBangNhanVien();
                            }

                            NguoiDung nguoiDung = new NguoiDung();
                            {
                                // Lấy thời gian hiện tại
                                DateTime now = DateTime.Now;

                                // Chuyển đổi thành chuỗi với định dạng mong muốn (VD: yyyymmddhhmmss)
                                string randomString = now.ToString("yyyyMMddHHmmss");

                                // Hiển thị chuỗi ngẫu nhiên
                                // Console.WriteLine(randomString);
                                nguoiDung.ID = randomString;
                                nguoiDung.idNhanVien = maNVCanThem;
                                nguoiDung.Matkhau = matKhau;

                                db.NguoiDungs.Add(nguoiDung);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, hãy chọn mã khác!", "Cảnh báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            //frmThemNhanVien f = new frmThemNhanVien();
            //f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmQuanly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet4_DichVu.DV' table. You can move, or remove it, as needed.
            this.dVTableAdapter.Fill(this.toaNhaChoThue999DataSet4_DichVu.DV);
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

            // Kiểm tra thông tin có hợp lệ không

            if (txtIDNv.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                return;
            }
            else
            {
                // Thêm nhân viên vào cơ sở dữ liệu
                XoaNv(idNv);
            }

            

            

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
                txtChucvu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenChucVu"].Value?.ToString();
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
            try
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
                int idChucVu = Convert.ToInt32(txtChucvu.SelectedValue); // Hàm này cần được triển khai

                // Kiểm tra thông tin có hợp lệ không
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                // Cập nhật nhân viên trong cơ sở dữ liệu
                CapNhatNv(hoTen, eMail, gioiTinh, sDt, diaChi, idChucVu, ngayVaolam, idNv, luong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void txtGioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtChucvu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenChucVu"].Value?.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNV = txtName.Text;
                string email = txtEmail.Text;
                string luong = txtLuong.Text;
                string gioiTinh = txtGioitinh.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtAddress.Text;
                string tenCV = txtChucvu.Text;
                DateTime ngayVaoLam = dtpNgayvaolam.Value;
                string maNV = txtIDNv.Text;

                ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
                var nguonDuLieu = db.Nhanviens;

                decimal luongreal = Convert.ToDecimal(luong);

                var ketQuaTimKiem = nguonDuLieu.Where(t =>
                    (t.HoTen.Contains(tenNV) || t.Email.Contains(email) || t.Luong == luongreal
                    || t.GioiTinh.Contains(gioiTinh) || t.SoDienThoai.Contains(sdt) || t.DiaChi.Contains(diaChi)
                    || t.IDNVien.Contains(maNV) || t.ChucVu.TenChucVu.Equals(tenCV) || t.NgayVaoLam.Value == ngayVaoLam)
                ).ToList();

                dgvNhanVien.DataSource = ketQuaTimKiem;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi!", "Lỗi");
            }
            
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNV.Text.Equals("") || rtbNoiDung.Text.Equals("") || txtSoTien.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                }
                else
                {
                    string maNhanVien = (string)cmbNV.SelectedValue;
                    string noiDung = rtbNoiDung.Text;
                    decimal soTien = Convert.ToDecimal(txtSoTien.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        Chi chi = new Chi();
                        {
                            chi.idNhanVien = maNhanVien;
                            chi.NoiDung = noiDung;
                            chi.SoTien = soTien;

                            db.Chis.Add(chi);
                            db.SaveChanges();
                        } 

                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadChiNV();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm!", "Lỗi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                txtMaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value?.ToString();
                txtTenDV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value?.ToString();
                txtGiaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaDV"].Value?.ToString();

            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDV.Text.Equals("") || txtGiaDV.Text.Equals("")) 
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ cần thêm", "Cảnh báo");
                }
                else
                {
                    string tenDV = txtTenDV.Text;
                    decimal giaDV = Convert.ToDecimal(txtGiaDV.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        DV dv = new DV();
                        {
                            dv.TenDV = tenDV;
                            dv.Gia = giaDV;

                            db.DVs.Add(dv);
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                    LoadDV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm", "Lỗi");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDV.Text.Equals(""))
                {
                    MessageBox.Show("Hãy chọn mã dịch vụ cần xóa!", "Thông báo");
                }
                else
                {
                    int maDVCanXoa = Convert.ToInt32(txtMaDV.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        var dv = db.DVs.FirstOrDefault(d => d.MaDV == maDVCanXoa);

                        db.DVs.Remove(dv);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                    LoadDV();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa", "Lỗi");
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDV.Text.Equals("") || txtTenDV.Text.Equals("") || txtGiaDV.Equals(""))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cần cập nhật", "Thông báo");
                }
                else
                {
                    int maDVCanCapNhat = Convert.ToInt32(txtMaDV.Text);
                    string tenDV = txtTenDV.Text;
                    decimal giaDV = Convert.ToDecimal(txtGiaDV.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        var dv = db.DVs.FirstOrDefault(n => n.MaDV == maDVCanCapNhat);

                        if (dv != null)
                        {
                            dv.TenDV = tenDV;
                            dv.Gia = giaDV;
                            
                            db.SaveChanges();
                            
                            MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo");
                            LoadDV();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dịch vụ để cập nhật", "Thông báo");
                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa!", "Thông báo");
            }
        }
    }
}
    


