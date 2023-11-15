using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Jonas
{
    public class MenuItemNumberExists : Exception
    {
        public MenuItemNumberExists(string message) : base(message)
        {

        }

        public MenuItemNumberExists()
        {

        }
    }
}
