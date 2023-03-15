using System;

namespace Test02
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string star = "*";
            string input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);

            for (int i = 1; i < input_number; i--)
            {
                for (int j = 0; i < j; j--)
                {
                    Console.Write(star);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}