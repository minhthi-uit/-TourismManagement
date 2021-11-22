using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace TourismManagement
{
    public partial class CustomerManagement : Form
    {
        CustomerDAL customerDAL = new CustomerDAL();
        CustomerBUS customerBUS = new CustomerBUS();    
        public CustomerManagement()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvListOfCustomer.DataSource = customerDAL.getCustomer();
            addBinding();
        }
        void addBinding()
        {
            txtID.DataBindings.Clear();
            txtIdentityCard.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Clear();
            tbAddress.DataBindings.Clear();
                   
            cbType.DataBindings.Clear();          

            txtID.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtIdentityCard.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtPhoneNumber.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            tbAddress.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "Address", true, DataSourceUpdateMode.Never);
            cbType.DataBindings.Add("Text", dgvListOfCustomer.DataSource, "Type", true, DataSourceUpdateMode.Never);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CUSTOMER kh = new CUSTOMER()
            {
                id_customer = Convert.ToInt32(txtID.Text),
                customer_name = txtName.Text,
                customer_cmnd = txtIdentityCard.Text,
                customer_address = tbAddress.Text,
                customer_type = (string)cbType.SelectedValue,
                
                customer_phone = txtPhoneNumber.Text,
             
            };

            customerBUS.Update(kh);
            LoadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
