using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart 
    {
        public List<Products> products = new List<Products>();
        private double finalPrice;

        public double priceToPay()
        {
            finalPrice = 0;
            foreach (Products prod in products)
            {
                finalPrice += prod.getPrice();
            }
            return finalPrice;
        }


    }
}
