using System;
using System.Collections.Generic;

namespace Les8
{
    internal class Program
    {
        public static void Show(Queue<string> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //FIFO
            //first-input-last-output
            #region Queue
            Queue<string> people = new Queue<string>();
            people.Enqueue("Tom");
            people.Enqueue("Bob");
            people.Enqueue("Mark");
            Show(people);
            //people.Clear();
            if (people.Contains("bob"))
            {
                Console.WriteLine("Yes, Bob in our queue");
            }
            var tom = people.Dequeue();
            Console.WriteLine($"Deque: {tom}");
            Show(people);
            Console.WriteLine();
            Console.WriteLine();
            var bob = people.Peek();
            Console.WriteLine($"Peek: {bob}");
            Show(people);
            #endregion
        }
    }
}
