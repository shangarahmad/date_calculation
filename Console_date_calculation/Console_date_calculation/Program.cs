using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_date_calculation
{
    using System;

    public class Program
    {
        public static int getAge(int month, int day, int year)
        {
            DateTime today = DateTime.Today;
            int atthisDay = today.Day;
            int atthisYear = today.Year;
            int atthisMonth = today.Month;
            int age = 0;
            if (atthisMonth < month)
            {
                age -= 1;
            }
            else if (atthisMonth == month)
            {
                if (atthisDay < day)
                {
                    age -= 1;
                }
            }
            atthisYear -= year;
            age += atthisYear;
            return age;
        }
        public static void Main()
        {
            int ageInYears = getAge(3, 3, 2000);
            Console.WriteLine(ageInYears);
        }
    }
}
