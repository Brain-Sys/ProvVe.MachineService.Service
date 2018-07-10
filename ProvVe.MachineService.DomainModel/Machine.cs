using System;

namespace ProvVe.MachineService.DomainModel
{
    public class Machine
    {
        public string Code { get; set; }
        public Customer Customer { get; set; }
        public double WorkHours { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}