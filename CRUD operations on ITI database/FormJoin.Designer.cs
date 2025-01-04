namespace ITI
{
    partial class FormJoin
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
            label1 = new Label();
            comboBoxStudents = new ComboBox();
            btnLoadData = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 61);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Students ";
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(237, 58);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(345, 28);
            comboBoxStudents.TabIndex = 2;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(341, 338);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(153, 38);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(260, 116);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(303, 202);
            dataGridView.TabIndex = 4;
            // 
            // FormJoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(btnLoadData);
            Controls.Add(comboBoxStudents);
            Controls.Add(label1);
            Name = "FormJoin";
            Text = "FormJoin";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxStudents;
        private Button btnLoadData;
        private DataGridView dataGridView;
    }
}