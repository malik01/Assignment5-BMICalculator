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
        ErrorProvider error = new ErrorProvider();
        private void bmicalculatebutton_Click(object sender, EventArgs e)
        {
            if (metricbutton.Checked)
            {
                double result = Convert.ToDouble(weight.Text) / (Convert.ToDouble(height.Text) * Convert.ToDouble(height.Text));
                bmiresult.Text = "" + result;
                if (result < 18.6)
                {
                    bmiscale.Text = "Underweight";
                }
                if (result > 18.6 && result<25)
                {
                    bmiscale.Text = "Normal";
                }
                if(result >=25 && result < 30)
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
                double result = Convert.ToDouble(weight.Text)*703 / (Convert.ToDouble(height.Text) * Convert.ToDouble(height.Text));
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


        private void height_Leave(object sender, EventArgs e)
        {
            if (height.Text == "" && weight.Text == "")
            {
                
                error.SetError(label7, "Please Enter value for height");
                error.SetError(label8, "Please Enter value for weight");
            }
            if (Convert.ToInt32(weight.Text) == 0 || Convert.ToInt32(height.Text) == 0)
            {
                error.SetError(label7, "Please Enter value greater than zero for height");
                error.SetError(label8, "Please Enter value greater than zero for weight");
            }
            else
            {
                
                bmicalculatebutton.Enabled = true;
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
            label7.Text = "Meter";
            label8.Text = "KG";
        }
    }
}