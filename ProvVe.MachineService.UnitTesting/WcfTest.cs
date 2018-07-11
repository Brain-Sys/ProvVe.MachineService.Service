using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvVe.MachineService.UnitTesting.DeviceService;

namespace ProvVe.MachineService.UnitTesting
{
    [TestClass]
    public class WcfTest
    {
        static IDeviceService client;

        [ClassInitialize]
        public static void PrimaDiTutti_i_Test(TestContext context)
        {
            client = new DeviceService.DeviceServiceClient();
        }

        [TestMethod]
        public void Test_metodo_remoto_Ping()
        {
            DateTime dt = client.Ping();
            Assert.AreNotEqual(DateTime.MinValue, dt);
            Assert.AreEqual(DateTime.Now.Day, dt.Day);
        }
    }
}