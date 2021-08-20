using System;
using static System.Console;

namespace H1_GPO
{
    class Program
    {
        /*
     * This will be a constant Work-In-Progress.
     * Mistakes, optimization and the overall structure and orginazation will be handled along the way.
     * 
     * I believe in making my code readable, organized and easy to understand so along the way i will focus on:
     * OOP principles, comments, DRY principles, clean code, and documentation.
     * 
     * NOTE: I will be using: -> using static System.Console; <- in most of this program. This means that i don't have 
     * to type Console. I do this because i think it makes the program more readable and and clean. Some examples:
     * 
     * Console.Write("");           -->           Write("");
     * Console.Writeline("");       -->           Writeline("");
     * Console.SetWindowSize(,);    -->           SetWindowSize(,);
     * Console.Clear();             -->           Clear();
     * Console.Readline();          -->           Readline();
     * Console.ReakKey();           -->           ReadKey();
     * 
     * Microsoft recommends it for cleaner code and i agree.
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
     * 
     * 
     * Created By: Danny Frandsen,
     * TECHCOLLEGE Aalborg
     * 
     * RUN ME! :)
     */

        static void Main(string[] args)
        {
            MainLoop ML = new MainLoop();
            MenuesHeadersAndInfo MHAI = new MenuesHeadersAndInfo();

            SetWindowPosition(0, 0);
            SetWindowSize(150, 48);

            MHAI.StartScreen();
            ML.ProgramIsRunning();
        }
    }
}
