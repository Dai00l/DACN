using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                int maTangCanSua = (int)dtgvTang.CurrentRow.Cells["maTangDataGridViewTextBoxColumn"].Value;
                var nguonDuLieu = db.Tangs;

                Tang tangCanSua = nguonDuLieu.Single(t => t.MaTang == maTangCanSua);

                tangCanSua.TenTang = textBox2.Text;
                tangCanSua.TrangThaiTang = comboBox1.SelectedItem?.ToString();

                // Cập nhật thông tin vào cơ sở dữ liệu
                db.Entry(tangCanSua).State = EntityState.Modified;
                db.SaveChanges();

                dtgvTang.DataSource = nguonDuLieu.ToList();
            }
            dtgvTang.Refresh();
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
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                int maTangCanSua = (int)dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value;
                var nguonDuLieu = db.Tangs;

                Tang tangCanSua = nguonDuLieu.Single(t => t.MaTang == maTangCanSua);

                tangCanSua.TenTang = textBox3.Text;
                tangCanSua.TrangThaiTang = comboBox2.SelectedItem?.ToString();

                // Cập nhật thông tin vào cơ sở dữ liệu
                db.Entry(tangCanSua).State = EntityState.Modified;
                db.SaveChanges();

                dataGridView2.DataSource = nguonDuLieu.ToList();
            }
            dataGridView2.Refresh();
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
                txtIdCSHT.Text = dgvPhong.Rows[e.RowIndex].Cells["idCosohatangphongDataGridViewTextBoxColumn"].Value?.ToString();
                txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells["GiaToaA"].Value?.ToString();
                txtIdTang.Text = dgvPhong.Rows[e.RowIndex].Cells["idTangDataGridViewTextBoxColumn"].Value?.ToString();

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
                textBox5.Text = dataGridView3.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value?.ToString();
                txtGiaPhong.Text = dataGridView3.Rows[e.RowIndex].Cells["GiaToaB"].Value?.ToString();
                textBox4.Text = dataGridView3.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value?.ToString();

            }
        }
    }
}
