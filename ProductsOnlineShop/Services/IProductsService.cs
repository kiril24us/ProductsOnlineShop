using ProductsOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsOnlineShop.Services
{
    public interface IProductsService
    {
        T ProductsInfo<T>();
    }
}
