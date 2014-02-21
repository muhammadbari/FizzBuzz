using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0, end = 0;
            Console.WriteLine("FizzBuzz Steps");
            Console.Write("Please enter the starting number: ");
            try
            {
                start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the ending number: ");
                end = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please try again");
            }
            string str = string.Empty;
            IFizzBuzz fb = new FizzBuzz1();
            str = fb.GetOutputString(start, end);
            Console.WriteLine("Output for Step 1:\n" + str);

            fb = new FizzBuzz2();
            str = fb.GetOutputString(start, end);
            Console.WriteLine("Output for Step 2:\n" + str);

            fb = new FizzBuzz3();
            str = fb.GetOutputString(start, end);
            Console.WriteLine("Output for Step 3:\n" + str);
            Console.ReadLine();
        }
    }
}
