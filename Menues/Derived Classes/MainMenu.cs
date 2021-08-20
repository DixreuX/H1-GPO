using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
       /*
        * This is the programs main menu class
        */

    class MainMenu : Menu
    {
        #region Class Members

        bool mainMenuIsRunning = true;

        #endregion

      

        public override void IsRunning()
        {
            while (mainMenuIsRunning == true)
            {
                PossibleChoices = new string[]
                {
                    " 1. Required Assignments\n",   // 0
                    " 3. Extra Assignments\n",      // 1
                    " 2. Special Projects (disabled)\n\n",     // 2
                    " H. HELP",                     // 3
                    " A  ABOUT",                    // 4
                    " X. EXIT PROGRAM"              // 5
                };

                switch (Navigation())
                {
                    case 0:
                        Menu RM = new RequiredMenu();
                        RM.IsRunning();
                        break;
                    case 1:
                        Menu EM = new ExtraMenu();
                        EM.IsRunning();
                        break;
                    case 2:           
                        break;
                    case 3:
                        HelpTextForUser Help = new HelpTextForUser();
                        Help.HelpText();
                        break;
                    case 4:
                        About About = new About();
                        About.AboutText();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public override void MenuHeader()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(String.Format("{0," + WindowWidth / 2 + "}", "\n       [ MAIN MENU ]                                                                                                     [ Made by: Danny Frandsen ]\n\n"));
        }
    }
}
