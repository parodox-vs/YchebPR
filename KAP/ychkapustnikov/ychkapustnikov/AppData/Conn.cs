using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ychkapustnikov.AppData
{
    internal class Conn
    {
        public static DodoPizzaEntities c;
        public static DodoPizzaEntities context
        {
            get
            {
                if (c == null)
                    c = new DodoPizzaEntities();
                return c;
            }
        }
    }
}
