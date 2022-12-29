using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Les05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = tbname.Text + ".txt";
            #region File
            //if (!File.Exists(filename))
            //{
            //    File.Create(filename);
            //}
            //File.WriteAllText(filename, rtbinput.Text);
            //File.AppendAllText(filename, rtbinput.Text);
            //var lines = rtbinput.Text.Split('\n');
            //File.WriteAllLines(filename, lines, Encoding.UTF8);
            //File.AppendAllLines(filename, lines);
            #endregion


            //FileStream fStream = File.Create("newFile.txt");
            //fStream.Close();

            //File.Create("newFile.txt").Close();
            //File.WriteAllText("newFile.txt", "test");

            FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate);
            string str = "Hello world";
            byte[] bytes = Encoding.Default.GetBytes(str);
            fstream.Write(bytes, 0, bytes.Length);
            fstream.Flush();
            Console.WriteLine();
            //fstream.Dispose();
            fstream.Close();
        }

        private void bshow_Click(object sender, EventArgs e)
        {
            string filename = tbname.Text + ".txt";
            #region File
            //rtboutput.Text = File.ReadAllText(filename);

            //File.ReadAllLines()
            #endregion
            
        }
    }
}
