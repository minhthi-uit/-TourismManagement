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

    }
}
