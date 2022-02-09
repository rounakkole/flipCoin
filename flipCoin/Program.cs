// See https://aka.ms/new-console-template for more information


using System;

namespace flipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("flip coin simulator");
            FlipCoin();
        }


        public static int FlipCoin()
        {
            //constant
            const int HEAD = 0;
            const int TAIL = 1;


            Random random = new Random();
            int flipResult = random.Next(0,2);
            if (flipResult == HEAD)
            {
                Console.WriteLine("Winner is Head");
            }
            else if (flipResult == TAIL)
            {
                Console.WriteLine("Winner is Tail");

            }


            return 0;
        }
    }
}
