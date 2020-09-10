using ProductsOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsOnlineShop.ViewModels
{
    public class ProductsViewModel
    {
        public IList<Product> products { get; set; }
    }
}
