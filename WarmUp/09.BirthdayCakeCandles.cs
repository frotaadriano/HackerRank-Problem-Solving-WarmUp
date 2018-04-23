using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank
{
    public class BirthdayCakeCandles
    {
        public BirthdayCakeCandles()
        {

        }

        public void Start()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public int birthdayCakeCandles(int n, int[] ar)
        {
            var maxValue = ar.Max();
            var candleCount = 0;

            for (int i = 0; i < n; i++)
            {
                if(ar[i] == maxValue)
                {
                    candleCount++;
                }
            }
            return candleCount;
        }
    }
    
}