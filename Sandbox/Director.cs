using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Director : Manager
    { 
        public Director(string navn, int salary, int noOfworkingHours)
            : base(navn, salary, noOfworkingHours, 20000)
        {
            
        }

    }
}
