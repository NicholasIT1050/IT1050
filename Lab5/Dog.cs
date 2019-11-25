using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Dog
    {
        public string Name;
        public string trickName;

        public void DoTrick()
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a {1}", Name, trickName);
        }
        public void Bark()
        {
            Console.WriteLine("{0} is barking...", Name);
        }
        
    }
}
