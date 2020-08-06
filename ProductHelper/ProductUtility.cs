using SampleProductApp.ProductModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProductApp.ProductHelper
{
    /// <summary>
    /// The main ProductHelper class.
    /// Contains all methods for calculating promotion. 
    /// </summary>
   public class ProductUtility : IProductUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        public void GetPriceByType(Product product)
        {
            switch (product.Id)
            {
                case "A":
                   product.Price = 50m;
                    break;
                case "B":
                    product.Price = 30m;
                    break;
                case "C":
                    product.Price = 20m;
                    break;
                case "D":
                    product.Price = 15m;
                    break;
            }
        }
         /// <summary>
        ///  In this method we are calculating price
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public int GetTotalPrice(List<Product> products)
        {
            try
            {
                int counterOfA = 0;
                int priceOfA = 50;
                int counterOfB = 0;
                int priceOfB = 30;
                int counterOfC = 0;
                int priceOfC = 20;
                int counterOfD = 0;
                int priceOfD = 15;
                int priceofCD = 30;

                foreach (Product pr in products)
                {
                    switch (pr.Id)
                    {
                        case "A":
                        case "a":
                            counterOfA += 1;
                            break;
                        case "B":
                        case "b":
                            counterOfB += 1;
                            break;
                        case "C":
                        case "c":
                            counterOfC += 1;
                            break;
                        case "D":
                        case "d":
                            counterOfD += 1;
                            break;
                    }
                }
                int totalPriceCD = 0;
                int totalPriceOfA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
                int totalPriceOfB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
                if (counterOfC > 0 && counterOfD > 0)
                {
                    int totalCoutCD = counterOfC > counterOfD ? counterOfD : counterOfC;
                    counterOfC -= totalCoutCD;
                    counterOfD -= totalCoutCD;
                    totalPriceCD = totalCoutCD * priceofCD;

                }
                int totalPriceOfC = (counterOfC * priceOfC);
                int totalPriceOfD = (counterOfD * priceOfD);
                return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD + totalPriceCD;
            }
          catch(Exception ex)
            {
                return 0;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
