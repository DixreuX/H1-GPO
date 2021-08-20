using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class ExtraMenu : Menu
    {
        bool extraIsRunning = true;

        #region Instansiering af ekstra opgave klasserne 

        
        
        #endregion

        public override void IsRunning()
        {
            while (extraIsRunning == true)
            {
                PossibleChoices = new string[]
                {
                    " 1. Swap values in 2 variables\n",
                    " 2. Replace values in 3 variables with assignment operators only\n",
                    " 3. \n",
                    " X. Return to Main Menu"
                };

                switch (Navigation())
                {
                    case 0:
                        EO1 EO1 = new EO1();
                        EO1.Exercise1();
                        break;
                    case 1:
                        EO2 EO2 = new EO2();
                        EO2.Exercise2();
                        break;
                    case 2:

                        break;
                    case 3:
                        extraIsRunning = false;
                        break;
                }
            }
        }

        public override void MenuHeader()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(String.Format("{0," + WindowWidth / 2 + "}", "\n       [ EXTRA ASSIGNMENTS ]                                                                                             [ Made by: Danny Frandsen ]\n\n"));
        }
    }
}
