using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart 
    {
        List<string> list { get; set; }
        int apCount;
        int orCount;
        Orange orange;
        Apple apple;

        public Cart(List<string> list)
        {
            this.list = list;
        }

        public int orangeCount()
        {
            foreach(string food in list)
            {
                if (food=="Orange")
                {
                    orCount++;
                }
            }
            return orCount;
        }

        public int appleCount()
        {
            foreach (string food in list)
            {
                if (food == "Apple")
                {
                    apCount++;
                }
            }
            return apCount;
        }


        public double Price(int apCount,int orCount)
        {
            double finalPrice = 0;
            finalPrice += orCount * (orange.orangePrice());
            finalPrice += apCount * (apple.applePrice());
            return finalPrice;
        }

        public string toString()
        {
            return "You will have to pay " + Price( apCount,  orCount )+ " cents.";
        }

    }
}
