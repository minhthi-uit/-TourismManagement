using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    
    public class HomeDAL
    {
        private static HomeDAL instance;

        public static HomeDAL Instance
        {
            get { if (instance == null) instance = new HomeDAL(); return HomeDAL.instance; }
            private set { HomeDAL.instance = value; }
        }
        private HomeDAL() { }
    }
}
