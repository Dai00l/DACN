using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DACN
{
    public partial class frmThuePhong : Form
    {
        string idNV;
        int giaPhong;
        string tenPhong;
        int idPhong;

        public frmThuePhong(string idNV, int giaPhong, string tenPhong, int idPhong)
        {
            InitializeComponent();
            this.idNV = idNV;
            this.giaPhong = giaPhong;
            this.tenPhong = tenPhong;
            this.idPhong = idPhong;
        }

        public void loadKhachHang()
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                var listKH = db.KHACHHANGs;
                cmbKH.DataSource = listKH.ToList();
                cmbKH.DisplayMember = "HoTen";
                cmbKH.ValueMember = "IDKH";
            }
        }

        public void DatPhong(string idKH, string idNV, DateTime NBD, DateTime NKT, int giaThue, int idPhong, string noiDung) 
        {
            using (ToaNhaChoThue999Entities db = new ToaNhaChoThue999Entities())
            {
                HopDong hd = new HopDong();
                {
                    hd.NgayBatDau = NBD;
                    hd.NgayKetThuc = NKT;
                    hd.GiaThue = giaThue;
                    hd.IDNhanVien = idNV;
                    hd.IDKhachHang = idKH;

                    db.HopDongs.Add(hd);
                    db.SaveChanges();
                }

                ThuePhong tp = new ThuePhong();
                {
                    tp.idPhong = idPhong;
                    tp.idKhachhang = idKH;

                    db.ThuePhongs.Add(tp);
                    db.SaveChanges();
                }

                Thu thu = new Thu();
                {
                    thu.SoTien = giaThue;
                    thu.NoiDung = noiDung;
                    thu.idNhanVien = idNV;
                    thu.idKhachHang = idKH;

                    db.Thus.Add(thu);
                    db.SaveChanges();
                }

                var nguonDuLieu = db.Phongs;
                Phong updatingPhong = nguonDuLieu.Single(t => t.MaPhong == idPhong);
                updatingPhong.TrangThaiPhong = "Đang Thuê";
                db.Entry(updatingPhong).State = EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Đặt phòng thành công!", "Thông Báo");
            this.Close();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            loadKhachHang();

            txtGiaa.Text = Convert.ToString(giaPhong);
            lblTenPhong.Text = "Thanh toán phòng " + tenPhong;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string idKH = cmbKH.SelectedValue.ToString();
            string IDNV = idNV;
            DateTime NBD = dtpNgayBatDau.Value;
            DateTime NKT = dtpNgayKetThuc.Value;
            int giaThue = Convert.ToInt32(txtGiaa.Text);
            int IdPhong = this.idPhong;
            string noiDung = rtbNoiDung.Text;

            DatPhong(idKH, IDNV, NBD, NKT, giaThue, IdPhong, noiDung);
        }
    }
}
