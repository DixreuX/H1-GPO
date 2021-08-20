using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class RequiredMenu : Menu
    {
        #region Class Members

        bool requiredMenuIsRunning = true;

        #endregion

        #region Class Instantiation

       
       

        #endregion


        public override void IsRunning()
        { 
            while (requiredMenuIsRunning == true)
            {
                PossibleChoices = new string[]
                {
                " 1. Describe datatypes\n",        // 0
                " 2. Sorting\n\n",                 // 1
                " R. Return to Main Menu\n"        // 2              
                };

             

                switch (Navigation())
                {
                    case 0:
                        RO1_BeskrivDatatyper RO1 = new RO1_BeskrivDatatyper();
                        RO1.DescribeDatatypes();
                        break;
                    case 1:
                        RO2_Sortering RO2 = new RO2_Sortering();
                        RO2.Sorting();
                        break;
                    case 2:
                        requiredMenuIsRunning = false;
                        break;                
                }
            }   
        }

        public override void MenuHeader()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(String.Format("{0," + WindowWidth / 2 + "}", "\n       [ REQUIRED ASSIGNMENTS ]                                                                                          [ Made by: Danny Frandsen ]\n\n"));
        }
    }
}
