namespace SDP_Project_WindowForm
{
    partial class CruiseBooking
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
            this.num = new System.Windows.Forms.NumericUpDown();
            this.lbl_cruiseName = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl_Price_ = new System.Windows.Forms.Label();
            this.lbl_CruiseID = new System.Windows.Forms.Label();
            this.lbl_CruiseOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.num.Location = new System.Drawing.Point(691, 54);
            this.num.Margin = new System.Windows.Forms.Padding(2);
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(43, 24);
            this.num.TabIndex = 15;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // lbl_cruiseName
            // 
            this.lbl_cruiseName.AutoSize = true;
            this.lbl_cruiseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_cruiseName.Location = new System.Drawing.Point(210, 55);
            this.lbl_cruiseName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_cruiseName.Name = "lbl_cruiseName";
            this.lbl_cruiseName.Size = new System.Drawing.Size(83, 18);
            this.lbl_cruiseName.TabIndex = 14;
            this.lbl_cruiseName.Text = "CriseName";
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_confirm.Location = new System.Drawing.Point(755, 47);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(68, 28);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl_Price_
            // 
            this.lbl_Price_.AutoSize = true;
            this.lbl_Price_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Price_.Location = new System.Drawing.Point(565, 52);
            this.lbl_Price_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Price_.Name = "lbl_Price_";
            this.lbl_Price_.Size = new System.Drawing.Size(42, 18);
            this.lbl_Price_.TabIndex = 12;
            this.lbl_Price_.Text = "Price";
            // 
            // lbl_CruiseID
            // 
            this.lbl_CruiseID.AutoSize = true;
            this.lbl_CruiseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_CruiseID.Location = new System.Drawing.Point(124, 55);
            this.lbl_CruiseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CruiseID.Name = "lbl_CruiseID";
            this.lbl_CruiseID.Size = new System.Drawing.Size(65, 18);
            this.lbl_CruiseID.TabIndex = 11;
            this.lbl_CruiseID.Text = "CruiseID";
            // 
            // lbl_CruiseOrderID
            // 
            this.lbl_CruiseOrderID.AutoSize = true;
            this.lbl_CruiseOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_CruiseOrderID.Location = new System.Drawing.Point(11, 55);
            this.lbl_CruiseOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CruiseOrderID.Name = "lbl_CruiseOrderID";
            this.lbl_CruiseOrderID.Size = new System.Drawing.Size(103, 18);
            this.lbl_CruiseOrderID.TabIndex = 10;
            this.lbl_CruiseOrderID.Text = "CruiseOrderID";
            // 
            // CruiseBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 331);
            this.Controls.Add(this.num);
            this.Controls.Add(this.lbl_cruiseName);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_Price_);
            this.Controls.Add(this.lbl_CruiseID);
            this.Controls.Add(this.lbl_CruiseOrderID);
            this.Name = "CruiseBooking";
            this.Text = "CruiseBooking";
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label lbl_cruiseName;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl_Price_;
        private System.Windows.Forms.Label lbl_CruiseID;
        private System.Windows.Forms.Label lbl_CruiseOrderID;
    }
}