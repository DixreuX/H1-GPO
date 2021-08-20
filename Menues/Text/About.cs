using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    class About
    {
        public void AboutText()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(
@" 

 ------------------------------------------------------------------------------------------------------------------------------------
 
 [PURPOSE OF THIS PROGRAM]

 I'm studying to become a programmer, so I am required to complete some assignments and exercises. I made this to combine as much as 
 possible for a future library. It is also more organized and i dont have to create a new project for every project or assignment.

 Hopefully it makes navigating my projects and progress easier for my teachers to read and review. 

 ------------------------------------------------------------------------------------------------------------------------------------

 [PROGRAM CONTENTS]

 The program is split up into multiple menues that contain any relevant data. 

 REQUIRED ASSIGNMENTS: This is where you can find assignments and excercises that i am requiered to complete to pass and advance.

 SPECIAL PROJECTS: This i where i will store special school projects.

 EXTRA ASSIGNMENTS: This is where you find all extra stuff that i'm working on when i have extra time in school or in my free time 
                    after school.
 
 ------------------------------------------------------------------------------------------------------------------------------------ 

 [ABOUT ME]

 I love coding, designing, researching, exploring my own creativity and overcoming challenges and that is why I want to be a programmer.
 
 My goal is to become a full stack developer, and the reason for that is that i like being involved in every step of a project, from
 a concept and/or an idea, to a finished program and/or product.

 The idea and the goal is more important to me than what i need to learn and research to reach that goal, so i'm not interested in
 in only getting good at one or two specific areas of programming. Front end, back end, databases, new technologies, coding languages 
 are all equally important and interresting to me. In summary, I want to be good at using the tools that i need to use for a project. 

 ------------------------------------------------------------------------------------------------------------------------------------

 Press ANY key to CLEAR
");

            ReadKey();
            Clear();
        }

        



    }
}
