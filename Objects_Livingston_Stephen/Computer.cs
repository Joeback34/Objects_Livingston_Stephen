using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Livingston_Stephen
{
    class Computer : IBootUp // the class implments the interface IBootUp.
    {   
        /// <summary>
        /// creates automatic properties for Brand, Type, and IsOn.
        /// </summary>
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Creates cunstructor with parameters for Brand, Type and IsOn. 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="type"></param>
        /// <param name="isOn"></param>
        public Computer(string brand,  string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        
           
        /// <summary>
        /// Method that tells the user if the computer is on or off.
        /// </summary>
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }

        }

        /// <summary>
        /// a return string that tells the user about the status of the computer.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"This computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }


    }
}
