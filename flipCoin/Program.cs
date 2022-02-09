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
            int i = 0;



            while (i <= 21)
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
                i++;
            }
            Console.WriteLine($"Head {headCount}");

            Console.WriteLine($"Tail {tailCount}");


            return 0;
        }
    }
}
