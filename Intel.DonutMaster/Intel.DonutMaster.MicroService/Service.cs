using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.MicroService
{

    public interface IService
    {
        void Start();

        void Stop();
    }

    public class Service : IService
    {
        private IDisposable webapp;

        public void Start()
        {
            string address = "http://localhost:5010";

            webapp = WebApp.Start<Startup>(address);
        }

        public void Stop()
        {
            webapp.Dispose();

        }
    }
}
