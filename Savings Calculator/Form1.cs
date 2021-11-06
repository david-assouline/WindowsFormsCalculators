using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savings_Calculator
{
    public partial class Form1 : Form
    {
        int numberOfMonthsValue;
        int monthlySavingsValue, annualInterestValue;
        double monthlyInterestMultiplier, balanceValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            numberOfMonthsValue += 1;
            numberOfMonthsTB.Text = numberOfMonthsValue.ToString();

            monthlySavingsValue = int.Parse(monthlySavingsTB.Text);
            annualInterestValue = int.Parse(annualInterestTB.Text);
            monthlyInterestMultiplier = 1 + (double)annualInterestValue / 100 / 12;

            balanceValue = (monthlySavingsValue * monthlyInterestMultiplier) + (balanceValue * monthlyInterestMultiplier);


            balanceTB.Text = "$" + balanceValue.ToString("0.00");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
