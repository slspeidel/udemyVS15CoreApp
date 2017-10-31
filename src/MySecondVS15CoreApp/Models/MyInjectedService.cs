using MySecondVS15CoreApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondVS15CoreApp.Models
{
    public class MyInjectedService : IMyInjectedService
    {
        public Guid MyGuid { get; set; }

        public MyInjectedService()
        {
            this.MyGuid = Guid.NewGuid();
        }
    }
}
