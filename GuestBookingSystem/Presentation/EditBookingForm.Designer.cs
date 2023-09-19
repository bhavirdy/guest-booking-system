namespace GuestBookingSystem.Presentation
{
    partial class EditBookingForm
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
            this.bookingView = new System.Windows.Forms.ListView();
            this.lblHeadingEdit = new System.Windows.Forms.Label();
            this.btnSubmitV = new System.Windows.Forms.Button();
            this.btnExitV = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.lblADate = new System.Windows.Forms.Label();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bookingView
            // 

            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 231);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;

            this.bookingView.HideSelection = false;
            this.bookingView.Location = new System.Drawing.Point(30, 66);
            this.bookingView.Name = "bookingView";
            this.bookingView.Size = new System.Drawing.Size(595, 260);
            this.bookingView.TabIndex = 0;
            this.bookingView.UseCompatibleStateImageBehavior = false;

            // 
            // lblHeadingEdit
            // 
            this.lblHeadingEdit.AutoSize = true;
            this.lblHeadingEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeadingEdit.Location = new System.Drawing.Point(37, 9);
            this.lblHeadingEdit.Name = "lblHeadingEdit";
            this.lblHeadingEdit.Size = new System.Drawing.Size(337, 54);
            this.lblHeadingEdit.TabIndex = 13;
            this.lblHeadingEdit.Text = "Edit Bookings";
            this.lblHeadingEdit.Click += new System.EventHandler(this.lblHeadingEdit_Click);
            // 
            // btnSubmitV
            // 
            this.btnSubmitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitV.Location = new System.Drawing.Point(657, 568);
            this.btnSubmitV.Name = "btnSubmitV";
            this.btnSubmitV.Size = new System.Drawing.Size(89, 31);
            this.btnSubmitV.TabIndex = 23;
            this.btnSubmitV.Text = "Submit";
            this.btnSubmitV.UseVisualStyleBackColor = true;
            // 
            // btnExitV
            // 
            this.btnExitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExitV.Location = new System.Drawing.Point(30, 568);
            this.btnExitV.Name = "btnExitV";
            this.btnExitV.Size = new System.Drawing.Size(95, 31);
            this.btnExitV.TabIndex = 24;
            this.btnExitV.Text = "Cancel";
            this.btnExitV.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Location = new System.Drawing.Point(335, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 29);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(246, 425);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(271, 22);
            this.txtDeposit.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(26, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Deposit";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(246, 529);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(271, 22);
            this.txtPaid.TabIndex = 44;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPaid.Location = new System.Drawing.Point(26, 530);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(49, 21);
            this.lblPaid.TabIndex = 43;
            this.lblPaid.Text = "Paid";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(246, 495);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(271, 22);
            this.txtCardNumber.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(26, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Card Number";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(246, 462);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(271, 22);
            this.txtRoomNum.TabIndex = 40;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRoomNum.Location = new System.Drawing.Point(26, 461);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(137, 21);
            this.lblRoomNum.TabIndex = 39;
            this.lblRoomNum.Text = "Room Number";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(246, 330);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(271, 22);

            this.txtCustID.TabIndex = 38;

            this.txtCustID.TabIndex = 20;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);

            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustID.Location = new System.Drawing.Point(26, 329);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(120, 21);
            this.lblCustID.TabIndex = 37;
            this.lblCustID.Text = "Customer ID";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(246, 390);
            this.dateTimePickerDepartureDate.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerDepartureDate.TabIndex = 36;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLeaveDate.Location = new System.Drawing.Point(26, 391);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(146, 21);
            this.lblLeaveDate.TabIndex = 35;
            this.lblLeaveDate.Text = "Departure Date";
            // 
            // lblADate
            // 
            this.lblADate.AutoSize = true;
            this.lblADate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblADate.Location = new System.Drawing.Point(26, 362);
            this.lblADate.Name = "lblADate";
            this.lblADate.Size = new System.Drawing.Size(116, 21);
            this.lblADate.TabIndex = 34;
            this.lblADate.Text = "Arrival Date";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(246, 362);
            this.dateTimePickerArrival.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(271, 22);

            this.dateTimePickerArrival.TabIndex = 33;
            this.dateTimePickerArrival.TabIndex = 15;
            // 
            // btnSubmitV
            // 
            this.btnSubmitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitV.Location = new System.Drawing.Point(644, 540);
            this.btnSubmitV.Name = "btnSubmitV";
            this.btnSubmitV.Size = new System.Drawing.Size(89, 31);
            this.btnSubmitV.TabIndex = 23;
            this.btnSubmitV.Text = "Submit";
            this.btnSubmitV.UseVisualStyleBackColor = true;
            this.btnSubmitV.Click += new System.EventHandler(this.btnSubmitV_Click);
            // 
            // btnExitV
            // 
            this.btnExitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExitV.Location = new System.Drawing.Point(30, 540);
            this.btnExitV.Name = "btnExitV";
            this.btnExitV.Size = new System.Drawing.Size(95, 31);
            this.btnExitV.TabIndex = 24;
            this.btnExitV.Text = "Cancel";
            this.btnExitV.UseVisualStyleBackColor = true;
            this.btnExitV.Click += new System.EventHandler(this.btnExitV_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Location = new System.Drawing.Point(320, 540);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 29);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 611);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.lblADate);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExitV);
            this.Controls.Add(this.btnSubmitV);
            this.Controls.Add(this.lblHeadingEdit);
            this.Controls.Add(this.bookingView);
            this.Name = "EditBookingForm";
            this.Text = "EditBookingForm";
            this.Load += new System.EventHandler(this.EditBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookingView;
        private System.Windows.Forms.Label lblHeadingEdit;
        private System.Windows.Forms.Button btnSubmitV;
        private System.Windows.Forms.Button btnExitV;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.Label lblADate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
    }
}