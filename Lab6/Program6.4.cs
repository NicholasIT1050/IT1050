using System;

namespace Lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            Random random = new Random();
            int randomNumber;
            for (var i =0; i<1000;++i)
            {
                randomNumber = random.Next(0, 100);
                array[i] = randomNumber;
            }
            foreach(int value in array)
            {
                Console.WriteLine(value);
            }

        }
    }
}
