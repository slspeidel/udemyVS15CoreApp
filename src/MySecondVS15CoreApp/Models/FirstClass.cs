using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondVS15CoreApp.Models
{
    public class FirstClass : IFirstClass
    {
        public string Value { get; set; }
        public FirstClass(string value)
        {
            Value = value;
        }
        public FirstClass()
        {

        }
        
    }
}
