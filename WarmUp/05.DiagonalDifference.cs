using System;

namespace HackerRank
{
    public class DiagonalDifference
    {
        public int diagonalDifference(int[][] a)
        {
            int primaryDiagonal = 0;
            int secoundDiagonal = 0;
            int arrayLength = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                primaryDiagonal += a[i][i];
                secoundDiagonal += a[i][arrayLength-i];

            }

            return Math.Abs(primaryDiagonal - secoundDiagonal);
        }
        public void Start()
        {
            Console.WriteLine("Description: https://www.hackerrank.com/challenges/diagonal-difference/problem");
            Console.Write("Type a INTEGER number that represents the length of array");

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                Console.WriteLine("Crie a linha [" + a_i + " ] da matrix!");
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.Write("Result is: ");

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}