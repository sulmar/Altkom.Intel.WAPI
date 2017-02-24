using Intel.DonutMaster.Interfaces;
using Intel.DonutMaster.RestApiServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Task.Run(()=>GetProductsTest());

            Console.ReadKey();
        }

        private static async Task GetProductsTest()
        {
            IProductsService productsService = new RestApiProductsService();

            var products = await productsService.GetAsync();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
