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

            int task_c = 1;
            int training = 0;

            for(int i = 0; i < contests.Length; i++)
            {
                if(task_c <= contests[i])
                {
                    training++;
                    task_c++;
                }
            }

            Console.WriteLine(training);
        }
    }
}
