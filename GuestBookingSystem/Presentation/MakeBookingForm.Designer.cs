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
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.lblADate = new System.Windows.Forms.Label();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.rBtnExistingCustomer = new System.Windows.Forms.RadioButton();
            this.rBtnNewCustomer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(201, 338);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(204, 20);
            this.txtPaid.TabIndex = 39;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(57, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Paid";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(221, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 32);
            this.button3.TabIndex = 37;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(201, 291);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(204, 20);
            this.txtCardNum.TabIndex = 36;
            this.txtCardNum.TextChanged += new System.EventHandler(this.txtCardNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(57, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Card Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeading.Location = new System.Drawing.Point(50, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(290, 44);
            this.lblHeading.TabIndex = 32;
            this.lblHeading.Text = "Make a Booking";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(201, 165);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(204, 20);
            this.txtCustID.TabIndex = 29;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustID.Location = new System.Drawing.Point(56, 165);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(92, 18);
            this.lblCustID.TabIndex = 28;
            this.lblCustID.Text = "Customer ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(49, 398);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 32);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Location = new System.Drawing.Point(394, 398);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(67, 32);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(201, 243);
            this.dateTimePickerDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDepartureDate.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerDepartureDate.TabIndex = 25;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLeaveDate.Location = new System.Drawing.Point(56, 244);
            this.lblLeaveDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(108, 18);
            this.lblLeaveDate.TabIndex = 24;
            this.lblLeaveDate.Text = "Departure Date";
            // 
            // lblADate
            // 
            this.lblADate.AutoSize = true;
            this.lblADate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblADate.Location = new System.Drawing.Point(56, 204);
            this.lblADate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblADate.Name = "lblADate";
            this.lblADate.Size = new System.Drawing.Size(83, 18);
            this.lblADate.TabIndex = 23;
            this.lblADate.Text = "Arrival Date";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(201, 204);
            this.dateTimePickerArrival.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerArrival.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerArrival.TabIndex = 22;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBookingID.Location = new System.Drawing.Point(57, 131);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(81, 18);
            this.lblBookingID.TabIndex = 40;
            this.lblBookingID.Text = "Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(201, 131);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(204, 20);
            this.txtBookingID.TabIndex = 41;
            // 
            // rBtnExistingCustomer
            // 
            this.rBtnExistingCustomer.AutoSize = true;
            this.rBtnExistingCustomer.Location = new System.Drawing.Point(109, 75);
            this.rBtnExistingCustomer.Name = "rBtnExistingCustomer";
            this.rBtnExistingCustomer.Size = new System.Drawing.Size(108, 17);
            this.rBtnExistingCustomer.TabIndex = 42;
            this.rBtnExistingCustomer.TabStop = true;
            this.rBtnExistingCustomer.Text = "Existing Customer";
            this.rBtnExistingCustomer.UseVisualStyleBackColor = true;
            // 
            // rBtnNewCustomer
            // 
            this.rBtnNewCustomer.AutoSize = true;
            this.rBtnNewCustomer.Location = new System.Drawing.Point(255, 75);
            this.rBtnNewCustomer.Name = "rBtnNewCustomer";
            this.rBtnNewCustomer.Size = new System.Drawing.Size(94, 17);
            this.rBtnNewCustomer.TabIndex = 43;
            this.rBtnNewCustomer.TabStop = true;
            this.rBtnNewCustomer.Text = "New Customer";
            this.rBtnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 470);
            this.Controls.Add(this.rBtnNewCustomer);
            this.Controls.Add(this.rBtnExistingCustomer);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.lblADate);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MakeBookingForm";
            this.Text = "MakeBookingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MakeBookingForm_FormClosed);
            this.Load += new System.EventHandler(this.MakeBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.Label lblADate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.RadioButton rBtnExistingCustomer;
        private System.Windows.Forms.RadioButton rBtnNewCustomer;
    }
}