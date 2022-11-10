using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace MathCalcualtorLib
{
    public class SimpleCalculator
	{
		public const string INPUT_ERROR = "Input error";

		public static bool ParseNumber(string text, ref double number)
		{
			bool result = true;
			try
			{
				number = Double.Parse(text);
			}
			catch (Exception e)
			{
				result = false;
			}
			return result;
		}



		public static string Multiply(string num1_txt, string num2_txt)
        {
			string result = "";
			double num1 = 0, num2 = 0;

			if (ParseNumber(num1_txt, ref num1) && ParseNumber(num2_txt, ref num2))	{
				result = (num1 * num2).ToString();
			}
			else {
				result = INPUT_ERROR;
			}
			return result;
		}


		public static string Add(string num1_txt, string num2_txt)
		{
			string result = "";
			double num1 = 0, num2 = 0;

			if (ParseNumber(num1_txt, ref num1) && ParseNumber(num2_txt, ref num2))
			{
				result = (num1 + num2).ToString();
			}
			else
			{
				result = INPUT_ERROR;
			}
			return result;
		}

	}
}
