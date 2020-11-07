using System;

namespace _1195B_SportMafia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int moves = Convert.ToInt32(input[0]);
            int candiesLeft = Convert.ToInt32(input[1]);

            int candies = 0;

            int c = 1;

            int eatenCandies = 0;

            for(int i = 0; i < moves; i++)
            {
                if(candiesLeft > candies)
                {
                    candies += c;
                    c++;
                }
                else
                {
                    eatenCandies++;
                    candies -= 1;
                }
            }


            Console.WriteLine(eatenCandies);

        }
    }
}
