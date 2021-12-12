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
using DAL;
namespace TourismManagement
{
    public partial class ucEmployee : UserControl
    {
        
        UserBUS userBUS = new UserBUS();
        int ID = 1;
        //int ID = HomePage.getID.UserID;
        ACCOUNT aCCOUNT;
        public ucEmployee()
        {
            InitializeComponent();
            aCCOUNT = userBUS.getUserByID(ID);
            txbUserName.Text = aCCOUNT.username;
            
          

            cmbAcessRights.Items.Add("Manager");
            cmbAcessRights.Items.Add("Staff");
            LoadData();
        }
        void LoadData()
        {
            dgvListOfEmployee.DataSource = userBUS.getAll();
            AddBinding();
        }
        void AddBinding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvListOfEmployee.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtDisplay_Name.DataBindings.Clear();
            txtDisplay_Name.DataBindings.Add("Text", dgvListOfEmployee.DataSource, "Display_Name", true, DataSourceUpdateMode.Never);
            cmbAcessRights.DataBindings.Clear();
            cmbAcessRights.DataBindings.Add("Text", dgvListOfEmployee.DataSource, "Acess_Rights", true, DataSourceUpdateMode.Never);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ACCOUNT aCCOUNT = new ACCOUNT()
            {
                id_user = Int32.Parse(txtID.Text),
                display_name = txtDisplay_Name.Text,
                permission = cmbAcessRights.Text,
            };
            userBUS.updateAccount(aCCOUNT);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userBUS.deleteAccount(Int32.Parse(txtID.Text));
                LoadData();
            }
        }

        private void btnUpdateSecurity_Click(object sender, EventArgs e)
        {
            if(txbPassword.Text!=aCCOUNT.pass)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassword.Focus();
            } 
            else if(txbReEnterPass.Text!=txbNewPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không đúng, vui lòng xác nhận lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbReEnterPass.Focus();
            } 
            else
            {
                aCCOUNT.username = txbUserName.Text;
                aCCOUNT.pass = txbNewPass.Text;
                userBUS.updatePassword(aCCOUNT);
                MessageBox.Show("Lưu thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "";
            txbNewPass.Text = "";
            txbReEnterPass.Text = "";
        }
    }
}
