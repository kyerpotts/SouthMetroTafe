using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdas
{
    class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //automatic properties - compiler makes private backing field for you.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

}
