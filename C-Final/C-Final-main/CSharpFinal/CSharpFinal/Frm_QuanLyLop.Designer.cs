namespace CSharpFinal
{
    partial class Frm_QuanLyLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.radMalop = new System.Windows.Forms.RadioButton();
            this.radThuockhoa = new System.Windows.Forms.RadioButton();
            this.radTenlop = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtThuocKhoaa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMalopp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenlopp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewTimkiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dataGridViewLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColTenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThuocKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtMalop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtThuocKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenlop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Lbtenlop = new DevComponents.DotNetBar.LabelX();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimkiem)).BeginInit();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1296, 611);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.radMalop);
            this.tabControlPanel2.Controls.Add(this.radThuockhoa);
            this.tabControlPanel2.Controls.Add(this.radTenlop);
            this.tabControlPanel2.Controls.Add(this.btnTimkiem);
            this.tabControlPanel2.Controls.Add(this.txtThuocKhoaa);
            this.tabControlPanel2.Controls.Add(this.txtMalopp);
            this.tabControlPanel2.Controls.Add(this.txtTenlopp);
            this.tabControlPanel2.Controls.Add(this.dataGridViewTimkiem);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1296, 582);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // radMalop
            // 
            this.radMalop.AutoSize = true;
            this.radMalop.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMalop.Location = new System.Drawing.Point(43, 153);
            this.radMalop.Name = "radMalop";
            this.radMalop.Size = new System.Drawing.Size(113, 29);
            this.radMalop.TabIndex = 20;
            this.radMalop.TabStop = true;
            this.radMalop.Text = "Mã Lớp";
            this.radMalop.UseVisualStyleBackColor = true;
            // 
            // radThuockhoa
            // 
            this.radThuockhoa.AutoSize = true;
            this.radThuockhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThuockhoa.Location = new System.Drawing.Point(43, 260);
            this.radThuockhoa.Name = "radThuockhoa";
            this.radThuockhoa.Size = new System.Drawing.Size(155, 29);
            this.radThuockhoa.TabIndex = 19;
            this.radThuockhoa.TabStop = true;
            this.radThuockhoa.Text = "Thuộc Khoa";
            this.radThuockhoa.UseVisualStyleBackColor = true;
            // 
            // radTenlop
            // 
            this.radTenlop.AutoSize = true;
            this.radTenlop.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenlop.Location = new System.Drawing.Point(43, 54);
            this.radTenlop.Name = "radTenlop";
            this.radTenlop.Size = new System.Drawing.Size(125, 29);
            this.radTenlop.TabIndex = 18;
            this.radTenlop.TabStop = true;
            this.radTenlop.Text = "Tên Lớp ";
            this.radTenlop.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Coral;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimkiem.Location = new System.Drawing.Point(667, 138);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(185, 58);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "TÌM KIẾM ";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtThuocKhoaa
            // 
            // 
            // 
            // 
            this.txtThuocKhoaa.Border.Class = "TextBoxBorder";
            this.txtThuocKhoaa.Location = new System.Drawing.Point(228, 264);
            this.txtThuocKhoaa.Name = "txtThuocKhoaa";
            this.txtThuocKhoaa.Size = new System.Drawing.Size(308, 26);
            this.txtThuocKhoaa.TabIndex = 17;
            // 
            // txtMalopp
            // 
            // 
            // 
            // 
            this.txtMalopp.Border.Class = "TextBoxBorder";
            this.txtMalopp.Location = new System.Drawing.Point(228, 156);
            this.txtMalopp.Name = "txtMalopp";
            this.txtMalopp.Size = new System.Drawing.Size(308, 26);
            this.txtMalopp.TabIndex = 16;
            // 
            // txtTenlopp
            // 
            // 
            // 
            // 
            this.txtTenlopp.Border.Class = "TextBoxBorder";
            this.txtTenlopp.Location = new System.Drawing.Point(228, 58);
            this.txtTenlopp.Name = "txtTenlopp";
            this.txtTenlopp.Size = new System.Drawing.Size(308, 26);
            this.txtTenlopp.TabIndex = 15;
            // 
            // dataGridViewTimkiem
            // 
            this.dataGridViewTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTimkiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTimkiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewTimkiem.Location = new System.Drawing.Point(0, 330);
            this.dataGridViewTimkiem.Name = "dataGridViewTimkiem";
            this.dataGridViewTimkiem.RowHeadersWidth = 62;
            this.dataGridViewTimkiem.RowTemplate.Height = 28;
            this.dataGridViewTimkiem.Size = new System.Drawing.Size(1296, 249);
            this.dataGridViewTimkiem.TabIndex = 2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "TÌM KIẾM ";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.dataGridViewLop);
            this.tabControlPanel1.Controls.Add(this.panelEx1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1296, 582);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenlop,
            this.ColMaLop,
            this.ColThuocKhoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewLop.Location = new System.Drawing.Point(3, 322);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.RowHeadersWidth = 62;
            this.dataGridViewLop.RowTemplate.Height = 28;
            this.dataGridViewLop.Size = new System.Drawing.Size(1296, 249);
            this.dataGridViewLop.TabIndex = 1;
            this.dataGridViewLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLop_CellClick);
            // 
            // ColTenlop
            // 
            this.ColTenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenlop.DataPropertyName = "TenLop";
            this.ColTenlop.HeaderText = "Tên Lớp ";
            this.ColTenlop.MinimumWidth = 8;
            this.ColTenlop.Name = "ColTenlop";
            // 
            // ColMaLop
            // 
            this.ColMaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaLop.DataPropertyName = "MaLop";
            this.ColMaLop.HeaderText = "MaLop";
            this.ColMaLop.MinimumWidth = 8;
            this.ColMaLop.Name = "ColMaLop";
            // 
            // ColThuocKhoa
            // 
            this.ColThuocKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColThuocKhoa.DataPropertyName = "ThuocKhoa";
            this.ColThuocKhoa.HeaderText = "Thuộc Khoa";
            this.ColThuocKhoa.MinimumWidth = 8;
            this.ColThuocKhoa.Name = "ColThuocKhoa";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.txtMalop);
            this.panelEx1.Controls.Add(this.txtThuocKhoa);
            this.panelEx1.Controls.Add(this.txtTenlop);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.Lbtenlop);
            this.panelEx1.Controls.Add(this.btnXoa);
            this.panelEx1.Controls.Add(this.btnThoát);
            this.panelEx1.Controls.Add(this.btnSua);
            this.panelEx1.Controls.Add(this.btnThem);
            this.panelEx1.Location = new System.Drawing.Point(4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1292, 312);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // txtMalop
            // 
            // 
            // 
            // 
            this.txtMalop.Border.Class = "TextBoxBorder";
            this.txtMalop.Location = new System.Drawing.Point(170, 143);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(308, 26);
            this.txtMalop.TabIndex = 16;
            // 
            // txtThuocKhoa
            // 
            // 
            // 
            // 
            this.txtThuocKhoa.Border.Class = "TextBoxBorder";
            this.txtThuocKhoa.Location = new System.Drawing.Point(232, 233);
            this.txtThuocKhoa.Name = "txtThuocKhoa";
            this.txtThuocKhoa.Size = new System.Drawing.Size(308, 26);
            this.txtThuocKhoa.TabIndex = 15;
            // 
            // txtTenlop
            // 
            // 
            // 
            // 
            this.txtTenlop.Border.Class = "TextBoxBorder";
            this.txtTenlop.Location = new System.Drawing.Point(170, 40);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(308, 26);
            this.txtTenlop.TabIndex = 14;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(28, 112);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(119, 87);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "MÃ LỚP ";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(28, 205);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(181, 71);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "THUỘC KHOA";
            // 
            // Lbtenlop
            // 
            this.Lbtenlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtenlop.ForeColor = System.Drawing.Color.White;
            this.Lbtenlop.Location = new System.Drawing.Point(28, 19);
            this.Lbtenlop.Name = "Lbtenlop";
            this.Lbtenlop.Size = new System.Drawing.Size(119, 71);
            this.Lbtenlop.TabIndex = 11;
            this.Lbtenlop.Text = "TÊN LỚP ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Yellow;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(987, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(185, 58);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.BackColor = System.Drawing.Color.Red;
            this.btnThoát.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoát.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoát.Location = new System.Drawing.Point(987, 174);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(185, 58);
            this.btnThoát.TabIndex = 9;
            this.btnThoát.Text = "THOÁT";
            this.btnThoát.UseVisualStyleBackColor = false;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(700, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(185, 58);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "SỬA ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Coral;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(700, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(185, 58);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "THÔNG TIN LỚP ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenLop";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Lớp ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ThuocKhoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Thuộc Khoa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Frm_QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 624);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_QuanLyLop";
            this.Text = "Frm_QuanLyLop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QuanLyLop_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimkiem)).EndInit();
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewLop;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenlop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX Lbtenlop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMalop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThuocKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThuocKhoa;
        private System.Windows.Forms.Button btnTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThuocKhoaa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMalopp;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenlopp;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewTimkiem;
        private System.Windows.Forms.RadioButton radMalop;
        private System.Windows.Forms.RadioButton radThuockhoa;
        private System.Windows.Forms.RadioButton radTenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}