// Author: Jonathan Spalding
// Assignment: Project 11
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/16/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Power_Ratings
{
    class TestResistors
    {
        // state constants and all variables
        private const int MAX = 50;
        private double resistance;
        private double powerRating;
        private int count;
        // create two arrays to keep together the voldate, and power
        private double[] voltageArray;
        private double[] powerArray;
        // The default constructor
        // Purpose: It sets all declared variables (data members of the class) to what they need to be.
        // Parameters:
        // Returns: None
        public TestResistors()
        {
            voltageArray = new double[MAX];
            powerArray = new double[MAX];
            count = 0;
        }
        // The SetResistance method
        // Purpose: creates a variable for resistance
        // Parameters: double Resistance
        // Returns: none
        public void SetResistance(double Resistance)
        {
            resistance = Resistance;
        }
        // The SetPowerRating method
        // Purpose: creates a variable for Power
        // Parameters: double power
        // Returns: none
        public void SetPowerRating(double power)
        {
            powerRating = power;
        }
        // The StoreVoltageValue method
        // Purpose: Gets the voltage, and divides it by the resistance to find the power.
        // Parameters: double double
        // Returns: none
        public void OhmsLaw(double voltage)
        {
            voltageArray[count] = voltage;
            // finds the power according to Ohm's Law and assigns it to the powerArray
            powerArray[count] = Math.Pow(voltage, 2) / resistance;
            // incrament count
            ++count;
        }
        // The GetCount method
        // Purpose: returns Count and increments it once each time.
        // Parameters: none
        // Returns: double count
        public int GetCount()
        {
            return count++;
        }
        // The GetVoltage method
        // Purpose: voltageArray
        // Parameters: none
        // Returns: int i
        public double GetVoltage(int i)
        {
            return voltageArray[i];
        }
        // The GetPower method
        // Purpose: returns powerArray
        // Parameters: none
        // Returns: int i
        public double GetPower(int i)
        {
            return powerArray[i];
        }
        // The Result method
        // Purpose: returns Count and increments it once each time.
        // Parameters: none
        // Returns: int i
        public string Result(int i)
        {
            // string for holding the result
            string result;
            // if powerarray fails to pass
            if (powerArray[i] < powerRating)
                // diasplay "no"
                result = "no";
            // else return "yes"
            else result = "yes";
            return result;
        }
    }
}
