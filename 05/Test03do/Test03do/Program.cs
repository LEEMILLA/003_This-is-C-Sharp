using System;

namespace Test03do
{
    class MainApp
    {
        static void Main(string[] args)
        {

            int i = 0;
            int j = 0;

            do
            {
                    Console.Write("*");
                do
                {
                    Console.Write("*");
                }
                while (j < i);
                i = i + 1;
                Console.WriteLine();
                j++;
            }
            while (i < 6) ;

        }
    }
}