using ProvVe.MachineService.WindowsApp.DeviceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            DeviceServiceClient client = new DeviceServiceClient();
            client.PingCompleted += Client_PingCompleted;
            client.PingAsync();

            //var today = client.Ping();
            //MessageBox.Show(today.ToString());
        }

        private void Client_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show(e.Result.ToString());
            }
        }
    }
}