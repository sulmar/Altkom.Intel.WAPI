using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.MicroService
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DonutMaster Started!");

            // TODO

            string address = "http://localhost:5010";

            using (var webapp = WebApp.Start<Startup>(address))
            {
                Console.WriteLine("Press any key to exit.");

                Console.ReadKey();
            }

        }
    }
}
