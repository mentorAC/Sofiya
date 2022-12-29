namespace Les02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.Text = Change.Koding(textBox2.Text, int.Parse(textBox1.Text));
            }
            else
            {
               textBox2.Text = Change.Unkoding(textBox2.Text, int.Parse(textBox1.Text));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = null;// во все ссылочные типы мы можем ложить значение null
            //например создадим свой класс и мы можем для него выделить память или же положить значение null
            MyClass myClass = new MyClass();//null

            //НО структуры не могут хранить null, например как на 30 строчке кода
            Car car;

            //однако у нас существует ряд моментов когда нужно сохранить значение null,
            //для этого мы делаем nullable тип из структуры, когда добавляем после типа знак вопроса
            int? age = null;

            //мы можем пользоваться переменной как и раньше, но у нее появляется 2 дополнительных свойства,
            //HasValue - флажок для проверки равняется ли переменная значению null или нет
            //Value - значение, которое храниться в переменной
               age = 101;

            if (age.HasValue)//например если age имеет значение (HasValue == true)
            {
                MessageBox.Show("Yes");//выполняется какая то логика
            }
        }
    }
}

class MyClass
{
    public string name;
    public string secondname;
    public int age;
}

struct Car
{
    public int model;
    public string name;
}