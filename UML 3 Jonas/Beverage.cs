using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Jonas
{
    public class Beverage : MenuItem
    {
        public Beverage(int number, string name, string description, double price, MenuType menutype, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, menutype, isVegan, isOrganic)
        {
            Alcohol = alcohol;
          
        }
        public override string PrintInfo()
        {
            return base.PrintInfo() + $" Alcohol{Alcohol}";
        }
        public override string ToString()
        {
            return base.ToString() + (Alcohol ? " Is alcoholic" : " Non alcoholic");
        }
        public bool Alcohol { get; set; } 

    }
}
