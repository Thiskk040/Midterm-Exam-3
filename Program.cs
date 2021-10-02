using System;
using System.Collections.Generic;

namespace _52
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";

            Flowerstore flowerStore = new Flowerstore();
            PrintSelectFlower(decide,flowerStore);

            Console.ReadLine();
        }
        static void PrintSelectFlower(string decide, Flowerstore flowerStore)///เมดทอดเลือกชนิดดอกไม้
        {
            string selectFlower;


            Console.WriteLine("Select number for buy flower");
            foreach (string i in flowerStore.flowerList)
            {
                Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
            Console.Write("Select Flower: ");
            selectFlower = Console.ReadLine();
            AddFlowerToCart(selectFlower,flowerStore);
            PrintContinueOrExit(decide,flowerStore);


        }
        static void AddFlowerToCart(string selectFlower, Flowerstore flowerStore)////เมดทอดเพิ่มจำนวนดอกไม้
        {
            
            switch (selectFlower)//ใช้ switch case กด 1 เป็นการเพิ่มกุหลาบลงในตะกร้า
            {
                case "1":
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine();
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                    
                    break;

                case "2"://ใช้ switch case กด 2 เป็นการเพิ่มทานตะวันลงในตะกร้า
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine();
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                    break;

                default://เมื่อผู้ใช้งานกรอกนอกเหนือจาก 1 และ 2 จะขึ้นข้อความนี้และให้กรอกใหม่
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
            
        }
        static void PrintContinueOrExit(string decide, Flowerstore flowerStore)///เมดทอดที่จะให้เลือกว่าจะซื้อดอกไม้ต่อหรือไม่ ถ้ากด Exit ให้แสดง Shopping cart ของ User
        {
            Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");
            Console.Write("Selected function :");
            decide = Console.ReadLine();

            if (decide == "exit")
            {
                Console.Write("Current my cart");
                flowerStore.showCart();
            }
            else
            {
                PrintSelectFlower(decide, flowerStore);
            }
        }
    }
}

