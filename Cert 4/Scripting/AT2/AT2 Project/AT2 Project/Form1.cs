/*
    Kyer Potts
    30003389
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//IO namespace required for interface.

namespace AT2_Project
{
    public partial class ArduinoControlSuite_V1 : Form
    {
        public SerialPort myPort;
        public string[] comPorts;
        public int[] maxTemps;
        public double maxTemp;
        public bool on;

        public ArduinoControlSuite_V1()
        {
            InitializeComponent();

            maxTemps = new int[4] { 18, 21, 24, 27 };//Add maxtemp dropdown choices to maxTemps array for combobox
            maxTemp = 40.0;//Set initial maxTemp to 40.0
            on = false;//Initialist on to 'false' for red LED
            Init();//Runs all prelimiary code to create connection and generate selections for connection combobox

            //Adds maxtemp combobox dropdown choices to dropdownbox selection
            foreach (int t in maxTemps)
            {
                cmbTempMax.Items.Add(t);
            }
        }

        public void Init()//Method to handle all Serial Port connection data
        {
            try 
            {
                comPorts = SerialPort.GetPortNames(); //Collect all available Serial Ports
                GetComPorts(comPorts); //add Port data to cmbComPort combo Box
                myPort = new SerialPort(); //Create new SerialPort object
                myPort.BaudRate = 9600; //set BaudRate to '9600'
                myPort.PortName = "notSelected"; //Set PortName to "notSelected"
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a COM Port.", "Select COM Port", MessageBoxButtons.OK, MessageBoxIcon.Information);//Displays message box if incorrect selection is entered
            }
        }

        //Data read in method for Arduino
        public void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line1 = myPort.ReadLine();//Read in firstLine from Arduino
            string line2 = myPort.ReadLine();//Read in firstLine from Arduino
            string line3 = myPort.ReadLine();//Read in firstLine from Arduino

            BeginInvoke(new LineReceivedEvent(LineReceivedOST), line1);//LineReceivedEvent object passing line1
            BeginInvoke(new LineReceivedEvent(LineReceivedIST), line2);//LineReceivedEvent object passing line2
            BeginInvoke(new LineReceivedEvent(LineReceivedISH), line3);//LineReceivedEvent object passing line3

        }

        //Creates LineReceivedEvent method to be used by Read in method
        private delegate void LineReceivedEvent(string line);

        //Method to receive and display line1 outside temp data
        private void LineReceivedOST(string line)
        {
            double tempC = 0;
            tempC = double.Parse(line);
            tempC = (tempC * 500) / 1023;
            tbOutsideTemp.Text = String.Format("{0:0.00}", tempC);
        }

        //Method to receive and display inside temp data
        private void LineReceivedIST(string line)
        {
            string insTemp = line;
            tbInsideTemp.Text = insTemp;
        }

        //Method to recieve and display inside humidity data
        private void LineReceivedISH(string line)
        {
            string insHum = line;
            tbInsideHumidity.Text = insHum;
        }

        //Method to add all available Serial Ports to cmbComPort
        public void GetComPorts(string[] array)
        {
            foreach (string a in array)
            {
                cmbComPort.Items.Add(a);
            }
        }

        //Button to connect to selected COM port
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.PortName = cmbComPort.Text;
                myPort.Open();
                myPort.DataReceived += myPort_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a COM Port.", "Select COM Port", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Red Led Toggle control
        private void btnRedLedToggle_Click(object sender, EventArgs e)
        {
            if (!on) //if button is not on
            {
                myPort.WriteLine("100"); //Write 100 to arduino for switch case
                on = true; // set on to true
            }
            else // if on is true
            {
                myPort.WriteLine("101"); //Write 101 to arduino for switch case
                on = false; // set on to false
            }
        }

        //Red Radio button clicked
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            myPort.WriteLine("102");//Write 102 to arduino for switch case
        }
        //Green Radio button clicked
        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            myPort.WriteLine("103");//Write 103 to arduino for switch case
        }
        //Blue Radio button clicked
        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            myPort.WriteLine("104");//Write 104 to arduino for switch case
        }
        //Off Radio button clicked
        private void radOff_CheckedChanged(object sender, EventArgs e)
        {
            myPort.WriteLine("105");//Write 105 to arduino for switch case
        }

        //Sets max temp from dropdown box and rings buzzer if current temp exceeds max temp
        private void btnTempMax_Click(object sender, EventArgs e)
        {
            if (cmbTempMax.Text == "18")
            {
                maxTemp = 18.0;
            }
            else if (cmbTempMax.Text == "21")
            {
                maxTemp = 21.0;
            }
            else if (cmbTempMax.Text == "24")
            {
                maxTemp = 24.0;
            }
            else if (cmbTempMax.Text == "27")
            {
                maxTemp = 27.0;
            }
            else
            {
                MessageBox.Show("Please select a maximum temperature.", "Select Max Temp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Rings buzzer if current inside temp exceeds max temp
            double currentTemp = double.Parse(tbInsideTemp.Text);
            if (currentTemp > maxTemp)
            {
                myPort.WriteLine("106");
            }
        }
    }
}
