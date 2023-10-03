namespace GuestBookingSystem.Presentation
{
    partial class CheckAvailability
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblADate = new System.Windows.Forms.Label();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(401, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(437, 282);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(26, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnProceed.Location = new System.Drawing.Point(648, 410);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(190, 35);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed with booking";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheck.Location = new System.Drawing.Point(235, 268);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 29);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Dates";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 212);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // lblADate
            // 
            this.lblADate.AutoSize = true;
            this.lblADate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblADate.Location = new System.Drawing.Point(48, 160);
            this.lblADate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblADate.Name = "lblADate";
            this.lblADate.Size = new System.Drawing.Size(83, 18);
            this.lblADate.TabIndex = 24;
            this.lblADate.Text = "Arrival Date";
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLeaveDate.Location = new System.Drawing.Point(23, 212);
            this.lblLeaveDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(108, 18);
            this.lblLeaveDate.TabIndex = 25;
            this.lblLeaveDate.Text = "Departure Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "Check Availability of Rooms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuestBookingSystem.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // CheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.lblADate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CheckAvailability";
            this.Text = "CheckAvailability";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckAvailability_FormClosed);
            this.Load += new System.EventHandler(this.CheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblADate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}