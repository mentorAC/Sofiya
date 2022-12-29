namespace Les10WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red_color = random.Next(0, 255);
            int blue_color = random.Next(0, 255);
            int green_color = random.Next(0, 255);
            button1.BackColor = Color.FromArgb(red_color, green_color, blue_color);
        }
    }
}
//RGB
//HEX