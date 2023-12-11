using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DACN
{
    public partial class frmQuanLyToaNha : Form
    {
        string idNV;
        public frmQuanLyToaNha(string idNhanVien)
        {
            InitializeComponent();
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.HoTen;
            this.idNV = idNhanVien;
           // LoadPhong(dtgvTang);
        }

        public void ReloadDgvPhong()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select p.MaPhong, p.TenPhong, p.TrangThaiPhong, cp.TenCSVCP, t.TenTang, p.Gia\r\n" +
                "from Phong p \r\n" +
                "left join CoSoHaTangPhong cp on p.idCosohatangphong = cp.MaCSVCP\r\n" +
                "left join Tang t on p.idTang = t.MaTang", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dgvPhong.DataSource = dt;
            dataGridView3.DataSource = dt;
        }

        public void ReloadTangA()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select t.MaTang, t.TenTang, t.TrangThaiTang, ct.TenCSVCT\r\nfrom Tang t left join CoSoHaTangTang ct on t.idCosohatangtang = ct.MaCSVCT\r\nwhere t.MaToa = 1", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dtgvTang.DataSource = dt;
        }

        public void ReloadTangB()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select t.MaTang, t.TenTang, t.TrangThaiTang, ct.TenCSVCT\r\nfrom Tang t left join CoSoHaTangTang ct on t.idCosohatangtang = ct.MaCSVCT\r\nwhere t.MaToa = 2", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
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
            //this.phongTableAdapter.Fill(this.toaNhaChoThue999DataSet3_Phong.Phong);
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet1.CoSoHaTangTang' table. You can move, or remove it, as needed.
            this.coSoHaTangTangTableAdapter.Fill(this.toaNhaChoThue999DataSet1.CoSoHaTangTang);
            // TODO: This line of code loads data into the 'toaNhaChoThue999DataSet.Tang' table. You can move, or remove it, as needed.
            //this.tangTableAdapter.Fill(this.toaNhaChoThue999DataSet.Tang);
            // Binding bd = new Binding("Text", Cons.Cons.LoginNhanVien, "Ten", true,DataSourceUpdateMode.OnPropertyChanged);

            ReloadDgvPhong();
            ReloadTangA();
            ReloadTangB();

            //SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //}
            //SqlCommand cmd1 = new SqlCommand("select p.MaPhong, p.TenPhong, p.TrangThaiPhong, cp.TenCSVCP, t.TenTang, p.Gia\r\n" +
            //    "from Phong p \r\n" +
            //    "left join CoSoHaTangPhong cp on p.idCosohatangphong = cp.MaCSVCP\r\n" +
            //    "left join Tang t on p.idTang = t.MaTang", conn);
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //da.SelectCommand = cmd1;
            //dt.Clear();
            //da.Fill(dt);
            //dgvPhong.DataSource = dt;
            //dataGridView3.DataSource = dt;

            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var listTenCSHTP = db.CoSoHaTangPhongs;
                var listTenTang = db.Tangs;

                cmbTenCSHTP.DataSource = listTenCSHTP.ToList();
                cmbTenCSHTP.DisplayMember = "TenCSVCP"; // Tên trường chứa tên
                cmbTenCSHTP.ValueMember = "MaCSVCP"; // Tên trường chứa ID

                cmbTenTang.DataSource = listTenTang.ToList();
                cmbTenTang.DisplayMember = "TenTang"; // Tên trường chứa tên
                cmbTenTang.ValueMember = "MaTang"; // Tên trường chứa ID

                textBox5.DataSource = listTenCSHTP.ToList();
                textBox5.DisplayMember = "TenCSVCP"; // Tên trường chứa tên
                textBox5.ValueMember = "MaCSVCP"; // Tên trường chứa ID

                textBox4.DataSource = listTenTang.ToList();
                textBox4.DisplayMember = "TenTang"; // Tên trường chứa tên
                textBox4.ValueMember = "MaTang"; // Tên trường chứa ID

                var listTenCSHTT = db.CoSoHaTangTangs;

                cmbTenCSHTTA.DataSource = listTenCSHTT.ToList();
                cmbTenCSHTTA.DisplayMember = "TenCSVCT";
                cmbTenCSHTTA.ValueMember = "MaCSVCT";

                comboBox3.DataSource = listTenCSHTT.ToList();
                comboBox3.DisplayMember = "TenCSVCT";
                comboBox3.ValueMember = "MaCSVCT";
            }





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
            frmDoiMatKhau f = new frmDoiMatKhau(idNV);
            f.ShowDialog();
        }

        private void dtgvTang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvTang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dtgvTang.Rows.Count)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dtgvTang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    // Hiển thị giá trị của ô trong TextBox và ComboBox tương ứng
                    textBox2.Text = dtgvTang.Rows[e.RowIndex].Cells["tenTangDataGridViewTextBoxColumn"].Value?.ToString();
                    comboBox1.Text = dtgvTang.Rows[e.RowIndex].Cells["trangThaiTangDataGridViewTextBoxColumn"].Value?.ToString();
                    cmbTenCSHTTA.Text = dtgvTang.Rows[e.RowIndex].Cells["TenCSVCTA"].Value?.ToString();
                    txtMaTangA.Text = dtgvTang.Rows[e.RowIndex].Cells["maTangDataGridViewTextBoxColumn"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("Giá trị ô không hợp lệ.");
                }
            }
        }

        private void btnTimtang_Click(object sender, EventArgs e)
        {
            string tenTang = textBox2.Text;
            string trangThaiTuan = comboBox1.SelectedItem?.ToString();

            TimKiemVaCapNhatDataGridView(tenTang, trangThaiTuan);
        }

        private void TimKiemVaCapNhatDataGridView(string tenTang, string trangThaiTuan)
        {
            // Lấy nguồn dữ liệu ban đầu (DataSource) của DataGridView
            ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
            var nguonDuLieu = db.Tangs;
            

            // Thực hiện truy vấn LINQ để lọc dữ liệu
            var ketQuaTimKiem = nguonDuLieu.Where(t =>
                (string.IsNullOrEmpty(tenTang) || t.TenTang.Contains(tenTang)) &&
                (string.IsNullOrEmpty(trangThaiTuan) || t.TrangThaiTang == trangThaiTuan)
            ).ToList();

            // Gán kết quả tìm kiếm vào DataGridView
            dtgvTang.DataSource = ketQuaTimKiem;
        }

        private void btnSuatang_Click(object sender, EventArgs e)
        {
            try
            {
                using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                {
                    int maTangCanSua = (int)dtgvTang.CurrentRow.Cells["maTangDataGridViewTextBoxColumn"].Value;
                    var nguonDuLieu = db.Tangs;

                    Tang tangCanSua = nguonDuLieu.Single(t => t.MaTang == maTangCanSua);

                    tangCanSua.TenTang = textBox2.Text;
                    tangCanSua.TrangThaiTang = comboBox1.SelectedItem?.ToString();
                    tangCanSua.idCosohatangtang = (int?)cmbTenCSHTTA.SelectedValue;

                    // Cập nhật thông tin vào cơ sở dữ liệu
                    db.Entry(tangCanSua).State = EntityState.Modified;
                    db.SaveChanges();

                    ReloadTangA();
                }
                dtgvTang.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi", "Lỗi");
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dtgvTang.Rows.Count)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    // Hiển thị giá trị của ô trong TextBox và ComboBox tương ứng
                    textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value?.ToString();
                    comboBox2.Text = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].Value?.ToString();
                    comboBox3.Text = dataGridView2.Rows[e.RowIndex].Cells["TenCSVCTB"].Value?.ToString();
                    txtMaTangB.Text = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("Giá trị ô không hợp lệ.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenTang = textBox3.Text;
            string trangThaiTuan = comboBox2.SelectedItem?.ToString();

            TimKiemVaCapNhatDataGridView2(tenTang, trangThaiTuan);
        }
        private void TimKiemVaCapNhatDataGridView2(string tenTang, string trangThaiTuan)
        {
            // Lấy nguồn dữ liệu ban đầu (DataSource) của DataGridView
            ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities();
            var nguonDuLieu = db.Tangs;


            // Thực hiện truy vấn LINQ để lọc dữ liệu
            var ketQuaTimKiem = nguonDuLieu.Where(t =>
                (string.IsNullOrEmpty(tenTang) || t.TenTang.Contains(tenTang)) &&
                (string.IsNullOrEmpty(trangThaiTuan) || t.TrangThaiTang == trangThaiTuan)
            ).ToList();

            // Gán kết quả tìm kiếm vào DataGridView
            dataGridView2.DataSource = ketQuaTimKiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                {
                    int maTangCanSua = (int)dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value;
                    var nguonDuLieu = db.Tangs;

                    Tang tangCanSua = nguonDuLieu.Single(t => t.MaTang == maTangCanSua);

                    tangCanSua.TenTang = textBox3.Text;
                    tangCanSua.TrangThaiTang = comboBox2.SelectedItem?.ToString();
                    tangCanSua.idCosohatangtang = (int?)comboBox3.SelectedValue;

                    // Cập nhật thông tin vào cơ sở dữ liệu
                    db.Entry(tangCanSua).State = EntityState.Modified;
                    db.SaveChanges();

                    ReloadTangB();
                }
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "lỗi");
            }
            
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhong.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dgvPhong.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                txtIdphong.Text = dgvPhong.Rows[e.RowIndex].Cells["maPhongDataGridViewTextBoxColumn"].Value?.ToString();
                txtTrangthai.Text = dgvPhong.Rows[e.RowIndex].Cells["trangThaiPhongDataGridViewTextBoxColumn"].Value?.ToString();
                txtTenphong.Text = dgvPhong.Rows[e.RowIndex].Cells["tenPhongDataGridViewTextBoxColumn"].Value?.ToString();
                cmbTenCSHTP.Text = dgvPhong.Rows[e.RowIndex].Cells["TenCSVCP"].Value?.ToString();
                txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells["GiaToaA"].Value?.ToString();
                cmbTenTang.Text = dgvPhong.Rows[e.RowIndex].Cells["TenTang"].Value?.ToString();

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã nhấp
                object cellValue = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Hiển thị giá trị của ô trong TextBox tương ứng
                textBox8.Text = dataGridView3.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value?.ToString();
                textBox6.Text = dataGridView3.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value?.ToString();
                textBox7.Text = dataGridView3.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value?.ToString();
                textBox5.Text = dataGridView3.Rows[e.RowIndex].Cells["idCosohatangphong"].Value?.ToString();
                txtGiaPhong.Text = dataGridView3.Rows[e.RowIndex].Cells["GiaToaB"].Value?.ToString();
                textBox4.Text = dataGridView3.Rows[e.RowIndex].Cells["idTang"].Value?.ToString();

            }
        }

        private void btnCapnhatphong_Click(object sender, EventArgs e)
        {
            try
            {
                using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                {
                    int maPhong = (int)dgvPhong.CurrentRow.Cells["maPhongDataGridViewTextBoxColumn"].Value;
                    var nguonDuLieu = db.Phongs;

                    Phong updatingPhong = nguonDuLieu.Single(t => t.MaPhong == maPhong);

                    updatingPhong.TenPhong = txtTenphong.Text;
                    updatingPhong.Gia = Convert.ToInt32(txtGia.Text);
                    updatingPhong.TrangThaiPhong = txtTrangthai.Text;
                    updatingPhong.idCosohatangphong = Convert.ToInt32(cmbTenCSHTP.SelectedValue);
                    updatingPhong.idTang = Convert.ToInt32(cmbTenTang.SelectedValue);

                    // Cập nhật thông tin vào cơ sở dữ liệu
                    db.Entry(updatingPhong).State = EntityState.Modified;
                    db.SaveChanges();

                    dgvPhong.Refresh();

                    ReloadDgvPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            //Console.WriteLine("Mã cơ sở hạ tầng: "+cmbTenCSHTP.SelectedValue);
            //Console.WriteLine("Mã tầng: " + cmbTenTang.SelectedValue);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                {
                    int maPhong = (int)dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value;
                    var nguonDuLieu = db.Phongs;

                    Phong updatingPhong = nguonDuLieu.Single(t => t.MaPhong == maPhong);

                    updatingPhong.TenPhong = textBox7.Text;
                    updatingPhong.Gia = Convert.ToInt32(txtGiaPhong.Text);
                    updatingPhong.TrangThaiPhong = textBox6.Text;
                    updatingPhong.idCosohatangphong = Convert.ToInt32(textBox5.SelectedValue);
                    updatingPhong.idTang = Convert.ToInt32(textBox4.SelectedValue);

                    // Cập nhật thông tin vào cơ sở dữ liệu
                    db.Entry(updatingPhong).State = EntityState.Modified;
                    db.SaveChanges();

                    dataGridView3.Refresh();

                    ReloadDgvPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdphong.Text.Equals("")
                    || txtTenphong.Text.Equals("")
                    || txtGia.Text.Equals("")
                    || txtTrangthai.Text.Equals("")
                    || cmbTenCSHTP.Text.Equals("")
                    || cmbTenTang.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng cần thêm", "Cảnh báo");
                }
                else
                {
                    int maPhongCanThem = Convert.ToInt32(txtIdphong.Text);
                    string tenPhong = txtTenphong.Text;
                    int giaThue = Convert.ToInt32(txtGia.Text);
                    string trangThai = txtTrangthai.Text;
                    int maCSVCP = Convert.ToInt32(cmbTenCSHTP.SelectedValue);
                    int maTang = Convert.ToInt32(cmbTenTang.SelectedValue);

                    bool isAdded = true;
                    foreach (DataGridViewRow row in dgvPhong.Rows)
                    {
                        int maPhong = Convert.ToInt32(row.Cells["maPhongDataGridViewTextBoxColumn"].Value);


                        if (maPhong == maPhongCanThem)

                        {
                            isAdded = false;

                        }
                    }
                    if (isAdded)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            Phong phong = new Phong();
                            {
                                phong.MaPhong = maPhongCanThem;
                                phong.TenPhong = tenPhong;
                                phong.Gia = giaThue;
                                phong.TrangThaiPhong = trangThai;
                                phong.idCosohatangphong = maCSVCP;
                                phong.idTang = maTang;

                                db.Phongs.Add(phong);
                                db.SaveChanges();

                                ReloadDgvPhong();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã phòng đã tồn tại, hãy chọn mã phòng khác!", "Cảnh báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Equals("")
                    || textBox7.Text.Equals("")
                    || txtGiaPhong.Text.Equals("")
                    || textBox6.Text.Equals("")
                    || textBox5.Text.Equals("")
                    || textBox5.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng cần thêm", "Cảnh báo");
                }
                else
                {
                    int maPhongCanThem = Convert.ToInt32(textBox8.Text);
                    string tenPhong = textBox7.Text;
                    int giaThue = Convert.ToInt32(txtGiaPhong.Text);
                    string trangThai = textBox6.Text;
                    int maCSVCP = Convert.ToInt32(textBox5.SelectedValue);
                    int maTang = Convert.ToInt32(textBox5.SelectedValue);

                    bool isAdded = true;
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        int maPhong = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);


                        if (maPhong == maPhongCanThem)

                        {
                            isAdded = false;

                        }
                    }
                    if (isAdded)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            Phong phong = new Phong();
                            {
                                phong.MaPhong = maPhongCanThem;
                                phong.TenPhong = tenPhong;
                                phong.Gia = giaThue;
                                phong.TrangThaiPhong = trangThai;
                                phong.idCosohatangphong = maCSVCP;
                                phong.idTang = maTang;

                                db.Phongs.Add(phong);
                                db.SaveChanges();

                                ReloadDgvPhong();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã phòng đã tồn tại, hãy chọn mã phòng khác!", "Cảnh báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdphong.Text.Equals(""))
                {
                    {
                        MessageBox.Show("Hãy chọn mã phòng cần xóa", "Lưu ý");
                    }
                }
                else
                {
                    int maPhongCanXoa = Convert.ToInt32(txtIdphong.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        var p = db.Phongs.FirstOrDefault(a => a.MaPhong == maPhongCanXoa);
                        db.Phongs.Remove(p);
                        db.SaveChanges();
                        ReloadDgvPhong();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi xóa", "Lỗi");
            }
        }

        private void btnXoa01_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Equals(""))
                {
                    {
                        MessageBox.Show("Hãy chọn mã phòng cần xóa", "Lưu ý");
                    }
                }
                else
                {
                    int maPhongCanXoa = Convert.ToInt32(textBox8.Text);

                    using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                    {
                        var p = db.Phongs.FirstOrDefault(a => a.MaPhong == maPhongCanXoa);
                        db.Phongs.Remove(p);
                        db.SaveChanges();
                        ReloadDgvPhong();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi xóa", "Lỗi");
            }
        }

        private void btnThuePhong1_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn phòng để thuê", "Thông báo");
            }
            else
            {
                string trangThaiPhong = (string)dgvPhong.CurrentRow.Cells["trangThaiPhongDataGridViewTextBoxColumn"].Value;

                if (trangThaiPhong.Equals("Đang Thuê"))
                {
                    MessageBox.Show("Phòng đang cho thuê, hãy chọn phòng khác!", "Thông báo");
                }
                else
                {
                    int giaPhong = (int)dgvPhong.CurrentRow.Cells["GiaToaA"].Value;
                    string tenPhong = (string)dgvPhong.CurrentRow.Cells["tenPhongDataGridViewTextBoxColumn"].Value;
                    int idPhong = Convert.ToInt32(txtIdphong.Text);
                    frmThuePhong f = new frmThuePhong(idNV, giaPhong, tenPhong, idPhong);
                    f.ShowDialog();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn phòng để thuê", "Thông báo");
            }
            else
            {
                string trangThaiPhong = (string)dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value;

                if (trangThaiPhong.Equals("Đang Thuê"))
                {
                    MessageBox.Show("Phòng đang cho thuê, hãy chọn phòng khác!", "Thông báo");
                }
                else
                {
                    int giaPhong = (int)dataGridView3.CurrentRow.Cells["GiaToaB"].Value;
                    string tenPhong = (string)dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value;
                    int idPhong = Convert.ToInt32(textBox8.Text);
                    frmThuePhong f = new frmThuePhong(idNV, giaPhong, tenPhong, idPhong);
                    f.ShowDialog();
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ReloadDgvPhong();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReloadDgvPhong();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTangA.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
                }
                else
                {
                    int maTangCanThem = Convert.ToInt32(txtMaTangA.Text);
                    bool isAdded = true;
                    foreach (DataGridViewRow row in dtgvTang.Rows)
                    {
                        int maTang = Convert.ToInt32(row.Cells["maTangDataGridViewTextBoxColumn"].Value);


                        if (maTang == maTangCanThem)

                        {
                            isAdded = false;

                        }
                    }
                    if (isAdded)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            Tang t = new Tang();
                            {
                                t.MaTang = maTangCanThem;
                                t.TenTang = textBox2.Text;
                                t.TrangThaiTang = comboBox1.Text;
                                t.idCosohatangtang = (int?)cmbTenCSHTTA.SelectedValue;
                                t.MaToa = 1;

                                db.Tangs.Add(t);
                                db.SaveChanges();

                                ReloadTangA();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã tầng đã tồn tại, hãy chọn mã phòng khác!", "Cảnh báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tầng!", "Thông báo");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTangB.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo");
                }
                else
                {
                    int maTangCanThem = Convert.ToInt32(txtMaTangB.Text);
                    bool isAdded = true;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        int maTang = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn6"].Value);


                        if (maTang == maTangCanThem)

                        {
                            isAdded = false;

                        }
                    }
                    if (isAdded)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            Tang t = new Tang();
                            {
                                t.MaTang = maTangCanThem;
                                t.TenTang = textBox3.Text;
                                t.TrangThaiTang = comboBox2.Text;
                                t.idCosohatangtang = (int?)comboBox3.SelectedValue;
                                t.MaToa = 2;

                                db.Tangs.Add(t);
                                db.SaveChanges();

                                ReloadTangB();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã tầng đã tồn tại, hãy chọn mã phòng khác!", "Cảnh báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tầng!", "Thông báo");
            }
        }

        private void btnXoaTangA_Click(object sender, EventArgs e)
        {
            try
            {
                int? maTangCanXoa = (int)dtgvTang.CurrentRow.Cells["maTangDataGridViewTextBoxColumn"].Value;
                if (maTangCanXoa == null)
                {
                    MessageBox.Show("Vui lòng chọn tầng cần xóa trong bảng", "Thông báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tầng " + maTangCanXoa + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            var t = db.Tangs.FirstOrDefault(a => a.MaTang == maTangCanXoa);
                            db.Tangs.Remove(t);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            ReloadTangA();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa!", "Thông báo");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int? maTangCanXoa = (int)dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value;
                if (maTangCanXoa == null)
                {
                    MessageBox.Show("Vui lòng chọn tầng cần xóa trong bảng", "Thông báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tầng " + maTangCanXoa + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
                        {
                            var t = db.Tangs.FirstOrDefault(a => a.MaTang == maTangCanXoa);
                            db.Tangs.Remove(t);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            ReloadTangB();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa!", "Thông báo");
            }
        }
    }
}
