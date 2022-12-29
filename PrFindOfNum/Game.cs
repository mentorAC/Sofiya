using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrFindOfNum
{
    class Game
    {
        private int number;
        public void Genaration(int startnum, int endnum)
        {
            Random random = new Random();
            number = random.Next(startnum, endnum);
        }
        public string Check(int value)
        {
            if(value < number)
            {
                return "Зданное число больше";
            }
            else if (value > number)
            {
                return "Заданное число меньше";
            }
            else
            {
                Task.Run(() => MessageBox.Show("Winner", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop));

                return string.Empty;//" ";
            }
        }
    }
}
