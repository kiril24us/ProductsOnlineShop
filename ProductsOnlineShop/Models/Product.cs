using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsOnlineShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public string ImageUrl { get; set; }

        [JsonConverter(typeof(InvalidDataFormatJsonConverter))]
        public DateTime DeliveryOn { get; set; }
    }
}
