using Kruemmel_monsters.build.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruemmel_monsters.build.Controller
{
    class CheckoutRoom
    {
        private List<Checkout> checkouts;

        public CheckoutRoom() { }

        public void openCheckout()
        {
            checkouts.Add(new Checkout());
        }

        public void closeCheckout(int id)
        {
            checkouts.RemoveAt(id);
        }
    }
}
