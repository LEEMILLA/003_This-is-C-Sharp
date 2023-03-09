using System;

namespace Test1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string star = "*";
            

            Console.WriteLine("*을 몇 번 돌리겠습니까?");
            string input = Console.ReadLine();
            int input_number = Convert.ToInt32(input);

            for (int i = 1; i < input_number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(star);

                }
                    Console.WriteLine();

            }
        }
    }
}