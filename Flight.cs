using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnandhuPMCodingChallengeNov14
{
    internal class Flight
    {
		private float _fare;

		public float FlightFare
		{
			get { return _fare; }
			set 
			{
				float temp = Convert.ToInt32(_bookingTime);
				if(temp >= 6 && temp< 9)
				{
					temp = 10;
				}
				else if(temp >= 9 && temp< 17)
				{
					temp = 20;
				}
				else if(temp >= 17 && temp<23)
				{
					temp = 7;
				}
				else
				{
					temp = 5;
				}
                _fare = value;
				_fare = _fare + ( _fare * (float)(temp/100));
				Console.WriteLine($"Increase in Fare Price {temp}% Booking Fare is : {_fare} ");
			}
		}

		private string _bookingTime;

		public string BookingTime
		{
			get { return  _bookingTime; }
			set 
			{ 
				_bookingTime = value;
				string[] time = value.Split(' ');
				if (time[1] == "PM")
				{	
					int _time = Convert.ToInt32(time[0]);
					_time += 12;
					_bookingTime = Convert.ToString(_time);	
					Console.WriteLine(_time);
					return;
				}else if (time[0] == "12")
				{
                    int _time = Convert.ToInt32(time[0]);
                    _time = 0;
                    _bookingTime = Convert.ToString(_time);
					return;
                }
				_bookingTime = time[0];

			}
		}


	}
}
