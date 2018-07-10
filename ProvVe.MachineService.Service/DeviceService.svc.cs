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
    public class DeviceService :
        IDeviceService,
        IDisposable
    {
        private void debug()
        {
#if DEBUG
            Thread.Sleep(2000);
#endif
        }

        public DateTime Ping()
        {
            debug();
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
            response.Interval = cron.Elapsed;

            return response;
        }

        public IQueryable<MachineDto> SearchMachines(GetMachinesRequest input)
        {
            List<MachineDto> result = new List<MachineDto>();

            // Su DB

            return result.AsQueryable();
        }
    }
}