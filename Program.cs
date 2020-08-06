using SampleProductApp.ProductModel;
using System;
using System.Collections.Generic;
using SampleProductApp.ProductHelper;

namespace SampleProductApp
{
   public class Program
    {
        /// <summary>
        /// This is main class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                ProductUtility productUtility = new ProductUtility();
                Console.WriteLine("Total number of order");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("Enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();
                    Product product = new Product(type);
                    products.Add(product);
                }

                int totalPrice = productUtility.GetTotalPrice(products);
                Console.WriteLine(totalPrice);
                Console.ReadLine();
            }
            catch(Exception  ex)
            {
                  Console.WriteLine(ex.Message);
            }
        }
    }
}
