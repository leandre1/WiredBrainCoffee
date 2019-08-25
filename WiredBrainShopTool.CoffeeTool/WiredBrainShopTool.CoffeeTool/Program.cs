using System;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainShopTool.CoffeeTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Info Tool!");

            Console.WriteLine("Type help to see available coffee shop, and quit to exit!");

            var data = new CoffeeShopDataProvider();
            var line = Console.ReadLine();
            bool valid = true;
            while (valid)
            {
               

                if (string.Equals("help",line, StringComparison.OrdinalIgnoreCase))
                {
                    var coffeeShops = data.LoadCoffeeShop();
                    Console.WriteLine("Available coffee shops!");
                    foreach (var shop in coffeeShops)
                    {
                        Console.WriteLine($"> {shop.Locations}");

                    }
                    Console.ReadLine();
                    
                }
                
               
            }
          






        }
    }
}
