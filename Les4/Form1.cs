using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Les4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        FileInfo
//Некоторые полезные методы и свойства класса FileInfo:
//CopyTo(path) : копирует файл в новое место по указанному пути path
//Create(): создает файл
//Delete() : удаляет файл
//MoveTo(destFileName) : перемещает файл в новое место
//Свойство Directory: получает родительский каталог в виде объекта DirectoryInfo
//Свойство DirectoryName: получает полный путь к родительскому каталогу
//Свойство Exists: указывает, существует ли файл
//Свойство Length: получает размер файла
//Свойство Extension: получает расширение файла
//Свойство Name: получает имя файла
//Свойство FullName: получает полное имя файла
        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("file.txt");
            if (fileInfo.Exists)
            {
                MessageBox.Show($"{fileInfo.FullName}\n{fileInfo.Name}\n{fileInfo.Length}");
            }

        }
//        File
//Класс File реализует похожую функциональность с помощью статических методов:
//Copy() : копирует файл в новое место
//Create(): создает файл
//Delete() : удаляет файл
//Move: перемещает файл в новое место
//Exists(file): определяет, существует ли файл
        private void bDelete_Click(object sender, EventArgs e)
        {
            //FileInfo fileinf = new FileInfo(textBox1.Text);
            //fileinf.Delete();
            //if (File.Exists(tbFileName.Text))
            //{
            //    File.Delete(tbFileName.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}


            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (var file in files)
            {
                if (file.Contains(".txt"))
                {
                    File.Delete(file);
                }
            }
            //for (int i = 0; i < files.Length; i++)
            //{
            //    if()files[i]
            //}
            


        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            //FileInfo fileinf = new FileInfo(textBox1.Text);
            //fileinf.Create().Dispose();
            //File.Create(tbFileName.Text);
            for (int i = 10; i < 100; i++)
            {
                File.Create($"{tbFileName.Text}{i}.txt");
            }
        }
    }
}
