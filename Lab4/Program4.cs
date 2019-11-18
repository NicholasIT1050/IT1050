using System;

    class Program
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);

            if ((i % 2) == 0)
            {
                Console.WriteLine("variable is even.");
            }

            else
            {
                Console.WriteLine("variable is odd.");
            }

        }
    }
}
