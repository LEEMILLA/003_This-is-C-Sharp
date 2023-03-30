using System;

namespace test4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
            int num;

            Console.Write("반복 횟수를 입력하세요 :");
            int readLine = Convert.ToInt16(Console.ReadLine());
                
            

            if (readLine <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }
            else
            {
                for (int i = 1; i < readLine + 1; i++) 
                {
                    for (int j = 0; j < i; j++)
                    {

                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}