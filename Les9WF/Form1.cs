using System.Diagnostics;

namespace Les9WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Do you like C#?", "Comment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
            if (res == DialogResult.No)
            {

            }
            
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine(i);
            }
            Debug.WriteLine("----------------");

            foo(0, 10);
        }
        void foo(int start, int end)
        {
            Debug.WriteLine(start);
            start++;
            if (start >= end)
            {
                return;
            }
            foo(start, end);
        }
    }
}