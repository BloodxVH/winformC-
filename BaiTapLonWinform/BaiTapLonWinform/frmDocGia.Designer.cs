namespace BaiTapLonWinform
{
    partial class frmDocGia
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTenCD = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radMaSach = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvThongTInSach = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTInSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpTimKiem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.txtNDTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(496, 28);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(334, 76);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Nhập thông tin cần Tìm kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(31, 33);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(278, 20);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTenCD);
            this.groupBox2.Controls.Add(this.radTenTG);
            this.groupBox2.Controls.Add(this.radTenSach);
            this.groupBox2.Controls.Add(this.radMaSach);
            this.groupBox2.Location = new System.Drawing.Point(34, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // radTenCD
            // 
            this.radTenCD.AutoSize = true;
            this.radTenCD.Location = new System.Drawing.Point(293, 33);
            this.radTenCD.Name = "radTenCD";
            this.radTenCD.Size = new System.Drawing.Size(62, 17);
            this.radTenCD.TabIndex = 0;
            this.radTenCD.TabStop = true;
            this.radTenCD.Text = "Tên CD";
            this.radTenCD.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            this.radTenTG.AutoSize = true;
            this.radTenTG.Location = new System.Drawing.Point(202, 33);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(62, 17);
            this.radTenTG.TabIndex = 0;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tên TG";
            this.radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenSach
            // 
            this.radTenSach.AutoSize = true;
            this.radTenSach.Location = new System.Drawing.Point(111, 33);
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
            this.radMaSach.Location = new System.Drawing.Point(20, 33);
            this.radMaSach.Name = "radMaSach";
            this.radMaSach.Size = new System.Drawing.Size(68, 17);
            this.radMaSach.TabIndex = 0;
            this.radMaSach.TabStop = true;
            this.radMaSach.Text = "Mã Sách";
            this.radMaSach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvThongTInSach);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sách";
            // 
            // dgvThongTInSach
            // 
            this.dgvThongTInSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTInSach.Location = new System.Drawing.Point(34, 29);
            this.dgvThongTInSach.Name = "dgvThongTInSach";
            this.dgvThongTInSach.Size = new System.Drawing.Size(796, 226);
            this.dgvThongTInSach.TabIndex = 0;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 444);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Độc giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTInSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTenCD;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvThongTInSach;
    }
}