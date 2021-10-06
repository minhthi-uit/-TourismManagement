
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
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdrMHC = new System.Windows.Forms.MonthCalendar();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msManhinhchinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdulich
            // 
            this.lbdulich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbdulich.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdulich.ForeColor = System.Drawing.Color.Maroon;
            this.lbdulich.Location = new System.Drawing.Point(0, 0);
            this.lbdulich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdulich.Name = "lbdulich";
            this.lbdulich.Size = new System.Drawing.Size(869, 49);
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
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.liênHệToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.msManhinhchinh.Location = new System.Drawing.Point(7, 49);
            this.msManhinhchinh.Name = "msManhinhchinh";
            this.msManhinhchinh.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msManhinhchinh.Size = new System.Drawing.Size(787, 32);
            this.msManhinhchinh.TabIndex = 14;
            this.msManhinhchinh.Text = "menuStrip1";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.quảnLýPhòngToolStripMenuItem.Text = "RentApartment";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Employee Manager";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Customer Manager";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.thốngKêToolStripMenuItem.Text = "Sales Report";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.liênHệToolStripMenuItem.Text = "Contact";
            // 
            // cdrMHC
            // 
            this.cdrMHC.Location = new System.Drawing.Point(698, 296);
            this.cdrMHC.Margin = new System.Windows.Forms.Padding(7);
            this.cdrMHC.Name = "cdrMHC";
            this.cdrMHC.TabIndex = 15;
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // Home_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 462);
            this.Controls.Add(this.cdrMHC);
            this.Controls.Add(this.lbdulich);
            this.Controls.Add(this.msManhinhchinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar cdrMHC;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
    }
}