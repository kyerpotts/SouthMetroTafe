using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        private int[] nums;
        public Form1()
        {
            InitializeComponent();
            nums = new int[] { 22, 7, 45, 4154, 78, 5, 0, 5547 };
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstOutPut.Items.Clear();
            foreach (int n in nums)
            {
                lstOutPut.Items.Add(n);
            }
        }
        private void BubbleSort(int[] nums)
        {
            //Bubble sort algorithm
            for(int outer = nums.Length - 1; outer > 0; outer--)
            {
                for(int inner = 0; inner < outer; inner++)
                {
                    if(nums[inner] > nums[inner + 1])
                    {
                        int tmp = nums[inner + 1];
                        nums[inner + 1] = nums[inner];
                        nums[inner] = tmp;
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort(nums);
        }
    }
}
