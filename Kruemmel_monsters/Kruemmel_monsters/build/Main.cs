using System;

namespace noname
{
    abstract class Product
    {
      // prepare interfaces for products
      //
      // END
    }

    //#########################################################################################

    public class CheckoutController
    {
        public static void Main()
        {
          // -> init checkoutroom
          // -> checkoutroom look for checkouts ==> not available ==> loop [ready state???]
          // --> Checkout get Order; set Order to QueueOrder ==> set Order to "cooking"
          //
          // => Checkout look for Order with state "ready" ==> not set ==> loop
          // --> Checkout give out Order
          // ---> Order delete in QueueOrder
          //
          //
          // END

        }
    }

    //#########################################################################################

    public class KitchenController
    {
        public static void Main()
        {
          // init kitchen
          // -> look for Orders in QueueOrder ==> not available ==> loop [ready state???]
          // --> look for Order with state "cooking" ==> not available ==> loop
          // ---> look for products, prepare Order, set Order state to "ready"
          //
          //
          // END
        }
    }

}
