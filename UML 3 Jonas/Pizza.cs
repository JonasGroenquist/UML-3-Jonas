using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Jonas
{
    public class Pizza:MenuItem
    {
        public Pizza(int number, string name, string description, double price, MenuType menutype, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, menutype, isVegan, isOrganic)
        {
            DeepPan = deepPan;

        }
        public override string PrintInfo()
        {
            return base.PrintInfo()+ $" Deeppan{DeepPan}";
        }
        public override string ToString()
        {
            return base.ToString()+ (DeepPan?" Is Deeppan":"ikke Deeppan");
        }
        public bool DeepPan {  get; set; }
    }
}
