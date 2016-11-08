using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Add you test of the Employee class and derived classes here
            Worker Jens = new Worker("truck driver", "maintenance", "Jens", 15000);
            Manager Martin = new Manager("Martin", 25000, 185, 20000);
            Console.WriteLine(Martin.GetSalaryPerMonth());

            Director hansie = new Director("Hansie", 30000, 200);
            hansie.GetSalaryPerMonth();
            Console.WriteLine(hansie.GetSalaryPerMonth());

            // The LAST line of code should be ABOVE this line
        }
    }
}
