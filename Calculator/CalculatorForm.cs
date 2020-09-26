using System;
using System.Windows.Forms;

namespace Calculator
{
    /*
     *       _____ _____ _____                _       _
     *      |_   _/  __ \_   _|              (_)     | |
     *        | | | /  \/ | |  ___  ___   ___ _  __ _| |
     *        | | ||      | | / __|/ _ \ / __| |/ _` | |
     *       _| |_| \__/\ | |_\__ \ (_) | (__| | (_| | |
     *      |_____\_____/ |_(_)___/\___/ \___|_|\__,_|_|
     *                   ___
     *                  |  _|___ ___ ___
     *                  |  _|  _| -_| -_|  LICENSE
     *                  |_| |_| |___|___|
     *
     * IT NEWS  <>  PROGRAMMING  <>  HW & SW  <>  COMMUNITY
     *
     * This source code is a part of online courses at IT social
     * network WWW.ICT.SOCIAL
     *
     * Feel free to use it for whatever you want, modify it and share it but
     * don't forget to keep this link in your code.
     *
     * Visit http://www.ict.social/licenses for more information
     */

    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            operationComboBox.SelectedIndex = 0;
        }

        public void calculateButton_Click (object sender, EventArgs e)
        {
            
            string operation = operationComboBox.SelectedItem.ToString();
            double number1 = Convert.ToDouble(number1NumericUpDown.Value);
            double number2 = Convert.ToDouble(number2NumericUpDown.Value);
            
            resultLabel.Text = calculateAnswer(operation, number1, number2).ToString();
        }
        
        public double calculateAnswer(string operation, double number1, double number2)
        {

            double result = 0;

            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else if (operation == "*")
                result = number1 * number2;
            else if (operation == "/")
            {
                if (number2 != 0)
                    result = number1 / number2;
                else
                    MessageBox.Show("You can't divide by zero");
            }

            return result;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
