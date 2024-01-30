using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '9'; //temp = temp + '9'
            txtResults.Text = temp;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '8';
            txtResults.Text = temp;
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

        private void btn7_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '7';
            txtResults.Text = temp;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '6';
            txtResults.Text = temp;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '5';
            txtResults.Text = temp;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '4';
            txtResults.Text = temp;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '3';
            txtResults.Text = temp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '2';
            txtResults.Text = temp;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (temp == "0")
                temp = "";
            temp += '1';
            txtResults.Text = temp;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string temp = txtResults.Text;
            if (!temp.Contains('.')) // ! is NOT
            {
                temp += '.';
                txtResults.Text = temp;
            }
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
                if (temp == "0")
                temp = "";
            temp += num;
            txtResults.Text = temp;
        }
        string opr = "";
        double operand = 0;
        private void btnEqu_Click(object sender, EventArgs e)
        {
            double operand2 = Double.Parse(txtResults.Text);
            switch (opr)
            {
                case "Add":operand = operand + operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case "Minus":operand = operand - operand2;
                    txtResults.Text = operand.ToString();
                    break;
                default:
                    break;
            }
            opr = "";

        }
 
        private void btnCE_Click(object sender, EventArgs e)
        {
            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
        }

        private void u_operator_Click(object sender, EventArgs e)
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
