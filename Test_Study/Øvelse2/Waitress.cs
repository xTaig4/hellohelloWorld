using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public class Waitress
    {
        private IOrder order;
        private Drink drink;

        public void TakeOrder(IOrder order)
        {
            this.order = order;
        }

        public Drink ServeDrink()
        {
            return drink;
        }

        public void GiveOrder(Barista barista)
        {
            drink = barista.MakeCoffe(order.Drink);
        }

        public IOrder ReadOrder() 
        {
            return order;
        }

        

    }
}
