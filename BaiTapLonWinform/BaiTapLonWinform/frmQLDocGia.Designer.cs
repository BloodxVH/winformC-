namespace BaiTapLonWinform
{
    partial class frmQLDocGia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTenDG = new System.Windows.Forms.RadioButton();
            this.radMaDG = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboLoaiDG = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm độc giả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNDTimKiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(382, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 81);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần Tìm kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(30, 34);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(222, 20);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTenDG);
            this.groupBox2.Controls.Add(this.radMaDG);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // radTenDG
            // 
            this.radTenDG.AutoSize = true;
            this.radTenDG.Location = new System.Drawing.Point(168, 34);
            this.radTenDG.Name = "radTenDG";
            this.radTenDG.Size = new System.Drawing.Size(63, 17);
            this.radTenDG.TabIndex = 0;
            this.radTenDG.TabStop = true;
            this.radTenDG.Text = "Tên ĐG";
            this.radTenDG.UseVisualStyleBackColor = true;
            // 
            // radMaDG
            // 
            this.radMaDG.AutoSize = true;
            this.radMaDG.Location = new System.Drawing.Point(37, 34);
            this.radMaDG.Name = "radMaDG";
            this.radMaDG.Size = new System.Drawing.Size(59, 17);
            this.radMaDG.TabIndex = 0;
            this.radMaDG.TabStop = true;
            this.radMaDG.Text = "Mã ĐG";
            this.radMaDG.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(576, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Trang chủ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboLoaiDG);
            this.groupBox4.Controls.Add(this.cboGioiTinh);
            this.groupBox4.Controls.Add(this.dtmNgaySinh);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.txtMK);
            this.groupBox4.Controls.Add(this.txtTenTK);
            this.groupBox4.Controls.Add(this.txtSoDT);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.txtTenDG);
            this.groupBox4.Controls.Add(this.txtMaDG);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(67, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(663, 160);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin độc giả";
            // 
            // cboLoaiDG
            // 
            this.cboLoaiDG.FormattingEnabled = true;
            this.cboLoaiDG.Location = new System.Drawing.Point(467, 104);
            this.cboLoaiDG.Name = "cboLoaiDG";
            this.cboLoaiDG.Size = new System.Drawing.Size(146, 21);
            this.cboLoaiDG.TabIndex = 3;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(467, 21);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(146, 21);
            this.cboGioiTinh.TabIndex = 3;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgaySinh.Location = new System.Drawing.Point(116, 81);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(146, 20);
            this.dtmNgaySinh.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(467, 132);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(146, 20);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(116, 135);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(146, 20);
            this.txtMK.TabIndex = 1;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(116, 109);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(146, 20);
            this.txtTenTK.TabIndex = 1;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(467, 75);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(146, 20);
            this.txtSoDT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(467, 48);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(146, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(116, 51);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(146, 20);
            this.txtTenDG.TabIndex = 1;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(116, 23);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(146, 20);
            this.txtMaDG.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghi Chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại ĐG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên TK:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Độc Giả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnLuu);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnSua);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Location = new System.Drawing.Point(67, 326);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(657, 59);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(464, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(358, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(253, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(134, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewDSDocGia);
            this.groupBox6.Location = new System.Drawing.Point(70, 410);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(654, 166);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách Độc Giả";
            // 
            // dataGridViewDSDocGia
            // 
            this.dataGridViewDSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSDocGia.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDSDocGia.Name = "dataGridViewDSDocGia";
            this.dataGridViewDSDocGia.Size = new System.Drawing.Size(648, 147);
            this.dataGridViewDSDocGia.TabIndex = 0;
            this.dataGridViewDSDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDocGia_CellClick);
            // 
            // frmQLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLDocGia";
            this.Load += new System.EventHandler(this.frmQLDocGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTenDG;
        private System.Windows.Forms.RadioButton radMaDG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiDG;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewDSDocGia;
    }
}