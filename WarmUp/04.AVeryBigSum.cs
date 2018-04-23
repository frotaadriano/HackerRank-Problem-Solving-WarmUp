using System;

namespace HackerRank
{
    public class AVeryBigSum
    { 
        public void Start()
        {

            Console.WriteLine("Description:  https://www.hackerrank.com/challenges/a-very-big-sum/problem" );
            Console.Write("Type the length of array ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Create Long Number array separeted by spaces ");
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);

            Console.Write("Resultado: ");
            Console.WriteLine(result);
            Console.ReadKey();   

        }

        private long aVeryBigSum(int n, long[] ar)
        {
            long sumOfLongArray = 0;
                
            for (int i = 0; i < n; i++)
            {
                sumOfLongArray += ar[i];
            }

            return sumOfLongArray;
        }
    }
}