using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class UserBUS
    {
        UserDAL userDAL = new UserDAL();
        public int Login(string username, string password)
        {
            return userDAL.Login(username, password);
        }
        public void Addaccount(ACCOUNT ac)
        {
             userDAL.Addaccount(ac);
        }
    }
}
