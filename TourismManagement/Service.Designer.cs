
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
            this.dgvCapNhatDichVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtCapNhatDichVu = new System.Windows.Forms.TextBox();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapNhatDichVu
            // 
            this.dgvCapNhatDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.TenDichVu,
            this.Gia});
            this.dgvCapNhatDichVu.Location = new System.Drawing.Point(12, 53);
            this.dgvCapNhatDichVu.Name = "dgvCapNhatDichVu";
            this.dgvCapNhatDichVu.ReadOnly = true;
            this.dgvCapNhatDichVu.Size = new System.Drawing.Size(482, 447);
            this.dgvCapNhatDichVu.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVu.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(321, 3);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(244, 47);
            this.lblDichVu.TabIndex = 8;
            this.lblDichVu.Text = "Rental service";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(500, 96);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(292, 41);
            this.txtGia.TabIndex = 15;
            // 
            // txtCapNhatDichVu
            // 
            this.txtCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapNhatDichVu.Location = new System.Drawing.Point(500, 53);
            this.txtCapNhatDichVu.Multiline = true;
            this.txtCapNhatDichVu.Name = "txtCapNhatDichVu";
            this.txtCapNhatDichVu.Size = new System.Drawing.Size(292, 37);
            this.txtCapNhatDichVu.TabIndex = 16;
            // 
            // stt
            // 
            this.stt.FillWeight = 38.07107F;
            this.stt.HeaderText = "Number";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenDichVu
            // 
            this.TenDichVu.FillWeight = 130.9645F;
            this.TenDichVu.HeaderText = "Name Service";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.FillWeight = 130.9645F;
            this.Gia.HeaderText = "Service price";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(518, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(615, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(711, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = " Save";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(24, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 28);
            this.button4.TabIndex = 20;
            this.button4.Text = "Back";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtCapNhatDichVu);
            this.Name = "Service";
            this.Text = "Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapNhatDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtCapNhatDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}