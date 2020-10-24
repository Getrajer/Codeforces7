using System;

namespace _116b_PolycarpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            int[] contests = new int[n];

            for(int i = 0; i < n; i++)
            {
                contests[i] = Convert.ToInt32(input[i]);
            }

            Array.Sort(contests);


        }
    }
}
