using ProvVe.MachineService.ModernWindowsApp.DeviceService;
using System.Windows;
using System.Linq;
using System.ServiceModel;
using System;

namespace ProvVe.MachineService.ModernWindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDeviceService client = new DeviceServiceClient("NetTcpTest");

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnCallWcf_Click(object sender, RoutedEventArgs e)
        {
            DateTime today2 = await client.PingAsync();
            MessageBox.Show(today2.ToString());

            //ResetRequest request = new ResetRequest(6, "igord");
            //request.ApplicationName = "Modern WPF";
            //request.ClientVersion = Assembly.GetExecutingAssembly().GetName().Version;
            //request.Username = "igord";

            //ResetResponse response = await client.ResetAsync(request);
            //var version = response.ServerVersion;
            //var ts = response.Interval;
            //MessageBox.Show(response.Success.ToString());

            //OpenPortRequest request2 = new OpenPortRequest();
            //request2.PortName = Ports.COM4;
            //request2.Protocol = "serial";
            //request2.Filename = "C:\\Windows\\System32\\kernel64.dll";

            //try
            //{
            //    OpenPortResponse response2 = await client.OpenPortAsync(request2);
            //}
            //catch (FaultException<ErrorDto> ex)
            //{
            //    int s = ex.Detail.Severity;
            //    string trace = ex.Detail.StackTrace;
            //    MessageBox.Show(ex.ToString());
            //}

            //var tuple = await client.CallAsync(34);


            //var list2 = await client.GetMachinesAsync(new GetMachinesRequest());

            //GetMachinesRequest request3 = new GetMachinesRequest();
            //var response3 = await client.SearchMachinesAsync(request3);
            //var list = response3
            //    .OrderByDescending(r => r.WorkHours)
            //    .Take(3)
            //    .ToList();
        }
    }
}