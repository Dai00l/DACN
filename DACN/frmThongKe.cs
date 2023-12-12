using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DACN
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            ReloadThongKeThu();
            ReloadThongKeChi();
        }

        public void ReloadThongKeThu()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select t.MaThu, nv.HoTen as HoTenNV, kh.HoTen as HoTenKH, t.NoiDung, t.SoTien\r\nfrom Thu t \r\ninner join Nhanvien nv on t.idNhanVien = nv.IDNVien \r\ninner join KHACHHANG kh on t.idKhachHang = kh.IDKH", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dgvThongKe.DataSource = dt;
        }
        public void ReloadThongKeChi()
        {
            SqlConnection conn = new SqlConnection("data source =DESKTOP-IOFB5UG\\SQLEXPRESS; initial catalog=ToaNhaChoThue999; integrated security=true");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select c.MaChi, c.NoiDung, nv.HoTen, c.SoTien\r\nfrom Chi c inner join Nhanvien nv on c.idNhanVien = nv.IDNVien", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dgvChi.DataSource = dt;
        }


        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.HoTen;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons.Cons.LoginNhanVien = null;
            this.Close();
        }

        private void btnInbaocaoThu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Word Document|*.docx";
                saveFileDialog1.Title = "Chọn vị trí lưu file";
                saveFileDialog1.FileName = "BaoCaoDoanhThu";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (DocX document = DocX.Create(saveFileDialog1.FileName))
                    {
                        document.InsertParagraph("Tòa Nhà Cho Thuê 999").FontSize(18).Bold().Alignment = Alignment.center;
                        document.InsertParagraph("$$$ Tổng Doanh Thu $$$").FontSize(18).Bold().Alignment = Alignment.center;

                        Table table = document.AddTable(dgvThongKe.Rows.Count + 2, dgvThongKe.Columns.Count); 
                        table.Alignment = Alignment.center;

                        for (int i = 0; i < dgvThongKe.Columns.Count; i++)
                        {
                            table.Rows[0].Cells[i].Paragraphs.First().Append(dgvThongKe.Columns[i].HeaderText).Bold();
                        }

                        for (int row = 0; row < dgvThongKe.Rows.Count; row++)
                        {
                            if (dgvThongKe.Rows[row].Cells != null)
                            {
                                for (int col = 0; col < dgvThongKe.Columns.Count; col++)
                                {
                                    if (dgvThongKe.Rows[row].Cells[col].Value != null)
                                    {
                                        table.Rows[row + 1].Cells[col].Paragraphs.First().Append(dgvThongKe.Rows[row].Cells[col].Value.ToString());
                                    }
                                    else
                                    {
                                        table.Rows[row + 1].Cells[col].Paragraphs.First().Append("N/A");
                                    }
                                }
                            }
                        }

                        decimal tongSoTien = 0;
                        for (int row = 0; row < dgvThongKe.Rows.Count; row++)
                        {
                            if (dgvThongKe.Rows[row].Cells["SoTien"].Value != null)
                            {
                                tongSoTien += Convert.ToDecimal(dgvThongKe.Rows[row].Cells["SoTien"].Value);
                            }
                        }

                        table.Rows[dgvThongKe.Rows.Count + 1].Cells[0].Paragraphs.First().Append("Tổng số tiền:").Bold();
                        table.Rows[dgvThongKe.Rows.Count + 1].Cells[1].Paragraphs.First().Append(tongSoTien.ToString()); // Format số tiền

                        for (int col = 0; col < dgvThongKe.Columns.Count; col++)
                        {
                            table.Rows[dgvThongKe.Rows.Count + 1].Cells[col].Width = table.Rows[0].Cells[col].Width;
                        }

                        document.InsertTable(table);

                        document.Save();
                        MessageBox.Show($"Đã xuất file tại {saveFileDialog1.FileName}", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Thông báo");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Word Document|*.docx";
                saveFileDialog1.Title = "Chọn vị trí lưu file";
                saveFileDialog1.FileName = "BaoCaoChi";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (DocX document = DocX.Create(saveFileDialog1.FileName))
                    {
                        document.InsertParagraph("Tòa Nhà Cho Thuê 999").FontSize(18).Bold().Alignment = Alignment.center;
                        document.InsertParagraph("Tổng chi").FontSize(18).Bold().Alignment = Alignment.center;

                        Table table = document.AddTable(dgvChi.Rows.Count + 2, dgvChi.Columns.Count);
                        table.Alignment = Alignment.center;

                        for (int i = 0; i < dgvChi.Columns.Count; i++)
                        {
                            table.Rows[0].Cells[i].Paragraphs.First().Append(dgvChi.Columns[i].HeaderText).Bold();
                        }

                        for (int row = 0; row < dgvChi.Rows.Count; row++)
                        {
                            if (dgvChi.Rows[row].Cells != null)
                            {
                                for (int col = 0; col < dgvChi.Columns.Count; col++)
                                {
                                    if (dgvChi.Rows[row].Cells[col].Value != null)
                                    {
                                        table.Rows[row + 1].Cells[col].Paragraphs.First().Append(dgvChi.Rows[row].Cells[col].Value.ToString());
                                    }
                                    else
                                    {
                                        table.Rows[row + 1].Cells[col].Paragraphs.First().Append("N/A");
                                    }
                                }
                            }
                        }

                        decimal tongSoTien = 0;
                        for (int row = 0; row < dgvChi.Rows.Count; row++)
                        {
                            if (dgvChi.Rows[row].Cells["SoTienC"].Value != null)
                            {
                                tongSoTien += Convert.ToDecimal(dgvChi.Rows[row].Cells["SoTienC"].Value);
                            }
                        }

                        table.Rows[dgvChi.Rows.Count + 1].Cells[0].Paragraphs.First().Append("Tổng số tiền:").Bold();
                        table.Rows[dgvChi.Rows.Count + 1].Cells[1].Paragraphs.First().Append(tongSoTien.ToString()); // Format số tiền

                        for (int col = 0; col < dgvChi.Columns.Count; col++)
                        {
                            table.Rows[dgvChi.Rows.Count + 1].Cells[col].Width = table.Rows[0].Cells[col].Width;
                        }

                        document.InsertTable(table);

                        document.Save();
                        MessageBox.Show($"Đã xuất file tại {saveFileDialog1.FileName}", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Thông báo");
            }
        }
    }
    
}
