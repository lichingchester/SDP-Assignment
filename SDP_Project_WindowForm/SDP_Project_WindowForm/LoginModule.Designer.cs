namespace SDP_Project_WindowForm
{
    partial class LoginModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titleName_loginform = new System.Windows.Forms.Label();
            this.lbl_name_loginform = new System.Windows.Forms.Label();
            this.txtBox_loginName_loginform = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_password_loginform = new System.Windows.Forms.TextBox();
            this.btn_login_loginform = new System.Windows.Forms.Button();
            this.ucStatuesBar1 = new SDP_Project_WindowForm.ucStatuesBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(765, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Tailor System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login Name :";
            // 
            // lbl_titleName_loginform
            // 
            this.lbl_titleName_loginform.AutoSize = true;
            this.lbl_titleName_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleName_loginform.Location = new System.Drawing.Point(360, 148);
            this.lbl_titleName_loginform.Name = "lbl_titleName_loginform";
            this.lbl_titleName_loginform.Size = new System.Drawing.Size(34, 20);
            this.lbl_titleName_loginform.TabIndex = 2;
            this.lbl_titleName_loginform.Text = "title";
            // 
            // lbl_name_loginform
            // 
            this.lbl_name_loginform.AutoSize = true;
            this.lbl_name_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_loginform.Location = new System.Drawing.Point(390, 148);
            this.lbl_name_loginform.Name = "lbl_name_loginform";
            this.lbl_name_loginform.Size = new System.Drawing.Size(49, 20);
            this.lbl_name_loginform.TabIndex = 3;
            this.lbl_name_loginform.Text = "name";
            // 
            // txtBox_loginName_loginform
            // 
            this.txtBox_loginName_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_loginName_loginform.Location = new System.Drawing.Point(254, 169);
            this.txtBox_loginName_loginform.Name = "txtBox_loginName_loginform";
            this.txtBox_loginName_loginform.Size = new System.Drawing.Size(195, 26);
            this.txtBox_loginName_loginform.TabIndex = 4;
            this.txtBox_loginName_loginform.TextChanged += new System.EventHandler(this.txtBox_loginName_loginform_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password :";
            // 
            // txtBox_password_loginform
            // 
            this.txtBox_password_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password_loginform.Location = new System.Drawing.Point(254, 229);
            this.txtBox_password_loginform.Name = "txtBox_password_loginform";
            this.txtBox_password_loginform.Size = new System.Drawing.Size(195, 26);
            this.txtBox_password_loginform.TabIndex = 6;
            // 
            // btn_login_loginform
            // 
            this.btn_login_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_loginform.Location = new System.Drawing.Point(254, 276);
            this.btn_login_loginform.Name = "btn_login_loginform";
            this.btn_login_loginform.Size = new System.Drawing.Size(195, 32);
            this.btn_login_loginform.TabIndex = 7;
            this.btn_login_loginform.Text = "Login";
            this.btn_login_loginform.UseVisualStyleBackColor = true;
            this.btn_login_loginform.Click += new System.EventHandler(this.btn_login_loginform_Click);
            // 
            // ucStatuesBar1
            // 
            this.ucStatuesBar1.BackColor = System.Drawing.Color.LightGray;
            this.ucStatuesBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatuesBar1.Location = new System.Drawing.Point(0, 393);
            this.ucStatuesBar1.Name = "ucStatuesBar1";
            this.ucStatuesBar1.sg_lblCurrentStatus = "";
            this.ucStatuesBar1.sg_lblCustomerSelection = "";
            this.ucStatuesBar1.Size = new System.Drawing.Size(765, 31);
            this.ucStatuesBar1.TabIndex = 8;
            this.ucStatuesBar1.Load += new System.EventHandler(this.ucStatuesBar1_Load);
            // 
            // LoginModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 424);
            this.Controls.Add(this.ucStatuesBar1);
            this.Controls.Add(this.btn_login_loginform);
            this.Controls.Add(this.txtBox_password_loginform);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_loginName_loginform);
            this.Controls.Add(this.lbl_name_loginform);
            this.Controls.Add(this.lbl_titleName_loginform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "LoginModule";
            this.Text = "Login Module";
            this.Load += new System.EventHandler(this.LoginModule_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginModule_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_titleName_loginform;
        private System.Windows.Forms.Label lbl_name_loginform;
        private System.Windows.Forms.TextBox txtBox_loginName_loginform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_password_loginform;
        private System.Windows.Forms.Button btn_login_loginform;
        private ucStatuesBar ucStatuesBar1;
    }
}