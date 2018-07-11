using ProvVe.MachineService.WinAppCallback.DeviceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace ProvVe.MachineService.WinAppCallback
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DeviceService.DeviceServiceClient client;
        AlarmCallback callback;

        public MainWindow()
        {
            InitializeComponent();
            callback = new AlarmCallback();
            var instanceContext = new InstanceContext(callback);
            client = new DeviceServiceClient(instanceContext);
        }
    }

    public class AlarmCallback : IDeviceServiceCallback
    {
        public NewAlarmOccurredResponse NewAlarmOccured(NewAlarmOccurredRequest request)
        {
            int alarmCount = request.Count;
            return null;
        }
    }
}
