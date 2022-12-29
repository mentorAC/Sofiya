namespace Les4
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
            this.bTest = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bTest
            // 
            this.bTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTest.Location = new System.Drawing.Point(102, 336);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(268, 153);
            this.bTest.TabIndex = 0;
            this.bTest.Text = "test";
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(446, 181);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(178, 75);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(705, 181);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(136, 75);
            this.bCreate.TabIndex = 2;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileName.Location = new System.Drawing.Point(446, 108);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(395, 53);
            this.tbFileName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 626);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

