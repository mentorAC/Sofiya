namespace Les06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = trackBar1.Minimum;
            progressBar1.Maximum = trackBar1.Maximum;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           label1.Text = trackBar1.Value.ToString();
            progressBar1.Value = trackBar1.Value;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Minimum = (int)numericUpDown1.Value;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Maximum = (int)numericUpDown2.Value;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= progressBar1.Maximum; i+=progressBar1.Maximum/10)
            {
                progressBar1.Value = i;
                await Task.Delay(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text) ;
        }
    }
}