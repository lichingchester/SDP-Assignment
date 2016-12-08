namespace SDP_Project_WindowForm
{
    partial class ucStatuesBar
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_currentTime_uc = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_currentStatus_customerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_currentStatus_uc = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_currentTime_uc,
            this.lbl_currentStatus_customerSelection,
            this.lbl_currentStatus_uc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_currentTime_uc
            // 
            this.lbl_currentTime_uc.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_currentTime_uc.Name = "lbl_currentTime_uc";
            this.lbl_currentTime_uc.Size = new System.Drawing.Size(78, 19);
            this.lbl_currentTime_uc.Text = "currentTime";
            // 
            // lbl_currentStatus_customerSelection
            // 
            this.lbl_currentStatus_customerSelection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_currentStatus_customerSelection.Name = "lbl_currentStatus_customerSelection";
            this.lbl_currentStatus_customerSelection.Size = new System.Drawing.Size(84, 19);
            this.lbl_currentStatus_customerSelection.Text = "currentStatus";
            // 
            // lbl_currentStatus_uc
            // 
            this.lbl_currentStatus_uc.Name = "lbl_currentStatus_uc";
            this.lbl_currentStatus_uc.Size = new System.Drawing.Size(80, 19);
            this.lbl_currentStatus_uc.Text = "currentStatus";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucStatuesBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.statusStrip1);
            this.Name = "ucStatuesBar";
            this.Size = new System.Drawing.Size(636, 26);
            this.Load += new System.EventHandler(this.ucStatuesBar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_currentTime_uc;
        private System.Windows.Forms.ToolStripStatusLabel lbl_currentStatus_uc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_currentStatus_customerSelection;

    }
}
