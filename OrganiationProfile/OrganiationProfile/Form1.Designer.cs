namespace OrganiationProfile
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            cbProgram = new ComboBox();
            txtMiddleInitial = new TextBox();
            cbGender = new ComboBox();
            txtContactNo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(39, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(47, 204);
            label4.Name = "label4";
            label4.Size = new Size(33, 19);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(47, 255);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(130, 255);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(249, 333);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(347, 112);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 7;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(347, 157);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 8;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(603, 158);
            label8.Name = "label8";
            label8.Size = new Size(29, 19);
            label8.TabIndex = 9;
            label8.Text = "M.I";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(347, 213);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 10;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(438, 270);
            label10.Name = "label10";
            label10.Size = new Size(82, 19);
            label10.TabIndex = 11;
            label10.Text = "Contact No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(130, 112);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(144, 23);
            txtStudentNo.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 157);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(144, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(130, 209);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(110, 23);
            txtAge.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(438, 157);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(144, 23);
            txtFirstName.TabIndex = 15;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(427, 108);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(189, 23);
            cbProgram.TabIndex = 16;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(649, 158);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(41, 23);
            txtMiddleInitial.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(407, 213);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(81, 23);
            cbGender.TabIndex = 18;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(526, 269);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(144, 23);
            txtContactNo.TabIndex = 19;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContactNo);
            Controls.Add(cbGender);
            Controls.Add(txtMiddleInitial);
            Controls.Add(cbProgram);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organizational Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private ComboBox cbProgram;
        private TextBox txtMiddleInitial;
        private ComboBox cbGender;
        private TextBox txtContactNo;
    }
}
