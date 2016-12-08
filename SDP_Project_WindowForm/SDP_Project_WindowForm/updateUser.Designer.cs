namespace SDP_Project_WindowForm
{
    partial class updateUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbBox_gender = new System.Windows.Forms.ComboBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.txtBox_surname = new System.Windows.Forms.TextBox();
            this.txtBox_givenName = new System.Windows.Forms.TextBox();
            this.txtBox_passport = new System.Windows.Forms.TextBox();
            this.txtBox_contact = new System.Windows.Forms.TextBox();
            this.txtBox_nationality = new System.Windows.Forms.TextBox();
            this.txtBox_custID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.button1.Location = new System.Drawing.Point(533, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBox_gender
            // 
            this.cbBox_gender.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.cbBox_gender.FormattingEnabled = true;
            this.cbBox_gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbBox_gender.Location = new System.Drawing.Point(473, 67);
            this.cbBox_gender.Name = "cbBox_gender";
            this.cbBox_gender.Size = new System.Drawing.Size(152, 24);
            this.cbBox_gender.TabIndex = 35;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.dtp_dob.Location = new System.Drawing.Point(169, 230);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(152, 27);
            this.dtp_dob.TabIndex = 34;
            // 
            // txtBox_surname
            // 
            this.txtBox_surname.Location = new System.Drawing.Point(169, 123);
            this.txtBox_surname.Name = "txtBox_surname";
            this.txtBox_surname.Size = new System.Drawing.Size(152, 22);
            this.txtBox_surname.TabIndex = 33;
            // 
            // txtBox_givenName
            // 
            this.txtBox_givenName.Location = new System.Drawing.Point(169, 178);
            this.txtBox_givenName.Name = "txtBox_givenName";
            this.txtBox_givenName.Size = new System.Drawing.Size(152, 22);
            this.txtBox_givenName.TabIndex = 32;
            // 
            // txtBox_passport
            // 
            this.txtBox_passport.Location = new System.Drawing.Point(473, 122);
            this.txtBox_passport.MaxLength = 8;
            this.txtBox_passport.Name = "txtBox_passport";
            this.txtBox_passport.Size = new System.Drawing.Size(152, 22);
            this.txtBox_passport.TabIndex = 31;
            // 
            // txtBox_contact
            // 
            this.txtBox_contact.Location = new System.Drawing.Point(473, 176);
            this.txtBox_contact.MaxLength = 8;
            this.txtBox_contact.Name = "txtBox_contact";
            this.txtBox_contact.Size = new System.Drawing.Size(152, 22);
            this.txtBox_contact.TabIndex = 30;
            // 
            // txtBox_nationality
            // 
            this.txtBox_nationality.Location = new System.Drawing.Point(473, 230);
            this.txtBox_nationality.Name = "txtBox_nationality";
            this.txtBox_nationality.Size = new System.Drawing.Size(152, 22);
            this.txtBox_nationality.TabIndex = 29;
            // 
            // txtBox_custID
            // 
            this.txtBox_custID.Location = new System.Drawing.Point(169, 68);
            this.txtBox_custID.Name = "txtBox_custID";
            this.txtBox_custID.ReadOnly = true;
            this.txtBox_custID.Size = new System.Drawing.Size(152, 22);
            this.txtBox_custID.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(84, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Surname :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(62, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Given Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(56, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date Of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(395, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(386, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Passport :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(393, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contact :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(376, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nationality :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(59, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer ID :";
            // 
            // updateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbBox_gender);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txtBox_surname);
            this.Controls.Add(this.txtBox_givenName);
            this.Controls.Add(this.txtBox_passport);
            this.Controls.Add(this.txtBox_contact);
            this.Controls.Add(this.txtBox_nationality);
            this.Controls.Add(this.txtBox_custID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "updateUser";
            this.Text = "updateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBox_gender;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.TextBox txtBox_surname;
        private System.Windows.Forms.TextBox txtBox_givenName;
        private System.Windows.Forms.TextBox txtBox_passport;
        private System.Windows.Forms.TextBox txtBox_contact;
        private System.Windows.Forms.TextBox txtBox_nationality;
        private System.Windows.Forms.TextBox txtBox_custID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}