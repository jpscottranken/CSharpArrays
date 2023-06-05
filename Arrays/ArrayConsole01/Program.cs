using System;
using static System.Console;

namespace ArrayConsole01
{
    internal class Program
    {
        //  Declare and initialize program constant
        const int NUMTENNANTS = 8;

        static void Main(string[] args)
        {
            //  Create string array called tennants
            string[] tennants = new string[NUMTENNANTS];

            //  Fill up the tennants array with strings
            FillTennantsArray(tennants);

            //  Display the values in the tennants array
            DisplayTennantsArray(tennants);
        }

        static void FillTennantsArray(string[] t)
        {
            //  Initializing the tennants array
            t[0] = "Jeff Scott";
            t[1] = "Greg Green";
            t[2] = "Brian Black";
            t[3] = "Mary Brown";
            t[4] = "Gail White";
            t[5] = "Karen Clark";
            t[6] = "Mike King";
            t[7] = "Barb Jones";
        }

        static void DisplayTennantsArray(string[] t)
        {
            //  Display heading
            WriteLine("    Array Program #1\nHardcoding An Empty Array");
            WriteLine("-------------------------");

            //  Display all array elements
            for (int lcv = 0; lcv < t.Length; lcv++)
            {
                WriteLine("Tennant #" + (lcv + 1) + "\t" + t[lcv]);
            }

            //  Another "poor" way of doing this
            //WriteLine(t[0]);
            //WriteLine(t[1]);
            //WriteLine(t[2]);
            //WriteLine(t[3]);
            //WriteLine(t[4]);
            //WriteLine(t[5]);
            //WriteLine(t[6]);
            //WriteLine(t[7]);

            ReadLine();
        }
    }
}
