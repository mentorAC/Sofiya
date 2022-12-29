using Newtonsoft.Json;
using System.Net;

namespace Les15
{
    public partial class Form1 : Form
    {
            GetInfo weatherinfo;
        public Form1()
        {
            weatherinfo  = new GetInfo(); 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lan = textBox1.Text;
            string lon = textBox2.Text;
           WeatherInfo weather  = weatherinfo.WeatherInfo(lan, lon);
            richTextBox1.Text = $"Tempreture: {weather.main.temp}\n Max: {weather.main.temp_max}\n Min{weather.main.temp_min}\n City: {weather.name}";
        }
    }

}