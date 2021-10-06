
namespace TourismManagement
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblChiTietTongTien = new System.Windows.Forms.Label();
            this.cmbSoPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.cmbTenBooking = new System.Windows.Forms.ComboBox();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnInCuaCTPP = new System.Windows.Forms.Button();
            this.btnSuaCuaCTPP = new System.Windows.Forms.Button();
            this.btnLuuCuaCTPP = new System.Windows.Forms.Button();
            this.btnXoaCuaCTPP = new System.Windows.Forms.Button();
            this.txtChiTietSoKhach = new System.Windows.Forms.TextBox();
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            this.btnThemCuaCTPP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.txtChiTietQuocTich = new System.Windows.Forms.TextBox();
            this.txtChiTietTenKhach = new System.Windows.Forms.TextBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblChiTietThanhTien = new System.Windows.Forms.Label();
            this.lblChiTietQuocTich = new System.Windows.Forms.Label();
            this.lblChiTietTenKhach = new System.Windows.Forms.Label();
            this.lblChiTietSoPhong = new System.Windows.Forms.Label();
            this.lblChiTietNgayVao = new System.Windows.Forms.Label();
            this.lblChiTietSoKhach = new System.Windows.Forms.Label();
            this.lblChiTietTenBooking = new System.Windows.Forms.Label();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            this.lblChiTietLoaiPhong = new System.Windows.Forms.Label();
            this.lblChiTietPP = new System.Windows.Forms.Label();
            this.lblChiTietNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblChiTietSoDem = new System.Windows.Forms.Label();
            this.txtChiTietSoDem = new System.Windows.Forms.TextBox();
            this.lblChiTietGiaPhong = new System.Windows.Forms.Label();
            this.txtChiTietGiaPhong = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Items.AddRange(new object[] {
            "Standard",
            "Superior",
            "Deluxe"});
            this.cmbNhanVien.Location = new System.Drawing.Point(741, 680);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(149, 21);
            this.cmbNhanVien.TabIndex = 142;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(617, 242);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(14, 16);
            this.lblThanhTien.TabIndex = 141;
            this.lblThanhTien.Text = "0";
            // 
            // lblChiTietTongTien
            // 
            this.lblChiTietTongTien.AutoSize = true;
            this.lblChiTietTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTongTien.Location = new System.Drawing.Point(645, 649);
            this.lblChiTietTongTien.Name = "lblChiTietTongTien";
            this.lblChiTietTongTien.Size = new System.Drawing.Size(14, 16);
            this.lblChiTietTongTien.TabIndex = 140;
            this.lblChiTietTongTien.Text = "0";
            // 
            // cmbSoPhong
            // 
            this.cmbSoPhong.FormattingEnabled = true;
            this.cmbSoPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSoPhong.Location = new System.Drawing.Point(405, 61);
            this.cmbSoPhong.Name = "cmbSoPhong";
            this.cmbSoPhong.Size = new System.Drawing.Size(168, 21);
            this.cmbSoPhong.TabIndex = 139;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(114, 192);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(149, 20);
            this.dtpNgayDen.TabIndex = 137;
            // 
            // cmbTenBooking
            // 
            this.cmbTenBooking.FormattingEnabled = true;
            this.cmbTenBooking.Items.AddRange(new object[] {
            "Booking.com",
            "Agoda",
            "Travel Loka",
            "AirBnB",
            "Đan Việt",
            "My Tour",
            "Expedia",
            "Khách Tự Đến",
            "Khách Đối Tác"});
            this.cmbTenBooking.Location = new System.Drawing.Point(114, 99);
            this.cmbTenBooking.Name = "cmbTenBooking";
            this.cmbTenBooking.Size = new System.Drawing.Size(149, 21);
            this.cmbTenBooking.TabIndex = 136;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(114, 56);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(149, 21);
            this.cmbLoaiPhong.TabIndex = 135;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(645, 685);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(32, 16);
            this.lblNhanVien.TabIndex = 134;
            this.lblNhanVien.Text = "Staff";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(560, 649);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(68, 16);
            this.lblTongTien.TabIndex = 133;
            this.lblTongTien.Text = "Into Money:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(120, 649);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(56, 16);
            this.lblKhachHang.TabIndex = 132;
            this.lblKhachHang.Text = "Customer";
            // 
            // btnInCuaCTPP
            // 
            this.btnInCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnInCuaCTPP.Image")));
            this.btnInCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCuaCTPP.Location = new System.Drawing.Point(806, 61);
            this.btnInCuaCTPP.Name = "btnInCuaCTPP";
            this.btnInCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnInCuaCTPP.TabIndex = 131;
            this.btnInCuaCTPP.Text = "Print";
            this.btnInCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // btnSuaCuaCTPP
            // 
            this.btnSuaCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCuaCTPP.Image")));
            this.btnSuaCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCuaCTPP.Location = new System.Drawing.Point(876, 242);
            this.btnSuaCuaCTPP.Name = "btnSuaCuaCTPP";
            this.btnSuaCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnSuaCuaCTPP.TabIndex = 130;
            this.btnSuaCuaCTPP.Text = "Review";
            this.btnSuaCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // btnLuuCuaCTPP
            // 
            this.btnLuuCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCuaCTPP.Image")));
            this.btnLuuCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCuaCTPP.Location = new System.Drawing.Point(786, 240);
            this.btnLuuCuaCTPP.Name = "btnLuuCuaCTPP";
            this.btnLuuCuaCTPP.Size = new System.Drawing.Size(84, 39);
            this.btnLuuCuaCTPP.TabIndex = 129;
            this.btnLuuCuaCTPP.Text = "Save";
            this.btnLuuCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // btnXoaCuaCTPP
            // 
            this.btnXoaCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCuaCTPP.Image")));
            this.btnXoaCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCuaCTPP.Location = new System.Drawing.Point(698, 61);
            this.btnXoaCuaCTPP.Name = "btnXoaCuaCTPP";
            this.btnXoaCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnXoaCuaCTPP.TabIndex = 128;
            this.btnXoaCuaCTPP.Text = "Delete";
            this.btnXoaCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // txtChiTietSoKhach
            // 
            this.txtChiTietSoKhach.Location = new System.Drawing.Point(114, 147);
            this.txtChiTietSoKhach.Name = "txtChiTietSoKhach";
            this.txtChiTietSoKhach.Size = new System.Drawing.Size(149, 20);
            this.txtChiTietSoKhach.TabIndex = 126;
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.AllowDrop = true;
            this.dgvChiTietDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.Column3,
            this.Column5,
            this.Column6,
            this.id});
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(62, 333);
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.RowHeadersVisible = false;
            this.dgvChiTietDichVu.RowTemplate.Height = 24;
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(707, 278);
            this.dgvChiTietDichVu.TabIndex = 125;
            // 
            // btnThemCuaCTPP
            // 
            this.btnThemCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCuaCTPP.Image")));
            this.btnThemCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCuaCTPP.Location = new System.Drawing.Point(592, 61);
            this.btnThemCuaCTPP.Name = "btnThemCuaCTPP";
            this.btnThemCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnThemCuaCTPP.TabIndex = 124;
            this.btnThemCuaCTPP.Text = "Add";
            this.btnThemCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCuaCTPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(449, 307);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(56, 20);
            this.txtSoLuong.TabIndex = 123;
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(192, 302);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(121, 21);
            this.cmbTenDichVu.TabIndex = 122;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(358, 307);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(51, 16);
            this.lblSoLuong.TabIndex = 121;
            this.lblSoLuong.Text = "Quantity";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDichVu.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.Location = new System.Drawing.Point(111, 302);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(74, 16);
            this.lblTenDichVu.TabIndex = 120;
            this.lblTenDichVu.Text = "Service name";
            // 
            // txtChiTietQuocTich
            // 
            this.txtChiTietQuocTich.Location = new System.Drawing.Point(405, 141);
            this.txtChiTietQuocTich.Name = "txtChiTietQuocTich";
            this.txtChiTietQuocTich.Size = new System.Drawing.Size(168, 20);
            this.txtChiTietQuocTich.TabIndex = 118;
            // 
            // txtChiTietTenKhach
            // 
            this.txtChiTietTenKhach.Location = new System.Drawing.Point(405, 99);
            this.txtChiTietTenKhach.Name = "txtChiTietTenKhach";
            this.txtChiTietTenKhach.Size = new System.Drawing.Size(168, 20);
            this.txtChiTietTenKhach.TabIndex = 117;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(373, 274);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(93, 25);
            this.lblDichVu.TabIndex = 116;
            this.lblDichVu.Text = "SERVICE";
            // 
            // lblChiTietThanhTien
            // 
            this.lblChiTietThanhTien.AutoSize = true;
            this.lblChiTietThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietThanhTien.Location = new System.Drawing.Point(526, 240);
            this.lblChiTietThanhTien.Name = "lblChiTietThanhTien";
            this.lblChiTietThanhTien.Size = new System.Drawing.Size(63, 16);
            this.lblChiTietThanhTien.TabIndex = 115;
            this.lblChiTietThanhTien.Text = "Into money";
            // 
            // lblChiTietQuocTich
            // 
            this.lblChiTietQuocTich.AutoSize = true;
            this.lblChiTietQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietQuocTich.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietQuocTich.Location = new System.Drawing.Point(314, 149);
            this.lblChiTietQuocTich.Name = "lblChiTietQuocTich";
            this.lblChiTietQuocTich.Size = new System.Drawing.Size(63, 16);
            this.lblChiTietQuocTich.TabIndex = 112;
            this.lblChiTietQuocTich.Text = "Nationality";
            // 
            // lblChiTietTenKhach
            // 
            this.lblChiTietTenKhach.AutoSize = true;
            this.lblChiTietTenKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenKhach.Location = new System.Drawing.Point(313, 104);
            this.lblChiTietTenKhach.Name = "lblChiTietTenKhach";
            this.lblChiTietTenKhach.Size = new System.Drawing.Size(89, 16);
            this.lblChiTietTenKhach.TabIndex = 111;
            this.lblChiTietTenKhach.Text = "Customer Name";
            // 
            // lblChiTietSoPhong
            // 
            this.lblChiTietSoPhong.AutoSize = true;
            this.lblChiTietSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoPhong.Location = new System.Drawing.Point(313, 61);
            this.lblChiTietSoPhong.Name = "lblChiTietSoPhong";
            this.lblChiTietSoPhong.Size = new System.Drawing.Size(80, 16);
            this.lblChiTietSoPhong.TabIndex = 110;
            this.lblChiTietSoPhong.Text = "Room Number";
            // 
            // lblChiTietNgayVao
            // 
            this.lblChiTietNgayVao.AutoSize = true;
            this.lblChiTietNgayVao.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayVao.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayVao.Location = new System.Drawing.Point(12, 192);
            this.lblChiTietNgayVao.Name = "lblChiTietNgayVao";
            this.lblChiTietNgayVao.Size = new System.Drawing.Size(40, 16);
            this.lblChiTietNgayVao.TabIndex = 108;
            this.lblChiTietNgayVao.Text = "Day in";
            // 
            // lblChiTietSoKhach
            // 
            this.lblChiTietSoKhach.AutoSize = true;
            this.lblChiTietSoKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoKhach.Location = new System.Drawing.Point(12, 145);
            this.lblChiTietSoKhach.Name = "lblChiTietSoKhach";
            this.lblChiTietSoKhach.Size = new System.Drawing.Size(99, 16);
            this.lblChiTietSoKhach.TabIndex = 107;
            this.lblChiTietSoKhach.Text = "Customer Number";
            // 
            // lblChiTietTenBooking
            // 
            this.lblChiTietTenBooking.AutoSize = true;
            this.lblChiTietTenBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenBooking.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenBooking.Location = new System.Drawing.Point(12, 97);
            this.lblChiTietTenBooking.Name = "lblChiTietTenBooking";
            this.lblChiTietTenBooking.Size = new System.Drawing.Size(81, 16);
            this.lblChiTietTenBooking.TabIndex = 106;
            this.lblChiTietTenBooking.Text = "Name booking";
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTroVeCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCTPP.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVeCuaCTPP.Image")));
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(62, 5);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(96, 36);
            this.btnTroVeCuaCTPP.TabIndex = 103;
            this.btnTroVeCuaCTPP.Text = "Back";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = false;
            // 
            // lblChiTietLoaiPhong
            // 
            this.lblChiTietLoaiPhong.AutoSize = true;
            this.lblChiTietLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietLoaiPhong.Location = new System.Drawing.Point(12, 56);
            this.lblChiTietLoaiPhong.Name = "lblChiTietLoaiPhong";
            this.lblChiTietLoaiPhong.Size = new System.Drawing.Size(61, 16);
            this.lblChiTietLoaiPhong.TabIndex = 105;
            this.lblChiTietLoaiPhong.Text = "Room type";
            // 
            // lblChiTietPP
            // 
            this.lblChiTietPP.AutoSize = true;
            this.lblChiTietPP.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPP.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPP.Location = new System.Drawing.Point(328, 5);
            this.lblChiTietPP.Name = "lblChiTietPP";
            this.lblChiTietPP.Size = new System.Drawing.Size(201, 29);
            this.lblChiTietPP.TabIndex = 104;
            this.lblChiTietPP.Text = "BILLING DETAILS";
            // 
            // lblChiTietNgayDi
            // 
            this.lblChiTietNgayDi.AutoSize = true;
            this.lblChiTietNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayDi.Location = new System.Drawing.Point(314, 192);
            this.lblChiTietNgayDi.Name = "lblChiTietNgayDi";
            this.lblChiTietNgayDi.Size = new System.Drawing.Size(47, 16);
            this.lblChiTietNgayDi.TabIndex = 113;
            this.lblChiTietNgayDi.Text = "Day out";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(405, 188);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(169, 20);
            this.dtpNgayDi.TabIndex = 138;
            // 
            // lblChiTietSoDem
            // 
            this.lblChiTietSoDem.AutoSize = true;
            this.lblChiTietSoDem.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoDem.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoDem.Location = new System.Drawing.Point(313, 238);
            this.lblChiTietSoDem.Name = "lblChiTietSoDem";
            this.lblChiTietSoDem.Size = new System.Drawing.Size(94, 16);
            this.lblChiTietSoDem.TabIndex = 114;
            this.lblChiTietSoDem.Text = "Number of nights";
            // 
            // txtChiTietSoDem
            // 
            this.txtChiTietSoDem.Location = new System.Drawing.Point(428, 236);
            this.txtChiTietSoDem.Name = "txtChiTietSoDem";
            this.txtChiTietSoDem.Size = new System.Drawing.Size(77, 20);
            this.txtChiTietSoDem.TabIndex = 119;
            // 
            // lblChiTietGiaPhong
            // 
            this.lblChiTietGiaPhong.AutoSize = true;
            this.lblChiTietGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietGiaPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietGiaPhong.Location = new System.Drawing.Point(12, 234);
            this.lblChiTietGiaPhong.Name = "lblChiTietGiaPhong";
            this.lblChiTietGiaPhong.Size = new System.Drawing.Size(69, 16);
            this.lblChiTietGiaPhong.TabIndex = 109;
            this.lblChiTietGiaPhong.Text = "Room Rates";
            // 
            // txtChiTietGiaPhong
            // 
            this.txtChiTietGiaPhong.Location = new System.Drawing.Point(114, 234);
            this.txtChiTietGiaPhong.Name = "txtChiTietGiaPhong";
            this.txtChiTietGiaPhong.Size = new System.Drawing.Size(149, 20);
            this.txtChiTietGiaPhong.TabIndex = 127;
            // 
            // STT
            // 
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "Number";
            this.STT.Name = "STT";
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "Service Name";
            this.TenDV.Name = "TenDV";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rates";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Into money";
            this.Column6.Name = "Column6";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 718);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblChiTietTongTien);
            this.Controls.Add(this.cmbSoPhong);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.cmbTenBooking);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnInCuaCTPP);
            this.Controls.Add(this.btnSuaCuaCTPP);
            this.Controls.Add(this.btnLuuCuaCTPP);
            this.Controls.Add(this.btnXoaCuaCTPP);
            this.Controls.Add(this.txtChiTietGiaPhong);
            this.Controls.Add(this.txtChiTietSoKhach);
            this.Controls.Add(this.dgvChiTietDichVu);
            this.Controls.Add(this.btnThemCuaCTPP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbTenDichVu);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.txtChiTietSoDem);
            this.Controls.Add(this.txtChiTietQuocTich);
            this.Controls.Add(this.txtChiTietTenKhach);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblChiTietThanhTien);
            this.Controls.Add(this.lblChiTietSoDem);
            this.Controls.Add(this.lblChiTietNgayDi);
            this.Controls.Add(this.lblChiTietQuocTich);
            this.Controls.Add(this.lblChiTietTenKhach);
            this.Controls.Add(this.lblChiTietSoPhong);
            this.Controls.Add(this.lblChiTietGiaPhong);
            this.Controls.Add(this.lblChiTietNgayVao);
            this.Controls.Add(this.lblChiTietSoKhach);
            this.Controls.Add(this.lblChiTietTenBooking);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Controls.Add(this.lblChiTietLoaiPhong);
            this.Controls.Add(this.lblChiTietPP);
            this.Name = "Service";
            this.Text = "Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblChiTietTongTien;
        private System.Windows.Forms.ComboBox cmbSoPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.ComboBox cmbTenBooking;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnInCuaCTPP;
        private System.Windows.Forms.Button btnSuaCuaCTPP;
        private System.Windows.Forms.Button btnLuuCuaCTPP;
        private System.Windows.Forms.Button btnXoaCuaCTPP;
        private System.Windows.Forms.TextBox txtChiTietSoKhach;
        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
        private System.Windows.Forms.Button btnThemCuaCTPP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.TextBox txtChiTietQuocTich;
        private System.Windows.Forms.TextBox txtChiTietTenKhach;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblChiTietThanhTien;
        private System.Windows.Forms.Label lblChiTietQuocTich;
        private System.Windows.Forms.Label lblChiTietTenKhach;
        private System.Windows.Forms.Label lblChiTietSoPhong;
        private System.Windows.Forms.Label lblChiTietNgayVao;
        private System.Windows.Forms.Label lblChiTietSoKhach;
        private System.Windows.Forms.Label lblChiTietTenBooking;
        private System.Windows.Forms.Button btnTroVeCuaCTPP;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.Label lblChiTietPP;
        private System.Windows.Forms.Label lblChiTietNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblChiTietSoDem;
        private System.Windows.Forms.TextBox txtChiTietSoDem;
        private System.Windows.Forms.Label lblChiTietGiaPhong;
        private System.Windows.Forms.TextBox txtChiTietGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}