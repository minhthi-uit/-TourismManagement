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
        public dynamic getAll()
        {
            return userDAL.getAll();
        }
        public void updateAccount(ACCOUNT ac)
        {
            userDAL.updateAccount(ac);
        }
        public void deleteAccount(int ID)
        {
            userDAL.deleteAccount(ID);
        }
        public int Login(string username, string password)
        {
            return userDAL.Login(username, password);
        }
        public void Addaccount(ACCOUNT ac)
        {
             userDAL.Addaccount(ac);
        }
        public ACCOUNT getUserByID(int ID)
        {
            return userDAL.getUserByID(ID);
        }
        public void updatePassword(ACCOUNT ac)
        {
            userDAL.updatePassword(ac);
        }
        public bool isManager(int ID)
        {
            return userDAL.isManager(ID);
        }
    }
}
