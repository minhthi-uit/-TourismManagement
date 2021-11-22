using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;


namespace TourismManagement
{
    public partial class SIGNUP : Form
    {
        UserBUS userBUS = new UserBUS();
        Bitmap bitmap = new Bitmap(Properties.Resources.avatar);
        Bitmap avatar;
        int avatarIndex = 0;
        int HEIGHT, WIDTH;
        public SIGNUP()
        {
            InitializeComponent();
        
            LoadAcess();
        }
        void LoadAcess()
        {
            cbAcessRights.Items.Add("Manager");
            cbAcessRights.Items.Add("Staff");
            cbAcessRights.SelectedIndex = 0;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Please fill in all the information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password does not match", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ACCOUNT aCCOUNT = new ACCOUNT()
            {
                
                pass = txtPassword.Text,
                permission = cbAcessRights.Text,
                display_name = txtDisplayName.Text,
                username = txtUsername.Text,
            };

            userBUS.Addaccount(aCCOUNT);
            MessageBox.Show("Sign Up Success", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool checkEmpty()
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

}
