﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmManin : Form
    {
        public frmManin()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void numPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            string temp = txtResults.Text;
            //clear display if operator is pressed
            if (flagOpPressed == true)
            {
                temp = "";
                flagOpPressed = false;
            }

            switch (num)
            {
                case ".":
                    if (!temp.Contains('.'))
                    {
                        temp += '.';
                    }
                    break;
                default:
                    if (temp == "0")
                        temp = "";
                    temp += num;
                    break;
            }
            txtResults.Text = temp;
        }
        string opr = "";
        double operand = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            double operand2 = Double.Parse(txtResults.Text);
            switch (opr)
            {
                case
                    "Add":operand = operand + operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case "Minus":
                    operand = operand - operand2;
                    txtResults.Text = operand.ToString();
                    break;
                default:
                    break;
            }
            opr = "";

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

        }

        bool flagOpPressed = false;
        private void operator_Click(object sender, EventArgs e)
        {
            btnEqu.PerformClick();
            // get the operand value
            operand = Double.Parse(txtResults.Text);
            // get the operator
            Button btn = (Button)sender;
            opr = btn.Tag.ToString();
            flagOpPressed = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
        }

        private void u_operatorClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string u_opr = btn.Tag.ToString();
            double value = Double.Parse(txtResults.Text);
            string results;
            switch (u_opr)
            {
                case "Sqrt":
                    results = Math.Sqrt(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    break;
                case "Sqr":
                    results = Math.Pow(value, 2).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    break;
            }

        }
    }
}
