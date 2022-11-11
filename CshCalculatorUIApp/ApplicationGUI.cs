/****************************************************************\
* This code written by Itai Danielly                             *
* This program is free software: you can redistribute it and/or  *
* modify it under the terms of the GNU General Public License    *
* as published by the Free Software Foundation, either version 3 *
* of the License, or (at your option) any later version.         *
* This program is distributed in the hope that it will be useful *
* but WITHOUT ANY WARRANTY; without even the implied warranty of *
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.           *
* See the GNU General Public License for more details.           *
\****************************************************************/
using System;
using System.Windows.Forms;
using CalcualtorLib;





namespace UserCalcualtorUI
{
	public partial class ApplicationGUI : Form
	{
		public ApplicationGUI()
		{
			InitializeComponent();
		}



#if UNIT_TEST_ENA
		public string CmdMultiply(string num1, string num2)
		{
            string result = m_MathCalcualtor.CmdMultiply(num1, num2);
			return result;
		}

		public string CmdAdd(string num1, string num2)
		{
            string result = m_MathCalcualtor.CmdAdd(num1, num2);
			return result;
		}
#endif
	}
}
