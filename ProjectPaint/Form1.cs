namespace ProjectPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var gr = pictureBox1.CreateGraphics();


            //Pen pen = new Pen(Color.Black, 5);
            //gr.DrawRectangle(pen, 200, 150, 100, 50);
            //Pen pen2 = new Pen(Color.DarkOrange, 8);
            //gr.DrawEllipse(pen2, 300, 200, 200, 200);
            //Pen pen3 = new Pen(Color.DarkSalmon, 3);
            //gr.DrawLine(pen3, 30, 70, 60, 100);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //var gr = pictureBox1.CreateGraphics();
            //Pen pen2 = new Pen(Color.DarkSalmon, 5);
            //gr.DrawEllipse(pen2, e.X-100, e.Y-100, 200, 200);
           
        }
        bool mouse = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false; 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse == true)
            {
                var gr = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Red, 1);
                Brush brush = new SolidBrush(Color.Red);
                //gr.DrawEllipse(pen, e.X, e.Y, 10, 10);
                gr.FillEllipse(brush, e.X, e.Y, 10, 10);
            }

            
        }
    }
}