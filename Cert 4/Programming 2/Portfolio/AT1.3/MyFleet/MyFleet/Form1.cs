using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFleet
{
    public partial class MyFleet : Form
    {
        public MyFleet()
        {
            InitializeComponent();
        }
        //Creates array of parent Vehicle Class type and sets intial values for the size of the array and the item counter for the array
        private static int arraySize = 20;
        private int counter = 0;
        Vehicle[] vehicleArray = new Vehicle[arraySize];

        //Clears all textbox controls of user input data
        public void ClearTBs()
        {
            tbMake.Clear();
            tbModel.Clear();
            tbYear.Clear();
            tbNumEngines.Clear();
            tbEngineType.Clear();
            tbLength.Clear();
            tbHullType.Clear();
            tbBodyType.Clear();
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "airplane" using the default constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "airplane" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnAddAirplane_Click(object sender, EventArgs e)
        {
            try
            {
                if(counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Airplane airplane = new Airplane();
                    airplane.setMake(tbMake.Text);
                    airplane.setModel(tbModel.Text);
                    airplane.setYear(int.Parse(tbYear.Text));
                    airplane.setNumEngines(int.Parse(tbNumEngines.Text));
                    airplane.setEngineType(tbEngineType.Text);
                    vehicleArray[counter] = airplane;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "airplane" using the overloaded constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "airplane" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnOverloadedAirplane_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Airplane airplane = new Airplane(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), int.Parse(tbNumEngines.Text), tbEngineType.Text);
                    vehicleArray[counter] = airplane;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "boat" using the default constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "boat" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boat boat = new Boat();
                    boat.setMake(tbMake.Text);
                    boat.setModel(tbModel.Text);
                    boat.setYear(int.Parse(tbYear.Text));
                    boat.setLength(tbLength.Text);
                    boat.setHullType(tbHullType.Text);
                    vehicleArray[counter] = boat;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "boat" using the overloaded constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "boat" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnOverloadedBoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boat boat = new Boat(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), tbLength.Text, tbHullType.Text);
                    vehicleArray[counter] = boat;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "car" using the default constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "car" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Car car = new Car();
                    car.setMake(tbMake.Text);
                    car.setModel(tbModel.Text);
                    car.setYear(int.Parse(tbYear.Text));
                    car.setBodyType(tbBodyType.Text);
                    vehicleArray[counter] = car;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        //Checks the current number of iterations within the array against the maximum array size
        //Creates instance of "car" using the overloaded constructor and passes values from textbox controls 
        //Initialises iteration of vehicleArray based on counter value with instance of "car" with collected textbox values
        //Displays the collected values int the Output listbox with the overriden Display() method
        //Clears Textboxes of user entered data
        //Increments counter for next iteration
        private void btnOverloadedCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter > arraySize)
                {
                    MessageBox.Show("List full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Car car = new Car(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), tbBodyType.Text);
                    vehicleArray[counter] = car;
                    lstOutput.Items.Add(vehicleArray[counter].Display());
                    ClearTBs();
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }
    }
}
