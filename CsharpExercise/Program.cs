using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter a character");
            //string character = Console.ReadLine();

            //Console.Write("Enter a width");
            //string width = Console.ReadLine();

            //int widthAsInt = Convert.ToInt32(width);

            //for (int i = 0; i < widthAsInt; i++)
            //{
            //    for (int j = 0; j < widthAsInt; j++)
            //    {
            //        Console.Write(character);
            //    }
            //    Console.WriteLine();
            //}


            Console.Write("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
            


        }
    }
}
