using ProvVe.MachineService.WindowsApp.DeviceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProvVe.MachineService.WindowsApp
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

        private void btnCallWcf_Click(object sender, RoutedEventArgs e)
        {
            int id1 = Thread.CurrentThread.ManagedThreadId;

            DeviceServiceClient client = new DeviceServiceClient("BasicHttpBinding_IDeviceService");
            client.PingCompleted += (s2, e2) => {
                int id2 = Thread.CurrentThread.ManagedThreadId;

                if (e2.Error == null)
                {
                    MessageBox.Show(e2.Result.ToString());
                }
            };
            client.PingAsync();

            //var today = client.Ping();
            //MessageBox.Show(today.ToString());
        }
    }
}