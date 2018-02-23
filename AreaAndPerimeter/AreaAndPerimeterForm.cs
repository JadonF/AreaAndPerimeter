/*
 * Created by: Jadon Fournier
 * Created on: 23-Feb-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - AreaAndPerimeter
 * This program allows you to calculate area and perimeter by entering the langth and width values.
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

namespace AreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();

            //Hide the Answer Labels
            this.lblPerimeter.Hide();
            this.lblArea.Hide();
        }

        //Declare Variables
        double width, length, area, perimeter;
        bool PerimeterCheck = false;
        bool AreaCheck = false;

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Close the program.
            this.Close();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            //Convert the input to a Double
            length = double.Parse(txtLength.Text);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            //Convert the input to a Double
            width = double.Parse(txtWidth.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Do the calculations, convert the answers to a string, display them and show the labels.
            area = length * width;
            perimeter = 2 * length + 2 * width;
            this.lblArea.Text = Convert.ToString(area) + " meters squared.";
            this.lblPerimeter.Text = Convert.ToString(perimeter) + " meters.";

            // Check to see which answers are selected.

            if (PerimeterCheck == true)
            {
                this.lblPerimeter.Show();
            }

            if (AreaCheck == true)
            {
                this.lblArea.Show();
            }

        }

        private void radPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            PerimeterCheck = true;
        }

        private void lblLength_Click(object sender, EventArgs e)
        {
            //accidentally clicked on this.
        }

        private void radArea_CheckedChanged(object sender, EventArgs e)
        {
            AreaCheck = true;
        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {
            //accidentally clicked on this.
        }

        private void lblArea_Click(object sender, EventArgs e)
        {
            //accidentally clicked on this.
        }
    }
}
