namespace PrTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tLoop.Enabled = !tLoop.Enabled;
            if (tLoop.Enabled)
            {
                button1.Text = "Stop";
                //tLoop.Enabled = false;        
            }
            else
            {
                button1.Text = "START";
                //button1.Enabled = true;
            }
            
        }

        private void tLoop_Tick(object sender, EventArgs e)
        {
            var lostTime = (dateTimePicker1.Value - DateTime.Now);
            lbtime.Text = $"{lostTime.Days} {lostTime.Hours}:{lostTime.Minutes}:{lostTime.Seconds}"; lostTime.ToString();
        }
    }
}