using System;

namespace test2_for
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 0;


            for (i = 5; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
                
            }
            
        }
    }
}