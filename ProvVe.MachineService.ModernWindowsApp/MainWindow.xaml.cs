using ProvVe.MachineService.ModernWindowsApp.DeviceService;
using System.Windows;
using System.Linq;

namespace ProvVe.MachineService.ModernWindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnCallWcf_Click(object sender, RoutedEventArgs e)
        {
            IDeviceService client = new DeviceServiceClient("NetTcpTest");

            //ResetRequest request = new ResetRequest(6, "igord");
            //request.ApplicationName = "Modern WPF";
            //request.ClientVersion = Assembly.GetExecutingAssembly().GetName().Version;
            //request.Username = "igord";

            //ResetResponse response = await client.ResetAsync(request);
            //var version = response.ServerVersion;
            //var ts = response.Interval;
            //MessageBox.Show(response.Success.ToString());

            //DateTime today2 = await client.PingAsync();
            //MessageBox.Show(today2.ToString());

            OpenPortRequest request2 = new OpenPortRequest();
            request2.PortName = Ports.COM4;
            request2.Protocol = "serial";
            request2.Filename = "C:\\Windows\\System32\\kernel32.dll";
            OpenPortResponse response2 = await client.OpenPortAsync(request2);

            if (response2.Success)
            {

            }

            GetMachinesRequest request3 = new GetMachinesRequest();
            var response3 = await client.SearchMachinesAsync(request3);
            var list = response3
                .OrderByDescending(r => r.WorkHours)
                .Take(3)
                .ToList();
        }
    }
}