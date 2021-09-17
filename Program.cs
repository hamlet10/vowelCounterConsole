using System;
using vowelCounter;

namespace vowelCounterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = vowelCounter.vowelCounter.Counter("Hamlet tiene una A");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
