namespace SDP_Project_WindowForm
{
    partial class ucABooking
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
            this.num_ChildNum_ucABooking = new System.Windows.Forms.NumericUpDown();
            this.num_AdultNum_ucABooking = new System.Windows.Forms.NumericUpDown();
            this.lbl_ChildPrice_ucABooking = new System.Windows.Forms.Label();
            this.lbl_AdultPrice_ucABooking = new System.Windows.Forms.Label();
            this.lbl_AttractionName_ucABooking = new System.Windows.Forms.Label();
            this.lbl_AttractionOrderID_ucABooking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_ChildNum_ucABooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AdultNum_ucABooking)).BeginInit();
            this.SuspendLayout();
            // 
            // num_ChildNum_ucABooking
            // 
            this.num_ChildNum_ucABooking.Location = new System.Drawing.Point(454, 13);
            this.num_ChildNum_ucABooking.Margin = new System.Windows.Forms.Padding(2);
            this.num_ChildNum_ucABooking.Name = "num_ChildNum_ucABooking";
            this.num_ChildNum_ucABooking.Size = new System.Drawing.Size(68, 22);
            this.num_ChildNum_ucABooking.TabIndex = 19;
            this.num_ChildNum_ucABooking.ValueChanged += new System.EventHandler(this.num_ChildNum_ucABooking_ValueChanged);
            // 
            // num_AdultNum_ucABooking
            // 
            this.num_AdultNum_ucABooking.Location = new System.Drawing.Point(342, 13);
            this.num_AdultNum_ucABooking.Margin = new System.Windows.Forms.Padding(2);
            this.num_AdultNum_ucABooking.Name = "num_AdultNum_ucABooking";
            this.num_AdultNum_ucABooking.Size = new System.Drawing.Size(68, 22);
            this.num_AdultNum_ucABooking.TabIndex = 18;
            this.num_AdultNum_ucABooking.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_AdultNum_ucABooking.ValueChanged += new System.EventHandler(this.num_AdultNum_ucABooking_ValueChanged);
            // 
            // lbl_ChildPrice_ucABooking
            // 
            this.lbl_ChildPrice_ucABooking.AutoSize = true;
            this.lbl_ChildPrice_ucABooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_ChildPrice_ucABooking.Location = new System.Drawing.Point(655, 10);
            this.lbl_ChildPrice_ucABooking.Name = "lbl_ChildPrice_ucABooking";
            this.lbl_ChildPrice_ucABooking.Size = new System.Drawing.Size(75, 18);
            this.lbl_ChildPrice_ucABooking.TabIndex = 17;
            this.lbl_ChildPrice_ucABooking.Text = "ChildPrice";
            // 
            // lbl_AdultPrice_ucABooking
            // 
            this.lbl_AdultPrice_ucABooking.AutoSize = true;
            this.lbl_AdultPrice_ucABooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_AdultPrice_ucABooking.Location = new System.Drawing.Point(575, 10);
            this.lbl_AdultPrice_ucABooking.Name = "lbl_AdultPrice_ucABooking";
            this.lbl_AdultPrice_ucABooking.Size = new System.Drawing.Size(74, 18);
            this.lbl_AdultPrice_ucABooking.TabIndex = 16;
            this.lbl_AdultPrice_ucABooking.Text = "AdultPrice";
            // 
            // lbl_AttractionName_ucABooking
            // 
            this.lbl_AttractionName_ucABooking.AutoSize = true;
            this.lbl_AttractionName_ucABooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_AttractionName_ucABooking.Location = new System.Drawing.Point(160, 10);
            this.lbl_AttractionName_ucABooking.Name = "lbl_AttractionName_ucABooking";
            this.lbl_AttractionName_ucABooking.Size = new System.Drawing.Size(110, 18);
            this.lbl_AttractionName_ucABooking.TabIndex = 15;
            this.lbl_AttractionName_ucABooking.Text = "AttractionName";
            // 
            // lbl_AttractionOrderID_ucABooking
            // 
            this.lbl_AttractionOrderID_ucABooking.AutoSize = true;
            this.lbl_AttractionOrderID_ucABooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_AttractionOrderID_ucABooking.Location = new System.Drawing.Point(14, 10);
            this.lbl_AttractionOrderID_ucABooking.Name = "lbl_AttractionOrderID_ucABooking";
            this.lbl_AttractionOrderID_ucABooking.Size = new System.Drawing.Size(122, 18);
            this.lbl_AttractionOrderID_ucABooking.TabIndex = 14;
            this.lbl_AttractionOrderID_ucABooking.Text = "AttractionOrderID";
            // 
            // ucABooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num_ChildNum_ucABooking);
            this.Controls.Add(this.num_AdultNum_ucABooking);
            this.Controls.Add(this.lbl_ChildPrice_ucABooking);
            this.Controls.Add(this.lbl_AdultPrice_ucABooking);
            this.Controls.Add(this.lbl_AttractionName_ucABooking);
            this.Controls.Add(this.lbl_AttractionOrderID_ucABooking);
            this.Name = "ucABooking";
            this.Size = new System.Drawing.Size(736, 51);
            ((System.ComponentModel.ISupportInitialize)(this.num_ChildNum_ucABooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AdultNum_ucABooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_ChildNum_ucABooking;
        private System.Windows.Forms.NumericUpDown num_AdultNum_ucABooking;
        private System.Windows.Forms.Label lbl_ChildPrice_ucABooking;
        private System.Windows.Forms.Label lbl_AdultPrice_ucABooking;
        private System.Windows.Forms.Label lbl_AttractionName_ucABooking;
        private System.Windows.Forms.Label lbl_AttractionOrderID_ucABooking;
    }
}
