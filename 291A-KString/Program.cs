using System;
using System.Collections.Generic;

namespace _291A_KString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string text = Console.ReadLine();

            List<string> characers = new List<string>();

            for(int i = 0; i < text.Length; i++)
            {
                int j = 0;

                bool isThere = false;

                while (j < characers.Count)
                {
                    if(characers[j][0] == text[i])
                    {
                        characers[j] += text[i];
                        isThere = true;
                    }

                    j++;
                }

                if (isThere == false)
                {
                    characers.Add(text[i].ToString());
                }
            }


            if(characers.Count == n)
            {
                bool isNotCorrect = false;
                for(int i = 0; i < characers.Count; i++)
                {
                    if(characers[0].Length != characers[i].Length)
                    {
                        Console.WriteLine(-1);
                        isNotCorrect = true;
                        break;
                    }
                }

                if (!isNotCorrect)
                {
                    for (int i = 0; i < characers.Count; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(characers[j][0]);
                        }
                    }
                }

            }
            else if(characers[0].Length == n && characers.Count == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(characers[0][0]);
                }
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
