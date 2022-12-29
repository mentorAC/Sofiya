using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les02
{
    static public class Change
    {
        static public string Koding(string text, int num)
        {

            StringBuilder input = new StringBuilder(text);
            for (int i = 0; i < input.Length; i++)  //алгоритм смещения 
            {
                char ch = input[i];
                int new_kod = ch + num;
                input[i] = (char)new_kod;
                if (new_kod > 'z')
                {
                    int step = new_kod - 'z';
                    int n_kod = 'a' + step - 1;
                    input[i] = (char)n_kod;
                }
                if (input[i] == ' ')
                {
                    char space = ' ';
                    input[i] = space;
                }
                else
                {
                    input[i] = (char)new_kod;
                }
            }
            return input.ToString();
            
        }
        static public string Unkoding(string text, int num)
        {
            StringBuilder input = new StringBuilder(text);
            
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                int new_kod = ch - num;
                if (new_kod < 'a')
                {
                    int step = 'a' - new_kod;
                    int n_kod = 'z' - step + 1;
                    input[i] = (char)n_kod;
                }
                if (input[i] == ' ')
                {
                    char space = ' ';
                    input[i] = space;
                }
                else
                {
                    input[i] = (char)new_kod;
                }

            }
            return input.ToString();
        }
            

    }
}
