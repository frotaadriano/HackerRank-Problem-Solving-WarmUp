using System;

namespace HackerRank
{
    //class Program
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    int n = Convert.ToInt32(Console.ReadLine());
    //    //    string[] ar_temp = Console.ReadLine().Split(' ');
    //    //    int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
    //    //    int result = simpleArraySum(n, ar);
    //    //    Console.WriteLine(result);
    //    //}

    //    //static int simpleArraySum(int n, int[] ar)
    //    //{
    //    //    var sum = 0;

    //    //    for (int i = 0; i < n; i++)
    //    //    {
    //    //        sum += ar[i];
    //    //    }
    //    //    return sum;
    //    //}

    //}


    public class CompareTheTriplets
    {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int aliceScore = 0;
            int bobScore = 0;
            
            Compare2Scores(a0, b0, ref aliceScore, ref bobScore);
            Compare2Scores(a1, b1, ref aliceScore, ref bobScore);
            Compare2Scores(a2, b2, ref aliceScore, ref bobScore);
            
            int[] result = { aliceScore , bobScore};

            return result;

        }
        private static void Compare2Scores(int firstValue, int secoundValue, ref int aliceScore, ref int bobScore)
        {
            if (firstValue > secoundValue)
            {
                aliceScore++;
            }
            else if (firstValue < secoundValue)
            {
                bobScore++;
            }
        }

        public void Start()
        {
            
            string description = " https://www.hackerrank.com/challenges/compare-the-triplets/problem";
            
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Type the 3 Values to Alice separeted by space (ex: 1 2 3:) ");
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            Console.WriteLine("Type the 3 Values to BOB separeted by space (ex: 1 2 3:) ");
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.Write("Result is: ");

            Console.WriteLine(String.Join(" ", result));
                      

            Console.ReadKey();

        }

    }
}
