using Newtonsoft.Json;

namespace Les13
{

    class Smartphone
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Memory { get; set; }
        public int Camera { get; set; }
    }

    class MyMoney
    {
        public int Count { get; set; }
        public string Valuta { get; set;}
    }
    class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public MyMoney Cash { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(i);
            //        Console.ResetColor();
            //    }
            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine(i);
            //    Console.ResetColor();
            //}
            #endregion
            //XML
            //JSON - JavaScript Object Notation
            Smartphone smartphone = new Smartphone()
            {
                Model = "IPhone",
                Color = "Red",
                Memory = 64,
                Camera = 19
            };

            string json = JsonConvert.SerializeObject(smartphone, Formatting.Indented);
            Console.WriteLine(json);

            string filename = "try.json";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            File.WriteAllText(filename, json);
            Smartphone newSmartphone = JsonConvert.DeserializeObject<Smartphone>(json);
            Console.WriteLine(newSmartphone.Model);
        }
    }
}