using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ArrayGUI
{
    public partial class frmArrayFun : Form
    {
        public frmArrayFun()
        {
            InitializeComponent();
        }

        //  Declare and Initialize Program constant
        const int LEN = 25;

        //  Declare and Initialize global variables
        int[] numbers = new int[LEN];
        int theSum = 0;
        double theAvg = 0.0;

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            FillArray();
        }

        private void FillArray()
        {
            Random rand = new Random();

            ClearListBox();

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                numbers[lcv] = rand.Next(0, 101);
                lstNumber.Items.Add(numbers[lcv]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            lstNumber.Items.Clear();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortAscending();
        }

        private void SortAscending()
        {
            Array.Sort(numbers);
            DisplayArray();
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortDescending();
        }

        private void SortDescending()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            DisplayArray();
        }

        private void DisplayArray()
        {
            ClearListBox();

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                lstNumber.Items.Add(numbers[lcv]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformTheSearch();
        }

        private void PerformTheSearch()
        {
            SortAscending();

            try
            {
                string valStr = Interaction.InputBox(
                                "Number To Search For",
                                "SEARCH",
                                "50", 450, 200);

                int value = Convert.ToInt32(valStr);

                if ((value < 0) || (value > 100))
                {
                    throw new ArgumentOutOfRangeException();
                }

                int result = Array.BinarySearch(numbers, value);

                if (result < 0)
                {
                    ShowMessage("The Value " + value.ToString() +
                                " WAS NOT Found In The Array",
                                "VALUE NOT FOUND");
                }
                else
                {
                    ShowMessage("The Value " + value.ToString() +
                                " WAS Found In The Array At Location " +
                                result.ToString(),
                                "VALUE WAS FOUND");
                }
            }
            catch (FormatException fe)
            {
                ShowMessage("Illegal Search Value\n" + fe.Message,
                            "SEARCH VALUE BLANK OR NON-NUMERIC");
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowMessage("Out Of Range Search Value\n" + aoore.Message,
                            "SEARCH VALUE OUT-OF-RANGE");
                return;
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillArray();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            CalculateTheSum(1);
        }

        private void CalculateTheSum(int n)
        {
            if (lstNumber.Items.Count == 0)
            {
                ShowMessage("There Is Nothing To Add!",
                            "LISTBOX CURRENTLY EMPTY!");
                return;
            }

            theSum = 0;
            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                theSum += numbers[lcv];
            }

            if (n == 1)
            {
                ShowMessage("The sum of all array elements is: "
                            + theSum.ToString(),
                            "SUM OF ALL ARRAY ELEMENTS");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (theSum != 0)
            {
                theAvg = (double) theSum / (double) numbers.Length;
            }
            else
            {
                CalculateTheSum(2);
                theAvg = (double)theSum / (double)numbers.Length;
            }

            ShowMessage("The average of all array elements is: " +
                        theAvg.ToString("n2"),
                        "LISTBOX CURRENTLY EMPTY");
             return;

        }

        private void btnLowest_Click(object sender, EventArgs e)
        {
            FindTheSmallestValue();
        }

        private void FindTheSmallestValue()
        {
            int lowest = numbers[0];

            if (lstNumber.Items.Count == 0)
            {
                ShowMessage("There Are No Values In ListBox!",
                            "LISTBOX CURRENTLY EMPTY!");
                return;
            }

            SortAscending();

            //for (int lcv = 1; lcv < numbers.Length; lcv++)
            //{
            //    if (numbers[lcv] < lowest)
            //    {
            //        lowest = numbers[lcv];
            //    }
            //}

            ShowMessage("The Smallest Number In The Array Is: " +
                        numbers[0].ToString(),
                        "SMALLEST ARRAY ELEMENT VALUE");
        }

        private void FindTheLargestValue()
        {
            int largest = numbers[0];

            if (lstNumber.Items.Count == 0)
            {
                ShowMessage("There Are No Values In ListBox!",
                            "LISTBOX CURRENTLY EMPTY!");
                return;
            }

            SortDescending();

            //for (int lcv = 1; lcv < numbers.Length; lcv++)
            //{
            //    if (numbers[lcv] > largest
            //    {
            //        largest = numbers[lcv];
            //    }
            //}

            ShowMessage("The Largest Number In The Array Is: " +
                        numbers[0].ToString(),
                        "LARGEST ARRAY ELEMENT VALUE");
        }

        private void btnHighest_Click(object sender, EventArgs e)
        {
            FindTheLargestValue();
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            FindTheMedian();
        }

        private void FindTheMedian()
        {
            SortAscending();
            ShowMessage("The Median In The Array Is: " +
                        numbers[12].ToString(),
                        "MEDIAN ARRAY ELEMENT VALUE");
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            FindTheRange();
        }

        private void FindTheRange()
        {
            SortDescending();
            int range = numbers[0] - numbers[numbers.Length - 1];

            ShowMessage("The Range In The Array Is: " +
                        range.ToString(),
                        "RANGE IN ARRAY");
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
