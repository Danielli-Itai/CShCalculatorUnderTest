#define UNIT_TEST_ENA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalcualtorLib;





namespace CalcualtorCtrl
{
    public partial class MathCalculatorCtrl : UserControl
    {
        public MathCalculatorCtrl ()
        {
            InitializeComponent();
        }



        private bool getNums(ref double num1, ref double num2)
        {
            bool result = SimpleCalculator.ParseNumber(Number1Text.Text, ref num1);
            result &= SimpleCalculator.ParseNumber(Number2Text.Text, ref num2);
            return result;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            ResultText.Text = SimpleCalculator.Multiply(Number1Text.Text, Number2Text.Text);
            Operator.Text = "*";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ResultText.Text = SimpleCalculator.Add(Number1Text.Text, Number2Text.Text);
            Operator.Text = "+";
        }

#if UNIT_TEST_ENA
		public string CmdMultiply(string num1, string num2)
		{
			Number2Text.Text = num1;
			Number1Text.Text = num2;

			Multiply_Click(null, null);

			return ResultText.Text;
		}

		public string CmdAdd(string num1, string num2)
		{
			Number2Text.Text = num1;
			Number1Text.Text = num2;

			Add_Click(null, null);

			return ResultText.Text;
		}

#endif
    }
}
