
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
            this.lblChiTietTongTien = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvListOfServices = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChiTietPP = new System.Windows.Forms.Label();
            this.dgvRegisterService = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntoMoney = new System.Windows.Forms.TextBox();
            this.btnIntoMoney = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterService)).BeginInit();
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
            this.cmbNhanVien.Location = new System.Drawing.Point(988, 837);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(197, 24);
            this.cmbNhanVien.TabIndex = 142;
            // 
            // lblChiTietTongTien
            // 
            this.lblChiTietTongTien.AutoSize = true;
            this.lblChiTietTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTongTien.Location = new System.Drawing.Point(860, 799);
            this.lblChiTietTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiTietTongTien.Name = "lblChiTietTongTien";
            this.lblChiTietTongTien.Size = new System.Drawing.Size(16, 19);
            this.lblChiTietTongTien.TabIndex = 140;
            this.lblChiTietTongTien.Text = "0";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(860, 843);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(39, 19);
            this.lblNhanVien.TabIndex = 134;
            this.lblNhanVien.Text = "Staff";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(747, 799);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(89, 19);
            this.lblTongTien.TabIndex = 133;
            this.lblTongTien.Text = "Into Money:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(160, 799);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(72, 19);
            this.lblKhachHang.TabIndex = 132;
            this.lblKhachHang.Text = "Customer";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(954, 236);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 35);
            this.btnPrint.TabIndex = 131;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(955, 126);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 44);
            this.btnDelete.TabIndex = 128;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvListOfServices
            // 
            this.dgvListOfServices.AllowDrop = true;
            this.dgvListOfServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOfServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListOfServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfServices.Location = new System.Drawing.Point(13, 71);
            this.dgvListOfServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListOfServices.Name = "dgvListOfServices";
            this.dgvListOfServices.RowHeadersVisible = false;
            this.dgvListOfServices.RowHeadersWidth = 51;
            this.dgvListOfServices.RowTemplate.Height = 24;
            this.dgvListOfServices.Size = new System.Drawing.Size(615, 247);
            this.dgvListOfServices.TabIndex = 125;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(83, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 44);
            this.btnBack.TabIndex = 103;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblChiTietPP
            // 
            this.lblChiTietPP.AutoSize = true;
            this.lblChiTietPP.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPP.Location = new System.Drawing.Point(437, 6);
            this.lblChiTietPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiTietPP.Name = "lblChiTietPP";
            this.lblChiTietPP.Size = new System.Drawing.Size(138, 32);
            this.lblChiTietPP.TabIndex = 104;
            this.lblChiTietPP.Text = "SERVICE";
            // 
            // dgvRegisterService
            // 
            this.dgvRegisterService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRegisterService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterService.Location = new System.Drawing.Point(13, 347);
            this.dgvRegisterService.Name = "dgvRegisterService";
            this.dgvRegisterService.RowHeadersWidth = 51;
            this.dgvRegisterService.RowTemplate.Height = 24;
            this.dgvRegisterService.Size = new System.Drawing.Size(721, 265);
            this.dgvRegisterService.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 144;
            this.label1.Text = "Service Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 145;
            this.label2.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 146;
            this.label3.Text = "Quanity";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(789, 87);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(126, 22);
            this.txtServiceName.TabIndex = 147;
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(789, 134);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(126, 22);
            this.txtQuanity.TabIndex = 148;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(789, 185);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(126, 22);
            this.txtUnitPrice.TabIndex = 149;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(955, 87);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 30);
            this.btnAdd.TabIndex = 150;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 151;
            this.label4.Text = "Into Money";
            // 
            // txtIntoMoney
            // 
            this.txtIntoMoney.Location = new System.Drawing.Point(789, 243);
            this.txtIntoMoney.Name = "txtIntoMoney";
            this.txtIntoMoney.ReadOnly = true;
            this.txtIntoMoney.Size = new System.Drawing.Size(126, 22);
            this.txtIntoMoney.TabIndex = 152;
            // 
            // btnIntoMoney
            // 
            this.btnIntoMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIntoMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIntoMoney.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntoMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnIntoMoney.Image")));
            this.btnIntoMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntoMoney.Location = new System.Drawing.Point(955, 178);
            this.btnIntoMoney.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntoMoney.Name = "btnIntoMoney";
            this.btnIntoMoney.Size = new System.Drawing.Size(142, 35);
            this.btnIntoMoney.TabIndex = 153;
            this.btnIntoMoney.Text = "Into Money";
            this.btnIntoMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIntoMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIntoMoney.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 154;
            this.label5.Text = "Total Money";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(816, 441);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(172, 36);
            this.txtTotalMoney.TabIndex = 155;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 638);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIntoMoney);
            this.Controls.Add(this.txtIntoMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegisterService);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lblChiTietTongTien);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvListOfServices);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChiTietPP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Service";
            this.Text = "Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblChiTietTongTien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvListOfServices;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChiTietPP;
        private System.Windows.Forms.DataGridView dgvRegisterService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntoMoney;
        private System.Windows.Forms.Button btnIntoMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMoney;
    }
}