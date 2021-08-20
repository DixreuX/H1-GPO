using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    public class EO1
    {
        int a = 2;
        int b = 6;

          public void Exercise1()
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                O1B();

                WriteLine("\n  Starting values: a = " + a + ", b =" + b);

                a = a * b;   // [2 * 6 = 12] 
                b = a / b;   // [12 / 6 = 2] b now has the value 2
                a = a / b;   // [12 / 2 = 6] a now has the value 6

                O1M();

                WriteLine("\n  After the swap: a = " + a + ", b =" + b);
               
                WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n  [Press ANY key to CLEAR]");
                ReadKey();
                Clear();
            }

        public void O1B()
        {
            WriteLine(@"
  ------------------------------------------------------------------------------------------------------ 
 |                                                                                                      |
 |  Introduktion til Algoritmer                                                                         |
 |                                                                                                      |
 |  Make an algorithm that interchanges the values of the variables x and y, using only assignment      |
 |  statements.                                                                                         | 
 |                                                                                                      |
 |  What is the minimum number of assignment statements needed to do so?                                | 
 |                                                                                                      |
  ------------------------------------------------------------------------------------------------------   ");
        }

        public void O1M()
        {
            WriteLine(@"
  ------------------------------------------------------------------------------------------------------ 
 |                                                                                                      |
 |  How:                                                                                                |
 |                                                                                                      |
 |  a = a * b;   // [2 * 6 = 12]                                                                        |
 |  b = a / b;   // [12 / 6 = 2] b now has the value 2                                                  |
 |  a = a / b;   // [12 / 2 = 6] a now has the value 6                                                  | 
 |                                                                                                      |
  ------------------------------------------------------------------------------------------------------   ");
        }
    }
}
