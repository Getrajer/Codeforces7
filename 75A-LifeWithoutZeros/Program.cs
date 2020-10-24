using System;

namespace _75A_LifeWithoutZeros
{
    class Program
    {
        static void Main(string[] args)
        {

            string number1_str = Console.ReadLine();
            string number2_str = Console.ReadLine();

            int number1 = Convert.ToInt32(number1_str);
            int number2 = Convert.ToInt32(number2_str);

            int first_result = number1 + number2;
            string first_result_str = first_result.ToString();
            

            string nd_number_1_str = "";

            for(int i = 0; i < number1_str.Length; i++)
            {
                if(number1_str[i] != '0')
                {
                    nd_number_1_str += number1_str[i];
                }
            }

            string nd_number_2_str = "";

            for (int i = 0; i < number2_str.Length; i++)
            {
                if (number2_str[i] != '0')
                {
                    nd_number_2_str += number2_str[i];
                }
            }

            string first_res_without_zer = "";

            for (int i = 0; i < first_result_str.Length; i++)
            {
                if(first_result_str[i] != '0')
                {
                    first_res_without_zer += first_result_str[i];
                }
            }

            int first_res_nozer = Convert.ToInt32(first_res_without_zer);

            int nd_number1 = Convert.ToInt32(nd_number_1_str);
            int nd_number2 = Convert.ToInt32(nd_number_2_str);

            int nd_result = nd_number1 + nd_number2;

            if(first_res_nozer == nd_result)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
