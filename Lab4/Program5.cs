using System;

namespace Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Please enter a temperature.");
            temp =Convert.ToInt32(Console.ReadLine());
            
            if (temp<=10)
            {
                Console.WriteLine("Polar Bear.");
            }
            else if (temp<=20)
            {
                Console.WriteLine("Penguin.");
            }
            else if (temp<=40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp<=50)
            {
                Console.WriteLine("Reindeer.");
            }
            else if (temp<=60)
            {
                Console.WriteLine("Deer.");
            }
            else if (temp<=70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp<=80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp<=90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
        }
    }
}
