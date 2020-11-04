using System;

namespace _1251A_BrokenKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] results = new string[n];

            for(int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if(text.Length == 1)
                {
                    results[i] = text;
                }
                else
                {
                    for(int j = 0; j < text.Length; j++)
                    {
                        if(j == 0)
                        {

                        }
                        else
                        {
                            if(text == "")
                            {
                                break;
                            }

                            if(text[j-1] == text[j])
                            {
                                text = text.Remove(j - 1, 2);
                                if(text != "")
                                {
                                    j -= 2;
                                }
                                else
                                {
                                    break;
                                }
                                
                            }
                            else
                            {
                            }
                        }
                    }

                    results[i] = text;
                }
            }


            for(int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
