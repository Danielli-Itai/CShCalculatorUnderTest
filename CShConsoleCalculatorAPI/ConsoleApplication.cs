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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserCalcualtorUI;




namespace CshCalculatorUIAPI
{
	class Program
	{
        private const int ERROR_SUCCESS = 0;


        private static Task<string> GetInputAsync()
        {
            return Task.Run(() => Console.ReadLine());
        }

        private delegate string GuiCommandEnvoke(Commands Commands_list, string command_line);
        public static void ThreadProc(ApplicationGUI gui)
        {
            // Indicates whther to continue reading input.
            bool running = true;

            UserCalculatorCmds.GUI(gui);

            // Initialize the commands object.
            Commands pCommands = CommandsApi.CommandsInit();

            // Assign the general commands to the commands list.
            CommandsApi.CommandAdd(ref pCommands, ConsoleCmd.CMD_ECHO, ConsoleCmd.EchoCmd);
            CommandsApi.CommandAdd(ref pCommands, ConsoleCmd.CMD_EXIT, ConsoleCmd.ExitCmd);

            // Assign the aplication GUI commands to the commands list.
            CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_SHOW, UserCalculatorCmds.GuiShowCmd);
            CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_HIDE, UserCalculatorCmds.GuiHideCmd);
            CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_MULT, UserCalculatorCmds.GuiMultCmd);
            CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_ADD, UserCalculatorCmds.GuiAddCmd);
            CommandsApi.CommandAdd(ref pCommands, UserCalculatorCmds.GUI_CLOSE, UserCalculatorCmds.GuiCloseCmd);



            // Continues loop.
            while (running)
            {
                // Print command promped '>'
                Console.Write(ConsoleCmd.CMD_PROMPED);

                // Get console command text"
                string command_line = GetInputAsync().Result;

                // Call for command execution by the GUI thread (enables accessing the GUI controls from a user thread).
                IAsyncResult invoke_result = gui.BeginInvoke(new GuiCommandEnvoke(CommandsApi.CommandExec), pCommands, command_line);

                //  Read the command result from the user thread.
                string result = (string)gui.EndInvoke(invoke_result);

                // Wite the result to the console.
                Console.Out.WriteLine(result);
                running = (ConsoleCmd.CMD_EXIT != result);
            }

            //  Exit command was issued.
            gui.Invoke(new Action(() => { gui.Close(); }));

            return;
        }




        static int Main(string[] args)
		{
            //  Set the environment Exit code.
            Environment.ExitCode = ERROR_SUCCESS;

            //  Create the application GUI
            Application.EnableVisualStyles();
            ApplicationGUI gui = new ApplicationGUI();
            gui.Hide();

            //  Start the console interface on a new Thread.
            Thread t = new Thread(()=>ThreadProc(gui));
            t.Start();

            //  Run the application.
            Application.Run(gui);

            //  Waite for the console thread to termiante.
            t.Join();

            //  Return with success.
            return ERROR_SUCCESS;
        }
	}
}
