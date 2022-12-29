namespace Les05
{
    partial class Form1
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
            this.bsave = new System.Windows.Forms.Button();
            this.bshow = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.rtbinput = new System.Windows.Forms.RichTextBox();
            this.rtboutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsave.Location = new System.Drawing.Point(27, 334);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(241, 104);
            this.bsave.TabIndex = 0;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // bshow
            // 
            this.bshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bshow.Location = new System.Drawing.Point(488, 334);
            this.bshow.Name = "bshow";
            this.bshow.Size = new System.Drawing.Size(263, 96);
            this.bshow.TabIndex = 1;
            this.bshow.Text = "Show";
            this.bshow.UseVisualStyleBackColor = true;
            this.bshow.Click += new System.EventHandler(this.bshow_Click);
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbname.Location = new System.Drawing.Point(27, 12);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(313, 41);
            this.tbname.TabIndex = 3;
            // 
            // rtbinput
            // 
            this.rtbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbinput.Location = new System.Drawing.Point(27, 72);
            this.rtbinput.Name = "rtbinput";
            this.rtbinput.Size = new System.Drawing.Size(282, 223);
            this.rtbinput.TabIndex = 5;
            this.rtbinput.Text = "";
            // 
            // rtboutput
            // 
            this.rtboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtboutput.Location = new System.Drawing.Point(435, 70);
            this.rtboutput.Name = "rtboutput";
            this.rtboutput.Size = new System.Drawing.Size(329, 215);
            this.rtboutput.TabIndex = 6;
            this.rtboutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtboutput);
            this.Controls.Add(this.rtbinput);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.bshow);
            this.Controls.Add(this.bsave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bshow;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.RichTextBox rtbinput;
        private System.Windows.Forms.RichTextBox rtboutput;
    }
}

