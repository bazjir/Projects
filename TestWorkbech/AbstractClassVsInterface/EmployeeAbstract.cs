using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{
    public abstract class EmployeeAbstract
    {
        //in the Abstract class

        protected String id;
        protected String lname;
        protected String fname;


        //properties
        public abstract String ID
        {
            get;
            set;
        }

        public abstract String FirstName
        {
            get;
            set;
        }

        public abstract String LastName
        {
            get;
            set;
        }


        //completed methods
        public String Update()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " updated";
        }

        public String Add()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " added";
        }

        public String Delete()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }

        public String Search()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " found";
        }



        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore i keep it uncompleted and 
        //let each implementation 
        //complete it the way they calculate the wage.
        public abstract String CalculateWage();

    }
}
