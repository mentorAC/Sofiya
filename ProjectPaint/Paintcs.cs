using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPaint
{
    internal class Paint
    {
        Bitmap bitmap;
        PictureBox region;  //поле малювання
        ComboBox color;     //кольора
        TrackBar width;     //ширина

        //конструктор який примає контроли
        public Paint(PictureBox pictureBox, ComboBox combobox, TrackBar trackBar)
        {
            region = pictureBox;
            color = combobox;
            width = trackBar; 
            AddAllColors(); //додаємо кольора 
        }
        private void AddAllColors()
        {
            Type colorType = typeof(Color);
            PropertyInfo[] colors = colorType.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            foreach (var clr in colors)
            {
                color.Items.Add(clr.Name);
            }

            color.Text = "Black";
        }
        Graphics graphics;
        Graphics graphicsforsafe;
        public void SetGraphic()    //встановлмо графіку 
        {
            if (region.Image == null)
            {
                bitmap = new Bitmap(region.Width, region.Height);
            }
            else
            {
                bitmap = new Bitmap(region.Image, region.Width, region.Height);
            }
            graphics = region.CreateGraphics();
            graphicsforsafe = Graphics.FromImage(bitmap); 
        }
        Point? lastpoint;   //остання очка
        public void DrawPen(Point drawpoint)
        {
            //створюємо ручку малювання
            Pen pen = new Pen(Color.FromName(color.Text),width.Value );
            if(lastpoint!= null)    //якщо минула точка існує
            {
                //малюємо лінію між 2ма точками 
                graphics.DrawLine(pen, drawpoint, lastpoint.Value);
                graphicsforsafe.DrawLine(pen, drawpoint, lastpoint.Value);
            }
            lastpoint = drawpoint;

        }
        public void DrawCircle(Point start, Point end)
        {
            region.Refresh();

            Pen pen = new Pen(Color.FromName(color.Text), width.Value);
            SetGraphic();
            graphics.DrawEllipse(pen, start.X, start.Y, end.X - start.X, end.X - start.X);
            graphicsforsafe.DrawEllipse(pen, start.X, start.Y, end.X - start.X, end.X - start.X);
        }
        public void DrawRectangle(Point start, Point end)
        {
            region.Refresh();

            Pen pen = new Pen(Color.FromName(color.Text), width.Value);
            SetGraphic();
            graphics.DrawRectangle(pen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
            graphicsforsafe.DrawRectangle(pen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
        }

        public void DrawElipse(Point start, Point end)
        {
            region.Refresh();
            Pen pen = new Pen(Color.FromName(color.Text), width.Value);
            SetGraphic();
            graphics.DrawEllipse(pen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
            graphicsforsafe.DrawEllipse(pen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
        }

        public void DrawLine(Point start, Point end)
        {
            region.Refresh();

            SetGraphic();
            Pen pen = new Pen(Color.FromName(color.Text), width.Value);
            graphics.DrawLine(pen, start, end);
            graphicsforsafe.DrawLine(pen, start, end);

        }
        //коли ми припиняємо малювання
        public void StopDrawing()
        {
            //видаляємо останню точку
            lastpoint = null;
            region.Image = bitmap;
        }

        //очищення поля
        public void Clear()
        {
            //створюємо пензлик
            Brush brush = new SolidBrush(Color.White);

            //малюємо білий прямокутник на весь регіон
            graphics.FillRectangle(brush, 0, 0, region.Width, region.Height);
            graphicsforsafe.FillRectangle(brush, 0, 0, region.Width, region.Height);
        }
       public void Save(string path)
        {
            region.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}