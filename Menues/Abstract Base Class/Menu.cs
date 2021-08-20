using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
     public abstract class Menu
    {
        // Members
        private string[] possibleChoices;
        public int choiceIndex;

        // Properties
        // The PossibleChoices property is the code behind, and it's contents is overrided by the derived class that is called.
        public string[] PossibleChoices { get => possibleChoices; set => possibleChoices = value; }


        // This method provides the user with a GUI that displays where they are in the choiceIndex and adds a bit of color and a marker. 
        public void GUI()
        {
            for (int i = 0; i < PossibleChoices.Length; i++)
            {
                string current = PossibleChoices[i];
                string marker;

                if (i == choiceIndex)
                {
                    marker = "->";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    marker = "  ";
                    ForegroundColor = ConsoleColor.Green;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{marker} {current}");
            }
            ResetColor();
        }


        // This method takes the users input. It handles the user interaction with predetermined keys.
        // The UpArrow and DownArrow navigates through the choiceIndex and Enter confirmes which switch case 
        // to run from the derived class. The associated MenuHeader(); is called to show the text for the menu. 

        public int Navigation()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                MenuHeader();
                GUI();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    choiceIndex--;
                    if (choiceIndex == -1)
                    {
                        choiceIndex = PossibleChoices.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    choiceIndex++;
                    if (choiceIndex == PossibleChoices.Length)
                    {
                        choiceIndex = 0;
                    }
                }
            }
            while (keyPressed != ConsoleKey.Enter);
            return choiceIndex;
        }


        // The called derived class overrides this method and displays the relevant Header for the menu
        public virtual void MenuHeader()
        {
        }


        // This is where the specific menu is called. A loop in the derived class will run and keep the user there until the loop is broken
        public virtual void IsRunning()
        {
        }
    }
}
