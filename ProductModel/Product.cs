using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProductApp.ProductModel
{
    /// <summary>
    /// Gets or sets the product. 
    /// </summary>
  public class Product
    {  
        public Product(string id)
        {
            this.Id = id;
        }
        public string Id { get; set; }
        public decimal Price { get; set; }
    }
}
