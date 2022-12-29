using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleTest
{
    internal class Program
    {
        static void GetName()
        {
            string name = Console.ReadLine();
            if(name.Length < 3)
            {
                //Exception exception = new Exception("Lenhth is smaller");
                //throw exception;

                throw new Exception("Lenhth is smaller");
            }


            Console.WriteLine($"Your name: {name}");
        }
        static void Main(string[] args)
        {
            #region Task1
            //int x = 5;
            //int y = x / 0;    //будет ошибка деления на 0
            //Console.WriteLine(y);

            //Human h = null;
            //h.Name = "name1";
            #endregion
            #region Task2
            //try   //блок проверки 
            //{
            //
            //}
            //catch //блок который ловит ошибку
            //{
            //
            //}
            //finally   //блок который в любом случае выполняется
            //{
            //
            //}
            ////////////////////////
            //try   //проверяем 
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine(y);
            //}
            //catch //ловим ошибку и выводим на экран сообщение
            //{
            //    Console.WriteLine("Error");
            //}
            //finally   //в любом случае код исполняется
            //{
            //    Console.WriteLine("Finally!");
            //}
            //Console.WriteLine("End of MAIN");
            #endregion
            #region Task3
            //int x = 5;
            //int q = 0;
            //if (q != 0)
            //{
            //    int y = x / q;
            //}
            //try
            //{
            //    int a = Convert.ToInt32("1asd");
            //    Console.WriteLine(a);

            //}
            //catch
            //{
            //    Console.WriteLine("Problem with convertation");
            //}

            //byte  //1byte =>
            //short //2byte => Int16
            //int   //4byte => Int32
            //long  //8byte => Int64

            //TryParse
            //if (int.TryParse("123", out int value))       //лучше всего не доводить до греха(до ошибки)
            //{                                             //и предотвращать ее с помощью ифа
            //    Console.WriteLine(value);
            //}
            #endregion
            #region Task4
            //int x = 0;
            //int y = 1;
            //try
            //{
            //    //int.Parse("qwer");

            //    int result = y / x;
            //}
            //catch(DivideByZeroException ex) when( y == 1)
            //{ 
            //    Console.WriteLine($"Ex1");
            //}
            //catch (DivideByZeroException ex)  //мы мжем фильтровать ошибки
            //{
            //    Console.WriteLine($"Ex2");
            //}


            //try
            //{
            //    int.Parse("qwer");
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine($"Exception info: {ex.Message}");
            //}
            #endregion
            #region Task5
            //try
            //{
            //    int.Parse("asdas"); 
            //    int x = 5;
            //    int y = x / 0;
            //}
            //catch (Exception ex)    //ловит абсолютно все ошибки и позволяет получить информацыю о них
            //{ 
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.TargetSite);
            //}
            #endregion
            Console.WriteLine("Start");
            try
            {
                GetName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              //Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End");
        }
    }

    class Human
    {
        public string Name { get; set; } 
    }
}
