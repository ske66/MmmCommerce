using Microsoft.AspNetCore.Mvc;
using MmmCommerceAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Controllers
{
    public class BasketController : Controller
    {

        [HttpPost("{basket_id}")]
        public ActionResult<BasketDto> AddItemToBasket(Guid basketId, [FromQuery] Guid stockId)
        {
            //get basket by ID then add item, return Basket DTO;
            //get product by Id, change reserved to true, and add it to basket

            var stock = new StockDto { StockId = Guid.NewGuid(), Size = "Medium", Color = "Blue", Reserved = true };

            return new BasketDto { BasketId = basketId, Discount = 0.2, DiscountType = Enums.DiscountType.Percentage, Items = new List<StockDto> { stock } };
        }
    }
}
