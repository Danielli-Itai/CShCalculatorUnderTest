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
using UserCalcualtorUI;
using System;





namespace CshCalculatorUIAPI
{
	public class UserCalculatorCmds
	{
		public const string GUI_SHOW = "GuiShow";
		public const string GUI_HIDE = "GuiHide";
		public const string GUI_MULT = "GuiMult";
		public const string GUI_ADD = "GuiAdd";
		public const string GUI_CLOSE = "GuiClose";



		private static ApplicationGUI gui = null;
		public static void GUI(ApplicationGUI gui)
        {
			UserCalculatorCmds.gui = gui;
		}

		/***
		* GuiShow opens the application graphical user interface.
		*/
		public static String GuiShowCmd(string[] parameters)
		{
			gui.Show();
			return ConsoleCmd.CMD_OK;
		}
		public static String GuiHideCmd(string[] parameters)
		{
			gui.Hide();
			return ConsoleCmd.CMD_OK;
		}

		public static String GuiMultCmd(string[] parameters){
			String result = gui.CmdMultiply(parameters[0], parameters[1]);
			return result;

		}

		public static String GuiAddCmd(string[] parameters)
		{
			String result = gui.CmdAdd(parameters[0], parameters[1]);
			return result;

		}

		public static String GuiCloseCmd(string[] parameters)
		{
			gui.Close();
			return ConsoleCmd.CMD_OK;
		}

	}
}
