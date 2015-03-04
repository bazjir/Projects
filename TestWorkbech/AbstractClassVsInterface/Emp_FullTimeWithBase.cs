using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    public class Emp_FullTimeWithBase:EmployeeBase
    {


        public new string FullName { get; set; }

        public override string Details()
        {
            return ID + " " + FullName + " From SubClass";
        }
    }
}
