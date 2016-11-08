using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private string Skill;
        private string maintenance;
    
        public Worker(string Skill, string maintenance, string name, int salaryPerMonth)
            :base(name, salaryPerMonth)
        {
            this.Skill = Skill;
            this.maintenance = maintenance;

        }
    }
}
