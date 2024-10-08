using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CounterClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Startar en ny räknare som börjar på '5'
            Counter counter = new Counter(0);

            // Höjer räknaren med två istället för ett
            counter.IncrementBy(2);

            // höjer räknaren med ett
            counter.Increment();
            counter.Increment();
            counter.Increment();
            // ska skriva ut 3
            Console.WriteLine("counter: " + counter.GetValue());
            counter.Reset();
            // ska skriva ut 0
            Console.WriteLine("Reset counter: " + counter.GetValue());
            
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    counter.Increment();
                    Console.Clear();
                    Console.WriteLine("Counter: " + counter.GetValue());
                }
            }
        }
    }
}
