using System;

namespace HackerRank
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        string[] ar_temp = Console.ReadLine().Split(' ');
    //        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
    //        int result = simpleArraySum(n, ar);
    //        Console.WriteLine(result);
    //    }

    //    static int simpleArraySum(int n, int[] ar)
    //    {
    //        var sum = 0;

    //        for (int i = 0; i < n; i++)
    //        {
    //            sum += ar[i];
    //        }
    //        return sum;
    //    }

    //}
    public class SimpleArraySum
    {
        static int simpleArraySum(int n, int[] ar)
        {
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public void Start()
        {

            Console.WriteLine("Description: SimpleArraySum");
            Console.Write("Type length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type array values with space, ex: 1 2 3: ");
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);

            Console.Write("RESULT: ");
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }


}
