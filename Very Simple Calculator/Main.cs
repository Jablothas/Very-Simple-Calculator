using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Very_Simple_Calculator
{
    public partial class Main : Form
    {
        decimal CurrentValue = 0; // Store temporary value from display
        decimal Result = 0; // Store value during whole process until user hit C
        char CurrentOperation = '!'; // Store the current mathematical operation
        bool CheckResultState = false; // Checks if result button has been triggered already

        public Main()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            CurrentValue = Convert.ToDecimal(Display.Text);

            if (CurrentOperation == '+')
            {
                Result += CurrentValue;
                Log.Text += CurrentValue + " = " + Result;
                CurrentValue = 0;
                Display.Text = "0";
            }

            if (CurrentOperation == '-')
            {
                Result -= CurrentValue;
                Log.Text += CurrentValue + " = " + Result;
                CurrentValue = 0;
                Display.Text = "0";
            }

            if (CurrentOperation == '*')
            {
                Result *= CurrentValue;
                if (CheckResultState == false)
                {
                    Log.Text += CurrentValue + " = " + Result;
                }
                else
                {
                    Log.Text = Result + " * ";
                }
                CurrentValue = 0;
                Display.Text = "0";
            }

            CurrentOperation = '=';
            CheckResultState = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Save current value from Display to CurrentValue
            CurrentValue = Convert.ToDecimal(Display.Text);
            CurrentOperation = '+';

            // If Result is currently empty, write CurrentValue to Result
            if (Result == 0)
            {
                Result = CurrentValue;
                Log.Text = Result + " + ";
                CurrentValue = 0;
                Display.Text = "";
            }
            // If Result has already a value, add CurrentValue to Result
            else if (Result != 0)
            {
                Result += CurrentValue;
                Log.Text = Result + " + ";
                CurrentValue = 0;
                Display.Text = "";
            }            
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            // Save current value from Display to CurrentValue
            CurrentValue = Convert.ToDecimal(Display.Text);
            CurrentOperation = '-';

            // If Result is currently empty, write CurrentValue to Result
            if (Result == 0)
            {
                Result = CurrentValue;
                Log.Text = Result + " - ";
                CurrentValue = 0;
                Display.Text = "";
            }
            // If Result has already a value, substract CurrentValue from Result
            else if (Result != 0)
            {
                Result -= CurrentValue;
                Log.Text = Result + " - ";
                CurrentValue = 0;
                Display.Text = "";
            }
        }

        private void BtnMlt_Click(object sender, EventArgs e)
        {

            if (CurrentOperation == '=')
            {            
                CurrentOperation = '*';
                Display.Text = "";
            }
            else
            {
                // Save current value from Display to CurrentValue
                CurrentValue = Convert.ToDecimal(Display.Text);
                CurrentOperation = '*';


                // If Result is currently empty, write CurrentValue to Result
                if (Result == 0)
                {
                    Result = CurrentValue;
                    Log.Text = Result + " * ";
                    CurrentValue = 0;
                    Display.Text = "";
                }
                // If Result has already a value, add CurrentValue to Result
                else if (Result != 0)
                {
                    Result *= CurrentValue;
                    Log.Text = Result + " * ";
                    CurrentValue = 0;
                    Display.Text = "";
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            CurrentValue = 0;
            CheckResultState = false;
            Log.Text = "Calculation cleared.";
            Display.Text = "";
            CurrentOperation = '!';
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            Display.Text += ",";
        }
    }
}
