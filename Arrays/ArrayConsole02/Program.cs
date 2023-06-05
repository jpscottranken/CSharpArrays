using System;
using static System.Console;

namespace ArrayConsole02
{
    internal class Program
    {
        //  Declare and initialize program constant
        const int NUMTENNANTS = 8;

        static void Main(string[] args)
        {
            //  Create string array called tennants
            string[] tennants = {
                                    "Jeff Scott",
                                    "Greg Green",
                                    "Brian Black",
                                    "Mary Brown",
                                    "Gail White",
                                    "Karen Clark",
                                    "Mike King",
                                    "Barb Jones"
                                };

            //  Display the values in the tennants array
            DisplayTennantsArray(tennants);
        }

        static void DisplayTennantsArray(string[] t)
        {
            //  Display heading
            WriteLine("    Array Program #2\nPrepopulating An Array");
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
