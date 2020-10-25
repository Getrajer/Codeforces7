using System;

namespace _12003A_CircleOfStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] solutions = new string[n];


            for(int i = 0; i < n; i++)
            {
                int s = Convert.ToInt32(Console.ReadLine());

                int previous = 0;
                int current = 0;

                int counter = 0;

                string[] students_str = Console.ReadLine().Split();
                bool clokvise = false;
                for (int j = 0; j < s; j++)
                {
                    if(i == 0)
                    {
                        previous = Convert.ToInt32(students_str[j]);
                        current = Convert.ToInt32(students_str[j]);
                        counter++;
                    }
                    else if(i == 1)
                    {
                        current = Convert.ToInt32(students_str[j]);

                        if(current == previous - 1)
                        {
                            clokvise = false;
                            previous = current;
                            counter++;
                        }
                        else if(current == previous + 1)
                        {
                            clokvise = true;
                            previous = current;
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if(clokvise == true)
                    {
                        current = Convert.ToInt32(students_str[j]);
                        if (current == previous + 1)
                        {
                            previous = current;
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if(clokvise == false)
                    {
                        current = Convert.ToInt32(students_str[j]);

                        if(current == previous - 1)
                        {
                            previous = current;
                            counter++;
                        }
                        else if(previous == 1 && current == s)
                        {
                            previous = current;
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if(counter == s)
                {
                    solutions[i] = "YES";
                }
                else
                {
                    solutions[i] = "NO";
                }

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(solutions[i]);
            }
        }
    }
}
