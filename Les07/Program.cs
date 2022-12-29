using System;
using System.Collections.Generic;
namespace Les07
{

    class Human
    {
        public string Name { get; }
        public Human(string name)
        {
           Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int[] arr = { 1, 2, 3 };

            List<int> nums = new List<int>() {1,2,3 };
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.Write($"{nums[i]} ");
            //}
            //Console.WriteLine(); 
            List<string> names = new List<string>() { "Bob", "Tom", "Sam" };
            List<string> users1 = new List<string>(names) { "Mike" };
            //foreach (var item in users)
            //{
            //    Console.Write($"{item} ");
            //}

            List<Human> humans = new List<Human>()
            {
                new Human("Bob"),
                new Human("Tom"),
                new Human("Sam")
            };
            //foreach (var item in humans)
            //{
            //    Console.Write($"{item.Name} ");
            //    //Console.Write($"{nameof(Human)} ");
            //}
            #endregion
            List<string> users = new List<string>(names) { "Mike" };
            users.Add("Max");
            users.Add("Roman");
            foreach (var item in users)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //users.Clear();
            //Console.WriteLine(users.Count);
            if (users.Contains("Namor"))
            {
                Console.WriteLine("Yes, I have him");
            }

            int index = users.IndexOf("Mot");
            Console.WriteLine($"Tom in {index}");
        }
    }
}
