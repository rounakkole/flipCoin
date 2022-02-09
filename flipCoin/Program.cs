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

            //initilization and declaration
            int headCount = 0;
            int tailCount = 0;


            while (headCount < 21 && tailCount < 21)
            {

                Random random = new Random();
                int flipResult = random.Next(0, 2);
                if (flipResult == HEAD)
                {
                    headCount++;

                }
                else if (flipResult == TAIL)
                {
                    tailCount++;


                }

            }
            Console.WriteLine($"Head {headCount}");

            Console.WriteLine($"Tail {tailCount}");


            if (headCount >= 21)
            {
                Console.WriteLine($"head won by {headCount - tailCount}");
            }
            else if (tailCount >= 21)
            {
                Console.WriteLine($"tail won by {tailCount - headCount}");

            }
            else if (headCount == tailCount)
            {
                Console.WriteLine("tie");

            }


            return 0;
        }
    }
}
