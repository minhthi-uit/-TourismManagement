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
        public ucEmployee()
        {
            InitializeComponent();
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
    }
}
