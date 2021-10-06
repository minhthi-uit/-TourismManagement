
namespace TourismManagement
{
    partial class Employee_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_manager));
            this.button4 = new System.Windows.Forms.Button();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.cdrQLNV = new System.Windows.Forms.MonthCalendar();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(35, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 28);
            this.button4.TabIndex = 22;
            this.button4.Text = "Back";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlQLNV.Controls.Add(this.label2);
            this.pnlQLNV.Controls.Add(this.dgvLichLamViec);
            this.pnlQLNV.Location = new System.Drawing.Point(186, 66);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(749, 447);
            this.pnlQLNV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee work schedule";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenNV,
            this.CaTruc,
            this.Ngay,
            this.id});
            this.dgvLichLamViec.Location = new System.Drawing.Point(3, 77);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.Size = new System.Drawing.Size(743, 401);
            this.dgvLichLamViec.TabIndex = 0;
            // 
            // cdrQLNV
            // 
            this.cdrQLNV.Location = new System.Drawing.Point(12, 229);
            this.cdrQLNV.Name = "cdrQLNV";
            this.cdrQLNV.TabIndex = 25;
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(384, 9);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(274, 39);
            this.lblQuanLyNhanVien.TabIndex = 24;
            this.lblQuanLyNhanVien.Text = "Employee manager";
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(-124, -29);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(94, 32);
            this.btnTroVeCuaQLNV.TabIndex = 27;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 161);
            this.panel2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update work schedule";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update employee information";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(14, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 122);
            this.panel1.TabIndex = 29;
            // 
            // stt
            // 
            this.stt.HeaderText = "Number";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Employee Name";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // CaTruc
            // 
            this.CaTruc.HeaderText = "Shift";
            this.CaTruc.Name = "CaTruc";
            this.CaTruc.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Day";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Employee_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.cdrQLNV);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_manager";
            this.Text = "Employee_manager";
            this.pnlQLNV.ResumeLayout(false);
            this.pnlQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.MonthCalendar cdrQLNV;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}