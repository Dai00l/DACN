namespace DACN
{
    partial class frmQuanlykhachhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlykhachhang));
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.idKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toaNhaChoThue999DataSet3 = new DACN.ToaNhaChoThue999DataSet3();
            this.kHACHHANGTableAdapter = new DACN.ToaNhaChoThue999DataSet3TableAdapters.KHACHHANGTableAdapter();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaydangky = new System.Windows.Forms.DateTimePicker();
            this.txtGioitinhKH = new System.Windows.Forms.TextBox();
            this.txtID_KH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toaNhaChoThue999DataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.AutoGenerateColumns = false;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKH,
            this.nameKH,
            this.diachiKH,
            this.emailKH,
            this.sdtKH,
            this.sexKH,
            this.ngayDK});
            this.dgvKH.DataSource = this.kHACHHANGBindingSource;
            this.dgvKH.Location = new System.Drawing.Point(12, 12);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(927, 227);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // idKH
            // 
            this.idKH.DataPropertyName = "IDKH";
            this.idKH.HeaderText = "IDKH";
            this.idKH.MinimumWidth = 6;
            this.idKH.Name = "idKH";
            this.idKH.Width = 125;
            // 
            // nameKH
            // 
            this.nameKH.DataPropertyName = "HoTen";
            this.nameKH.HeaderText = "HoTen";
            this.nameKH.MinimumWidth = 6;
            this.nameKH.Name = "nameKH";
            this.nameKH.Width = 125;
            // 
            // diachiKH
            // 
            this.diachiKH.DataPropertyName = "DiaChi";
            this.diachiKH.HeaderText = "DiaChi";
            this.diachiKH.MinimumWidth = 6;
            this.diachiKH.Name = "diachiKH";
            this.diachiKH.Width = 125;
            // 
            // emailKH
            // 
            this.emailKH.DataPropertyName = "Email";
            this.emailKH.HeaderText = "Email";
            this.emailKH.MinimumWidth = 6;
            this.emailKH.Name = "emailKH";
            this.emailKH.Width = 125;
            // 
            // sdtKH
            // 
            this.sdtKH.DataPropertyName = "SoDienThoai";
            this.sdtKH.HeaderText = "SoDienThoai";
            this.sdtKH.MinimumWidth = 6;
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Width = 125;
            // 
            // sexKH
            // 
            this.sexKH.DataPropertyName = "GioiTinh";
            this.sexKH.HeaderText = "GioiTinh";
            this.sexKH.MinimumWidth = 6;
            this.sexKH.Name = "sexKH";
            this.sexKH.Width = 125;
            // 
            // ngayDK
            // 
            this.ngayDK.DataPropertyName = "NgayDangKy";
            this.ngayDK.HeaderText = "NgayDangKy";
            this.ngayDK.MinimumWidth = 6;
            this.ngayDK.Name = "ngayDK";
            this.ngayDK.Width = 125;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.toaNhaChoThue999DataSet3;
            // 
            // toaNhaChoThue999DataSet3
            // 
            this.toaNhaChoThue999DataSet3.DataSetName = "ToaNhaChoThue999DataSet3";
            this.toaNhaChoThue999DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.Red;
            this.btnXoaKH.Location = new System.Drawing.Point(1031, 173);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(108, 41);
            this.btnXoaKH.TabIndex = 5;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.BackColor = System.Drawing.Color.Cyan;
            this.btnCapnhatKH.Location = new System.Drawing.Point(1031, 33);
            this.btnCapnhatKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(108, 38);
            this.btnCapnhatKH.TabIndex = 6;
            this.btnCapnhatKH.Text = "Cập nhật ";
            this.btnCapnhatKH.UseVisualStyleBackColor = false;
            this.btnCapnhatKH.Click += new System.EventHandler(this.btnCapnhatKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.Lime;
            this.btnThemKH.Location = new System.Drawing.Point(1031, 100);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(108, 38);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgaydangky);
            this.panel1.Controls.Add(this.txtGioitinhKH);
            this.panel1.Controls.Add(this.txtID_KH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtEmailKH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAddressKH);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.txtNameKH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 212);
            this.panel1.TabIndex = 7;
            // 
            // dtpNgaydangky
            // 
            this.dtpNgaydangky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydangky.Location = new System.Drawing.Point(608, 83);
            this.dtpNgaydangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaydangky.Name = "dtpNgaydangky";
            this.dtpNgaydangky.Size = new System.Drawing.Size(269, 22);
            this.dtpNgaydangky.TabIndex = 165;
            // 
            // txtGioitinhKH
            // 
            this.txtGioitinhKH.Location = new System.Drawing.Point(147, 118);
            this.txtGioitinhKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioitinhKH.Name = "txtGioitinhKH";
            this.txtGioitinhKH.Size = new System.Drawing.Size(128, 22);
            this.txtGioitinhKH.TabIndex = 163;
            // 
            // txtID_KH
            // 
            this.txtID_KH.Location = new System.Drawing.Point(608, 140);
            this.txtID_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_KH.Name = "txtID_KH";
            this.txtID_KH.ReadOnly = true;
            this.txtID_KH.Size = new System.Drawing.Size(220, 22);
            this.txtID_KH.TabIndex = 161;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 162;
            this.label10.Text = "ID Khách Hàng :";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Location = new System.Drawing.Point(147, 52);
            this.txtEmailKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(269, 22);
            this.txtEmailKH.TabIndex = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 159;
            this.label8.Text = "Ngày Đăng Ký  :";
            // 
            // txtAddressKH
            // 
            this.txtAddressKH.Location = new System.Drawing.Point(608, 15);
            this.txtAddressKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressKH.Name = "txtAddressKH";
            this.txtAddressKH.Size = new System.Drawing.Size(269, 22);
            this.txtAddressKH.TabIndex = 152;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(147, 177);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(269, 22);
            this.txtSDTKH.TabIndex = 151;
            // 
            // txtNameKH
            // 
            this.txtNameKH.Location = new System.Drawing.Point(147, 10);
            this.txtNameKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(269, 22);
            this.txtNameKH.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 158;
            this.label7.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 157;
            this.label3.Text = "Giới Tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 156;
            this.label5.Text = "Số Điện Thoại :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 155;
            this.label9.Text = "Địa Chỉ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 18);
            this.label12.TabIndex = 153;
            this.label12.Text = "Tên Khách Hàng :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1122, 404);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 39);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // frmQuanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 527);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnCapnhatKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dgvKH);
            this.Name = "frmQuanlykhachhang";
            this.Text = "frmQuanlykhachhang";
            this.Load += new System.EventHandler(this.frmQuanlykhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toaNhaChoThue999DataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private ToaNhaChoThue999DataSet3 toaNhaChoThue999DataSet3;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private ToaNhaChoThue999DataSet3TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDK;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgaydangky;
        private System.Windows.Forms.TextBox txtGioitinhKH;
        private System.Windows.Forms.TextBox txtID_KH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddressKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}