using System;

namespace Lab_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int exhibit;
            Console.WriteLine("Please enter number of the exhibit");
            exhibit = int.Parse(Console.ReadLine());
            switch (exhibit)
            {
                case 1:
                    Console.WriteLine("Polar Bear");
                    break;
                case 2:
                    Console.WriteLine("Penguin");
                    break;
                case 3:
                    Console.WriteLine("Moose");
                    break;
                case 4:
                    Console.WriteLine("Reindeer");
                    break;
                case 5:
                    Console.WriteLine("Deer");
                    break;
                case 6:
                    Console.WriteLine("Turtle");
                    break;
                case 7:
                    Console.WriteLine("Lion");
                    break;
                case 8:
                    Console.WriteLine("Fish");
                    break;
                case 9:
                    Console.WriteLine("Bug");
                    break;
                default:
                    Console.WriteLine("Please enter a valide number");
                    break;
            }
        }
    }
}
