using System;
using static System.Console;

namespace ArrayConsole05
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int NUMELEMENTS =  25;
        const int MINNUMBER   =   0;
        const int MAXNUMBER   = 101;

        //  Declare and iniitalize global variables
        static Random rand   = new Random();
        static int[] numbers = new int[NUMELEMENTS];

        static void Main(string[] args)
        {
            FillArray();
            int lowest  = GetLowestArrayElement();
            int highest = GetHighestArrayElement();
            int sum     = GetSumOfArrayElements();
            double avg  = GetAvgOfArrayElements(sum);
            ////WriteLine("Sum = " + sum.ToString() +
            ////          "\nAvg = " + avg.ToString("n2"));
            DisplayStats(lowest, highest, sum, avg);
            SortArrayInAscendingOrderAndDisplay();
            SortArrayInDescendingOrderAndDisplay();
            ReadLine();
        }

        //  Fill the numbers array with 25 random numbers between 1 - 100
        static void FillArray()
        {
            string outputStr = "";

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                numbers[lcv] = rand.Next(MINNUMBER, MAXNUMBER);
                outputStr += numbers[lcv] + " ";
            }

            WriteLine("The Original Array\n" + outputStr);
        }

        //  Find the smallest number in the array
        static int GetLowestArrayElement()
        {
            int lowest = numbers[0];

            for (int lcv = 1; lcv < numbers.Length; lcv++)
            {
                if (numbers[lcv] < lowest)
                {
                    lowest = numbers[lcv];
                    //WriteLine("The current value of lowest is: " + lowest.ToString());
                    //ReadLine();
                }
            }

            return lowest;
        }

        //  Find the largest number in the array
        static int GetHighestArrayElement()
        {
            int highest = numbers[0];

            for (int lcv = 1; lcv < numbers.Length; lcv++)
            {
                if (numbers[lcv] > highest)
                {
                    highest = numbers[lcv];

                    //WriteLine("The current value of highest is: " + highest.ToString());
                    //ReadLine();
                }
            }

            return highest;
        }

        static int GetSumOfArrayElements()
        {
            int sum = 0;

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                sum += numbers[lcv];
                //WriteLine("The current sum is: " + sum.ToString());
                //ReadLine();
            }

            return sum;
        }

        static double GetAvgOfArrayElements(int sum)
        {
            return (double)sum / numbers.Length;
        }

        static void DisplayStats(int l, int h, int s, double a)
        {
            string outputStr = "\nArray Statistics\n";
            outputStr += ("-----------------\n");
            outputStr += " Lowest Array Element Value: " + l.ToString();
            outputStr += "\nHighest Array Element Value: " + h.ToString();
            outputStr += "\nSum Of Array Element Values: " + s.ToString();
            outputStr += "\nAvg Of Array Element Values: " + a.ToString("n2");
            outputStr += "\n";

            WriteLine(outputStr);
            ReadLine();
        }

        static void SortArrayInAscendingOrderAndDisplay()
        {
            Array.Sort(numbers);
            DisplaySortedArray(1);
        }

        static void SortArrayInDescendingOrderAndDisplay()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            DisplaySortedArray(2);
        }

        static void DisplaySortedArray(int t)
        {
            string outputStr = "";

            Write("\nArray In ");
            Write((t == 1) ? "Ascending " : "Descending ");
            WriteLine("Order");

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                outputStr += numbers[lcv].ToString() + " ";
            }

            WriteLine(outputStr);
        }
    }
}
