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
                do
                {
                    Console.Write("*");
                }
                while (j < i);
                i = i + 1;
                j++;
                Console.WriteLine();
            }
            while (i < 6) ;

        }
    }
}