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
                Console.WriteLine();
                i++;
            }
            while (i < 6) ;

        }
    }
}