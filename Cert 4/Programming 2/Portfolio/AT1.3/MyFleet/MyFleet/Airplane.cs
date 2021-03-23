using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFleet
{
    class Airplane: Vehicle
    {
        //Airplane class fields
        private int _numEngines;
        private string _engineType;

        //default constructor, sets intial values for child Airplane fields
        public Airplane()
        {
            _numEngines = 0;
            _engineType = "";
        }
        //Overloaded constructor that takes data from textbox controls from Form
        public Airplane(string make, string model, int year, int numEngines, string engineType)
        {
            _make = make;
            _model = model;
            _year = year;
            _numEngines = numEngines;
            _engineType = engineType;
        }

        //Accessors for Airplane fields until next comment
        public int getNumEngines()
        {
            return _numEngines;
        }
        public void setNumEngines(int numEngines)
        {
            _numEngines = numEngines;
        }
        public string getEngineType()
        {
            return _engineType;
        }
        public void setEngineType(string engineType)
        {
            _engineType = engineType;
        }

        //Overridden method that allows Airplane fields to be access from within arrays of Vehicle class type
        public override string Display()
        {
            return (_make + ", " + _model + ", " + _year + ", " + _numEngines + ", " + _engineType);
        }
    }
}
