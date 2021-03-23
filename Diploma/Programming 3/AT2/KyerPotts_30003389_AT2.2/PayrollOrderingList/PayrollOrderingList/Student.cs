using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollOrderingList
{
    class Student : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }

        public Student (int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            Student compareToObj = (Student)obj;

            return this.id.CompareTo(compareToObj.id);
        }
    }
}
