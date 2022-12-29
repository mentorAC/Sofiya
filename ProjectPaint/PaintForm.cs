using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaint
{
    public partial class PaintForm : Form
    {
        Paint paint;                //обьект пеінта, який малює зображення
        DrawingType drawingType;    //тип того, що ми малюємо 
        public PaintForm()
        {
            InitializeComponent();
            paint = new Paint(pictureBox1, comboBox1, trackBar1);   //створюємо пеінт

            
        }

        private void bline_Click(object sender, EventArgs e)
        {
            drawingType = DrawingType.LINE; //при натисканні на кнопку лінії змінюємо тип малювання
        }

        private void bCircle_Click(object sender, EventArgs e)
        {
            drawingType= DrawingType.CIRCLE;
        }

        private void bElipse_Click(object sender, EventArgs e)
        {
            drawingType = DrawingType.ELIPSE;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //коли змінюємо трек бар, в цей момент виводимо нове його значення
            width.Text = $"Width: {trackBar1.Value}";
        }

        private void bRectangle_Click(object sender, EventArgs e)
        {
            drawingType = DrawingType.RECTANGLE;
        }

        private void bPen_Click(object sender, EventArgs e)
        {
            drawingType = DrawingType.PEN;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            //коли натискаємо на кнопку очищення
            paint.Clear();  //очищуємо поле
        }
        bool mouse = false; //перевірка чи натиснута машка
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            paint.SetGraphic(); //встановлюємо графіку
            start_p = e.Location;
        }
        Point start_p;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse == true)   //якщо мишка натиснута
            {
                switch (drawingType)
                {
                    case DrawingType.PEN:
                        paint.DrawPen(e.Location);
                        break;
                    case DrawingType.LINE:
                        paint.DrawLine(start_p, e.Location);
                        break;
                    case DrawingType.CIRCLE:
                        paint.DrawCircle(start_p, e.Location);
                        break;
                    case DrawingType.RECTANGLE:
                        paint.DrawRectangle(start_p, e.Location);
                        break;
                    case DrawingType.ELIPSE:
                        paint.DrawElipse(start_p, e.Location);
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            paint.StopDrawing();    //припиняємо малювання
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image files(*.png)|*.png";


            if(sfd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(sfd.FileName);
                paint.Save(sfd.FileName);
            }
        }
    }
}
