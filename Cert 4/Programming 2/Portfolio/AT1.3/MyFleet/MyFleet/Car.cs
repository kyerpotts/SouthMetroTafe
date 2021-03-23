using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFleet
{
    class Car: Vehicle
    {
        //Car class fields
        private string _bodyType;

        //default constructor, sets intial values for child Boat fields
        public Car()
        {
            _bodyType = "";
        }
        //Overloaded constructor that takes data from textbox controls from Form
        public Car(string make, string model, int year, string bodyType)
        {
            _make = make;
            _model = model;
            _year = year;
            _bodyType = bodyType;
        }

        //Accessors for Boat fields until next comment
        public string getBodyType()
        {
            return _bodyType;
        }
        public void setBodyType(string bodyType)
        {
            _bodyType = bodyType;
        }

        //Overridden method that allows Airplane fields to be access from within arrays of Vehicle class type
        public override string  Display()
        {
            return (_make + ", " + _model + ", " + _year + ", " + _bodyType);
        }
    }
}
