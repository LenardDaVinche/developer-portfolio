using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        // Properties   / fields
        public string firstname;
        public string lastname;
        public DateTime dob;
        public int annual_salary;

        public string GetInfo()
        {
            string info = firstname + " " + lastname;
            info += ". DOB = " + dob.ToString();
            info += ". Salary = £" + annual_salary.ToString();

            return info;
        }

        public string CalculateAge()
    {
        TimeSpan span = DateTime.Now - this.dob;
        DateTime age = DateTime.MinValue + span;

        int ageYear = age.Year - 1;
        int ageMonth = age.Month - 1;
        int ageDay = age.Day - 1;

        string dobString = ageYear.ToString() + " years, " + ageMonth.ToString() + " months, " + ageDay.ToString() + " days old.";

        return dobString;
    }

    public string CalculateTotalEarnings()
    {
        TimeSpan span = DateTime.Now - this.dob;
        DateTime age = DateTime.MinValue + span;


        int ageYear = age.Year - 1;
        int ageMonth = age.Month - 1;
        int ageDay = age.Day - 1;

        int total_earnings = 0;

        if (ageYear >= 21)
        {
            total_earnings = (ageYear - 21) * annual_salary;
            double fraction = (Convert.ToDouble(ageMonth * 30 + ageDay) / 365);
            total_earnings += Convert.ToInt32(annual_salary * fraction);
        }

        return "Your overall earnings since 21 years of age are £" + total_earnings.ToString();
    }
}
}
