namespace ITI
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            st_id = new TextBox();
            fname = new TextBox();
            lname = new TextBox();
            address = new TextBox();
            age = new TextBox();
            pictureBox1 = new PictureBox();
            btnAddStudent = new Button();
            ResText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(127, 89);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "Student_ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(128, 302);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 1;
            label2.Text = "Student_Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(102, 246);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 2;
            label3.Text = "Student_Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(128, 194);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 3;
            label4.Text = "Last_Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(127, 145);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 4;
            label5.Text = "First_Name";
            // 
            // st_id
            // 
            st_id.Location = new Point(257, 89);
            st_id.Name = "st_id";
            st_id.Size = new Size(448, 27);
            st_id.TabIndex = 5;
            // 
            // fname
            // 
            fname.Location = new Point(257, 145);
            fname.Name = "fname";
            fname.Size = new Size(448, 27);
            fname.TabIndex = 6;
            // 
            // lname
            // 
            lname.Location = new Point(257, 194);
            lname.Name = "lname";
            lname.Size = new Size(448, 27);
            lname.TabIndex = 7;
            // 
            // address
            // 
            address.Location = new Point(257, 249);
            address.Name = "address";
            address.Size = new Size(448, 27);
            address.TabIndex = 8;
            // 
            // age
            // 
            age.Location = new Point(257, 302);
            age.Name = "age";
            age.Size = new Size(448, 27);
            age.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(154, 361);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(250, 43);
            btnAddStudent.TabIndex = 11;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // ResText
            // 
            ResText.AutoSize = true;
            ResText.Location = new Point(447, 364);
            ResText.Name = "ResText";
            ResText.Size = new Size(0, 20);
            ResText.TabIndex = 12;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 455);
            Controls.Add(ResText);
            Controls.Add(btnAddStudent);
            Controls.Add(pictureBox1);
            Controls.Add(age);
            Controls.Add(address);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(st_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreate";
            Text = "FormCreate";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox st_id;
        private TextBox fname;
        private TextBox lname;
        private TextBox address;
        private TextBox age;
        private PictureBox pictureBox1;
        private Button btnAddStudent;
        private Label ResText;
    }
}