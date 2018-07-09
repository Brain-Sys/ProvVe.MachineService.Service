using ProvVe.MachineService.ConsoleApp.DeviceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvVe.MachineService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Si trova nel namespace che abbiamo scelto in fase di "Add Service Reference"
            // Ha come suffisso "Client"
            // Il nome della classe è composto da Namespace + *Client (?)
            var client = new DeviceServiceClient();
            DateTime today = client.Ping();

            Console.WriteLine(today.ToString());
            Console.ReadLine();
        }
    }
}