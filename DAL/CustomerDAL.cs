using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        QLDuLichEntities entities = new QLDuLichEntities();
        public dynamic getCustomer()
        {
            var kh = from c in entities.CUSTOMERs
                     select new
                     {
                         ID = c.id_customer,
                         Name = c.customer_name,
                         CMND = c.customer_cmnd,        
                         Phone = c.customer_phone,
                         Type = c.customer_type,
                         Address = c.customer_address
                     };
            return kh.ToList();
        }
        public int insertCustomer(CUSTOMER kh)
        {
            entities.CUSTOMERs.Add(kh);
            entities.SaveChanges();
            return kh.id_customer;
        }

        public void updateCustomer(CUSTOMER kh)
        {
            CUSTOMER k = entities.CUSTOMERs.Find(kh.id_customer);
            k.customer_name = kh.customer_name;          
            k.customer_phone = kh.customer_phone;           
            k.customer_cmnd = kh.customer_cmnd;
            k.customer_address = kh.customer_address;
            k.customer_type = kh.customer_type;
            entities.SaveChanges();
        }

        public void deleteCustomer(int ID)
        {
            CUSTOMER kh = entities.CUSTOMERs.Find(ID);
            if (kh != null)
            {
                entities.CUSTOMERs.Remove(kh);
                entities.SaveChanges();
            }
        }

        public dynamic findKhachHangByCMND(String CMND)
        {
            var kh = from c in entities.CUSTOMERs
                     where c.customer_cmnd.Contains(CMND)
                     select new
                     {
                         ID = c.id_customer,
                         Name = c.customer_name,
                         CMND = c.customer_cmnd,                      
                         Phone = c.customer_phone,
                         Type = c.customer_type,
                         Address = c.customer_address
                     };
            return kh.ToList().FirstOrDefault();
        }

        public CUSTOMER findKhachHangByID(int ID)
        {
            return entities.CUSTOMERs.Find(ID);
        }

        public dynamic findCustomer(string customerName, string CMND)
        {
            var result = from c in entities.CUSTOMERs
                         select c;
            if (customerName != "")
                result = from c in result
                         where c.customer_name.Contains(customerName)
                         select c;
            if (CMND != "")
                result = from c in result
                         where c.customer_cmnd.Contains(CMND)
                         select c;

            var data = from c in result
                       select new
                       {
                           ID = c.id_customer,
                           Name = c.customer_name,
                           CMND = c.customer_cmnd,               
                           Phone = c.customer_phone,
                           Type = c.customer_type,
                           Address = c.customer_address
                       };

            return data.ToList();
        }
    }
}
