using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PayrollSalarySortingApp
{
    public partial class SalarySortingForm : Form
    {
        public SalarySortingForm()
        {
            InitializeComponent();
        }
        //Instatiates Stopwatch to be used for timing calculations
        Stopwatch stopwatch = new Stopwatch();
        //Variable used to store stopwatch data in string format
        private string SortTime;
        //Static variable to control the size of the array that the program will generate data to
        private static int ArrayMax = 1000;
        //Instatiates random number generator used to generate salary data
        private Random randSalary = new Random();
        //Array to store Salary Data when it is generated using the random number generator
        private int[] salaryArray;
        //Counter for the testing portion of the application that provides csv data outputs
        int arraySizePlus = 50000;

        //This region contains all of the functional methods used within the program
        #region Functional Methods
        //Method used to read data from an array and display it within the output box
        private void DisplaySalary(int[] array)
        {
            foreach (int i in array)
            {
                lstOutput.Items.Add(i);
            }
        }

        //Method used to generate the salary using the random number generator, and store the resulting data within the array elements
        private void GenerateSalary()
        {
            salaryArray = new int[ArrayMax];
            for (int i = 0; i < ArrayMax; i++)
            {
                salaryArray[i] = randSalary.Next(25000, 150000);
                lstOutput.Items.Add(salaryArray[i]);
            }
        }

        //Salary generating method to be used for test implementation
        private void GenerateSalaryPlus()
        {   
            salaryArray = new int[arraySizePlus];
            for (int i = 0; i < arraySizePlus; i++)
            {
                salaryArray[i] = randSalary.Next(25000, 150000);
            }
        }

        //Method used to display salary for test implementation
        private void DisplaySalary()
        {
            for (int i = 0; i < salaryArray.Length; i++)
            {
                lstOutput.Items.Add(salaryArray[i]);
            }
        }

        //Method used to format stopwatch time into a string format
        private string DisplayElapsedTime(TimeSpan span)
        {
            string elapsedTime = String.Format("{0}", span.TotalSeconds);
            return elapsedTime;
        }

        //Method to write data to csv file for excel import
        private void WriteData(string sortMethod, int arraySize, string elapsedTime, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
                {
                    file.WriteLine(sortMethod + "," + arraySize + "," + elapsedTime);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e, "Error writing to CSV file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //This region contains the sorting methods used throughout the application
        #region Sorting Methods
        #region BubbleSort

        //Standard bubblesort algorithm
        private void BubbleSort(int[] array)
        {
            for(int outer = array.Length - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if(array[inner] > array[inner + 1])
                    {
                        int temp = array[inner + 1];
                        array[inner + 1] = array[inner];
                        array[inner] = temp;
                    }
                }
            }
        }
        #endregion

        #region Merge Sort

        //Standard Merge Sort algorithm
        public static int[] mergeSort(int[] ar)
        {
            Func<int[], int[]> firstHalf = (array) =>
            {
                return array.Take((array.Length + 1) / 2).ToArray();
            };

            Func<int[], int[]> secondHalf = (array) =>
            {
                return array.Skip((array.Length + 1) / 2).ToArray();
            };

            Func<int[], int[], int[]> mergeSortedArrays = (ar1, ar2) =>
            {
                int[] mergedArray = new int[ar1.Length + ar2.Length];

                int i1 = 0, i2 = 0, currentMin;

                while (i1 < ar1.Length || i2 < ar2.Length)
                {
                    if (i1 < ar1.Length && i2 < ar2.Length)
                    {
                        if (ar1[i1] < ar2[i2])
                        {
                            currentMin = ar1[i1];
                            i1++;
                        }
                        else
                        {
                            currentMin = ar2[i2];
                            i2++;
                        }
                    }
                    else if (i1 < ar1.Length)
                    {
                        currentMin = ar1[i1];
                        i1++;
                    }
                    else
                    {
                        currentMin = ar2[i2];
                        i2++;
                    }
                    mergedArray[i1 + i2 - 1] = currentMin;
                }
                return mergedArray;
            };

            int[] half1 = firstHalf(ar); //always /geq than half2
            int[] half2 = secondHalf(ar);

            if (half1.Length < 2)
                return mergeSortedArrays(half1, half2);
            else
                return mergeSortedArrays(mergeSort(half1), mergeSort(half2));

        }
        #endregion

        #endregion

        //This region contains all of the button methods used in the non-test implementation of the application
        #region Button Methods
        
        //Button method to generate salary data
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            GenerateSalary();
        }

        //Button method to sort salary data with Bubble Sort algorithm
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            stopwatch.Reset();
            stopwatch.Start();
            BubbleSort(salaryArray);
            stopwatch.Stop();
            SortTime = DisplayElapsedTime(stopwatch.Elapsed);
            tbTimer.Text = SortTime.ToString();
            DisplaySalary(salaryArray);
        }

        //Button method to sort salary data with Merge Sort algorithm
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            salaryArray = mergeSort(salaryArray);
            DisplaySalary(salaryArray);
        }

        //Button method to sort salary data with Radix Sort algorithm
        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            salaryArray = RadixSort.Sort(salaryArray);
            DisplaySalary(salaryArray);
        }
        #endregion

        //This region contains all of the button methods used the the test implementation of the application
        #region Test Methods

        //Button method used to generate salary and then sort using the bubble sort algorithm.
        //Iterative loop is used to provide multiple test units for further analysis
        private void btnTestBS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    GenerateSalaryPlus();
                    stopwatch.Start();
                    BubbleSort(salaryArray);
                    stopwatch.Stop();
                    SortTime = DisplayElapsedTime(stopwatch.Elapsed);
                    WriteData("Bubble Sort", arraySizePlus, SortTime, "bubblesort.csv");
                    stopwatch.Reset();
                }
                arraySizePlus = arraySizePlus + 10000;
            }
            DisplaySalary();
            MessageBox.Show("Complete!", "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            arraySizePlus = 50000;
        }

        //Button method used to generate salary and tthen sort using merge sort algorithm.
        //Iterative loop is used to provide multiple test units for further analysis
        private void btnTestMS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    GenerateSalaryPlus();
                    stopwatch.Start();
                    salaryArray = mergeSort(salaryArray);
                    stopwatch.Stop();
                    SortTime = DisplayElapsedTime(stopwatch.Elapsed);
                    WriteData("Merge Sort", arraySizePlus, SortTime, "mergesort.csv");
                    stopwatch.Reset();
                }
                arraySizePlus = arraySizePlus + 10000;
            }
            DisplaySalary();
            MessageBox.Show("Complete!", "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            arraySizePlus = 50000;
        }

        //Button method used to generate salary and tthen sort using radix sort algorithm.
        //Iterative loop is used to provide multiple test units for further analysis
        private void btnTestRS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    GenerateSalaryPlus();
                    stopwatch.Start();
                    salaryArray = RadixSort.Sort(salaryArray);
                    stopwatch.Stop();
                    SortTime = DisplayElapsedTime(stopwatch.Elapsed);
                    WriteData("Radix Sort", arraySizePlus, SortTime, "radixsort.csv");
                    stopwatch.Reset();
                }
                arraySizePlus = arraySizePlus + 10000;
            }
            DisplaySalary();
            MessageBox.Show("Complete!", "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            arraySizePlus = 50000;
        }
        #endregion
    }
}
