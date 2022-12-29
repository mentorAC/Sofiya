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
            string name = null;// �� ��� ��������� ���� �� ����� ������ �������� null
            //�������� �������� ���� ����� � �� ����� ��� ���� �������� ������ ��� �� �������� �������� null
            MyClass myClass = new MyClass();//null

            //�� ��������� �� ����� ������� null, �������� ��� �� 30 ������� ����
            Car car;

            //������ � ��� ���������� ��� �������� ����� ����� ��������� �������� null,
            //��� ����� �� ������ nullable ��� �� ���������, ����� ��������� ����� ���� ���� �������
            int? age = null;

            //�� ����� ������������ ���������� ��� � ������, �� � ��� ���������� 2 �������������� ��������,
            //HasValue - ������ ��� �������� ��������� �� ���������� �������� null ��� ���
            //Value - ��������, ������� ��������� � ����������
               age = 101;

            if (age.HasValue)//�������� ���� age ����� �������� (HasValue == true)
            {
                MessageBox.Show("Yes");//����������� ����� �� ������
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