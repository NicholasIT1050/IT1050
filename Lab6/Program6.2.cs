using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i=0; i <months.Length; i++)
            {
                Console.WriteLine(i+1 + " " +months[i]);
            }
        }
    }
}
