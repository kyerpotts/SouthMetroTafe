using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesAndLambdas
{
    public partial class Form1 : Form
    {
        private delegate bool Match(Employee e1, Employee e2);



        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Employee tom = new Employee("Tom", "Jones");
            Employee tomS = new Employee("Tom", "Smith");

            Match matcher = SameFirstName;

            //MessageBox.Show("Same first name is " + matcher(tom, tomS));
            //A lambda expression can be used to define a delegate's method
            matcher = (a, b) => a.LastName == b.LastName;

            //MessageBox.Show("Same last name is " + matcher(tom, tomS));

            Compare(tom, tomS, SameFirstName);
            Compare(tom, tomS, matcher);

            tom.Department = "Accounting";
            tomS.Department = "Accounting";

            Compare(tom, tomS, (x, y) => x.Department == y.Department);

        }

        private bool SameFirstName (Employee e1, Employee e2)
        {
            return e1.FirstName == e2.FirstName;
        }

        private void Compare(Employee e1, Employee e2, Match matcher)
        {
            if (matcher(e1, e2))
            {
                MessageBox.Show("Employees match according to delegate");
            }
            else
            {
                MessageBox.Show("Employees do NOT match according to delegate");
            }
        }
    }
}
