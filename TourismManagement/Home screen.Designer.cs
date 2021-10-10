
namespace TourismManagement
{
    partial class Home_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_screen));
            this.lbdulich = new System.Windows.Forms.Label();
            this.msManhinhchinh = new System.Windows.Forms.MenuStrip();
            this.EmployeeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cdrMHC = new System.Windows.Forms.MonthCalendar();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentApartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payApartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useTheServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentApartmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payApartmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.useTheServiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msManhinhchinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdulich
            // 
            this.lbdulich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbdulich.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdulich.ForeColor = System.Drawing.Color.Maroon;
            this.lbdulich.Location = new System.Drawing.Point(0, 0);
            this.lbdulich.Name = "lbdulich";
            this.lbdulich.Size = new System.Drawing.Size(1191, 60);
            this.lbdulich.TabIndex = 13;
            this.lbdulich.Text = "Sunflower International Village";
            this.lbdulich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbdulich.Click += new System.EventHandler(this.lblKhachSan_Click);
            // 
            // msManhinhchinh
            // 
            this.msManhinhchinh.BackColor = System.Drawing.Color.LightBlue;
            this.msManhinhchinh.Dock = System.Windows.Forms.DockStyle.None;
            this.msManhinhchinh.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msManhinhchinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msManhinhchinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeMenu,
            this.ManageMenu,
            this.FunctionMenu,
            this.ContactMenu,
            this.SalesReportMenu});
            this.msManhinhchinh.Location = new System.Drawing.Point(9, 60);
            this.msManhinhchinh.Name = "msManhinhchinh";
            this.msManhinhchinh.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msManhinhchinh.Size = new System.Drawing.Size(794, 39);
            this.msManhinhchinh.TabIndex = 14;
            this.msManhinhchinh.Text = "menuStrip1";
            // 
            // EmployeeMenu
            // 
            this.EmployeeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManagementToolStripMenuItem,
            this.apartmentManagementToolStripMenuItem});
            this.EmployeeMenu.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeMenu.Name = "EmployeeMenu";
            this.EmployeeMenu.Size = new System.Drawing.Size(129, 35);
            this.EmployeeMenu.Text = "Employee";
            // 
            // ManageMenu
            // 
            this.ManageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentApartmentToolStripMenuItem,
            this.payApartmentToolStripMenuItem,
            this.useTheServiceToolStripMenuItem,
            this.billManagementToolStripMenuItem});
            this.ManageMenu.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMenu.Name = "ManageMenu";
            this.ManageMenu.Size = new System.Drawing.Size(111, 35);
            this.ManageMenu.Text = "Manage";
            // 
            // FunctionMenu
            // 
            this.FunctionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentApartmentToolStripMenuItem1,
            this.payApartmentToolStripMenuItem1,
            this.useTheServiceToolStripMenuItem1});
            this.FunctionMenu.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionMenu.Name = "FunctionMenu";
            this.FunctionMenu.Size = new System.Drawing.Size(121, 35);
            this.FunctionMenu.Text = "Function";
            // 
            // ContactMenu
            // 
            this.ContactMenu.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactMenu.Name = "ContactMenu";
            this.ContactMenu.Size = new System.Drawing.Size(110, 35);
            this.ContactMenu.Text = "Contact";
            // 
            // cdrMHC
            // 
            this.cdrMHC.Location = new System.Drawing.Point(931, 364);
            this.cdrMHC.Name = "cdrMHC";
            this.cdrMHC.TabIndex = 15;
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.customerManagementToolStripMenuItem.Text = "Employee Management";
            // 
            // apartmentManagementToolStripMenuItem
            // 
            this.apartmentManagementToolStripMenuItem.Name = "apartmentManagementToolStripMenuItem";
            this.apartmentManagementToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.apartmentManagementToolStripMenuItem.Text = "Sign Up";
            // 
            // rentApartmentToolStripMenuItem
            // 
            this.rentApartmentToolStripMenuItem.Name = "rentApartmentToolStripMenuItem";
            this.rentApartmentToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.rentApartmentToolStripMenuItem.Text = "Apartment Management";
            // 
            // payApartmentToolStripMenuItem
            // 
            this.payApartmentToolStripMenuItem.Name = "payApartmentToolStripMenuItem";
            this.payApartmentToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.payApartmentToolStripMenuItem.Text = "Customer Management";
            this.payApartmentToolStripMenuItem.Click += new System.EventHandler(this.payApartmentToolStripMenuItem_Click);
            // 
            // useTheServiceToolStripMenuItem
            // 
            this.useTheServiceToolStripMenuItem.Name = "useTheServiceToolStripMenuItem";
            this.useTheServiceToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.useTheServiceToolStripMenuItem.Text = "Service Management";
            // 
            // billManagementToolStripMenuItem
            // 
            this.billManagementToolStripMenuItem.Name = "billManagementToolStripMenuItem";
            this.billManagementToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.billManagementToolStripMenuItem.Text = "Bill Management";
            // 
            // rentApartmentToolStripMenuItem1
            // 
            this.rentApartmentToolStripMenuItem1.Name = "rentApartmentToolStripMenuItem1";
            this.rentApartmentToolStripMenuItem1.Size = new System.Drawing.Size(269, 36);
            this.rentApartmentToolStripMenuItem1.Text = "Rent Apartment";
            // 
            // payApartmentToolStripMenuItem1
            // 
            this.payApartmentToolStripMenuItem1.Name = "payApartmentToolStripMenuItem1";
            this.payApartmentToolStripMenuItem1.Size = new System.Drawing.Size(269, 36);
            this.payApartmentToolStripMenuItem1.Text = "Pay Apartment";
            // 
            // useTheServiceToolStripMenuItem1
            // 
            this.useTheServiceToolStripMenuItem1.Name = "useTheServiceToolStripMenuItem1";
            this.useTheServiceToolStripMenuItem1.Size = new System.Drawing.Size(269, 36);
            this.useTheServiceToolStripMenuItem1.Text = "Use The Service";
            // 
            // SalesReportMenu
            // 
            this.SalesReportMenu.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportMenu.Name = "SalesReportMenu";
            this.SalesReportMenu.Size = new System.Drawing.Size(166, 35);
            this.SalesReportMenu.Text = "Sales Reports";
            // 
            // Home_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 569);
            this.Controls.Add(this.cdrMHC);
            this.Controls.Add(this.lbdulich);
            this.Controls.Add(this.msManhinhchinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home_screen";
            this.Text = "Home_screen";
            this.msManhinhchinh.ResumeLayout(false);
            this.msManhinhchinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbdulich;
        private System.Windows.Forms.MenuStrip msManhinhchinh;
        private System.Windows.Forms.ToolStripMenuItem EmployeeMenu;
        private System.Windows.Forms.ToolStripMenuItem ManageMenu;
        private System.Windows.Forms.ToolStripMenuItem FunctionMenu;
        private System.Windows.Forms.ToolStripMenuItem ContactMenu;
        private System.Windows.Forms.MonthCalendar cdrMHC;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentApartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payApartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useTheServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentApartmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem payApartmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem useTheServiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SalesReportMenu;
    }
}