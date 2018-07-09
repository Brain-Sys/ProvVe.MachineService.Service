﻿using System;
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
            DeviceService.DeviceServiceClient client = new DeviceService.DeviceServiceClient();

            // Sincrona, da evitare nella UI :-S
            // DateTime today1 = client.Ping();

            DateTime today2 = await client.PingAsync();
            MessageBox.Show(today2.ToString());
        }
    }
}