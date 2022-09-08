using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Aspirant : Student
    {
        string work;
        double averageMark;
        public Aspirant(string firstName, string lastName, string group, double averageMark, string work) : base(firstName, lastName, group, averageMark)
        {
            this.work = work;
        }
        public int getScholarship()
        {
            if (averageMark == 5)
            {
                return 20000;
            }
            else
            {
                return 18000;
            }
        }
    }
}

