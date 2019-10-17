using System;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            int gyess;
            gyess = new Random().Next(100);

            Console.WriteLine("輸入數字: ");
            while(true)
            {
                string input_str = Console.ReadLine();
                input = int.Parse(input_str);

                if(input==gyess)
                {
                    Console.WriteLine("答對了!");
                    break;
                }
                Console.WriteLine("答錯了");
            }
        }
    }
}
