namespace ProjectPaint
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bline = new System.Windows.Forms.Button();
            this.bCircle = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.bElipse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.width = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.bPen = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bline
            // 
            this.bline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bline.Location = new System.Drawing.Point(13, 45);
            this.bline.Name = "bline";
            this.bline.Size = new System.Drawing.Size(112, 43);
            this.bline.TabIndex = 0;
            this.bline.Text = "Line";
            this.bline.UseVisualStyleBackColor = true;
            this.bline.Click += new System.EventHandler(this.bline_Click);
            // 
            // bCircle
            // 
            this.bCircle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCircle.Location = new System.Drawing.Point(131, 45);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(139, 54);
            this.bCircle.TabIndex = 1;
            this.bCircle.Text = "Circle";
            this.bCircle.UseVisualStyleBackColor = true;
            this.bCircle.Click += new System.EventHandler(this.bCircle_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRectangle.Location = new System.Drawing.Point(131, 105);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(139, 52);
            this.bRectangle.TabIndex = 2;
            this.bRectangle.Text = "Rectangle";
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // bElipse
            // 
            this.bElipse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bElipse.Location = new System.Drawing.Point(-3, 105);
            this.bElipse.Name = "bElipse";
            this.bElipse.Size = new System.Drawing.Size(128, 43);
            this.bElipse.TabIndex = 3;
            this.bElipse.Text = "Elipse";
            this.bElipse.UseVisualStyleBackColor = true;
            this.bElipse.Click += new System.EventHandler(this.bElipse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(276, 49);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width.Location = new System.Drawing.Point(276, 13);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(66, 30);
            this.width.TabIndex = 6;
            this.width.Text = "width";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.color.Location = new System.Drawing.Point(440, 9);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(71, 30);
            this.color.TabIndex = 7;
            this.color.Text = "Color:";
            // 
            // bPen
            // 
            this.bPen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPen.Location = new System.Drawing.Point(481, 87);
            this.bPen.Name = "bPen";
            this.bPen.Size = new System.Drawing.Size(149, 51);
            this.bPen.TabIndex = 8;
            this.bPen.Text = "Pen";
            this.bPen.UseVisualStyleBackColor = true;
            this.bPen.Click += new System.EventHandler(this.bPen_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClear.Location = new System.Drawing.Point(636, 87);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(139, 51);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 643);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.saveImageAsToolStripMenuItem.Text = "Save image as...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 806);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bPen);
            this.Controls.Add(this.color);
            this.Controls.Add(this.width);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bElipse);
            this.Controls.Add(this.bRectangle);
            this.Controls.Add(this.bCircle);
            this.Controls.Add(this.bline);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bline;
        private Button bCircle;
        private Button bRectangle;
        private Button bElipse;
        private ComboBox comboBox1;
        private TrackBar trackBar1;
        private Label width;
        private Label color;
        private Button bPen;
        private Button bClear;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveImageAsToolStripMenuItem;
    }
}