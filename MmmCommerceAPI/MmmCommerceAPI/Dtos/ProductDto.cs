using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Dtos
{
    public class ProductDto
    {
        [JsonPropertyName("id")]
        public Guid ProductId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("materials")]
        public string[] Materials { get; set; }

        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        [JsonPropertyName("item_listed")]
        public bool ItemListed { get; set; }

        [JsonPropertyName("stock")]
        public List<StockDto> Stock { get; set; }
    }
}
