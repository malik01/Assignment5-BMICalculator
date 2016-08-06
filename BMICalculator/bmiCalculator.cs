using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{

    public partial class bmiCalculator : Form
    {
        public bmiCalculator()
        {
            InitializeComponent();
        }
        public bool FormFocus { get; set; }
        private void bmicalculatebutton_Click(object sender, EventArgs e)
        {
            //checks for if the metric radiobutton is checked 
            if (metricbutton.Checked)
            {
                double result = Convert.ToDouble(weight.Text) / (Convert.ToDouble(height.Text) * Convert.ToDouble(height.Text));
                bmiresult.Text = "" + result;
                if (result < 18.6)
                {
                    bmiscale.Text = "Underweight";
                }
                if (result > 18.6 && result < 25)
                {
                    bmiscale.Text = "Normal";
                }
                if (result >= 25 && result < 30)
                {
                    bmiscale.Text = "Overweight";
                }
                if (result >= 30)
                {
                    bmiscale.Text = "Obese";
                }
            }
            if (imperialbutton.Checked)
            {
                double result = Convert.ToDouble(weight.Text) * 703 / (Convert.ToDouble(height.Text) * Convert.ToDouble(height.Text));
                bmiresult.Text = "" + result;
                if (result < 18.6)
                {
                    bmiscale.Text = "Underweight";
                }
                if (result > 18.6 && result < 25)
                {
                    bmiscale.Text = "Normal";
                }
                if (result >= 25 && result < 30)
                {
                    bmiscale.Text = "Overweight";
                }
                if (result >= 30)
                {
                    bmiscale.Text = "Obese";
                }
            }

        }

        private void bmiCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void bmiCalculatorButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            
            if (FormFocus == true)
            {
               

                // read the string in the TextBox
                string heightbox = height.Text;

                // add the text of the button clicked to the currentResult
                heightbox += clickedbutton.Text;

                // update the ResultTextBox
                height.Text = heightbox;
                this.ActiveControl = height;
            }
            else if (FormFocus == false)
            {

                // read the string in the TextBox
                string weightbox = weight.Text;

                // add the text of the button clicked to the currentResult
                weightbox += clickedbutton.Text;

                // update the ResultTextBox
                weight.Text = weightbox;
                this.ActiveControl = weight;
            }
            }
        







        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void imperialbutton_CheckedChanged(object sender, EventArgs e)
        {
            weight.Clear();
            height.Clear();
            bmiresult.Clear();
            bmiscale.Clear();
            label7.Text = "Inches";
            label8.Text = "Pounds";

        }

        private void metricbutton_CheckedChanged(object sender, EventArgs e)
        {
            weight.Clear();
            height.Clear();
            bmiresult.Clear();
            bmiscale.Clear();
            label7.Text = "Meters";
            label8.Text = "KG";
        }

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        //removes one digit at a time
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (height.Text.Length == 1)
            {
                height.Text = "";
            }
             else if (height.Text.Length > 1)
            {
                height.Text = height.Text.Remove(height.Text.Length - 1);
            }
            else if (weight.Text.Length == 1)
            {
                weight.Text = "";
            }
            else if (weight.Text.Length > 1)
            {
                weight.Text = weight.Text.Remove(weight.Text.Length - 1);
            }
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (height.Focused)
            {
                this.FormFocus = true;
            }
            else if (weight.Focused)
            {
                this.FormFocus = false;
            }
        }
    }
}