using Microsoft.AspNetCore.Mvc;
using MmmCommerceAPI.Dtos;
using MmmCommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MmmCommerceAPI.Controllers
{
    public class StockController : Controller
    {

        [HttpPost]
        public ActionResult<StockDto> AddStock(StockDto stock)
        {
            return new StockDto();
        }
    }
}
