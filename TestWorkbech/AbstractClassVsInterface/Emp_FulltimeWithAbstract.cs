using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    public class Emp_FulltimeWithAbstract:EmployeeAbstract      
    {
        public override string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public override string FirstName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public override string LastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        //common methods that are implemented 
        //in the abstract class

        public new String Delete()
        {
            return base.Delete();
        }
        //common methods that are implemented 


        //in the abstract class

        public new String Search()
        {
            return base.Search();
        }
        //common methods that are implemented 


        //in the abstract class

        public new String Update()
        {
            return base.Update();
        }

        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore I override it here.
        public override String CalculateWage()
        {
            return "Full time employee " +
                  base.fname + " is calculated " +
                  "using the Abstract class...";
        }
    }
}
