using System;

namespace Break
{
    class MainApp
    {
        static void Main(String[] args)
        {
            
            while(true)
            {
                Console.Write("계속할까요? (예/아니요)");
                string answer = Console.ReadLine();

                if (answer == "아니dy")
                    break;

            }
          
        }
    }
}