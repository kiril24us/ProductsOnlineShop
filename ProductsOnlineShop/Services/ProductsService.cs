﻿using Newtonsoft.Json;
using ProductsOnlineShop.Models;
using ProductsOnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProductsOnlineShop.Services
{
    public class ProductsService : IProductsService
    {
        public T ProductsInfo<T>()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\Кирил\source\repos\ProductsOnlineShop\ProductsOnlineShop\wwwroot\lib\Products.json\productsInformation.json");
            var products = JsonConvert.DeserializeObject<T>(json);
            return products;
        }
    }
}
