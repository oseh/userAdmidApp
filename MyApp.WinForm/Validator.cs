using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.WinForm
{
    class Validator
    {
        string FN;
        string SN;
        bool IA;
        string DoB;


        public Validator(string fn, string sn, bool ia, string dob)
        {
             FN = fn;
             SN = sn;
             IA = ia;
             DoB = dob;
        }

        // calculates the numbers of years between 2 dates 
        private int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }

        // checks to see if surename or forename is valid 
        public bool isValidName()
        {
            if (FN == string.Empty || SN == string.Empty || FN.Length > 20 || SN.Length > 20)
            {
                MessageBox.Show("Name fields can't be empty or larger than 20 characters!");
                return false;
            }
            else
                return true;
        }

        // checks to see if date of birth is valid
        public bool IsValidDateOfBirth()
        {
            string[] formats = { "dd/MM/yyyy" };
            DateTime parsedDateTime;
            bool validDate = DateTime.TryParseExact(DoB, formats, Thread.CurrentThread.CurrentCulture,
                                           DateTimeStyles.None, out parsedDateTime);
            int age = Years(parsedDateTime, DateTime.Now);

            bool inPast = parsedDateTime < DateTime.Now;
            if (!validDate)
                MessageBox.Show("Date format is incorrect, correct: dd/MM/yyyy.");
            else if (!inPast)
                MessageBox.Show("Date must be in the past");
            else if (age > 150)
                MessageBox.Show("Age is too high, must be less that 150");


            // return true if the date is valid and is not in the future 
            return (validDate && inPast && age < 150);
        }
    }
}
