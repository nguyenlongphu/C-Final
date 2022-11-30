namespace CSharpFinal
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDanhMuc = new DevComponents.DotNetBar.ButtonX();
            this.btnQuanLySinhVien = new DevComponents.DotNetBar.ButtonX();
            this.btnQuanLyLop = new DevComponents.DotNetBar.ButtonX();
            this.pnlHeThong = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHeThong = new DevComponents.DotNetBar.ButtonX();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonX();
            this.btnQuanLyTaiKhoan = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panel1.SuspendLayout();
            this.pnlDanhMuc.SuspendLayout();
            this.pnlHeThong.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlDanhMuc);
            this.panel1.Controls.Add(this.pnlHeThong);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 533);
            this.panel1.TabIndex = 0;
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.Controls.Add(this.btnDanhMuc);
            this.pnlDanhMuc.Controls.Add(this.btnQuanLySinhVien);
            this.pnlDanhMuc.Controls.Add(this.btnQuanLyLop);
            this.pnlDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDanhMuc.Location = new System.Drawing.Point(0, 177);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(200, 107);
            this.pnlDanhMuc.TabIndex = 2;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDanhMuc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(1, 1);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(1);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(194, 33);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuanLySinhVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(1, 36);
            this.btnQuanLySinhVien.Margin = new System.Windows.Forms.Padding(1);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(194, 33);
            this.btnQuanLySinhVien.TabIndex = 1;
            this.btnQuanLySinhVien.Text = "Quản Lý Sinh Viên";
            this.btnQuanLySinhVien.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuanLyLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuanLyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLop.Location = new System.Drawing.Point(1, 71);
            this.btnQuanLyLop.Margin = new System.Windows.Forms.Padding(1);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(194, 33);
            this.btnQuanLyLop.TabIndex = 2;
            this.btnQuanLyLop.Text = "Quản Lý Lớp";
            this.btnQuanLyLop.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // pnlHeThong
            // 
            this.pnlHeThong.Controls.Add(this.btnHeThong);
            this.pnlHeThong.Controls.Add(this.btnDangXuat);
            this.pnlHeThong.Controls.Add(this.btnQuanLyTaiKhoan);
            this.pnlHeThong.Controls.Add(this.btnThoat);
            this.pnlHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeThong.Location = new System.Drawing.Point(0, 33);
            this.pnlHeThong.Name = "pnlHeThong";
            this.pnlHeThong.Size = new System.Drawing.Size(200, 144);
            this.pnlHeThong.TabIndex = 1;
            // 
            // btnHeThong
            // 
            this.btnHeThong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHeThong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.Location = new System.Drawing.Point(1, 1);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(1);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(194, 33);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Hệ Thống ";
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(1, 36);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(1);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(194, 33);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuanLyTaiKhoan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(1, 71);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(1);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(194, 33);
            this.btnQuanLyTaiKhoan.TabIndex = 2;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1, 106);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(194, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.reflectionLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnX
            // 
            this.btnX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnX.BackColor = System.Drawing.SystemColors.Control;
            this.btnX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnX.Location = new System.Drawing.Point(681, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(39, 35);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "X";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Location = new System.Drawing.Point(300, 6);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(130, 32);
            this.reflectionLabel1.TabIndex = 3;
            this.reflectionLabel1.Text = "<b><font size=\"+7\"><i>Finals</i><font color=\"#B02B2C\"> 40%\r\n</font></font></b>";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(200, 38);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(723, 495);
            this.reflectionImage1.TabIndex = 2;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(923, 533);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Main";
            this.panel1.ResumeLayout(false);
            this.pnlDanhMuc.ResumeLayout(false);
            this.pnlHeThong.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlHeThong;
        private DevComponents.DotNetBar.ButtonX btnHeThong;
        private DevComponents.DotNetBar.ButtonX btnDangXuat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btnQuanLyTaiKhoan;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.FlowLayoutPanel pnlDanhMuc;
        private DevComponents.DotNetBar.ButtonX btnDanhMuc;
        private DevComponents.DotNetBar.ButtonX btnQuanLySinhVien;
        private DevComponents.DotNetBar.ButtonX btnQuanLyLop;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX btnX;
    }
}