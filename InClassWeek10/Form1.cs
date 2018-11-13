using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassWeek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            // clear text
            lblMessage1.Text = "";
            // use a loop to display number 100 - 120
            for (Int32 counter = 100; counter <= 120; counter+=2)
            {
                lblMessage1.Text += counter + " ";
            }
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            // clear text
            lblMessage1.Text = "";
            // create a while loop to display #s from 100 - 120
            // set counter 100
            Int32 counter = 101;
            while(counter <=120)
            {
                lblMessage1.Text += counter + " ";

                //add 1 to counter
                counter+=2;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // capture the x and y axis as variables
            Int32 x = Convert.ToInt32(txtXNumber.Text);
            Int32 y = Convert.ToInt32(txtYNumber.Text);

            // send x and y to the AddNumbers methos and display result
            Int32 result = AddNumbers(x, y);
            lblOutput.Text = Convert.ToString(result);
        }

        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            // add the two input parameters together
            Int32 sum = x + y;

            // return the sum to the main method testing the team explorer
            return sum;
        }
    }
}
