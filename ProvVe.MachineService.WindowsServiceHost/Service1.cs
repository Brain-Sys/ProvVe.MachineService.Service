using ProvVe.MachineService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.WindowsServiceHost
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost host;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(IDeviceService));
            host.Opening += Host_Opening;
            host.Opened += Host_Opened;
            host.Faulted += Host_Faulted;
            host.Open();
        }

        private void Host_Faulted(object sender, EventArgs e)
        {
            
        }

        private void Host_Opened(object sender, EventArgs e)
        {
            
        }

        private void Host_Opening(object sender, EventArgs e)
        {
            
        }

        protected override void OnStop()
        {
            host.Close();
        }

        protected override void OnContinue()
        {
            base.OnContinue();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }
    }
}
