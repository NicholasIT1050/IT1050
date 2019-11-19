using System;

namespace Lab_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("**********".Substring(0, i));
            }
            for (j = 10; j > 0; j--)
            {
                Console.WriteLine("**********".Substring(0, j));
            }
            
            
        }
    }
}
