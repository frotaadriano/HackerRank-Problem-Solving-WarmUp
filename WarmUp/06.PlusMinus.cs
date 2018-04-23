using System;

namespace HackerRank
{
    public class PlusMinus
    {
        public void Start()
        {
            Console.WriteLine("Description: https://www.hackerrank.com/challenges/diagonal-difference/problem");
            Console.Write("Type a INTEGER number that represents the length of array");


            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Create the array typing spaces (1 2 3)");

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Console.Write("Result is: ");

            plusMinus(arr);




            Console.ReadKey();

        }

        private void plusMinus(int[] arr)
        {
            var positive = 0.0;
            var negative = 0.0;
            var zeroes = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zeroes++;
                }
            }
            Console.WriteLine(positive / arr.Length);
            Console.WriteLine(negative / arr.Length);
            Console.WriteLine(zeroes / arr.Length); 
        }
    }
}