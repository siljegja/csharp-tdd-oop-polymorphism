using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();
        public List<IProduct> products { get { return _products; } }    

        public void add(IProduct product)
        {
            products.Add(product);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (IProduct product in products)
            {
                total += product.getPrice();
            }
            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct product in products)
            {
                if (product.getName().Equals(name)) return true;
            }
            return false;
        }
    }
}
