using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnandhuPMCodingChallengeNov14
{
    internal class Dob
    {
        public DateOnly DateofBirth;
        public DateOnly Today;

        public void SetData()
        {
            Console.WriteLine("Enter DOB : ");
            DateofBirth = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Today : ");
            Today = DateOnly.Parse(Console.ReadLine());
        }
        public void GetData()
        {
            Console.WriteLine("DOB : "+DateofBirth);

        }
        public void Details()
        {
            var days = Today.DayNumber - DateofBirth.DayNumber;
            var hours = days * 24;
            Console.WriteLine("No of Days : "+days);
            Console.WriteLine("No of hours : " + hours);
            Console.WriteLine("No of Weeks : " + days / 7);
            Console.WriteLine("No of months : " + days / 30);
            Console.WriteLine("No of Years : " + days / 365);
            var years = DateofBirth.Year;
            if( years % 400 == 0)
            {
                Console.WriteLine($"{DateofBirth} is a leap Year ");
            }
            else if( years % 100 != 0 && years % 400 ==0)
            {
                Console.WriteLine($"{DateofBirth} is a leap Year ");

            }
            else
            {
                Console.WriteLine($"{DateofBirth} is Not a leap Year ");

            }


        }
    }
}
