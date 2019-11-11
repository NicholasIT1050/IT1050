## Lab3
### question 1
They are similar in that they only act if the conditions are met. The difference is and If statement on acts once while the while statement will keep going until the conditions are no longer met.

### Everything else
using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW!");
            }
            bool isTrue;

            isTrue = true;
            if (isTrue)
            {
                Console.WriteLine("It is True.");
            }
            else
                Console.WriteLine("It is False.");

            double temp;
            double celsius;
            Console.WriteLine("Enter the temperature. ");
            temp = Convert.ToDouble(Console.ReadLine());
            celsius = (temp - 32d) * 5d / 9d;
            Console.WriteLine(celsius);
            if (temp <40)
            {
                Console.WriteLine("It is cold.");
            }
            if (temp >90)
            {
                Console.WriteLine("It is hot,");
            }
             

            int counter = 1;
            while (counter<=10)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }

            int counter2 = 60;
            while (counter2 >= 20)
            {
                Console.WriteLine(counter2);
                counter2 = counter2 - 1;

            }

            int counter3 = 10;
            while (counter<=20)
            {
                Console.WriteLine("counter3");
                counter3 = counter3 + 1;
            }
            
        }
    }
}
