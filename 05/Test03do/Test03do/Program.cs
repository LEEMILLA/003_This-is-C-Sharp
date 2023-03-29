using System;

namespace Test03do
{
    class MainApp
    {
        static void Main(string[] args)
        {

            int i = 1;
            int j = 0;

            do
            {
                   
                do
                {
                   if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                    j++;

                }
                while (j < i);
                
                Console.WriteLine();
                j = 0;
                i++;
                
            }
            while (i < 6) ;

        }
    }
}