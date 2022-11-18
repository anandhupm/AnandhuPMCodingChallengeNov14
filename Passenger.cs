using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnandhuPMCodingChallengeNov14
{
    internal class Passenger
    {
        public string Name { get; set; }
		private int _miles;
		private int _points;
		private DateOnly _dob;
		private int age;

		public DateOnly Dob
		{
			get { return _dob; }
			set 
			{
				_dob = value;
                var date = DateOnly.Parse(DateTime.UtcNow.ToString("dd-MM-yyyy"));
				var age = date.DayNumber - _dob.DayNumber;
				age = age / 365;
				
				if(age > 60)
				{
					Console.WriteLine("Older");
				}
				else if(age > 30)
				{
                    Console.WriteLine("Adult");

                }
                else if (age > 10)
                {
                    Console.WriteLine("Youth");

				}
				else
				{
					Console.WriteLine("Kid");
				}


            }
        
		}
        public void SetData()
        {
            Console.WriteLine("Enter DOB : ");
            Dob = DateOnly.Parse(Console.ReadLine());
        }

        public int Miles
		{
			get { return _miles; }
			set 
			{
				_miles = value;
				if(value > 1000000)
				{
					_points = 50;
				}
				else if(value> 50000)
				{
                    _points = 30;

                }
                else if (value > 20000)
                {
					_points = 20;

                }
                else
				{
					_points = 10;
				}
				Console.WriteLine($"You got {_points} Points..!!!");
            }
		}

	}
}
