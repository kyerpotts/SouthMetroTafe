using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFleet
{
    class Boat: Vehicle
    {
        //Boat class fields
        private string _length;
        private string _hullType;

        //default constructor, sets intial values for child Boat fields
        public Boat()
        {
            _length = "";
            _hullType = "";
        }
        //Overloaded constructor that takes data from textbox controls from Form
        public Boat(string make, string model, int year, string length, string hullType)
        {
            _make = make;
            _model = model;
            _year = year;
            _length = length;
            _hullType = hullType;
        }

        //Accessors for Boat fields until next comment
        public string getLength()
        {
            return _length;
        }
        public void setLength(string length)
        {
            _length = length;
        }
        public string getHullType()
        {
            return _hullType;
        }
        public void setHullType(string hullType)
        {
            _hullType = hullType;
        }

        //Overridden method that allows Airplane fields to be access from within arrays of Vehicle class type
        public override string Display()
        {
            return (_make + ", " + _model + ", " + _year + ", " + _length + ", " + _hullType);
        }
    }
}
