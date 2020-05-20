using System;

namespace GitTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "Usenmfon";
            Console.WriteLine("My name is " + name);
            //Console.WriteLine("User details");
            string bankName = "Straford plc";
            string contactNumber = "+1 7552341";
            Console.WriteLine("User Details\n"+
            "Bank: " + bankName +
            "\nContact: " + contactNumber);
        }
    }
}
