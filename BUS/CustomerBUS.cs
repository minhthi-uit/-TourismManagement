using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class CustomerBUS
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public void Update(CUSTOMER customer)
        {
            customerDAL.updateCustomer(customer);
        }

    }
}
