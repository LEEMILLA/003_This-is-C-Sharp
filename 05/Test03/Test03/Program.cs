using System;

namespace Test03
{
    class MainApp
    {
        static void Main(string[] args)
        {

            /* 
             * =====================================
             * 주석: FOR 문으로 *을 찍어본다
             * =====================================
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            int i = 1;
            int j = 1;

            while (i < 6)
            {
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                i++;
                Console.WriteLine();
            }
        }
    }
}