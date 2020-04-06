using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // An if statement is a conditional jump that branches the program a single time.
            // A while (or any LOOP) is a conditional structure that performs a jump repeatedly if the condition is true.

            int speedLimit = 35, speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
                Console.Write("\n\n");
            }

            var rand = new Random();
            bool isTrue = (rand.NextDouble() > 0.5);

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            // OR
            // Console.WriteLine(isTrue ? "It is True!" : "It is False!");

            Console.Write("\n\n");

            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            i = 60;

            while (i >= 20)
            {
                Console.WriteLine(i);
                i -= 5;
            }

            Console.WriteLine("\n");

            i = 10;

            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
}
