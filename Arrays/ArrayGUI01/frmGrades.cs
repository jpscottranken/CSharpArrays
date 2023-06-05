using System;
using System.Windows.Forms;

namespace ArrayGUI01
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const int MINGRADE =   0;
        const int MAXGRADE = 100;

        public void CalculateGrades()
        {
            int nGrade    = 0;
            string lGrade = "";
            bool result;

            //  Make non-numeric input check
            result = Int32.TryParse(txtNumberGrade.Text, out nGrade);
            if (!result)
            {
                ResetNumberTextBox();
                return;
            }

            //  There was a number in the textbox.
            //  So, make range check
            if ((nGrade < MINGRADE) || (nGrade > MAXGRADE))
            {
                ResetNumberTextBox();
                return;
            }

            //  Input was numeric and between 0 - 100
            //  So, calculate associated letter grade
            if (nGrade >= 90)
            {
                lGrade = "A";
            }
            else if (nGrade >= 80)
            {
                lGrade = "B";
            }
            else if (nGrade >= 70)
            {
                lGrade = "C";
            }
            else if (nGrade >= 60)
            {
                lGrade = "D";
            }
            else if (nGrade >= 0)
            {
                lGrade = "F";
            }

            //  Display Letter Grade
            txtLetterGrade.Text = lGrade;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateGrades();
        }

        private void ResetNumberTextBox()
        {
            txtLetterGrade.Text = "Invalid Input";
            txtNumberGrade.Text = "";
            txtNumberGrade.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
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
    }
}
