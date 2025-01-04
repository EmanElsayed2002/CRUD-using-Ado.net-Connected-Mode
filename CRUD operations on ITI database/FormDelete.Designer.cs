namespace ITI
{
    partial class FormDelete
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            ResText = new Label();
            btnAddStudent = new Button();
            age = new TextBox();
            address = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            st_id = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 28);
            comboBox1.TabIndex = 40;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(150, 39);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 39;
            label6.Text = "Student Names";
            // 
            // ResText
            // 
            ResText.AutoSize = true;
            ResText.Location = new Point(470, 374);
            ResText.Name = "ResText";
            ResText.Size = new Size(0, 20);
            ResText.TabIndex = 38;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(192, 0, 0);
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = SystemColors.ButtonHighlight;
            btnAddStudent.Location = new Point(125, 371);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(284, 43);
            btnAddStudent.TabIndex = 37;
            btnAddStudent.Text = "Delete Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // age
            // 
            age.Location = new Point(280, 312);
            age.Name = "age";
            age.Size = new Size(448, 27);
            age.TabIndex = 36;
            // 
            // address
            // 
            address.Location = new Point(280, 259);
            address.Name = "address";
            address.Size = new Size(448, 27);
            address.TabIndex = 35;
            // 
            // lname
            // 
            lname.Location = new Point(280, 204);
            lname.Name = "lname";
            lname.Size = new Size(448, 27);
            lname.TabIndex = 34;
            // 
            // fname
            // 
            fname.Location = new Point(280, 155);
            fname.Name = "fname";
            fname.Size = new Size(448, 27);
            fname.TabIndex = 33;
            // 
            // st_id
            // 
            st_id.Location = new Point(280, 99);
            st_id.Name = "st_id";
            st_id.Size = new Size(448, 27);
            st_id.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(150, 155);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 31;
            label5.Text = "First_Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(151, 204);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 30;
            label4.Text = "Last_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(125, 256);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 29;
            label3.Text = "Student_Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(151, 312);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 28;
            label2.Text = "Student_Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(150, 99);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 27;
            label1.Text = "Student_ID";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(437, 371);
            button1.Name = "button1";
            button1.Size = new Size(291, 43);
            button1.TabIndex = 41;
            button1.Text = "Update Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(ResText);
            Controls.Add(btnAddStudent);
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
            Name = "FormDelete";
            Text = "FormDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label6;
        private Label ResText;
        private Button btnAddStudent;
        private TextBox age;
        private TextBox address;
        private TextBox lname;
        private TextBox fname;
        private TextBox st_id;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}