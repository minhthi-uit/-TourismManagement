using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HomeBUS
    {
        private static HomeBUS instance;

        public static HomeBUS Instance
        {
            get { if (instance == null) instance = new HomeBUS(); return HomeBUS.instance; }
            private set { HomeBUS.instance = value; }
        }

        public static int RoomWidth = 170;
        public static int RoomHeight = 170;

        private HomeBUS() { }
    }
}
