﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame
{

    public class Game
    {
        public static int GetInput(int min, int max)
        {
            int result = -1;
            while (true)
            {
                string Input_str = Console.ReadLine();
                if (int.TryParse(Input_str, out result))
                {
                    result = int.Parse(Input_str);
                    if (result >= min && result <= max)
                    {
                        break;
                    }
                    Console.WriteLine("輸入錯誤!!請輸入(1~100)");
                }
                else
                {
                    Console.WriteLine("請輸入數字!!");
                }
            }
            return result;
        }
        public Game()
        {
            Console.WriteLine("發生建構");
        }
        public void Play()
        {
            Console.WriteLine("開始遊戲!!");
            int input = -1;
            int gyess = 55;
            gyess = new Random().Next(100);
            Console.WriteLine("輸入數字: ");
            while (true)
            {

                input = GetInput(1, 100);

                if (input == gyess)
                {
                    Console.WriteLine("答對了!");
                    break;
                }
                Console.WriteLine("答錯了");
            }
        }
    }
}
