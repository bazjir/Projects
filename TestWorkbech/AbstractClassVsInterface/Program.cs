using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    /// <summary>
    /// Resource: http://www.codeproject.com/Articles/11155/Abstract-Class-versus-Interface
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Abstract Class
            EmployeeAbstract emp = new Emp_FulltimeWithAbstract();
            emp.ID = "123";
            emp.LastName = "İpekyüz";
            emp.FirstName = "Baz Jir";


            // Interface
            IEmployee empWithInterface = new Emp_fulltime2();
            empWithInterface.ID = "123";
            empWithInterface.LastName = "İpekyüz";
            empWithInterface.FirstName = "Baz";


            // Base
            EmployeeBase empWithBase = new Emp_FullTimeWithBase();
            empWithBase.ID = 123;
            empWithBase.FullName = "Baz Jir İpekyüz";

            Console.WriteLine(emp.CalculateWage());

            Console.WriteLine(empWithInterface.CalculateWage());

            Console.WriteLine(empWithBase.Details());

            Console.Read();
        }
    }
}
