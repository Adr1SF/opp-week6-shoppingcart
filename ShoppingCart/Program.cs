using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Products apple = new Products(0.6);
            Products orange = new Products(0.25);


            Cart myCart = new Cart();

            myCart.products.Add(orange);
            myCart.products.Add(apple);
            myCart.products.Add(orange);

            Console.WriteLine(myCart.priceToPay());

        }
    }
}
