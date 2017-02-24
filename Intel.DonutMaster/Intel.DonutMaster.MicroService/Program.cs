using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Intel.DonutMaster.MicroService
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DonutMaster Started!");

            // TODO

            HostFactory.Run(config =>
            {
                config.Service<IService>(sc =>
                {
                    sc.ConstructUsing(() => new Service());

                    sc.WhenStarted(s => s.Start());

                    sc.WhenStopped(s => s.Stop());
                });


                config.RunAsLocalSystem();

                config.SetServiceName("DonutMaster");
                config.SetDescription("Donut Master Micro Service");

                config.StartAutomatically();


            });

        }
    }
}
