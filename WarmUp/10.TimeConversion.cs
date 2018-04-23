using System;

namespace HackerRank
{

    public class TimeConversion
    {


        public void Start()
        {
            Console.WriteLine("Description: https://www.hackerrank.com/challenges/diagonal-difference/problem");
            Console.Write("Time like : 07:05:45PM to 19:05:45");


            string s = Console.ReadLine();
            string result = timeConversion(s);

            Console.WriteLine("Result is: ");

            Console.WriteLine(result);




            Console.ReadKey();

        }

        private string timeConversion(string s)
        {
            //DateTime dateTime = DateTime.ParseExact(time, "hh:mm:sstt",
            //System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(dateTime.ToString("HH:mm:ss"));


            var detecAMOrPM = s.Substring(s.Length - 2, 2);
            var timeWithoutAMPM = s.Replace(detecAMOrPM, "");
            var timeTWithout2FirstNumbers = Convert.ToInt16(s.Substring(0, 2));
            var dateConverted = "";

            if (detecAMOrPM.Equals("PM"))
            {
                if (timeTWithout2FirstNumbers.Equals(12))
                {
                    dateConverted = timeWithoutAMPM;
                }
                else
                {
                    var plus12 = timeTWithout2FirstNumbers + 12;
                    var restOfTime = timeWithoutAMPM.Substring(2, timeWithoutAMPM.Length - 2);
                    dateConverted = plus12.ToString() + restOfTime;
                }
            }
            else
            {
                if (timeTWithout2FirstNumbers.Equals(12))
                {
                    var restOfTime = timeWithoutAMPM.Substring(2, timeWithoutAMPM.Length - 2);
                    dateConverted = "00" + restOfTime;
                }
                else
                {
                    dateConverted = timeWithoutAMPM;
                }

            }

            return dateConverted;

        }
    }
}