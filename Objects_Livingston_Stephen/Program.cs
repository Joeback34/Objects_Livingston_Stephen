using System;

namespace Objects_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-One", true); // Creates new object.
            IBootUp myBootUp = myComputer; // Assigns myComputer object to myBootUp object. 
            Console.WriteLine(myComputer.Equals(myBootUp)); // Prints to the user that myComputer equals myBootUp. 

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true); // Tells the user the statement is true.
            Console.WriteLine(myComputer.Equals(myOtherComputer));  // Prints to the user that myComputer equals myOtherComputer. 

            string myString = myComputer.ToString(); // Tells the user about the status of the computer.
            string myOtherString = myString;    // Declares myOtherString set to myString.

            myString = "Hi!";

            //Prints a messege to the user.
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);
            
            
            Console.WriteLine(myString == myComputer.ToString()); // Compares the two computer objects and prints the results. 
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType()); // Calls GetType method and prints the results to the console.
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff(); // Calls the PowerOnOff Method.
            
            Console.WriteLine(myString == myOtherComputer.ToString()); // Compares two Objects and prints results to user.

            Console.WriteLine(myString.Contains('i')); // Prints if the variable contains the letter i.

            Console.WriteLine(myString.ToUpper()); // Calls ToUpper on string variable and prints results.
        }
    }
}
