using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les8WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Patient> queue = new Queue<Patient>();
        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                Name = tbname.Text,
                Year = (int)numericUpDown1.Value,
                Diagnoz = tbdiagnoz.Text
            };
            queue.Enqueue(patient);
        }
    }
}
