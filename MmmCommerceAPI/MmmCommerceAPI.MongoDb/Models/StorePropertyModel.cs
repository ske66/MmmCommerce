using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Models
{
    public class StorePropertyModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Currency { get; set; }
        public List<string> DeliveryZones { get; set; }
        public bool isOpen { get; set; }
    }
}
