using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregorianToPerennial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputBX.Font = new Font("Sans Serif", 10);
            dateIN.Value = DateTime.Today;
            Main();
        }
        private TimeSpan findDiff(DateTime x, DateTime y)
        {
            return (y - x);
        }
        private string getPRDay(int x, bool q)
        {
            string y = "";
            x = x % 7;
            if(q)
            {
                x++;
            }
            switch(x)
            {
                case 1:
                    y = "Sunday";
                    break;
                case 2:
                    y = "Monday";
                    break;                  
                case 3:
                    y = "Tuesday";
                    break;
                case 4:
                    y = "Wednesday";
                    break;
                case 5:
                    y = "Thursday";
                    break;
                case 6:
                    y = "Friday";
                    break;
                case 0:
                    y = "Saturday";
                    break;
            }
            return y;
        }
        private void dateIN_ValueChanged(object sender, EventArgs e)
        {
            Main();
        }
        private void Main()
        {
            string prDateDay, prDateDate = "", prDateMonth = "";            
            string prDateYear = dateIN.Value.Year.ToString();
            DateTime date = dateIN.Value;
            DateTime jan1 = new DateTime(dateIN.Value.Year, 1, 1, 0, 0, 0);
            TimeSpan diff = findDiff(date, jan1);
            int diffDays = (int)diff.TotalDays;
            diffDays = (diffDays * -1) + 1;
            System.Diagnostics.Debug.Write("diffDays: " + diffDays);

            bool sndTRUE;
            if (sundayStrtTRUE.Checked)
            {
                sndTRUE = true;
            }
            else
            {
                sndTRUE = false;
            }
            prDateDay = getPRDay(diffDays, sndTRUE);

            if (diffDays < 29)
            {
                prDateDate = diffDays.ToString();
                prDateMonth = "January";
            }
            if (diffDays > 28 && diffDays < (28 * 2) + 1)
            {
                prDateDate = (diffDays - 28).ToString();
                prDateMonth = "February";
            }
            if (diffDays > 28 * 2 && diffDays < (28 * 3) + 1)
            {
                prDateDate = (diffDays - 28 * 2).ToString();
                prDateMonth = "March";
            }
            if (diffDays > 28 * 3 && diffDays < (28 * 4) + 1)
            {
                prDateDate = (diffDays - 28 * 3).ToString();
                prDateMonth = "April";
            }
            if (diffDays > 28 * 4 && diffDays < (28 * 5) + 1)
            {
                prDateDate = (diffDays - 28 * 4).ToString();
                prDateMonth = "May";
            }
            if (diffDays > 28 * 5 && diffDays < (28 * 6) + 1)
            {
                prDateDate = (diffDays - 28 * 5).ToString();
                prDateMonth = "June";
            }
            if (diffDays > 28 * 6 && diffDays < (28 * 7) + 1)
            {
                prDateDate = (diffDays - 28 * 6).ToString();
                prDateMonth = "Sol";
            }
            if (diffDays > 28 * 7 && diffDays < (28 * 8) + 1)
            {
                prDateDate = (diffDays - 28 * 7).ToString();
                prDateMonth = "July";
            }
            if (diffDays > 28 * 8 && diffDays < (28 * 9) + 1)
            {
                prDateDate = (diffDays - 28 * 8).ToString();
                prDateMonth = "August";
            }
            if (diffDays > 28 * 9 && diffDays < (28 * 10) + 1)
            {
                prDateDate = (diffDays - 28 * 9).ToString();
                prDateMonth = "September";
            }
            if (diffDays > 28 * 10 && diffDays < (28 * 11) + 1)
            {
                prDateDate = (diffDays - 28 * 10).ToString();
                prDateMonth = "October";
            }
            if (diffDays > 28 * 11 && diffDays < (28 * 12) + 1)
            {
                prDateDate = (diffDays - 28 * 11).ToString();
                prDateMonth = "November";
            }
            if (diffDays > 28 * 12 && diffDays < (28 * 13) + 1)
            {
                prDateDate = (diffDays - 28 * 12).ToString();
                prDateMonth = "December";
            }
            if (diffDays == 365 || diffDays == 366)
            {
                prDateDay = "";
                prDateDate = "Year";
                prDateMonth = "Day";
            }
            // OUTPUT
            outputBX.Text = string.Format("{0} {1} {2} {3}", prDateDay, prDateDate, prDateMonth, prDateYear);
        }

        private void sundayStrtTRUE_CheckedChanged(object sender, EventArgs e)
        {
            Main();
        }
    }
}
