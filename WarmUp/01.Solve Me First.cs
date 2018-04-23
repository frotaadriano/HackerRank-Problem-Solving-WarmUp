using System;

namespace HackerRank
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int val1 = Convert.ToInt32(Console.ReadLine());
    //        int val2 = Convert.ToInt32(Console.ReadLine());
    //        int sum = solveMeFirst(val1, val2);
    //        Console.WriteLine(sum);
    //        Console.ReadKey();

    //    }

    //    static int solveMeFirst(int a, int b)
    //    {
    //        // Hint: Type return a+b; below  
    //        return a + b;
    //    }
    //}
    public class SolveMeFirst
    {
        static int solveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            return a + b;
        }

        public void Start()
        {
            Console.WriteLine("Description: Sum of Two values");
            Console.Write("Type the first value: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the secound value: ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.Write("Result is: ");
            Console.WriteLine(sum);
            Console.ReadKey();

        }

    }

}
