using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            decimal yearsToRetire;

            // Get Input from Users through the textbox
            livingExpense = decimal.Parse(txtLivingExpense.Text);
            yearsToRetire = decimal.Parse(txtYearsToRetire.Text);

            // Calculate values
            decimal totalValue = Convert.ToDecimal(livingExpense) * Convert.ToDecimal(yearsToRetire);

            // return Values to user
            rtbTotalToRetire.Text = "If your total cost of living expense is " + livingExpense + " annually." + 
                                    " You should save a total of " + totalValue + "." +
                                    " To retire for the next " + yearsToRetire + " Years";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetirementCalculations();

        }
#endregion
    }
}
