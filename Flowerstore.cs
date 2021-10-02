using System;
using System.Collections.Generic;
namespace _52
{
    class Flowerstore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public Flowerstore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }
        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
    }  }
}
