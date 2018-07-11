using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using ProvVe.MachineService.Interfaces;
using ProvVe.MachineService.NetworkMessages.Dto;
using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;

namespace ProvVe.MachineService.Service
{
    // PerCall : viene creata un'istanza ad ogni chiamata, meno performante ma stateless
    // Single : istanza globale, singleton, con memoria
    // PerSession : istanza dedicata a ciascun proxy connesso dal client
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    //[ServiceContract(CallbackContract = typeof(IAlarmNotifier))]
    public class DeviceService :
        IDeviceService,
        IDisposable
    {
        Timer timer;
        int pingCountFromClient = 0;
        Guid uniqueId;
        Random rnd = new Random((int)DateTime.Now.Ticks);

        public DeviceService()
        {
            timer = new Timer(tick, null, 1000, 10000);
            uniqueId = Guid.NewGuid();
        }

        // "Battito" del timer
        private void tick(object parameter)
        {
            try
            {
                OperationContext ctx = OperationContext.Current;

                if (ctx != null)
                {
                    IAlarmNotifier channel = OperationContext.Current.GetCallbackChannel<IAlarmNotifier>();
                    channel.NewAlarmOccured(new NewAlarmOccurredRequest()
                    {
                        Count = rnd.Next(0, 20)
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void debug()
        {
#if DEBUG
            Thread.Sleep(2000);
#endif
        }

        public DateTime Ping()
        {
            pingCountFromClient++;
            debug();
            Console.WriteLine(pingCountFromClient);

            return DateTime.Now;
        }

        public ResetResponse Reset(ResetRequest input)
        {
            debug();

            ResetResponse response = new ResetResponse();
            response.Success = true;

            return response;
        }

        public void Dispose()
        {
            // Cleanup della memoria / risorse / stream
            Debug.WriteLine(this.uniqueId.ToString());
            Console.WriteLine(this.uniqueId.ToString());
        }

        public OpenPortResponse OpenPort(OpenPortRequest request)
        {
            Stopwatch cron = new Stopwatch();
            cron.Start();

            OpenPortResponse response = new OpenPortResponse();

            try
            {
                // double value = 23.0 / 0.0;
                response.Content = System.IO.File.ReadAllBytes(request.Filename);
                response.Success = true;
            }
            catch (Exception ex)
            {
                //response.Exception = ex;
                response.ExceptionMessage = ex.Message;
                response.Success = false;

                var errDto = new ErrorDto();
                errDto.Message = ex.Message;
                errDto.Severity = 2;
                errDto.StackTrace = ex.StackTrace;
                throw new FaultException<ErrorDto>(errDto,
                    new FaultReason(ex.Message));
            }
            finally
            {
                cron.Stop();
                response.Interval = cron.Elapsed;
            }

            return response;
        }

        public GetMachinesResponse GetMachines(GetMachinesRequest input)
        {
            Stopwatch cron = new Stopwatch();
            cron.Start();

            var response = new GetMachinesResponse();
            //response.Items.FirstOrDefault().Customers.FirstOrDefault().Machines.FirstOrDefault().Customers.FirstOrDefault

            try
            {
                // double value = 23.0 / 0.0;
                response.Success = true;
            }
            catch (Exception ex)
            {
                //response.Exception = ex;
                response.ExceptionMessage = ex.Message;
                response.Success = false;
            }

            cron.Stop();
            response.Interval = cron.Elapsed + TimeSpan.FromMilliseconds(435);

            return response;
        }

        public IQueryable<MachineDto> SearchMachines(GetMachinesRequest input)
        {
            List<MachineDto> result = new List<MachineDto>();

            // Su DB

            return result.AsQueryable();
        }

        public Tuple<string, int, string, DateTime> Call(double request)
        {
            var response = new Tuple<string, int, string, DateTime>
                ("a", 8, "b", DateTime.Now);

            //var x = (name: "a", age: 8, surname: "b", today: DateTime.Now);

            return response;
        }
    }
}