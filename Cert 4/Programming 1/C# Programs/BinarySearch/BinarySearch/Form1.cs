using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        private int[] nums;

        public Form1()
        {
            InitializeComponent();
            nums = new int[] { 45, 6897, 45, 354, 22, 478, 671, 354 };
        }

        private void btnSortAndShow_Click(object sender, EventArgs e)
        {
            Array.Sort(nums);
            foreach(int n in nums)
            {
                lstOutPut.Items.Add(n);
            }

        }
        private int BinarySearch(int[] nums, int search)
        {
            //Binary Search Algorithm
            int lowerBound = 0;
            int upperBound = nums.Length - 1;
            int i;

            while(true)
            {
                i = (lowerBound + upperBound) / 2;
                if(nums[i] == search)
                {
                    return i; //found it
                }
                else if(lowerBound > upperBound)
                {
                    return -1; // can't find it
                }
                else
                {
                    if (nums[i] < search)
                    {
                        lowerBound = i + 1;
                    }
                    else
                    {
                        upperBound = i - 1;
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int search = int.Parse(tbSearch.Text);
            int index = BinarySearch(nums, search);

            if( index != -1)
            {
                MessageBox.Show("Found num at " + index);
            }
            else
            {
                MessageBox.Show("num not found");
            }
        }
    }
}
