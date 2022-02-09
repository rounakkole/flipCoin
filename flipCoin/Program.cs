// See https://aka.ms/new-console-template for more information


using System;

namespace flipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("flip coin simulator");


            int difference1 = FlipCoin(21);
            int diff = 0;


            if (difference1 == 0)
            {
                TieCondition(2);
            }




        }


        public static int FlipCoin(int MARGIN)
        {
            //constant
            const int HEAD = 0;
            const int TAIL = 1;

            //initilization and declaration
            int headCount = 0;
            int tailCount = 0;
            int difference = 0;


            while (headCount < MARGIN && tailCount < MARGIN)
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


            if (headCount >= MARGIN)
            {
                difference = headCount - tailCount;
                Console.WriteLine($"head won by {difference}");
            }
            else if (tailCount >= MARGIN)
            {
                difference = tailCount - headCount;
                Console.WriteLine($"tail won by {difference}");

            }
            else if (headCount == tailCount)
            {
                Console.WriteLine("tie");

            }

 
            return difference;
        }


        public static int TieCondition(int MARGIN)
        {
            //constant
            const int HEAD = 0;
            const int TAIL = 1;

            //initilization and declaration
            int headCount = 0;
            int tailCount = 0;
            int difference = 0;



            while (difference < 2)
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

                if (headCount >= MARGIN)
                {
                    difference = headCount - tailCount;
                    //Console.WriteLine($"head won by {difference}");
                }
                else if (tailCount >= MARGIN)
                {
                    difference = tailCount - headCount;
                    //Console.WriteLine($"tail won by {difference}");
                }




            }
            Console.WriteLine($"Head {headCount}");

            Console.WriteLine($"Tail {tailCount}");



            return 0;
        }

    }
}
