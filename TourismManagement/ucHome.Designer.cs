namespace TourismManagement
{
    partial class ucHome
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnAddCheckin = new System.Windows.Forms.Button();
            this.flpHome = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1369, 686);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(219, 103);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Location = new System.Drawing.Point(1369, 390);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(219, 110);
            this.btnAddBill.TabIndex = 17;
            this.btnAddBill.Text = "Pay Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnAddCheckin
            // 
            this.btnAddCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnAddCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCheckin.ForeColor = System.Drawing.Color.White;
            this.btnAddCheckin.Location = new System.Drawing.Point(1370, 96);
            this.btnAddCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCheckin.Name = "btnAddCheckin";
            this.btnAddCheckin.Size = new System.Drawing.Size(219, 103);
            this.btnAddCheckin.TabIndex = 16;
            this.btnAddCheckin.Text = "Create Rental Voucher";
            this.btnAddCheckin.UseVisualStyleBackColor = false;
            this.btnAddCheckin.Click += new System.EventHandler(this.btnAddCheckin_Click);
            // 
            // flpHome
            // 
            this.flpHome.Location = new System.Drawing.Point(3, 31);
            this.flpHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpHome.Name = "flpHome";
            this.flpHome.Size = new System.Drawing.Size(1344, 895);
            this.flpHome.TabIndex = 15;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.btnAddCheckin);
            this.Controls.Add(this.flpHome);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1616, 956);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnAddCheckin;
        private System.Windows.Forms.FlowLayoutPanel flpHome;
    }
}