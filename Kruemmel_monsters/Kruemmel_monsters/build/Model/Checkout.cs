using noname;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruemmel_monsters.build.Model
{
    class Checkout
    {
        private List<Product> products = new List<Product>();

        public void addProduct (Product product) {
            products.Add(product);
        }

        public void removeProduct (Product product) {
            products.Remove(product);
        }

        public List<string> getProductList ()
        {
            List<String> stringList = new List<string>();
            foreach (Product p in products)
            {
                stringList.Add(p.Name);
            }
            return stringList;
        }

        public List<Product> getProductList()
        {
            return this.products;
        }


    }
}
