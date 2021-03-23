using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kyer Potts
//30003389
namespace GamesStore
{
    [Serializable]
    class Customer
    {
        private string custID;
        private string surname;
        private string firstname;
        private string email;

        public Customer(string custID, string surname, string firstname, string email)
        {
            setCustID(custID);
            setSurname(surname);
            setFirstName(firstname);
            setEmail(email);
        }

        public void setCustID(string custID)
        {
            this.custID = custID;
        }

        public string getCustID()
        {
            return custID;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return surname;
        }

        public void setFirstName(string firstname)
        {
            this.firstname = firstname;
        }

        public string getFirstName()
        {
            return firstname;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }
    }
}
