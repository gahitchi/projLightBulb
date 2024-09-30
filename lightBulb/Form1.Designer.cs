namespace lightBulb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_on = new Button();
            button_off = new Button();
            pictureBox1 = new PictureBox();
            button_up = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_on
            // 
            button_on.Location = new Point(50, 91);
            button_on.Name = "button_on";
            button_on.Size = new Size(183, 73);
            button_on.TabIndex = 0;
            button_on.Text = "on";
            button_on.UseVisualStyleBackColor = true;
            button_on.Click += button1_Click;
            // 
            // button_off
            // 
            button_off.Location = new Point(50, 285);
            button_off.Name = "button_off";
            button_off.Size = new Size(183, 73);
            button_off.TabIndex = 1;
            button_off.Text = "off";
            button_off.UseVisualStyleBackColor = true;
            button_off.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.light_off;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.light_off;
            pictureBox1.Location = new Point(529, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button1_Click;
            // 
            // button_up
            // 
            button_up.Location = new Point(359, 80);
            button_up.Name = "button_up";
            button_up.Size = new Size(55, 94);
            button_up.TabIndex = 3;
            button_up.Text = "up";
            button_up.UseVisualStyleBackColor = true;
            button_up.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(359, 274);
            button2.Name = "button2";
            button2.Size = new Size(55, 94);
            button2.TabIndex = 4;
            button2.Text = "down";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button_up);
            Controls.Add(pictureBox1);
            Controls.Add(button_off);
            Controls.Add(button_on);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_on;
        private Button button_off;
        private PictureBox pictureBox1;
        private Button button_up;
        private Button button2;
    }
}
