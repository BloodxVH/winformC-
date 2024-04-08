namespace BaiTapLonWinform
{
    partial class frmDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoanCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.chkMatKhauCu = new System.Windows.Forms.CheckBox();
            this.chkMatKhauMoi = new System.Windows.Forms.CheckBox();
            this.chkNhapLaiMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtTaiKhoanCu
            // 
            this.txtTaiKhoanCu.Location = new System.Drawing.Point(207, 29);
            this.txtTaiKhoanCu.Name = "txtTaiKhoanCu";
            this.txtTaiKhoanCu.Size = new System.Drawing.Size(149, 20);
            this.txtTaiKhoanCu.TabIndex = 1;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(207, 66);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(149, 20);
            this.txtMatKhauCu.TabIndex = 1;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(207, 109);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(149, 20);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(207, 154);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(149, 20);
            this.txtNhapLaiMatKhau.TabIndex = 1;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // chkMatKhauCu
            // 
            this.chkMatKhauCu.AutoSize = true;
            this.chkMatKhauCu.Location = new System.Drawing.Point(378, 69);
            this.chkMatKhauCu.Name = "chkMatKhauCu";
            this.chkMatKhauCu.Size = new System.Drawing.Size(47, 17);
            this.chkMatKhauCu.TabIndex = 2;
            this.chkMatKhauCu.Text = "Xem";
            this.chkMatKhauCu.UseVisualStyleBackColor = true;
            this.chkMatKhauCu.CheckedChanged += new System.EventHandler(this.chkMatKhauCu_CheckedChanged);
            // 
            // chkMatKhauMoi
            // 
            this.chkMatKhauMoi.AutoSize = true;
            this.chkMatKhauMoi.Location = new System.Drawing.Point(378, 112);
            this.chkMatKhauMoi.Name = "chkMatKhauMoi";
            this.chkMatKhauMoi.Size = new System.Drawing.Size(47, 17);
            this.chkMatKhauMoi.TabIndex = 2;
            this.chkMatKhauMoi.Text = "Xem";
            this.chkMatKhauMoi.UseVisualStyleBackColor = true;
            this.chkMatKhauMoi.CheckedChanged += new System.EventHandler(this.chkMatKhauMoi_CheckedChanged);
            // 
            // chkNhapLaiMatKhau
            // 
            this.chkNhapLaiMatKhau.AutoSize = true;
            this.chkNhapLaiMatKhau.Location = new System.Drawing.Point(378, 157);
            this.chkNhapLaiMatKhau.Name = "chkNhapLaiMatKhau";
            this.chkNhapLaiMatKhau.Size = new System.Drawing.Size(47, 17);
            this.chkNhapLaiMatKhau.TabIndex = 2;
            this.chkNhapLaiMatKhau.Text = "Xem";
            this.chkNhapLaiMatKhau.UseVisualStyleBackColor = true;
            this.chkNhapLaiMatKhau.CheckedChanged += new System.EventHandler(this.chkNhapLaiMatKhau_CheckedChanged);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(151, 206);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(281, 206);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 263);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.chkNhapLaiMatKhau);
            this.Controls.Add(this.chkMatKhauMoi);
            this.Controls.Add(this.chkMatKhauCu);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtTaiKhoanCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoanCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.CheckBox chkMatKhauCu;
        private System.Windows.Forms.CheckBox chkMatKhauMoi;
        private System.Windows.Forms.CheckBox chkNhapLaiMatKhau;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThoat;
    }
}