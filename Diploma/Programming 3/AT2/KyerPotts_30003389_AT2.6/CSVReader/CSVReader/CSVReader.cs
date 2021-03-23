using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;

namespace CSVReader
{
    public partial class CSVReader : Form
    {
        public CSVReader()
        {
            InitializeComponent();
        }

        // List holding all of the record data read in from the .csv file
        List<Titles> records = new List<Titles>();

        // Button method to open .csv file and display the titles in the lstOutput box
        private void btnOpen_Click(object sender, EventArgs e)
        {   
            ReadCSV();
            DisplayList();
        }

        // Button method to save new .csv file with all record data
        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteCSV();
        }

        // Method to read .csv file and save all data in Titles objects
        public void ReadCSV()
        {
            // Identifies the IO and CsvHelper objects that will be used to read the .csv file
            using (var reader = new StreamReader("titles.csv"))
            using (var csv = new CsvReader(reader))
            {
                // Sets the headers from the .csv file
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                // Reads the first line of the .csv file
                csv.Read();
                // Reads the first line of the .csv file as the header
                csv.ReadHeader();
                // Continues to read.csv file line by line until null data
                while (csv.Read())
                {
                    // Creates a new Titles object with id and name values read from .csv file
                    var record = new Titles
                    {
                        id = csv.GetField<int>("id"),
                        name = csv.GetField("name")
                    };
                    // Adds newly created Titles object into List
                    records.Add(record);
                }
            }
        }

        //Method to Write Titles objects saved in records List to new .csv file
        public void WriteCSV()
        {
            // Identifies the IO and CsvHelper objects that will be used to write the .csv file
            using (var writer = new StreamWriter("savedtitles.csv"))
            using (var csv = new CsvWriter(writer))
            {
                // Writes all of the data from the records List to the newly created "savedtitles.csv" file
                csv.WriteRecords(records);
            }
        }

        // Method used to display the record data in the lstOutput box on the form
        public void DisplayList()
        {
            // foreach loop parses each item in records List
            foreach (Titles t in records)
            {
                // Adds the name of each record item to the lstOutput list box
                lstOutput.Items.Add(t.name);
            }
        }
    }
}
