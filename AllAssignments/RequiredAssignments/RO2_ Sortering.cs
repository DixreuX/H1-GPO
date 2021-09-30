using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class RO2_Sortering
    {
        bool sortingIsRunning = true;
        int[] randomNumbers = { 2, 3, 6, 9, 1, 4, 8, 7, 5, 12, 15, 11, 13, 14 };
        char[] randomLetters = { 'G', 'A', 'Z', 'B', 'Y', 'C', 'X', 'I', 'H', 'D', 'K', 'J', 'F', 'E' };

        public void Sorting()
        {
            // My version of Quick Sorting

            while (sortingIsRunning == true)
            {
                // Displays the original declared array (letters)

                Clear();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n\n  These are the original arrays with the preset positions and values. They are displayed using a foreach \n  loop that goes throug the elements of the array and then some custom string adjustments for structure");
                WriteLine("\n\n  int[]\n");

                foreach (int rn in randomNumbers) // Displays the original declared array (int numbers)
                {
                    Write("  {0} ", rn);
                }

                WriteLine("\n\n\n  char[]\n");

                foreach (char rl in randomLetters) // Displays the original declared array (char characters)
                {
                    Write("  {0} ", rl);
                }

                WriteLine("\n\n\n  Let's sort this mess. Press ENTER to make the world a better place.\n\n");
                ReadKey();

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n\n  These are the sorted arrays. Same code, except that i used C#'s Array class to sort the specific array\n  before the foreach loop. Syntax: Array.Sort(randomNumbers); and Array.Sort(randomLetters);");
                WriteLine("\n\n  int[]\n");

                // Sorts the arrays
                Array.Sort(randomNumbers);
                Array.Sort(randomLetters);

                foreach (int rn in randomNumbers) // Displays the sorted array (int numbers)
                {
                    Write("  {0} ", rn);
                }

                WriteLine("\n\n\n  char[]\n");

                foreach (char rl in randomLetters) // Displays the sorted array (char characters)
                {
                    Write("  {0} ", rl);
                }

                WriteLine("\n\n\n  Press ENTER to continue on to Quick Sorting");

                ReadKey(sortingIsRunning = false);
                QuickSorting();
            }
        }

        public void QuickSorting()
        {
            QuickSort QS = new QuickSort();
            QS.DisplayQuickSort();
            ReadKey();
        }

    }
}
