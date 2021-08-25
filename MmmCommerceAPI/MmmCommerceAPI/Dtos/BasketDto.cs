using MmmCommerceAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Dtos
{
    public class BasketDto
    {
        public Guid BasketId { get; set; }
        public List<StockDto> Items { get; set; }
        public double Subtotal { get; set; }
        public DiscountType DiscountType { get; set; }
        public double Discount { get; set; }
        public double Total { get => DiscountType == DiscountType.Percentage ? Subtotal / Discount : Subtotal - Discount; }
    }
}
