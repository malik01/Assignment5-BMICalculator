﻿using System;
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
            if (height.Text == "" && weight.Text=="" || height.Text ==""|| weight.Text=="" )
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Please Enter Required Values";
            }
            
            else
            {
                label5.ForeColor = Color.Black;
                label5.Text = "System Of Measurement";
                bmicalculatebutton.Enabled = true;
            }
            }
        
         
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Centimeters";
            label8.Text = "Pounds";
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Meter";
            label8.Text = "KG";
        }
    }
}