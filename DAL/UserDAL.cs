using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        QLDuLichEntities entities = new QLDuLichEntities();
        public dynamic getAll()
        {
            var data = from c in entities.ACCOUNTs
                       select new
                       {
                           ID = c.id_user,
                           Display_Name = c.display_name,
                           Acess_Rights = c.permission,
                       };
            return data.ToList();
        }
        public void deleteAccount(int ID)
        {
            ACCOUNT aCCOUNT = entities.ACCOUNTs.Find(ID);
            if (aCCOUNT != null)
            {
                entities.ACCOUNTs.Remove(aCCOUNT);
                entities.SaveChanges();
            }
        }
        public void updateAccount(ACCOUNT ac)
        {
            ACCOUNT aCCOUNT = entities.ACCOUNTs.Find(ac.id_user);
            aCCOUNT.display_name = ac.display_name;
            aCCOUNT.permission = ac.permission;
            entities.SaveChanges();
        }
        public int Login(string username, string password)
        {
            var existuser = entities.ACCOUNTs.FirstOrDefault(m => m.username.Equals(username));
            if (existuser != null)
            {
                if (existuser.pass.Equals(password))
                    return existuser.id_user;
                else
                    return -1;
            }
            return -1;
        }
        public void Addaccount(ACCOUNT ac)
        {
            entities.ACCOUNTs.Add(ac);
            entities.SaveChanges();
        }
    }
}
