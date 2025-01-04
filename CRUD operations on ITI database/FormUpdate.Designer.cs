
namespace ITI
{
    partial class FormUpdate
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
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // ResText
            // 
            ResText.AutoSize = true;
            ResText.Location = new Point(500, 389);
            ResText.Name = "ResText";
            ResText.Size = new Size(0, 20);
            ResText.TabIndex = 24;
            ResText.Click += this.ResText_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(207, 386);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(250, 43);
            btnAddStudent.TabIndex = 23;
            btnAddStudent.Text = "Update Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // age
            // 
            age.Location = new Point(310, 327);
            age.Name = "age";
            age.Size = new Size(448, 27);
            age.TabIndex = 22;
            age.TextChanged += this.age_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(310, 274);
            address.Name = "address";
            address.Size = new Size(448, 27);
            address.TabIndex = 21;
            address.TextChanged += this.address_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(310, 219);
            lname.Name = "lname";
            lname.Size = new Size(448, 27);
            lname.TabIndex = 20;
            lname.TextChanged += this.lname_TextChanged;
            // 
            // fname
            // 
            fname.Location = new Point(310, 170);
            fname.Name = "fname";
            fname.Size = new Size(448, 27);
            fname.TabIndex = 19;
            fname.TextChanged += this.fname_TextChanged;
            // 
            // st_id
            // 
            st_id.Location = new Point(310, 114);
            st_id.Name = "st_id";
            st_id.Size = new Size(448, 27);
            st_id.TabIndex = 18;
            st_id.TextChanged += this.st_id_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(180, 170);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 17;
            label5.Text = "First_Name";
            label5.Click += this.label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(181, 219);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 16;
            label4.Text = "Last_Name";
            label4.Click += this.label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(155, 271);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 15;
            label3.Text = "Student_Address";
            label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(181, 327);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 14;
            label2.Text = "Student_Age";
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(180, 114);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 13;
            label1.Text = "Student_ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 54);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 25;
            label6.Text = "Student Names";
            label6.Click += this.label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 28);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormUpdate";
            Text = "FormUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void st_id_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResText_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

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
        private Label label6;
        private ComboBox comboBox1;
    }
}