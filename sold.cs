using System;
using System.Collections.Generic;
using System.Linq;
namespace FINAL
{
    internal class Sold
    {
        public static void MostSold()
        {
            string[] items = { "Charger",
                           "Powerbank",
                           "Phonecase",
                           "Earphones",
                           "Adaptor",
                           "Headphones",
                           "SD Cards",
                           "Speakers",
                           "Samsung Phone",
                           "Realme Phone",
                           "Iphone",
                           "Xiaomi Phone",
                           "Vivo Phone",
                           "Infinix Phone",
                           "POCO x3"};

            int[] sales = new int[15];

            sales[0] = 13;
            sales[1] = 2;
            sales[2] = 4;
            sales[3] = 12;
            sales[4] = 0;
            sales[5] = 1;
            sales[6] = 8;
            sales[7] = 10;
            sales[8] = 3;
            sales[9] = 5;
            sales[10] = 11;
            sales[11] = 1;
            sales[12] = 9;
            sales[13] = 6;
            sales[14] = 7;
           

            int bestSellerIndex = 0;
            int mostSale = sales[0];

            Console.WriteLine("\nHighest sold item: ");

            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] > mostSale)
                {
                    mostSale = sales[i];
                    bestSellerIndex = i;

                    Console.WriteLine($"{items[mostSale]} - {sales[bestSellerIndex]} sales");
                }
            }
        }
    }
}



           


     


   