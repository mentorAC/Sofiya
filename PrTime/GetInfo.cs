using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PrTime
{
    internal class GetInfo
    {
        private string filename = "filedate.txt";
        public void SetDate(DateTime date)
        {

            if (!File.Exists(filename))
            {
                File.Create(filename);
                File.WriteAllText(filename, date.ToString());
            }
        }
        public void GetDate()
        {

        }

    }
}
