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

namespace Les03
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Drives
            //var drives = DriveInfo.GetDrives();
            //this.richTextBox1.AppendText("Name\tType\tSize\tEmpty Size\n");

            //foreach (var drive in drives)
            //{
            //    richTextBox1.AppendText($"{drive.Name}\t{drive.DriveType}\t");
            //    if (drive.IsReady)
            //    {
            //        richTextBox1.AppendText($"{drive.TotalSize}\t{drive.TotalFreeSpace}");
            //    }
            //    richTextBox1.AppendText("\n");
            //}
            #endregion

            #region EXIST CREATE DELETE
            //string path = $@"D:\Work cs\SfOOP\{richTextBox1.Text}";
            //Directory.CreateDirectory($@"D:\Work cs\SfOOP\{richTextBox1.Text}");
            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path);
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
            #endregion

            #region GetDirectories
            //richTextBox1.Text = Directory.GetCurrentDirectory();
            //var dirs = Directory.GetDirectories(@"D:\Work cs\SfOOP");
            //foreach (var dir in dirs)
            //{
            //    richTextBox1.AppendText($"{dir}\n");
            //}
            #endregion
            #region GetFiles
            //var files = Directory.GetFiles(@"D:\Work cs\SfOOP\Les01");
            //foreach (var file in files)
            //{
            //    string[] sp = file.Split('\\');

            //    richTextBox1.AppendText($"{sp[sp.Length-1]}\n");
            //}
            #endregion
            #region Times
            //Directory.GetLastWriteTime();
            //Directory.GetLastAccessTime();
            //Directory.GetCreationTime();
            //var dicts = Directory.GetCurrentDirectory();
            //var time = Directory.GetLastWriteTime(dicts);
            //var acc_t = Directory.GetLastAccessTime(dicts);
            //var creat = Directory.GetCreationTime(dicts);

            //richTextBox1.AppendText($"GetCurrentDirectory: {dicts}\n GetLastWriteTime: {time}\n GetLastAccessTime: {acc_t}\n GetCreationTime: {creat}");
            #endregion

            DirectoryInfo di = new DirectoryInfo(@"D:\Work cs\SfOOP\Les01");
            richTextBox1.Text =
                $"FullName: {di.FullName}\n" +
                $"Name: {di.Name}\n" +
                $"Parent: {di.Parent}\n" +
                $"Root: {di.Root}";
        }
    }
}
