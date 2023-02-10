using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 words or die!!!");
            Console.WriteLine();
            string Word1 = Console.ReadLine();
            string Word2 = Console.ReadLine();
            string Word3 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Which word do you like? - 1, 2 or 3?");
            int Izbor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Izbor == 1)
            {
                Console.WriteLine($"You like {Word1}? Cool");
            }
            else if (Izbor == 2)
            {
                Console.WriteLine($"You like {Word2}? Cool");
            }
            else if (Izbor == 3)
            {
                Console.WriteLine($"Please don't tell me you like {Word3}... Not cool");
            }



        }
    }
}
