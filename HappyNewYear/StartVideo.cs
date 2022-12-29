using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNewYear
{
    internal class StartVideo
    {
        static public void Start(string link)
        {
            try
            {
                Process.Start(link);
            }
            catch
            {
                link = link.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {link}") { CreateNoWindow = true });

            }
        }
    }
}
