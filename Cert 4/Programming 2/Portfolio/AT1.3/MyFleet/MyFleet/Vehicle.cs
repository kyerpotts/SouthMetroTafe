using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFleet
{
    class Vehicle
    {
        //fields to be shared by all subclasses
        protected string _make;
        protected string _model;
        protected int _year;

        //default constructor, sets intial values for parent Vehicle class fields
        public Vehicle()
        {
            _make = "";
            _model = "";
            _year = 0;
        }

        //Accessors for Vehicle parent class until next comment
        public string getMake()
        {
            return _make;
        }
        public void setMake(string make)
        {
            _make = make;
        }
        public string getModel()
        {
            return _model;
        }
        public void setModel(string model)
        {
            _model = model;
        }
        public int getYear()
        {
            return _year;
        }
        public void setYear(int year)
        {
            _year = year;
        }

        //display method that allows subclass methods to override and access their fields from within the array 
        public virtual string Display()
        {
            return (_make + ", " + _model + ", " + _year);
        }
    }
}
