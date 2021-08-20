using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_GPO
{
    public class MainLoop
    {
        // This is the engine that drives the program and it is here we navigate and decide what code to call

        #region Boolean that controls the Main Loop

        bool mainLoopIsRunning = true;

        #endregion

        #region Property for activating/deactivating the Main Loop

        public bool MainLoopIsRunning { get => mainLoopIsRunning; set => mainLoopIsRunning = value; }

        #endregion

        #region Object to instantiate

        Menu MM = new MainMenu();

        #endregion


        public void ProgramIsRunning()
        {       
            while (MainLoopIsRunning == true) // Main Loop
            {               
                    MM.IsRunning();
            }    
        }
    }
}
