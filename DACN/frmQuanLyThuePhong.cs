using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN
{
    public partial class frmQuanLyThuePhong : Form
    {
        public frmQuanLyThuePhong()
        {
            InitializeComponent();
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.HoTen;
            LoadPhong(dtgvTang);
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
            // Binding bd = new Binding("Text", Cons.Cons.LoginNhanVien, "Ten", true,DataSourceUpdateMode.OnPropertyChanged);
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons.Cons.LoginNhanVien = null;
            this.Close();
        }
        void LoadPhong(DataGridView dtgv)
        {
            using (ToaNhaChoThue88888Entities db = new ToaNhaChoThue88888Entities())
            {
                var source = from t in db.Tangs
                             select new
                             {
                                 Tầng = t.TenTang,
                                 Trạng_Thái_Tầng = t.TrangThaiTang,
                                 Cơ_Sở_Hạ_Tầng = t.CoSoHaTangTangs

                             };

                        dtgv.DataSource = source.ToList();
            }
            


        }
    }
}
