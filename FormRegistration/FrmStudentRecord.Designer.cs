namespace FormRegistration
{
    partial class FrmStudentRecord
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
            this.registerbtn = new System.Windows.Forms.Button();
            this.findtbn = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerbtn.Location = new System.Drawing.Point(466, 105);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(117, 36);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // findtbn
            // 
            this.findtbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findtbn.Location = new System.Drawing.Point(466, 159);
            this.findtbn.Name = "findtbn";
            this.findtbn.Size = new System.Drawing.Size(117, 37);
            this.findtbn.TabIndex = 1;
            this.findtbn.Text = "Find";
            this.findtbn.UseVisualStyleBackColor = true;
            this.findtbn.Click += new System.EventHandler(this.findtbn_Click);
            // 
            // uploadbtn
            // 
            this.uploadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uploadbtn.Location = new System.Drawing.Point(466, 212);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(117, 35);
            this.uploadbtn.TabIndex = 2;
            this.uploadbtn.Text = "Upload";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Records";
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(86, 96);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(287, 173);
            this.lvShowText.TabIndex = 4;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 326);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.findtbn);
            this.Controls.Add(this.registerbtn);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.Load += new System.EventHandler(this.FrmStudentRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button findtbn;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvShowText;
    }
}