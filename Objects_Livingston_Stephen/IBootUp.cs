using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Livingston_Stephen
{   // interface called IBootUp
    interface IBootUp
    {   
        public bool IsOn { get; set; } // Boolean property with automatic getter and setter.

        public void PowerOnOff(); // decalres method to interface.
        

        
    }
}
