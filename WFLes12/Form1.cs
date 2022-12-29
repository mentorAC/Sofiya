using System.Diagnostics;

namespace WFLes12
{
    public partial class Form1 : Form
    {
        Telegramsend telegramsend;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Error.WriteLine("Click");
            //Debug.WriteLine("Click");
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No item was selected");
                return;
            }
            string sendtext = richTextBox1.Text;
            telegramsend.TextSend(sendtext, comboBox1.SelectedItem.ToString());
            //telegramsend.TextSend(sendtext);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            string token = "5758808566:AAEkafZTd-VxtBVyxMja_J5LXOTyNOAKPTU";

            telegramsend = new Telegramsend(token);

            var items = telegramsend.GetItems();
            comboBox1.Items.AddRange(items);

            telegramsend.Start();
            string getmetext = await telegramsend.GetinfAsync();
            MessageBox.Show(getmetext);
        }
    }
}