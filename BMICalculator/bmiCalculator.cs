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

        private void bmicalculatebutton_Click(object sender, EventArgs e)
        {

        }

        private void bmiCalculator_Load(object sender, EventArgs e)
        {

        }

        private void height_Leave(object sender, EventArgs e)
        {
            if(height.Text==""||Convert.ToDouble(height.Text)< 1)
            {
                height.ForeColor = Color.Red;
                label5.Text = "Enter correct value for the fileds in red";
            }
            else
            {
                bmicalculatebutton.Enabled = true;
            }
        }
    }
}
