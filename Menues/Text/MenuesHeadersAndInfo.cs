using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class MenuesHeadersAndInfo
    {
        public void StartScreen()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\n");
            WriteLine(
                @"
                                     ___         _      ___                                   _            
                                    | _ )__ _ __(_)__  | _ \_ _ ___ __ _ _ _ __ _ _ __  _ __ (_)_ _  __ _  
                                    | _ / _` (_-| / _| |  _| '_/ _ / _` | '_/ _` | '  \| '  \| | ' \/ _` | 
                                    |___\__,_/__|_\__| |_| |_| \___\__, |_| \__,_|_|_|_|_|_|_|_|_||_\__, | 
                                                                    |___/                            |___/  ");

            WriteLine("\n");
            WriteLine(
                @"
                                     ___        ___                       ___                 _             
                                    | _ )_  _  |   \ __ _ _ _  _ _ _  _  | ___ _ __ _ _ _  __| |______ _ _  
                                    | _ | || | | |) / _` | ' \| ' | || | | _| '_/ _` | ' \/ _` (_-/ -_| ' \ 
                                    |___/\_, | |___/\__,_|_||_|_||_\_, | |_||_| \__,_|_||_\__,_/__\___|_||_|
                                          |__/                      |__/                                     ");
            WriteLine("\n\n\n\n\n\n\n                                                             Press ANY key to START");
            ReadKey();
        }
    }
}
