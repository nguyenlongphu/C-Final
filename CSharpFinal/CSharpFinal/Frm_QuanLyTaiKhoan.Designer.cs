namespace CSharpFinal
{
    partial class Frm_QuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ckbNhoMatKhau = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dgvUsers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhoMatKhau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.Teal;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(0, 0);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(9);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(1241, 113);
            this.textBoxX1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(515, 285);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "labelX1";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Teal;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelX2.Location = new System.Drawing.Point(410, 20);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(474, 63);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Quản lí tài khoản";
            // 
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnRefresh,
            this.btnThoat});
            this.bar1.Location = new System.Drawing.Point(0, 113);
            this.bar1.Margin = new System.Windows.Forms.Padding(2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1241, 49);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            this.bar1.ItemClick += new System.EventHandler(this.bar1_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.FontBold = true;
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.FontBold = true;
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FontBold = true;
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FontBold = true;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FontBold = true;
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(29, 176);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(129, 51);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Tài khoản";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // txtTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(162, 182);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(234, 41);
            this.txtTaiKhoan.TabIndex = 6;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(611, 182);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(234, 41);
            this.txtMatKhau.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(456, 176);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(109, 51);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Mật khẩu";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(928, 176);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(177, 51);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Nhớ mật khẩu";
            // 
            // ckbNhoMatKhau
            // 
            this.ckbNhoMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbNhoMatKhau.Location = new System.Drawing.Point(1109, 182);
            this.ckbNhoMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNhoMatKhau.Name = "ckbNhoMatKhau";
            this.ckbNhoMatKhau.Size = new System.Drawing.Size(83, 46);
            this.ckbNhoMatKhau.TabIndex = 10;
            this.ckbNhoMatKhau.Text = "checkBoxX1";
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaiKhoan,
            this.colMatKhau,
            this.colNhoMatKhau});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 261);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1241, 407);
            this.dgvUsers.TabIndex = 11;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTaiKhoan.DataPropertyName = "taiKhoan";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTaiKhoan.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTaiKhoan.FillWeight = 80F;
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.MinimumWidth = 6;
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            // 
            // colMatKhau
            // 
            this.colMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMatKhau.DataPropertyName = "matKhau";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMatKhau.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMatKhau.FillWeight = 80F;
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.MinimumWidth = 6;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            // 
            // colNhoMatKhau
            // 
            this.colNhoMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhoMatKhau.DataPropertyName = "nhoMatKhau";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.colNhoMatKhau.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNhoMatKhau.FillWeight = 60F;
            this.colNhoMatKhau.HeaderText = "Nhớ mật khẩu";
            this.colNhoMatKhau.MinimumWidth = 6;
            this.colNhoMatKhau.Name = "colNhoMatKhau";
            this.colNhoMatKhau.ReadOnly = true;
            // 
            // Frm_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1241, 668);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.ckbNhoMatKhau);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Frm_QuanLyTaiKhoan";
            this.Text = "Frm_QuanLyTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQLTK_Closing);
            this.Load += new System.EventHandler(this.Frm_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbNhoMatKhau;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNhoMatKhau;
    }
}