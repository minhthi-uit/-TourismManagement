using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TourismManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        

            ucRoom1.Visible = false;
            ucHome1.Visible = false;
            ucBill1.Visible = false;
            ucSale1.Visible = false;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = false;
        }

    
        private void btnHome_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucHome1.Visible = true;
  
            ucRoom1.Visible = false;
            ucSale1.Visible = false;
            ucBill1.Visible=false;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;


            ucHome1.Visible = false;
            ucBill1.Visible = false;
            ucRoom1.Visible = true;
            ucSale1.Visible = false;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = false;

        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            if (panel_left.Width == 350)
            {
                panel_left.Width = 77;
            }
            else
            {
                panel_left.Width = 350;
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucRoom1.Visible = false;
            ucHome1.Visible = false;         
            ucBill1.Visible = true;
            ucSale1.Visible = false;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = false;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucRoom1.Visible = false;
            ucHome1.Visible = false;
            ucBill1.Visible = false;
            ucSale1.Visible = true;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = false;

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucRoom1.Visible = false;
            ucHome1.Visible = false;
            ucBill1.Visible = false;
            ucSale1.Visible = false;
            ucCustomer1.Visible = true;
            ucEmployee1.Visible = false;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucRoom1.Visible = false;
            ucHome1.Visible = false;
            ucBill1.Visible = false;
            ucSale1.Visible = false;
            ucCustomer1.Visible = false;
            ucEmployee1.Visible = true;
        }
    }
}
