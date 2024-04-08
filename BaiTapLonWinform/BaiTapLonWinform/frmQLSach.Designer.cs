namespace BaiTapLonWinform
{
    partial class frmQLSach
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTenCD = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radMaSach = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
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
            this.dataGridViewDSSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNDTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(450, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(22, 19);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(243, 20);
            this.txtNDTimKiem.TabIndex = 1;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTenCD);
            this.groupBox2.Controls.Add(this.radTenTG);
            this.groupBox2.Controls.Add(this.radTenSach);
            this.groupBox2.Controls.Add(this.radMaSach);
            this.groupBox2.Location = new System.Drawing.Point(27, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // radTenCD
            // 
            this.radTenCD.AutoSize = true;
            this.radTenCD.Location = new System.Drawing.Point(284, 22);
            this.radTenCD.Name = "radTenCD";
            this.radTenCD.Size = new System.Drawing.Size(60, 17);
            this.radTenCD.TabIndex = 0;
            this.radTenCD.TabStop = true;
            this.radTenCD.Text = "Chủ đề";
            this.radTenCD.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            this.radTenTG.AutoSize = true;
            this.radTenTG.Location = new System.Drawing.Point(197, 22);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(61, 17);
            this.radTenTG.TabIndex = 0;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tác giả";
            this.radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenSach
            // 
            this.radTenSach.AutoSize = true;
            this.radTenSach.Location = new System.Drawing.Point(106, 22);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(72, 17);
            this.radTenSach.TabIndex = 0;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tên Sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            // 
            // radMaSach
            // 
            this.radMaSach.AutoSize = true;
            this.radMaSach.Location = new System.Drawing.Point(15, 22);
            this.radMaSach.Name = "radMaSach";
            this.radMaSach.Size = new System.Drawing.Size(68, 17);
            this.radMaSach.TabIndex = 0;
            this.radMaSach.TabStop = true;
            this.radMaSach.Text = "Mã Sách";
            this.radMaSach.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboTinhTrang);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.txtNamXB);
            this.groupBox4.Controls.Add(this.txtNXB);
            this.groupBox4.Controls.Add(this.txtDonGia);
            this.groupBox4.Controls.Add(this.txtTacGia);
            this.groupBox4.Controls.Add(this.txtChuDe);
            this.groupBox4.Controls.Add(this.txtSLNhap);
            this.groupBox4.Controls.Add(this.txtTenSach);
            this.groupBox4.Controls.Add(this.txtMaSach);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 151);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Sách";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(547, 96);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(168, 21);
            this.cboTinhTrang.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(547, 123);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(168, 20);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(116, 123);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(168, 20);
            this.txtNamXB.TabIndex = 1;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(116, 96);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(168, 20);
            this.txtNXB.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(547, 70);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(168, 20);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(116, 70);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(168, 20);
            this.txtTacGia.TabIndex = 1;
            // 
            // txtChuDe
            // 
            this.txtChuDe.Location = new System.Drawing.Point(547, 20);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(168, 20);
            this.txtChuDe.TabIndex = 1;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(547, 46);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(168, 20);
            this.txtSLNhap.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(116, 46);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(168, 20);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(116, 20);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(168, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghi Chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm XB :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tình Trạng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NXB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn Giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác Giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SL Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chủ Đề:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewDSSach);
            this.groupBox5.Location = new System.Drawing.Point(12, 374);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 171);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách Sách";
            // 
            // dataGridViewDSSach
            // 
            this.dataGridViewDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSSach.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDSSach.Name = "dataGridViewDSSach";
            this.dataGridViewDSSach.Size = new System.Drawing.Size(770, 152);
            this.dataGridViewDSSach.TabIndex = 0;
            this.dataGridViewDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSach_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(183, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(279, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(462, 333);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(559, 333);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 556);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSach";
            this.Load += new System.EventHandler(this.frmQLSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.RadioButton radTenCD;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtChuDe;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
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
        private System.Windows.Forms.DataGridView dataGridViewDSSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}