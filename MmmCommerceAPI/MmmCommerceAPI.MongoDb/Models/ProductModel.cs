using System;
using System.Collections.Generic;

namespace MmmCommerceAPI.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string[] Materials { get; set; }

        public string[] Tags { get; set; }
        public bool ItemListed { get; set; }

        public List<StockModel> Stock { get; set; }
    }
}
