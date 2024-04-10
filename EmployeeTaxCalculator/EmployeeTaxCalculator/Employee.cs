using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaxCalculator
{
    internal class Employee
    {
        private string lastName; //Last name of employee
        private int payType; //Hourly or monthly pay, 0 for hourly, 1 for monthly
        private double payRate; //Pay rate of employee

        public string LastName
        {
            get { return lastName;  }
            set { lastName = value; }
        }

        public int PayType
        {
            get { return payType; }
            set { payType = value; }
        }

        public double PayRate 
        { 
            get { return payRate; }
            set { payRate = value; }
        }
    }
}
