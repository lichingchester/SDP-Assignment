namespace SDP_Project_WindowForm
{
    partial class UCHotelSelect
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
            this.ht_room_name = new System.Windows.Forms.Label();
            this.ht_book = new System.Windows.Forms.Button();
            this.ht_child = new System.Windows.Forms.Label();
            this.ht_audults = new System.Windows.Forms.Label();
            this.ht_price = new System.Windows.Forms.Label();
            this.ht_room_size = new System.Windows.Forms.Label();
            this.ht_room_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ht_room_name
            // 
            this.ht_room_name.AutoSize = true;
            this.ht_room_name.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ht_room_name.Location = new System.Drawing.Point(3, 0);
            this.ht_room_name.Name = "ht_room_name";
            this.ht_room_name.Size = new System.Drawing.Size(148, 21);
            this.ht_room_name.TabIndex = 15;
            this.ht_room_name.Text = "HotelRoomName";
            // 
            // ht_book
            // 
            this.ht_book.Location = new System.Drawing.Point(277, 142);
            this.ht_book.Name = "ht_book";
            this.ht_book.Size = new System.Drawing.Size(86, 28);
            this.ht_book.TabIndex = 14;
            this.ht_book.Text = "Book";
            this.ht_book.UseVisualStyleBackColor = true;
            this.ht_book.Click += new System.EventHandler(this.ht_book_Click);
            // 
            // ht_child
            // 
            this.ht_child.AutoSize = true;
            this.ht_child.Location = new System.Drawing.Point(89, 149);
            this.ht_child.Name = "ht_child";
            this.ht_child.Size = new System.Drawing.Size(52, 12);
            this.ht_child.TabIndex = 13;
            this.ht_child.Text = "MaxChild";
            // 
            // ht_audults
            // 
            this.ht_audults.AutoSize = true;
            this.ht_audults.Location = new System.Drawing.Point(5, 149);
            this.ht_audults.Name = "ht_audults";
            this.ht_audults.Size = new System.Drawing.Size(62, 12);
            this.ht_audults.TabIndex = 12;
            this.ht_audults.Text = "MaxAudults";
            // 
            // ht_price
            // 
            this.ht_price.AutoSize = true;
            this.ht_price.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ht_price.Location = new System.Drawing.Point(306, 96);
            this.ht_price.Name = "ht_price";
            this.ht_price.Size = new System.Drawing.Size(57, 24);
            this.ht_price.TabIndex = 11;
            this.ht_price.Text = "Price";
            // 
            // ht_room_size
            // 
            this.ht_room_size.AutoSize = true;
            this.ht_room_size.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ht_room_size.Location = new System.Drawing.Point(4, 87);
            this.ht_room_size.Name = "ht_room_size";
            this.ht_room_size.Size = new System.Drawing.Size(65, 15);
            this.ht_room_size.TabIndex = 10;
            this.ht_room_size.Text = "RoomSize";
            // 
            // ht_room_type
            // 
            this.ht_room_type.AutoSize = true;
            this.ht_room_type.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ht_room_type.Location = new System.Drawing.Point(3, 41);
            this.ht_room_type.Name = "ht_room_type";
            this.ht_room_type.Size = new System.Drawing.Size(99, 21);
            this.ht_room_type.TabIndex = 9;
            this.ht_room_type.Text = "RoomType";
            // 
            // UCHotelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ht_room_name);
            this.Controls.Add(this.ht_book);
            this.Controls.Add(this.ht_child);
            this.Controls.Add(this.ht_audults);
            this.Controls.Add(this.ht_price);
            this.Controls.Add(this.ht_room_size);
            this.Controls.Add(this.ht_room_type);
            this.Name = "UCHotelSelect";
            this.Size = new System.Drawing.Size(381, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ht_room_name;
        private System.Windows.Forms.Button ht_book;
        private System.Windows.Forms.Label ht_child;
        private System.Windows.Forms.Label ht_audults;
        private System.Windows.Forms.Label ht_price;
        private System.Windows.Forms.Label ht_room_size;
        private System.Windows.Forms.Label ht_room_type;
    }
}
