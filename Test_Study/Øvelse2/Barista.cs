using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public class Barista
    {


        public virtual Drink MakeCoffe(string drink)
        {
            string[] drinks = ReadMenu();

            if (drinks.Contains<string>(drink))
            {
                return new Drink(drink);
            }

            return null;
        }

        string[] ReadMenu()
        {
            string[] drinks = new string[] {"Americano", "Cafe Latte", "Flat White", "Cortado", "Espresso", "Tai's Special brygget"};
            return drinks;
        }
    }

    
}
