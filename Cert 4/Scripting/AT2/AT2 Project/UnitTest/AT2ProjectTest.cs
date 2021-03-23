using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AT2_Project;

namespace UnitTest
{
    [TestClass]
    public class AT2ProjectTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Tests to see whether buzzer works correctly when maxTemp values are generated
            string cmbTempMaxText = "27";
            double maxTemp = 40.0;

            if (cmbTempMaxText == "18") //If combobox text = 18
            {
                maxTemp = 18.0; // sets maxTemp 25.0
            }
            else if (cmbTempMaxText == "21") //If combobox text = 21
            {
                maxTemp = 21.0; // sets maxTemp 21.0
            }
            else if (cmbTempMaxText == "24") //If combobox text = 24
            {
                maxTemp = 24.0; // sets maxTemp 24.0
            }
            else if (cmbTempMaxText == "27") //If combobox text = 27
            {
                maxTemp = 27.0; // sets maxTemp 27.0
            }

            double currentTemp = 30.0;
            if (currentTemp > maxTemp) // if currentTemp > maxTemp (max temperature set)
            {
                Console.WriteLine("106");//Print 106 to Arduino case control
            }

            // Testing Mood Light Button Click code/algorithms
            //Red Radio Button Selected
            Console.WriteLine("102");//Print 102 to Arduino case control


            //Green Radio Button Selected
            Console.WriteLine("103");//Print 102 to Arduino case control


            //Blue Radio Button Blue Selected
            Console.WriteLine("104");//Print 103 to Arduino case control


            //OFF Radio Button Selected
            Console.WriteLine("105");//Print 104 to Arduino case control
        }
    }
}
