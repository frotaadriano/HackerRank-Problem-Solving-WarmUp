using System;
using System.Linq;

namespace HackerRank
{
    public class MiniMaxSum
    {
        public void Start()
        {

            Console.WriteLine("Create the array (length = 5) typing spaces (1 2 3)");
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            long minSum = arr.Sum() - arr.Max();
            long maxSum = arr.Sum() - arr.Min();
           
            Console.WriteLine("Result is: ");

            Console.WriteLine("{0} {1}", minSum, maxSum);
             

            Console.ReadKey();

        }
 
    }
}