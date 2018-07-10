using ProvVe.MachineService.ModernWindowsApp.DeviceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            IDeviceService client = new DeviceServiceClient();

            ResetRequest request = new ResetRequest(6, "igord");
            ResetResponse response = await client.ResetAsync(request);
            MessageBox.Show(response.Success.ToString());

            DateTime today2 = await client.PingAsync();
            MessageBox.Show(today2.ToString());

            OpenPortRequest request2 = new OpenPortRequest();
            request2.PortName = Ports.COM4;
            request2.Protocol = "serial";
            OpenPortResponse response2 = await client.OpenPortAsync(request2);

        }
    }
}