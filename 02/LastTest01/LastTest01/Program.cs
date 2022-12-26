using System;

namespace LastTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            int defender;
            int attacker;
            int defenderNumber;
            int attackerNumber;

            Random random = new Random();
            defenderNumber = random.Next(1, 100);

            

            Console.WriteLine(defenderNumber);

                        

            while (true)
            {

                Console.WriteLine("번호를 입력해주세요.");
                attackerNumber = int.Parse(Console.ReadLine());
                

                if (attackerNumber > defenderNumber)
                {
                    Console.WriteLine("더 큰 숫자입니다. 다시 입력해주세요.");
                }
                else if (attackerNumber < defenderNumber)
                {
                    Console.WriteLine("더 작은 숫자입니다. 다시 입력해주세요.");
                }

                    
                

                if (defenderNumber == attackerNumber)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }



        }
    }
}