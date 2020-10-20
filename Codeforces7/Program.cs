using System;

namespace _352AJeffAndDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] numbers_str = Console.ReadLine().Split();

            int[] numbers = new int[n];

            int fives = 0;
            int zeros = 0;

            

            for(int i = 0; i < numbers_str.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbers_str[i]);
                if (numbers[i] == 0) zeros++;
                if (numbers[i] == 5) fives++;
            }

            Array.Sort(numbers);

            if(zeros == 0)
            {
                Console.WriteLine(-1);
            }
            else if(fives < 9)
            {
                Console.WriteLine(0);
            }
            else
            {
                fives -= fives % 9;

                for(int i = 0; i < fives; i++)
                {
                    Console.Write(5);
                }

                for (int i = 0; i < zeros; i++)
                {
                    Console.Write(0);
                }
            }

        }
    }
}
