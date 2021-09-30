using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class HelpTextForUser
    {
        public void HelpText()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(
@" 

 ------------------------------------------------------------------------------------------------------------------------------------
 
 [NAVIGATION]

 Use the UP and DOWN keys on the keyboard to navigate the menues. Use the ENTER to confirm a selection.

 ------------------------------------------------------------------------------------------------------------------------------------

 [MENUES]

 When the program starts, the Main Menu is displayed. The Main Menu is where you find HELP, ABOUT and EXIT PROGRAM, so navigate back
 to this if you wish to view these options. 

 The submenues are where you find the different topics. The assignments and solutions can be found as code in the classes in 
 Visual Studio, or you can view it through the interface i have made. It's up to the user. 

 ------------------------------------------------------------------------------------------------------------------------------------

 [TROUBLESHOOTING]

 If the program has issues starting it is probably because i have set the terminal/console window to a fixed size that might not fit
 your screen. Lower the values in Program.cs or comment out the whole line. The text and menues are formatted to this fixed window
 size, so you might have to manually expand the window to see all printed lines.

 At the end of every session working on this program, i will make sure that is runs and that there are no errors. At the moment i
 dont use any extra stuff, so there should be no dependancy problems running this Console App.

 ------------------------------------------------------------------------------------------------------------------------------------ 

 Press ANY key to CLEAR
");

            ReadKey();
            Clear();
        }
    }
}
