using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
     
        }

        #region RetirementCalculations
        public void RetirementCalculations()
        {
            // Variables
            decimal livingExpense;
            int yearsToRetire;
            float inflationRatePercent;

            // Get Input from Users through the textbox
            livingExpense = decimal.Parse(txtLivingExpense.Text);
            yearsToRetire = int.Parse(txtYearsToRetire.Text);
            inflationRatePercent = float.Parse(txtInflationRate.Text) / 100;

            // Calculate values
            decimal inflationRateTotal = Convert.ToDecimal(inflationRatePercent) * livingExpense;
            decimal inflationRateYear = inflationRateTotal * Convert.ToDecimal(yearsToRetire);
            decimal inflationTotal = livingExpense + inflationRateYear * yearsToRetire;

            decimal totalValue = inflationTotal * yearsToRetire;
     

            // return Values to user
            rtbTotalToRetire.Text = "If your cost of living expense is kept the same at $" + livingExpense + " annually." +
                                    "\nWith a inflation rate at " + inflationRatePercent +
                                    "%, the total you should try to save is $" + totalValue + "." +
                                    " To retire for " + yearsToRetire + " Years";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetirementCalculations();
            
        }
#endregion
    }
}
