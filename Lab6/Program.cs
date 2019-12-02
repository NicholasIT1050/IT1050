using System;

namespace Lab6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesofpeople = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            foreach (string names in namesofpeople)
            {
                Console.WriteLine("{0} {1}", i + 1, names);
                i++;
            }
        }
    }
}
