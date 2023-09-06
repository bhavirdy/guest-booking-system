namespace GuestBookingSystem.Presentation
{
    partial class MakeBookingForm
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
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.lblADate = new System.Windows.Forms.Label();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(251, 140);
            this.dateTimePickerArrival.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerArrival.TabIndex = 0;
            // 
            // lblADate
            // 
            this.lblADate.AutoSize = true;
            this.lblADate.Location = new System.Drawing.Point(57, 140);
            this.lblADate.Name = "lblADate";
            this.lblADate.Size = new System.Drawing.Size(77, 16);
            this.lblADate.TabIndex = 1;
            this.lblADate.Text = "Arrival Date";
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(60, 189);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(99, 16);
            this.lblLeaveDate.TabIndex = 2;
            this.lblLeaveDate.Text = "Departure Date";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(251, 189);
            this.dateTimePickerDepartureDate.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDepartureDate.TabIndex = 3;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(668, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(57, 94);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(80, 16);
            this.lblCustID.TabIndex = 6;
            this.lblCustID.Text = "Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(251, 94);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(200, 22);
            this.txtCustID.TabIndex = 7;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Location = new System.Drawing.Point(60, 241);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(95, 16);
            this.lblRoomNum.TabIndex = 8;
            this.lblRoomNum.Text = "Room Number";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(251, 241);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(200, 22);
            this.txtRoomNum.TabIndex = 9;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(60, 293);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(54, 16);
            this.lblDeposit.TabIndex = 10;
            this.lblDeposit.Text = "Deposit";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(251, 290);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(200, 22);
            this.txtDeposit.TabIndex = 11;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(37, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(357, 54);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Make a Booking";
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.lblADate);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Name = "MakeBookingForm";
            this.Text = "MakeBookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.Label lblADate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblHeading;
    }
}