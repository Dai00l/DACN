namespace DACN
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpThu = new System.Windows.Forms.TabPage();
            this.btnInbaocaoThu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.MaThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChi = new System.Windows.Forms.TabPage();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTenNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.MaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienC = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1.SuspendLayout();
            this.tpThu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.tbChi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpThu);
            this.tabControl1.Controls.Add(this.tbChi);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tpThu
            // 
            this.tpThu.Controls.Add(this.btnInbaocaoThu);
            this.tpThu.Controls.Add(this.panel3);
            this.tpThu.Location = new System.Drawing.Point(4, 25);
            this.tpThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpThu.Name = "tpThu";
            this.tpThu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpThu.Size = new System.Drawing.Size(1205, 526);
            this.tpThu.TabIndex = 0;
            this.tpThu.Text = "Thu";
            this.tpThu.UseVisualStyleBackColor = true;
            // 
            // btnInbaocaoThu
            // 
            this.btnInbaocaoThu.Location = new System.Drawing.Point(1076, 50);
            this.btnInbaocaoThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInbaocaoThu.Name = "btnInbaocaoThu";
            this.btnInbaocaoThu.Size = new System.Drawing.Size(120, 23);
            this.btnInbaocaoThu.TabIndex = 26;
            this.btnInbaocaoThu.Text = "In báo cáo";
            this.btnInbaocaoThu.UseVisualStyleBackColor = true;
            this.btnInbaocaoThu.Click += new System.EventHandler(this.btnInbaocaoThu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvThongKe);
            this.panel3.Location = new System.Drawing.Point(37, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 306);
            this.panel3.TabIndex = 20;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThu,
            this.HoTenNV,
            this.HoTenKH,
            this.NoiDung,
            this.SoTien});
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1159, 306);
            this.dgvThongKe.TabIndex = 0;
            // 
            // MaThu
            // 
            this.MaThu.DataPropertyName = "MaThu";
            this.MaThu.HeaderText = "Mã Thu";
            this.MaThu.MinimumWidth = 6;
            this.MaThu.Name = "MaThu";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Nhân Viên";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Khách Hàng";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Tổng";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            // 
            // tbChi
            // 
            this.tbChi.Controls.Add(this.btnIn);
            this.tbChi.Controls.Add(this.panel1);
            this.tbChi.Location = new System.Drawing.Point(4, 25);
            this.tbChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChi.Name = "tbChi";
            this.tbChi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChi.Size = new System.Drawing.Size(1205, 526);
            this.tbChi.TabIndex = 1;
            this.tbChi.Text = "Chi";
            this.tbChi.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1097, 27);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(99, 23);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvChi);
            this.panel1.Location = new System.Drawing.Point(23, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 306);
            this.panel1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTenNhanVien});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // tmiTenNhanVien
            // 
            this.tmiTenNhanVien.Name = "tmiTenNhanVien";
            this.tmiTenNhanVien.Size = new System.Drawing.Size(224, 26);
            this.tmiTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // dgvChi
            // 
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChi,
            this.NoiDungC,
            this.HoTen,
            this.SoTienC});
            this.dgvChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChi.Location = new System.Drawing.Point(0, 0);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(1177, 306);
            this.dgvChi.TabIndex = 0;
            // 
            // MaChi
            // 
            this.MaChi.DataPropertyName = "MaChi";
            this.MaChi.HeaderText = "Mã Chi";
            this.MaChi.MinimumWidth = 6;
            this.MaChi.Name = "MaChi";
            // 
            // NoiDungC
            // 
            this.NoiDungC.DataPropertyName = "NoiDung";
            this.NoiDungC.HeaderText = "Nội Dung";
            this.NoiDungC.MinimumWidth = 6;
            this.NoiDungC.Name = "NoiDungC";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên Nhân Viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // SoTienC
            // 
            this.SoTienC.DataPropertyName = "SoTien";
            this.SoTienC.HeaderText = "Số Tiền";
            this.SoTienC.MinimumWidth = 6;
            this.SoTienC.Name = "SoTienC";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 705);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.tabControl1.ResumeLayout(false);
            this.tpThu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.tbChi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpThu;
        private System.Windows.Forms.TabPage tbChi;
        private System.Windows.Forms.Button btnInbaocaoThu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiTenNhanVien;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewLinkColumn SoTienC;
    }
}