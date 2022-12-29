using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03TelegramBot
{
    internal class Answer
    {
       private string[] massive;
       private Random random;
        public Answer()
        {
            if (!File.Exists("filetegbot.txt"))
            {
                File.Create("filetegbot.txt").Close();

            }

            massive = new string[] { "Yes", "No", "Maybe" };
            random = new Random();
        }
        public string Chose()
        {
            return massive[random.Next(massive.Length)];
        }
    }

}
