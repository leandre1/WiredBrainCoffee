using System;
using System.Linq;
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
               if(string.Equals("quit",line,StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (string.Equals("help",line, StringComparison.OrdinalIgnoreCase))
                {
                    var coffeeShops = data.LoadCoffeeShop();
                    Console.WriteLine("Available coffee shops!");
                    foreach (var shop in coffeeShops)
                    {
                        Console.WriteLine($"> {shop.Locations}");

                    }
                    
                }
                else
                {
                    var foundCoffeeShops = data.LoadCoffeeShop()
                        .Where(x => x.Locations.StartsWith(line, StringComparison.OrdinalIgnoreCase));
                    if(foundCoffeeShops.Count() == 0)
                    {
                        Console.WriteLine($"> No such {line} found!");
                    }
                    else if(foundCoffeeShops.Count() == 1)
                    {
                       var shop = foundCoffeeShops.Single();
                        Console.WriteLine($"> {shop.Locations}");
                        Console.WriteLine($"> beans in stock in  {shop.BeansInStockInKgs} kg");
                    }
                    else
                    {
                        Console.WriteLine("> multiple coffee shops found!");
                        foreach (var shop in foundCoffeeShops)
                        {
                            Console.WriteLine($"> {shop.Locations}");
                        }

                    }
                }
              line =  Console.ReadLine();
            }
            
          






        }
    }
}
