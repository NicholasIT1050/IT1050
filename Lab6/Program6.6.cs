using System;

namespace Lab6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };


            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine("{0,2}. {1}", i+1, names[i]);

            }
        }
    }
}
