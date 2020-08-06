using SampleProductApp.ProductModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProductApp.ProductHelper
{
    /// <summary>
    /// This is the IProductService interface.
    /// </summary>
    interface IProductUtility
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }
}
