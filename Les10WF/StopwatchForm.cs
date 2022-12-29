using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les10WF
{
    public partial class StopwatchForm : Form
    {
        public StopwatchForm()
        {
            InitializeComponent();
        }

            Stopwatch stopwatch = new Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            stopwatch.Timer_start();
            label1.Text = stopwatch.Todisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stopwatch.Timerstop();
            richTextBox1.Clear();
            label1.Text = stopwatch.Todisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"{stopwatch.Todisplay()}\n");
        }
    }
}
