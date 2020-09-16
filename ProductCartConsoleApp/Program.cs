using System;
using System.Collections.Generic;

namespace ProductCartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductCartModel> products = new List<ProductCartModel>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                ProductCartModel p = new ProductCartService(type);
                products.Add(p);
            }

            int totalPrice = ProductCartService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

    }
}
