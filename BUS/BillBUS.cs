using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BillBUS
    {
        BillDAL billDAL = new BillDAL();
        public dynamic getAll()
        {
            return billDAL.getAll();
        }
        public dynamic findBill(int ID, string customerName, string apartmentName)
        {
            return billDAL.findBill(ID, customerName, apartmentName);
        }
        public int getBillID(int RentalID)
        {
            return billDAL.getBillID(RentalID);
        }
        public BILL_DETAILS getBillByID(int BillID)
        {
            return billDAL.getBillByID(BillID);
        }
    }
}
