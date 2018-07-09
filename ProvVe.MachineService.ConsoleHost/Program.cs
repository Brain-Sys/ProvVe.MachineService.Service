using ProvVe.MachineService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost
                (typeof(DeviceService),
                new Uri("http://localhost:12345"));

            host.Open();
            Console.WriteLine("WCF started...");
            Console.ReadLine();
            host.Close();
            host = null;
        }
    }
}