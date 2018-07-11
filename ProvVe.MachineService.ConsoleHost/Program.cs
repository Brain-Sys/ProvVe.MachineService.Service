using ProvVe.MachineService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
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

            // NetTcpBinding

            //Type bindingType = Type.GetType("System.ServiceModel.NetTcpBinding, System.ServiceModel");
            //Binding bnd = Activator.CreateInstance(bindingType) as Binding;
            //host.AddServiceEndpoint(
            //    typeof(IDeviceService),
            //    new NetTcpBinding(),
            //    "net.tcp://TRAPPIST/DeviceService.svc");

            host.AddServiceEndpoint(
                typeof(IDeviceService),
                new WSDualHttpBinding(),
                "http://localhost:54321");

            //var user = new ServiceAuthenticationManager();
            //host.Authentication.ServiceAuthenticationManager = user;
            host.Opened += Host_Opened;
            host.Closed += (s, e) => { };
            host.UnknownMessageReceived += Host_UnknownMessageReceived;

            foreach (var item in host.Description.Endpoints)
            {
                
            }

            host.Open();
            Console.WriteLine("WCF started...");
            Console.ReadLine();
            host.Close();
            host = null;
        }

        private static void Host_UnknownMessageReceived(object sender,
            UnknownMessageReceivedEventArgs e)
        {
            Message msg = e.Message;
            MessageHeaders headers = msg.Headers;
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Un nuovo client si è connesso...");
        }
    }
}