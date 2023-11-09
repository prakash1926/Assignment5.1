using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string String = Console.ReadLine();

            Console.WriteLine("Enter your Age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Height :");
            double Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nName :" + String + "\nAge :" + age + "\nHeight :" + Height);

            Console.ReadKey();
        }
    }
}
