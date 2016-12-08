namespace SDP_Project_WindowForm
{
    partial class ucCForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_showPDF = new System.Windows.Forms.Button();
            this.lbl_price_ucCForm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cruise_ucCForm = new System.Windows.Forms.Label();
            this.lbl_day_ucCForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_showPDF
            // 
            this.btn_showPDF.AutoSize = true;
            this.btn_showPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_showPDF.Location = new System.Drawing.Point(14, 24);
            this.btn_showPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showPDF.Name = "btn_showPDF";
            this.btn_showPDF.Size = new System.Drawing.Size(84, 28);
            this.btn_showPDF.TabIndex = 9;
            this.btn_showPDF.Text = "showPDF";
            this.btn_showPDF.UseVisualStyleBackColor = true;
            this.btn_showPDF.Click += new System.EventHandler(this.btn_showPDF_Click);
            // 
            // lbl_price_ucCForm
            // 
            this.lbl_price_ucCForm.AutoSize = true;
            this.lbl_price_ucCForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_price_ucCForm.Location = new System.Drawing.Point(638, 29);
            this.lbl_price_ucCForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price_ucCForm.Name = "lbl_price_ucCForm";
            this.lbl_price_ucCForm.Size = new System.Drawing.Size(40, 18);
            this.lbl_price_ucCForm.TabIndex = 8;
            this.lbl_price_ucCForm.Text = "price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(752, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cruise_ucCForm
            // 
            this.lbl_cruise_ucCForm.AutoSize = true;
            this.lbl_cruise_ucCForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_cruise_ucCForm.Location = new System.Drawing.Point(226, 29);
            this.lbl_cruise_ucCForm.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_cruise_ucCForm.Name = "lbl_cruise_ucCForm";
            this.lbl_cruise_ucCForm.Size = new System.Drawing.Size(119, 18);
            this.lbl_cruise_ucCForm.TabIndex = 6;
            this.lbl_cruise_ucCForm.Text = "showCriseName";
            // 
            // lbl_day_ucCForm
            // 
            this.lbl_day_ucCForm.AutoSize = true;
            this.lbl_day_ucCForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_day_ucCForm.Location = new System.Drawing.Point(116, 29);
            this.lbl_day_ucCForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_day_ucCForm.Name = "lbl_day_ucCForm";
            this.lbl_day_ucCForm.Size = new System.Drawing.Size(70, 18);
            this.lbl_day_ucCForm.TabIndex = 5;
            this.lbl_day_ucCForm.Text = "showDay";
            // 
            // ucCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_showPDF);
            this.Controls.Add(this.lbl_price_ucCForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cruise_ucCForm);
            this.Controls.Add(this.lbl_day_ucCForm);
            this.Name = "ucCForm";
            this.Size = new System.Drawing.Size(857, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showPDF;
        private System.Windows.Forms.Label lbl_price_ucCForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cruise_ucCForm;
        private System.Windows.Forms.Label lbl_day_ucCForm;
    }
}
