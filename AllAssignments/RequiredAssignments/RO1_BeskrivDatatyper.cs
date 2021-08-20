using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class RO1_BeskrivDatatyper
    {
        bool describeDatatypesIsRunning = true;

        public void DescribeDatatypes()
        {          
            while (describeDatatypesIsRunning == true)
            {
                // Displays size in bytes and range of the most common datatypes (75% done, too much repetition)

                Clear();

                ForegroundColor = ConsoleColor.Green;

                WriteLine("\n Below is a list of different datatypes with information on each of them. [75% done]");

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n sbyte\n\n [8-bit signed integer]\n Size: " + sizeof(sbyte) + " bytes\n Range: " + sbyte.MinValue + " to " + sbyte.MaxValue + "\n");
               
                unsafe
                {
                    // declare variable
                    sbyte a = 5;
                    WriteLine(" Variable: sbyte a = " + a + ";");

                    // store variable a address 
                    // location in pointer variable p
                    sbyte* p = &a;
                    WriteLine(" Value of this variable: {0}", a);
                    WriteLine(" Address of this variable: {0}", (long)p);
                    
                    // display values
                    WriteLine("\n\n                                     Array: sbyte[] numbers = { sbyte.MinValue, 16, 104, sbyte.MaxValue };\n");
                    WriteLine("                                                               Capped at 28 digits\n");

                    // converts values from the array and displays it in a grid with headers
                    sbyte[] numbers = { sbyte.MinValue, 16, 104, sbyte.MaxValue };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (sbyte number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n byte\n\n [8-bit unsigned interger]\n Size: " + sizeof(byte) + " bytes\n Range: " + byte.MinValue + " to " + byte.MaxValue + "\n");
                
                unsafe
                {
                    byte b = 10;
                    WriteLine(" Variable: byte b = " + b + ";");                 
                    byte* p = &b;
                    WriteLine(" Value of this variable: {0}", b);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                     Array: byte[] numbers = { byte.MinValue, 44, 174, 221, sbyte.MaxValue };\n");
                    WriteLine("                                                               Capped at 28 digits\n");

                    byte[] numbers = { byte.MinValue, 44, 174, 221, byte.MaxValue };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (byte number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n short\n\n [16-bit signed integer]\n Size: " + sizeof(short) + " bytes\n Range: " + short.MinValue + " to " + short.MaxValue + "\n");

                unsafe
                {
                    short c = 15;
                    WriteLine(" Variable: short n = " + c + ";");
                    short* p = &c;
                    WriteLine(" Value of this variable: {0}", c);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                     Array: short[] numbers = { short.MinValue, 44, 174, 221, short.MaxValue };\n");
                    WriteLine("                                                               Capped at 28 digits\n");

                    short[] numbers = { short.MinValue, 44, 174, 221, short.MaxValue };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (short number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n ushort\n\n [16-bit unsigned integer]\n Size: " + sizeof(ushort) + " bytes\n Range: " + ushort.MinValue + " to " + ushort.MaxValue + "\n");

                unsafe
                {
                    ushort d = 20;
                    WriteLine(" Variable: ushort d = " + d + ";");                 
                    ushort* p = &d;
                    WriteLine(" Value of this variable: {0}", d);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                   Array: ushort[] numbers = { ushort.MinValue, 54, 400, 766, ushort.MaxValue };\n");
                    WriteLine("                                                              Capped at 28 digits\n");

                    ushort[] numbers = { ushort.MinValue, 54, 400, 766, ushort.MaxValue };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (ushort number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n int\n\n [32-bit signed integer]\n Size: " + sizeof(int) + " bytes\n Range: " + int.MinValue + " to " + int.MaxValue + "\n");

                unsafe
                {
                    int e = 25;
                    WriteLine(" Variable: int e = " + e + ";");                    
                    int* p = &e;
                    WriteLine(" Value of this variable: {0}", e);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                         Array: int[] numbers = { 43, 678, 1281, 1573, 531 };\n");
                    WriteLine("                                                       Capped at 28 digits, no min-max\n");

                    int[] numbers = { 43, 678, 1281, 1573, 531 };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (int number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n uint\n\n [32-bit unsigned integer]\n Size: " + sizeof(uint) + " bytes\n Range: " + uint.MinValue + " to " + uint.MaxValue + "\n");

                unsafe
                {
                    uint f = 30;
                    WriteLine(" Variable: uint f = " + f + ";");
                    uint* p = &f;
                    WriteLine(" Value of this variable: {0}", f);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                             Array: uint[] numbers = { 1, 6, 46, 457, 1451 };\n");
                    WriteLine("                                                        Capped at 28 digits, no min-max\n");

                    uint[] numbers = { 1, 6, 46, 457, 1451 };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (uint number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n long\n\n [64-bit signed integer]\n Size: " + sizeof(long) + " bytes\n Range: " + long.MinValue + " to " + long.MaxValue + "\n");

                unsafe
                {
                    long g = 35;
                    WriteLine(" Variable: long g = " + g + ";");
                    long* p = &g;
                    WriteLine(" Value of this variable: {0}", g);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                             Array: long[] numbers = { 42, 253, 532, 2453, 4001 };\n");
                    WriteLine("                                                         Capped at 28 digits, no min-max\n");

                    long[] numbers = { 42, 253, 532, 2453, 4001 };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (long number in numbers)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    number, Convert.ToString(number, 2),
                                    Convert.ToString(number, 8),
                                    Convert.ToString(number, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n ulong\n\n [64-bit unsigned integer]\n Size: " + sizeof(ulong) + " bytes\n Range: " + ulong.MinValue + " to " + ulong.MaxValue + "\n");

                unsafe
                {
                    ulong h = 40;
                    WriteLine(" Variable: ulong h = " + h + ";");
                    ulong* p = &h;
                    WriteLine(" Value of this variable: {0}", h);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    //WriteLine("\n\n                                        Array: ulong[] numbers = { 5, 43, 423, 234, 932 };\n");
                    //WriteLine("                                                      Capped at 28 digits, no min-max\n");

                    //ulong[] numbers = { 5, 43, 423, 234, 932 };
                    //WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                 " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    //WriteLine("");
                    //foreach (ulong number in numbers)
                    //{
                    //    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                number, Convert.ToString(number, 2),
                    //                Convert.ToString(number, 8),
                    //                Convert.ToString(number, 16));
                    //}
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n char\n\n [16-bit single Unicode character]\n Size: " + sizeof(char) + " bytes\n");

                unsafe
                {
                    char i = 'h';
                    WriteLine(" Variable: char i = " + i + ";");
                    char* p = &i;
                    WriteLine(" Value of this variable: {0}", i);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    WriteLine("\n\n                                     Array: char[] characters = { 'D', 'A', 'N', 'N', 'Y' };\n");
                    WriteLine("                                                               Capped at 28 digits\n");

                    char[] characters = { 'D', 'A', 'N', 'N', 'Y' };
                    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                     " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    WriteLine("");
                    foreach (char character in characters)
                    {
                        WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                                    character, Convert.ToString(character, 2),
                                    Convert.ToString(character, 8),
                                    Convert.ToString(character, 16));
                    }
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n float\n\n [32-bit Single-precision floating point type]\n Size: " + sizeof(float) + " bytes\n Range: " + float.MinValue + " to " + float.MaxValue + "\n");

                unsafe
                {
                    float j = 45;
                    WriteLine(" Variable: float j = " + j + ";");
                    float* p = &j;
                    WriteLine(" Value of this variable: {0}", j);
                    WriteLine(" Address of this variable: {0}", (long)p);


                    //WriteLine("\n\n                                     Array: float[] numbers = { long.MinValue, 673, 923, 1392, float.MaxValue };\n");
                    //WriteLine("                                                               Capped at 28 digits\n");

                    //float[] numbers = { 4,3f, 92,7F, 135,3F };
                    //WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                 " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    //WriteLine("");
                    //foreach (float number in numbers)
                    //{
                    //    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                number, Convert.ToString(number, 2),
                    //                Convert.ToString(number, 8),
                    //                Convert.ToString(number, 16));
                    //}
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n double\n\n [64-bit double-precision floating point type]\n Size: " + sizeof(double) + " bytes\n Range: " + double.MinValue + " to " + double.MaxValue + "\n");

                unsafe
                {
                    double k = 45;
                    WriteLine(" Variable: double k = " + k + ";");
                    double* p = &k;
                    WriteLine(" Value of this variable: {0}", k);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    //WriteLine("\n\n                                     Array: double[] numbers = { double.MinValue, 231, 432, 1132, double.MaxValue };\n");
                    //WriteLine("                                                               Capped at 28 digits\n");

                    //double[] numbers = { double.MinValue, 231, 432, 1132, double.MaxValue };
                    //WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                 " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    //WriteLine("");
                    //foreach (double number in numbers)
                    //{
                    //    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                number, Convert.ToString(number, 2),
                    //                Convert.ToString(number, 8),
                    //                Convert.ToString(number, 16));
                    //}
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n decimal\n\n [128-bit decimal type for financial and monetary calculations]\n Size: " + sizeof(decimal) + " bytes\n Range: " + decimal.MinValue + " to " + decimal.MaxValue + "\n");

                unsafe
                {
                    decimal l = 50;
                    WriteLine(" Variable: decimal l = " + l + ";");
                    decimal* p = &l;
                    WriteLine(" Value of this variable: {0}", l);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    //WriteLine("\n\n                                     Array: decimal[] numbers = { decimal.MinValue, 6780, 400020, 25000600, decimal.MaxValue };\n");
                    //WriteLine("                                                               Capped at 28 digits\n");

                    //decimal[] numbers = { decimal.MinValue, 67, 400, 2500, decimal.MaxValue };
                    //WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                 " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    //WriteLine("");
                    //foreach (decimal number in numbers)
                    //{
                    //    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                number, Convert.ToString(number, 2),
                    //                Convert.ToString(number, 8),
                    //                Convert.ToString(number, 16));
                    //}
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n bool\n\n [8-bit logical true/false value]\n Size: " + sizeof(bool) + " bytes\n");

                unsafe
                {
                    bool m = true;
                    WriteLine(" Variable: bool m = " + m + ";");
                    bool* p = &m;
                    WriteLine(" Value of this variable: {0}", m);
                    WriteLine(" Address of this variable: {0}", (long)p);

                    //WriteLine("\n\n                                     Array: bool[] numbers = {  true, false };\n");
                    //WriteLine("                                                               Capped at 28 digits\n");

                    //bool[] yesOrNo = { true, false };
                    //WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                 " [Value]", "[Binary]", "[Octal]", "[Hex]");
                    //WriteLine("");
                    //foreach (bool statement in yesOrNo)
                    //{
                    //    WriteLine(" {0,28}   {1,28}   {2,28}   {3,28}",
                    //                statement, Convert.ToString(statement, 2),
                    //                Convert.ToString(statement, 8),
                    //                Convert.ToString(statement, 16));
                    //}
                }

                WriteLine("\n ----------------------------------------------------------------------------------------------------------------------------------------------------");

                WriteLine("\n\n\n                                                          [Press ANY key to CONTINUE]");
                SetCursorPosition(0, 0);
                ReadKey(describeDatatypesIsRunning = false); ;
                Clear();
            } 
        }
    }
}
