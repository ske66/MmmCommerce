using MmmCommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmCommerceAPI.MongoDb.Models
{
    public class BasketModel
    {
        public List<StockModel> Stock { get; set; }
    }
}
