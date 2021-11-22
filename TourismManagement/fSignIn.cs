using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TourismManagement
{
    public partial class SinIn : Form
    {
        UserBUS userBUS = new UserBUS();
        public SinIn()
        {
            InitializeComponent();
        }
        public bool CheckEmpty()
        {
            if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter in your full username and password!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Please enter username!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
 
        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() == false)
            {
                int ID = userBUS.Login(txtUsername.Text, txtPassword.Text);
                if (ID != -1)
                {

                    MessageBox.Show("Logged in succesfully", "Notification", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    
                    HomePage menu = new HomePage();
                    SinIn sinIn = new SinIn();

                    sinIn.Close();
                    menu.ShowDialog();
                   
                }

                else
                    MessageBox.Show("Login failed. Please try again!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SIGNUP signUp = new SIGNUP();
            signUp.ShowDialog();
        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
