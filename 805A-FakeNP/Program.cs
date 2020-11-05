using System;

namespace _805A_FakeNP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int l = Convert.ToInt32(input[0]);
            int r = Convert.ToInt32(input[1]);

            int divisor = 2;
            int occurence = 0;
            int maxOccurence = 0;

            if(l == r)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = l; j <= r; j++)
                    {
                        if (j % i == 0)
                        {
                            occurence++;
                        }
                    }

                    if (occurence > maxOccurence)
                    {
                        divisor = i;
                        maxOccurence = occurence;
                        occurence = 0;
                    }
                    else
                    {
                        occurence = 0;
                    }
                }

                Console.WriteLine(divisor);
            }
        }
    }
}
