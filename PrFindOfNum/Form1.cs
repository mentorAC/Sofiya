namespace PrFindOfNum
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            game =  new Game();
            game.Genaration((int)numericUpDown1.Value, Convert.ToInt32( numericUpDown2.Value));
        }
        //short => 2byte
        //int => 4byte
        //decimal => 16byte

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( text:"I`m msg mox", 
            //                 caption:"Header", 
            //                 buttons: MessageBoxButtons.RetryCancel,
            //                 icon: MessageBoxIcon.Information);
            label1.Text = game.Check(int.Parse(textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Genaration((int)numericUpDown1.Value, Convert.ToInt32(numericUpDown2.Value));

        }
    }
}