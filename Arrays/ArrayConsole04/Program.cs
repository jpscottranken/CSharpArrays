using System;
using static System.Console;

namespace ArrayConsole04
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int NUMSTUDENTS = 6;
        const int MINTESTSCORE = 0;
        const int MAXTESTSCORE = 100;
        static void Main(string[] args)
        {
            string[] studentNames = new string[NUMSTUDENTS];
            int[] studentScores   = new int[NUMSTUDENTS];

            InputNamesAndGrades(studentNames, studentScores);
            FigureStatistics(studentScores);
        }

        static void InputNamesAndGrades(string[] sn, int[] ss)
        {
            try
            {
                //  Input student names and
                //  their associated test scores
                for (int lcv = 0; lcv < sn.Length; lcv++)
                {
                    //  Input each student name
                    Write("\nInput Student #" + (lcv + 1) + " Name: ");
                    sn[lcv] = ReadLine();

                    //  Input each student test score
                    Write("Input Student #" + (lcv + 1) + " Score: ");
                    ss[lcv] = Convert.ToInt32(ReadLine());

                    //  Range check for score < 0 or score > 100
                    if ((ss[lcv] < MINTESTSCORE) || (ss[lcv] > MAXTESTSCORE))
                    {
                        throw new ArgumentOutOfRangeException(
                                "You Entered A Score < " + MINTESTSCORE.ToString() +
                                " Or > " + MAXTESTSCORE.ToString());
                    }
                }
            }
            catch (FormatException fe)
            {
                WriteLine("\nNon-Numeric Input.\nAssociated Message Was: " +
                          fe.Message + "\nProgram Closing Now");
                ReadLine();
                Environment.Exit(0);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                WriteLine("\nOut Of Range Input.\nAssociated Message Was: " +
                          aoore.Message + "\nProgram Closing Now");
                ReadLine();
                Environment.Exit(0);
            }
        }

        static void FigureStatistics(int[] ss)
        {
            //WriteLine("\n\nIn Figure Statistics Function");
            int lowScore    = DetermineLowestScore(ss);
            int highScore   = DetermineHighestScore(ss);
            int sumScore    = DetermineSumOfAllScores(ss);
            double avgScore = DetermineAverageScore(sumScore);
            //WriteLine("Average Score Is: " + avgScore.ToString("n2"));
            DisplayStatistics(lowScore, highScore, sumScore, avgScore);

            ReadLine();
        }

        static int DetermineLowestScore(int[] ss)
        {
            int low = MAXTESTSCORE + 1;

            for (int lcv = 0; lcv < ss.Length; lcv++)
            {
                if (ss[lcv] < low)
                {
                    low = ss[lcv];
                    //WriteLine("Current Lowest Score Is: " + low.ToString());
                }

            }

            return low;
        }

        static int DetermineHighestScore(int[] ss)
        {
            int high = MINTESTSCORE - 1;

            for (int lcv = 0; lcv < ss.Length; lcv++)
            {
                if (ss[lcv] > high)
                {
                    high = ss[lcv];
                    //WriteLine("Current Highest Score Is: " + high.ToString());
                }

            }

            return high;
        }

        static int DetermineSumOfAllScores(int[] ss)
        {
            int sum = 0;

            for (int lcv = 0; lcv < ss.Length; lcv++)
            {
                sum += ss[lcv];
                //WriteLine("Current Value Of Sum Is: " + sum.ToString());
            }

            return sum;
        }

        static double DetermineAverageScore(int sumScore)
        {
            return (double)sumScore / NUMSTUDENTS;
        }

        static void DisplayStatistics(int low, int high, 
                                      int sum, double avg)
        {
            string outputStr = "\n\n";
            outputStr += "Array Stats Program:\n";
            outputStr += "--------------------\n";
            outputStr += "Lowest Test Score:\t"    + low.ToString();
            outputStr += "\nHighest Test Score:\t" + high.ToString();
            outputStr += "\nSum Of Test Scores:\t" + sum.ToString();
            outputStr += "\nAvg Of Test Scores:\t" + avg.ToString("n2");

            WriteLine(outputStr);

            ReadLine();
        }

    }
}
