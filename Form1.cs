﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Official_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            {
                c = a + b; 
                label4.Text = "total = " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "difference = " + c.ToString();

            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "product = " + c.ToString();

            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "quotient = "+ c.ToString();

            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "log = " + c.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
