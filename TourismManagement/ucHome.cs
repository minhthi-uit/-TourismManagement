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
    public partial class ucHome : UserControl
    {
    

        public ucHome()
        {
            InitializeComponent();
        }

        private void btnAddCheckin_Click(object sender, EventArgs e)
        {
            fRentRoom f = new fRentRoom();
            f.TopLevel = false;
            flpHome.Controls.Add(f);
            f.Show();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            fPayBill f = new fPayBill();
            f.TopLevel = false;
            flpHome.Controls.Add(f);
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flpHome.Controls.Clear();
        }
    }
}
