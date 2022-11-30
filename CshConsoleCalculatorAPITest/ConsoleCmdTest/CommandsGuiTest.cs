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
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UserCalcualtorUI;
using CshCalculatorUIAPI;
//using CshCalculatorUIAPITest;
//using CshConsoleAPI;
// using UserCalcualtorUI;




namespace CshConsoleTest
{

	[TestClass]
	public class CommandsGuiTest
	{
		private const string CMD_GUI_SHOW = UserCalculatorCmds.GUI_SHOW + "()";
		private const string CMD_GUI_MULT = UserCalculatorCmds.GUI_MULT + "(2,3)";
		private const string CMD_GUI_CLOSE = UserCalculatorCmds.GUI_CLOSE + "()";




		//	Test the commands list using the echo command function.
		[TestMethod]
		public void TestCommandGui()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);


            //	Check adding echo command to commands list.
            Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_SHOW, UserCalculatorCmds.GuiShowCmd));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_HIDE, UserCalculatorCmds.GuiHideCmd));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_MULT, UserCalculatorCmds.GuiMultCmd));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_CLOSE, UserCalculatorCmds.GuiCloseCmd));

			//	Create application main GUI object.
			UserCalculatorCmds.GUI(new ApplicationGUI());

            //	Execute the echo command in the command list.
            

            Assert.IsTrue(ConsoleCmd.CMD_OK == CommandsApi.CommandExec(pCommands, CMD_GUI_SHOW));
            Assert.IsTrue("6" == CommandsApi.CommandExec(pCommands, CMD_GUI_MULT));
			Assert.IsTrue(ConsoleCmd.CMD_OK == CommandsApi.CommandExec(pCommands, CMD_GUI_CLOSE));

			return;
		}

	};
}
