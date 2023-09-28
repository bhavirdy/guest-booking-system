namespace GuestBookingSystem.Presentation
{
    partial class ViewTables
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(34, 73);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(131, 45);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "View Customer Table";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(231, 73);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(131, 45);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "View Booking Table";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Location = new System.Drawing.Point(432, 73);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(131, 45);
            this.btnReceptionist.TabIndex = 3;
            this.btnReceptionist.Text = "View Receptionist Table";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(631, 73);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(131, 45);
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "View Room Table";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // ViewTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnReceptionist);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewTables";
            this.Text = "View Tables";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.testForm_FormClosed);
            this.Load += new System.EventHandler(this.testForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnReceptionist;
        private System.Windows.Forms.Button btnRoom;
    }
}