namespace ITI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-306, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1604, 835);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(633, 127);
            button1.Name = "button1";
            button1.Size = new Size(216, 68);
            button1.TabIndex = 1;
            button1.Text = "Create ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(855, 127);
            button2.Name = "button2";
            button2.Size = new Size(237, 68);
            button2.TabIndex = 2;
            button2.Text = "Read ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(633, 201);
            button4.Name = "button4";
            button4.Size = new Size(459, 68);
            button4.TabIndex = 4;
            button4.Text = "Delete | Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Brown;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(633, 275);
            button5.Name = "button5";
            button5.Size = new Size(459, 68);
            button5.TabIndex = 5;
            button5.Text = "Join";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 741);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}
