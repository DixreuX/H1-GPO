using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class EO2
    {
        int a = 10;
        int b = 20;
        int c = 30;

        public void Exercise2()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            O2B();

            WriteLine("\n  Starting values: values: a = " + a + ", b = " + b + ", c = " + c);

            a = 30;  //new assigned value for a
            b = 10;  //new assigned value for b
            c = 20;  //new assigned value for c

            O2M();

            WriteLine("\n  New values: a = " + a + ", b = " + b + ", c = " + c);

            WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            WriteLine("\n  [Press ANY key to CLEAR]");
            ReadKey();
            Clear();
        }

        public void O2B()
        {
            WriteLine(@"
  ------------------------------------------------------------------------------------------------------ 
 |                                                                                                      |
 |  Introduktion til Algoritmer                                                                         |
 |                                                                                                      |
 |  Make an algorithm that uses only assignment statements to replace thevalues of the triple           |
 |  (x, y, z) with (z, x, y).                                                                           | 
 |                                                                                                      |
 |  What is the minimum number of assignment statements needed?                                         |
 |                                                                                                      |
  ------------------------------------------------------------------------------------------------------   ");
        }

        public void O2M()
        {
            WriteLine(@"
  ------------------------------------------------------------------------------------------------------ 
 |                                                                                                      |
 |  How:                                                                                                |
 |                                                                                                      |
 |  a = 30;  //new assigned value for a                                                                 |
 |  b = 10;  //new assigned value for b                                                                 |
 |  c = 20;  //new assigned value for c                                                                 | 
 |                                                                                                      |
  ------------------------------------------------------------------------------------------------------   ");
        }
    }
}
