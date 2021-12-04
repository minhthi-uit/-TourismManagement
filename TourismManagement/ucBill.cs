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
    public partial class ucBill : UserControl
    {
        BillBUS billBUS = new BillBUS();
        int BillID = 0;
        public ucBill()
        {
            InitializeComponent();
            LoadData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            dgvListOfBill.DataSource = billBUS.getAll();
            addBinding();
        }
        void addBinding()
        {
            txtIDBill.DataBindings.Clear();
            txtIDCustomer.DataBindings.Clear();
            txtNameCustomer.DataBindings.Clear();
            txtNameApartment.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtServiceFee.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtRentalDays.DataBindings.Clear();
            txtApartmentMoney.DataBindings.Clear();
            dtpPaymentDay.DataBindings.Clear();
            txtTotal.DataBindings.Clear();

            txtIDBill.DataBindings.Add("Text", dgvListOfBill.DataSource, "ID_Bill", true, DataSourceUpdateMode.Never);
            txtIDCustomer.DataBindings.Add("Text", dgvListOfBill.DataSource, "ID_Customer", true, DataSourceUpdateMode.Never);
            txtNameCustomer.DataBindings.Add("Text", dgvListOfBill.DataSource, "Name_Customer", true, DataSourceUpdateMode.Never);
            txtNameApartment.DataBindings.Add("Text", dgvListOfBill.DataSource, "Name_Apartment", true, DataSourceUpdateMode.Never);
            txtType.DataBindings.Add("Text", dgvListOfBill.DataSource, "Type_Of_Apartment", true, DataSourceUpdateMode.Never);
            txtServiceFee.DataBindings.Add("Text", dgvListOfBill.DataSource, "Service_Fee", true, DataSourceUpdateMode.Never);
            txtPrice.DataBindings.Add("Text", dgvListOfBill.DataSource, "Price", true, DataSourceUpdateMode.Never);
            txtRentalDays.DataBindings.Add("Text", dgvListOfBill.DataSource, "Rental_Days", true, DataSourceUpdateMode.Never);
            txtApartmentMoney.DataBindings.Add("Text", dgvListOfBill.DataSource, "Apartment_Money", true, DataSourceUpdateMode.Never);
            dtpPaymentDay.DataBindings.Add("Text", dgvListOfBill.DataSource, "Payment_Day", true, DataSourceUpdateMode.Never);
            txtTotal.DataBindings.Add("Text", dgvListOfBill.DataSource, "Total_Money", true, DataSourceUpdateMode.Never);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (txtIDBillSearch.Text != "")
            {
                ID = Convert.ToInt32(txtIDBillSearch.Text);
            }
            dgvListOfBill.DataSource = billBUS
                .findBill(ID,txtNameCustomerSearch.Text,txtNameApartmentSearch.Text);

            addBinding();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBill printBill = new PrintBill(billBUS.getBillID(BillID));
            printBill.Show();
        }

        private void dgvListOfBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                BillID = (int)dgvListOfBill.Rows[e.RowIndex].Cells["ID_Bill"].Value;
            }    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
