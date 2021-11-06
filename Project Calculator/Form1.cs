using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator
{
    public partial class Form1 : Form
    {
        int initialInvestmentValue, yearlyRevenueValue, yearlyExpensesValue, currentYear, currentValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void initialInvestmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            initialInvestmentValue = int.Parse(initialInvestmentTB.Text);
            yearlyRevenueValue = int.Parse(yearlyRevenueTB.Text);
            yearlyExpensesValue = int.Parse(yearlyExpensesTB.Text);

            while (true)
            {
                currentYear += 1;
                currentValue += (yearlyRevenueValue - yearlyExpensesValue);
                if (currentValue >= initialInvestmentValue)
                {
                    break;
                }

            }

            breakEvenYearTB.Text = currentYear.ToString();


        }
        private void calculateForDoubleButton_Click(object sender, EventArgs e)
        {
            currentYear = 0;
            currentValue = 0;

            for (int i = 0; i < int.Parse(breakEvenYearTB.Text) * 2; i += 1)
            {
                currentYear += 1;
                currentValue += (yearlyRevenueValue - yearlyExpensesValue);
                doubleBreakEvenTB.Text += String.Format("{0}: {1:0.00}$",
                         currentYear, currentValue - initialInvestmentValue);
                doubleBreakEvenTB.Text += "\r\n";

            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
