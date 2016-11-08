using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Manager:Employee
    {
        private int nrOfWorkingHours;
        private int monthlyBonus;

        public Manager(string navn, int salary, int nrOfworkingHours, int monthlyBonus):base(navn, salary)
        {
            this.nrOfWorkingHours = nrOfworkingHours;
            this.monthlyBonus = monthlyBonus;
        }

        public override int GetSalaryPerMonth()
        {
            if (nrOfWorkingHours >= 180)
            {
                return base.GetSalaryPerMonth() + monthlyBonus;
            }
            return base.GetSalaryPerMonth();
        }
    }
}
