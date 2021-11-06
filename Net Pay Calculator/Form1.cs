using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Tax___Pension_Calculator
{
    public partial class Form1 : Form
    {
        int[] catASalaries = new int[] { 45000, 50000, 55000, 58000, 60000 };
        int[] catBSalaries = new int[] { 52000, 60000, 67000, 74000, 80000 };
        double[] taxBrackets = new double[] { 0.30, 0.35, 0.40 };

        int taxBracketIdentifier;
        int yearsOfServiceValue;
        int salaryIndex;
        int actualSalary;
        double chosenPension;



        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            yearsOfServiceValue = int.Parse(yearsOfServiceTB.Text);

            if (yearsOfServiceValue >= 0 && yearsOfServiceValue <= 4)
            {
                salaryIndex = 0;
            }
            else if (yearsOfServiceValue >= 5 && yearsOfServiceValue <= 9)
            {
                salaryIndex = 1;
            }
            else if (yearsOfServiceValue >= 10 && yearsOfServiceValue <= 14)
            {
                salaryIndex = 2;
            }
            else if (yearsOfServiceValue >= 15 && yearsOfServiceValue <= 19)
            {
                salaryIndex = 3;
            }
            else if (yearsOfServiceValue > 19)
            {
                salaryIndex = 4;
            }

            if (rb0Percent.Checked)
            {
                chosenPension = 0.00;
            }

            else if (rb3Percent.Checked)
            {
                chosenPension = 0.03;
            }

            else if (rb5Percent.Checked)
            {
                chosenPension = 0.05;
            }

            if (catAButton.Checked)
            {
                actualSalary = catASalaries[salaryIndex];
            }

            else if (catBButton.Checked)
            {
                actualSalary = catBSalaries[salaryIndex];
            }


            if (actualSalary < 55000)
            {
                taxBracketIdentifier = 0;
            }

            else if (actualSalary >= 55000 && actualSalary < 70000)
            {
                taxBracketIdentifier = 1;
            }

            else if (actualSalary >= 70000)
            {
                taxBracketIdentifier = 2;
            }

            double taxesPaid = actualSalary * taxBrackets[taxBracketIdentifier];
            double pensionPaid = (actualSalary - taxesPaid) * chosenPension;
            double netPay = actualSalary - taxesPaid - pensionPaid;

            resultsTB.Text = String.Format("The gross salary is: ${0:0.00}\r\nThe deducted taxes amount is: ${1:0.00}" +
            "\r\nThe pension deduction is: ${2:0.00}\r\nThe net pay is: ${3:0.00}", actualSalary, taxesPaid, pensionPaid, netPay);








        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
