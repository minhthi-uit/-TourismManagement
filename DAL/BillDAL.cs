using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        QLDuLichEntities entities = new QLDuLichEntities();
        public dynamic getAll()
        {
            var data = from c in entities.BILL_DETAILS
                       select new
                       {
                           ID_Bill = c.id_bill,
                           ID_Customer = c.BILL.CUSTOMER.id_customer,
                           Name_Customer = c.BILL.CUSTOMER.customer_name,
                           Name_Apartment = c.CHECKIN.ROOM.room_name,
                           Type_Of_Apartment = c.CHECKIN.ROOM.ROOMTYPE.room_type,
                           Payment_Day = c.BILL.date_end,
                           Rental_Days = c.date_number,
                           Price=c.CHECKIN.ROOM.ROOMTYPE.price_per_day,
                           Service_Fee=c.CHECKIN.SERVICE.into_money,
                           Apartment_Money=c.CHECKIN.money_checkin,
                           Total_Money=c.BILL.total_money,
                           
                       };
            return data.ToList();

        }
        public dynamic findBill(int ID, string customerName, string apartmentName)
        {
            var result = from c in entities.BILL_DETAILS
                         select c;
            if (ID != -1)
                result = from c in entities.BILL_DETAILS
                         where c.id_bill == ID
                         select c;
            if (customerName != "")
                result = from c in result
                         where c.BILL.CUSTOMER.customer_name.Contains(customerName)
                         select c;
            if (apartmentName != "")
                result = from c in result
                         where c.CHECKIN.ROOM.room_name.Contains(apartmentName)
                         select c;
            var data = from c in result
                       select new
                       {
                           ID_Bill = c.id_bill,
                           ID_Customer = c.BILL.CUSTOMER.id_customer,
                           Name_Customer = c.BILL.CUSTOMER.customer_name,
                           Name_Apartment = c.CHECKIN.ROOM.room_name,
                           Type_Of_Apartment = c.CHECKIN.ROOM.ROOMTYPE.room_type,
                           Payment_Day = c.BILL.date_end,
                           Rental_Days = c.date_number,
                           Price=c.CHECKIN.ROOM.ROOMTYPE.price_per_day,
                           Service_Fee = c.CHECKIN.SERVICE.into_money,
                           Apartment_Money = c.CHECKIN.money_checkin,
                           Total_Money = c.BILL.total_money,
                           
                       };
            return data.ToList();
        }
        public int getBillID(int BillID)
        {
            BILL_DETAILS bILL_DETAILS = entities.BILL_DETAILS.Where(c => c.id_bill == BillID).SingleOrDefault();
            return (int) bILL_DETAILS.id_bill;
        }
        public BILL_DETAILS getBillByID(int BillID)
        {
            return entities.BILL_DETAILS.Where(c => c.id_bill == BillID).SingleOrDefault();
        }
    }
}
