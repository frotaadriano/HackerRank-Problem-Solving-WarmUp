using System;

namespace HackerRank
{ 
      public class Staircase
    {


        public void Start()
        {
            Console.WriteLine("Description: https://www.hackerrank.com/challenges/diagonal-difference/problem");
            Console.Write("Type a INTEGER number that represents the length of array");




            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is: ");
            staircase(n);

            



            Console.ReadKey();

        }

        private void staircase(int n)
        {
            var stair = "";
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(stair.PadLeft(n-i, ' ') + stair.PadRight(i, '#')); 
            }
        }
    }
}