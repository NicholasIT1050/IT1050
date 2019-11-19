using System;

namespace Lab_4._10
{
    class Program
    {
        static void Main()
        {
            int counter = 10;

            for (int r = 0; r < counter; r++)
            {
                for (int c = 0; c < r; c++) 
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < counter - r; c++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int r = counter; r >= 0; r--) 
            {
                for (int c = 0; c < r; c++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < counter - r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
