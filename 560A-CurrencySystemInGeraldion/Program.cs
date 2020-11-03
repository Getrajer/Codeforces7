using System;

namespace _560A_CurrencySystemInGeraldion
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();

            int[] arrayNum = new int[m];

            for(int i = 0; i < m; i++)
            {
                int n = Convert.ToInt32(numbers[i]);

                if(n == 1)
                {
                    Console.WriteLine(-1);
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine(1);

        }
    }
}
