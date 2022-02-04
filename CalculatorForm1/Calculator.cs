using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm1
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        String firstdigit, seconddigit;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            //Generic Button(0-9) and decimal point
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            // Clear Entry Button
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                btnEqual.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            firstdigit = equation.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //Equals Button
            seconddigit = result.Text; 
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "X":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "x^y":
                    result.Text = Math.Pow(Double.Parse(result.Text), value).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
            //===============================

            btnRemoveHistory.Visible = true;
            ShowHistory.AppendText(firstdigit + "     " + seconddigit + " = "+ "\n");
            ShowHistory.AppendText("\n\t" + result.Text + "\n\n");
            lblShow.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Button
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            //Square Root Button
            double sr = Double.Parse(result.Text);
            result.Text = System.Convert.ToString(result.Text);
            sr = Math.Sqrt(sr);
            result.Text = System.Convert.ToString(sr);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            // +/- Button
            double s = Convert.ToDouble(result.Text);
            result.Text = Convert.ToString(-1 * s);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            // 1/x Button
            Double k;

            k = Convert.ToDouble(1.0 / Convert.ToDouble(result.Text));
            result.Text = System.Convert.ToString(k);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            // x^2
            Double k;

            k = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(k);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Delete Button
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);

            }

            if (result.Text == "")
            {
                result.Text = "0";

            }
        }

        private void btnRemoveHistory_Click(object sender, EventArgs e)
        {
            ShowHistory.Clear();
            if(lblShow.Text == "")
            {
                lblShow.Text = "There's no history yet";

            }
            btnRemoveHistory.Visible = false;
            ShowHistory.ScrollBars = 0;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEqual.Focus();
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btnZero.PerformClick();
                    break;
                case "1":
                    btnOne.PerformClick();
                    break;
                case "2":
                    btnTwo.PerformClick();
                    break;
                case "3":
                    btnThree.PerformClick();
                    break;
                case "4":
                    btnFour.PerformClick();
                    break;
                case "5":
                    btnFive.PerformClick();
                    break;
                case "6":
                    btnSix.PerformClick();
                    break;
                case "7":
                    btnSeven.PerformClick();
                    break;
                case "8":
                    btnEight.PerformClick();
                    break;
                case "9":
                    btnNine.PerformClick();
                    break;
                case "/":
                    btnDivide.PerformClick();
                    break;
                case "*":
                    btnTImes.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "-":
                    btnMinus.PerformClick();
                    break;
                case "=":
                    btnEqual.PerformClick();
                    break;
                default:
                    break;
             }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
