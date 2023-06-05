using System;
using static System.Console;

namespace ArrayConsole03
{
    internal class Program
    {
        //  Declare and initialize program constant
        const int NUMTENNANTS = 8;

        static void Main(string[] args)
        {
            string[] tennants = new string[NUMTENNANTS];

            //  Input a value for each array element
            InputArrayElements(tennants);

            //  Display all array elements
            DisplayTennantsArray(tennants);
        }

        static void InputArrayElements(string[] t)
        {
            //  Input all array elements
            for (int lcv = 0; lcv < t.Length; lcv++)
            {
                Write("Enter Name Of Tennant #" + (lcv + 1) + "\t");
                t[lcv] = ReadLine();
            }
        }

        static void DisplayTennantsArray(string[] t)
        {
            //  Display heading
            WriteLine("\n\n    Array Program #3\nInput/Output An Array");
            WriteLine("---------------------");

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
