using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Models
{
    public class StockModel
    {
        public Guid Id { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public bool Reserved { get; set; }
    }
}
