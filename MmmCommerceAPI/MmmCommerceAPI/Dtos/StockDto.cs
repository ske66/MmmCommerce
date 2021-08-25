using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Dtos
{
    public class StockDto
    {
        [JsonPropertyName("id")]
        public Guid StockId { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("reserved")]
        public bool Reserved { get; set; }
    }
}
