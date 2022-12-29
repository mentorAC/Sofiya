using System;

namespace Les11
{
    class Counter
    {
        public int Count { get; private set; }
        public Counter(int counter = 0)
        {
            this.Count = counter;
        }

        public void Plus(int value)
        {
            Count += value;
        }

        public static bool operator >(Counter counter1, Counter counter2)
        {
            return counter1.Count > counter2.Count;
        }
        public static bool operator <(Counter counter1, Counter counter2)
        {
            return counter1.Count < counter2.Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Counter counter1 = new Counter();
            //Counter counter2 = new Counter();
            //Random rnd = new Random();
            //for (int i = 0; i < rnd.Next(1000); i++)
            //{
            //    counter1.Plus(1);
            //}
            //for (int i = 0; i < rnd.Next(1000); i++)
            //{
            //    counter2.Plus(1);
            //}
            //if(counter1 > counter2)
            //{
            //    Console.WriteLine("FIRST");
            //}
            //else
            //{
            //    Console.WriteLine("SECOND");
            //}
            #endregion
            GRN grivna1 = new GRN(100);
            GRN grivna2 = new GRN(1000);
            if(grivna1 > grivna2)
            {
                Console.WriteLine("FIRST");

            }
            else
            {
                Console.WriteLine("SECOND");
            }
        }
    }
}
