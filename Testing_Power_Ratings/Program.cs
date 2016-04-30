// Author: Jonathan Spalding
// Assignment: Project 11
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/16/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;
using System.IO;

namespace Testing_Power_Ratings
{
    class Program
    {
        static void Main(string[] args)

        {
            // state all constants and variables
            int num = 0;
            double count = 0;
            string inputString;
            const double MAX = 50; 
            // create an object for Test Resistors.
            TestResistors objectRef = new TestResistors();
            //Write Instructions
            WriteLine("Resistor Batch Test Analysis Program\nData file must be in your Documents folder\nPlease enter the file name: ");
            // crete a string event to run C# agiin.
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";
            //create variable for the file with "theTextFile"
            StreamReader theTextFile = new StreamReader(environment + ReadLine());
            // put the first line in the file in an array, and split it.
            string[] a1 = theTextFile.ReadLine().Split();
            // first element in the array parsed to a double and assigned to its own variable
            double resistance = double.Parse(a1[0]);
            // call back the resistance 
            objectRef.SetResistance(resistance);
            // set the power in the array to a double variable.
            double power = double.Parse(a1[1]);
            // call back the Set Power Rating
            objectRef.SetPowerRating(power);
            // do while loop for when the file has more that can be read, or it is less than 50.
            do
            {
                // set the input string variable equall with ReadLine
                inputString = theTextFile.ReadLine();
                // if there is data to be read
                if (inputString != null)
                    // find the power of that line of data according to Ohm's Law
                    objectRef.OhmsLaw(double.Parse(inputString));
            }
            // if there isn't any data, or if it reaches 50 items, exit the do-while loop
            while (inputString != null && num < MAX);
            // find out how many items have been read in the file
            count = objectRef.GetCount();
            // WriteLine a title for the output
            WriteLine("\n\nRes#\tDissipation\tPassed");
            // for loop that runs through as many times as there were items in the file
            for (var i = 0; i < count; ++i)
                // Write the totals according to the format of the title.
                WriteLine($"{(i + 1)}\t{objectRef.GetPower(i):f}\t\t{objectRef.Result(i)}");
            // ReadKey for keeping the window open.
            ReadKey(true);
        }
    }
}
