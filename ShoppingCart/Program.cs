using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Orange");
            list.Add("Apple");

            Cart cart=new Cart(list);

            Console.WriteLine(cart.appleCount());
            Console.WriteLine(cart.orangeCount());

            Console.WriteLine(cart.toString());

        }
    }
}
