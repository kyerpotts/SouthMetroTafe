// <copyright file="CSVReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PipeClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CsvHelper;

    /// <summary>
    /// Class creates a CSV reader containing a Linked List.
    /// </summary>
    internal class CSVReader
    {
        private LinkedList<Movies> records = new LinkedList<Movies>();

        /// <summary>
        /// Method used to get Movie data.
        /// </summary>
        /// <returns>Returns a Linked List containing all movie data.</returns>
        public LinkedList<Movies> GetMovies()
        {
            return this.records;
        }

        /// <summary>
        /// Method used to Read the CSV file and import the data to the Linked List.
        /// </summary>
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
                    var record = new Movies
                    {
                        Id = csv.GetField<int>("Id"),
                        Name = csv.GetField("Name"),
                    };

                    // Adds newly created Titles object into List
                    if (this.records.First == null)
                    {
                        this.records.AddFirst(record);
                    }
                    else
                    {
                        this.records.AddAfter(this.records.Last, record);
                    }
                }
            }
        }
    }
}
