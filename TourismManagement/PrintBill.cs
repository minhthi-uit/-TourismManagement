using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace TourismManagement
{
    public partial class PrintBill : Form
    {
        BillBUS billBUS = new BillBUS();
        BILL_DETAILS bILL_DETAILS = new BILL_DETAILS();
        public PrintBill(int BillID)
        {
            InitializeComponent();
            bILL_DETAILS = billBUS.getBillByID(BillID);

            txtCustomerName.Text = bILL_DETAILS.BILL.CUSTOMER.customer_name.ToString();
            txtIdBill.Text = bILL_DETAILS.BILL.id_bill.ToString();
            dtPaymentDay.Value = bILL_DETAILS.BILL.date_end.Value;
            txtSurchageRatio.Text = bILL_DETAILS.surchage_ratio.ToString();

            
            txtApartmentName.Text = bILL_DETAILS.CHECKIN.ROOM.room_name;
            txtTypeOfApartment.Text = bILL_DETAILS.CHECKIN.ROOM.ROOMTYPE.room_type.ToString();
            txtRentalDays.Text = bILL_DETAILS.date_number.ToString();
            txtUnitPrice.Text = bILL_DETAILS.CHECKIN.ROOM.ROOMTYPE.price_per_day.ToString();
            txtApartment_Money.Text = bILL_DETAILS.CHECKIN.money_checkin.ToString();
            txtServiceFee.Text = bILL_DETAILS.CHECKIN.SERVICE.into_money.ToString();
            txtTotalMoney.Text = bILL_DETAILS.BILL.total_money.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int WIDTH = this.Width + 180;
            int HEIGHT = this.Height - 60;
            var bm = new Bitmap(WIDTH, HEIGHT);
            

            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(new System.Drawing.Point(this.Location.X + 30, this.Location.Y + 50), System.Drawing.Point.Empty, new Size(WIDTH, HEIGHT));

            var dlg = new SaveFileDialog { DefaultExt = "png", Filter = "Png Files|*.png" };
            var res = dlg.ShowDialog();
            if (res == DialogResult.OK) bm.Save(dlg.FileName, ImageFormat.Png);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
