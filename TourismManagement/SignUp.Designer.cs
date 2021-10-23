namespace TourismManagement
{
    partial class SIGNUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNUP));
            this.panel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxTTCN = new System.Windows.Forms.GroupBox();
            this.cbAcessRights = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.labelAcessRights = new System.Windows.Forms.Label();
            this.labelRepassword = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.labelDK = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.groupBoxTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.groupBoxTTCN);
            this.panel.Controls.Add(this.labelDK);
            this.panel.Controls.Add(this.btnSignUp);
            this.panel.Controls.Add(this.picAvatar);
            this.panel.Location = new System.Drawing.Point(3, 4);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(723, 481);
            this.panel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 399);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 39);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxTTCN
            // 
            this.groupBoxTTCN.Controls.Add(this.cbAcessRights);
            this.groupBoxTTCN.Controls.Add(this.labelUsername);
            this.groupBoxTTCN.Controls.Add(this.txtRePassword);
            this.groupBoxTTCN.Controls.Add(this.txtPassword);
            this.groupBoxTTCN.Controls.Add(this.txtUsername);
            this.groupBoxTTCN.Controls.Add(this.txtDisplayName);
            this.groupBoxTTCN.Controls.Add(this.labelAcessRights);
            this.groupBoxTTCN.Controls.Add(this.labelRepassword);
            this.groupBoxTTCN.Controls.Add(this.labelPassWord);
            this.groupBoxTTCN.Controls.Add(this.labelDisplayName);
            this.groupBoxTTCN.Location = new System.Drawing.Point(219, 121);
            this.groupBoxTTCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCN.Name = "groupBoxTTCN";
            this.groupBoxTTCN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCN.Size = new System.Drawing.Size(469, 257);
            this.groupBoxTTCN.TabIndex = 7;
            this.groupBoxTTCN.TabStop = false;
            this.groupBoxTTCN.Text = "Enter personal information";
            // 
            // cbAcessRights
            // 
            this.cbAcessRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcessRights.FormattingEnabled = true;
            this.cbAcessRights.Location = new System.Drawing.Point(233, 199);
            this.cbAcessRights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAcessRights.Name = "cbAcessRights";
            this.cbAcessRights.Size = new System.Drawing.Size(216, 26);
            this.cbAcessRights.TabIndex = 11;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(27, 71);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(94, 20);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(233, 158);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(216, 24);
            this.txtRePassword.TabIndex = 8;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(233, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 24);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(233, 70);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 24);
            this.txtUsername.TabIndex = 6;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(233, 26);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(216, 24);
            this.txtDisplayName.TabIndex = 5;
            // 
            // labelAcessRights
            // 
            this.labelAcessRights.AutoSize = true;
            this.labelAcessRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcessRights.ForeColor = System.Drawing.Color.Black;
            this.labelAcessRights.Location = new System.Drawing.Point(27, 205);
            this.labelAcessRights.Name = "labelAcessRights";
            this.labelAcessRights.Size = new System.Drawing.Size(121, 20);
            this.labelAcessRights.TabIndex = 4;
            this.labelAcessRights.Text = "Acess Rights";
            // 
            // labelRepassword
            // 
            this.labelRepassword.AutoSize = true;
            this.labelRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepassword.ForeColor = System.Drawing.Color.Black;
            this.labelRepassword.Location = new System.Drawing.Point(27, 158);
            this.labelRepassword.Name = "labelRepassword";
            this.labelRepassword.Size = new System.Drawing.Size(168, 20);
            this.labelRepassword.TabIndex = 3;
            this.labelRepassword.Text = "Re-enter password";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassWord.ForeColor = System.Drawing.Color.Black;
            this.labelPassWord.Location = new System.Drawing.Point(27, 114);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(91, 20);
            this.labelPassWord.TabIndex = 2;
            this.labelPassWord.Text = "Password";
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayName.ForeColor = System.Drawing.Color.Black;
            this.labelDisplayName.Location = new System.Drawing.Point(24, 28);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(126, 20);
            this.labelDisplayName.TabIndex = 0;
            this.labelDisplayName.Text = "Display Name";
            // 
            // labelDK
            // 
            this.labelDK.AutoSize = true;
            this.labelDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDK.Location = new System.Drawing.Point(281, 14);
            this.labelDK.Name = "labelDK";
            this.labelDK.Size = new System.Drawing.Size(154, 36);
            this.labelDK.TabIndex = 5;
            this.labelDK.Text = "SIGN UP ";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(268, 399);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(143, 39);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(35, 168);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(155, 159);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 6;
            this.picAvatar.TabStop = false;
            // 
            // SIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 486);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SIGNUP";
            this.Text = "Sign Up";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBoxTTCN.ResumeLayout(false);
            this.groupBoxTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxTTCN;
        private System.Windows.Forms.ComboBox cbAcessRights;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label labelAcessRights;
        private System.Windows.Forms.Label labelRepassword;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.Label labelDK;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}