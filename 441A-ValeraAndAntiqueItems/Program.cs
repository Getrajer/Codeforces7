using System;
using System.Collections.Generic;

namespace _441A_ValeraAndAntiqueItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = Convert.ToInt32(input[0]);
            int money = Convert.ToInt32(input[1]);

            List<int> sellers = new List<int>();

            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();

                int seller_nr = Convert.ToInt32(input[0]);

                for(int j = 1; j < input.Length; j++)
                {
                    int price = Convert.ToInt32(input[j]);

                    if(price < money)
                    {
                        sellers.Add(i + 1);
                        break;
                    }
                }
            }


            if(sellers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sellers.Count);

                sellers.Sort();

                for (int i = 0; i < sellers.Count; i++)
                {
                    Console.Write($"{sellers[i]} ");
                }
            }

        }
    }
}
