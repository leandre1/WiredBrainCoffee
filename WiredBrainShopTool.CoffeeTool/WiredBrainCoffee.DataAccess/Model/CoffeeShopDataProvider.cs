using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShop()
        {
            yield return new CoffeeShop() { BeansInStockInKgs = 100, Locations = "Frankfurt" };
            yield return new CoffeeShop() { BeansInStockInKgs = 50, Locations = "Brussels" };
            yield return new CoffeeShop() { BeansInStockInKgs = 150, Locations = "Paris" };
        }
    }
}
