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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblHeadingEdit = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.lblADate = new System.Windows.Forms.Label();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitV = new System.Windows.Forms.Button();
            this.btnExitV = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(197, 476);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(271, 22);
            this.txtRoomNum.TabIndex = 22;
            this.txtRoomNum.TextChanged += new System.EventHandler(this.txtRoomNum_TextChanged);
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRoomNum.Location = new System.Drawing.Point(26, 477);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(137, 21);
            this.lblRoomNum.TabIndex = 21;
            this.lblRoomNum.Text = "Room Number";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(197, 368);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(271, 22);
            this.txtCustID.TabIndex = 20;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustID.Location = new System.Drawing.Point(26, 367);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(120, 21);
            this.lblCustID.TabIndex = 19;
            this.lblCustID.Text = "Customer ID";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(197, 440);
            this.dateTimePickerDepartureDate.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerDepartureDate.TabIndex = 18;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLeaveDate.Location = new System.Drawing.Point(26, 440);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(146, 21);
            this.lblLeaveDate.TabIndex = 17;
            this.lblLeaveDate.Text = "Departure Date";
            // 
            // lblADate
            // 
            this.lblADate.AutoSize = true;
            this.lblADate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblADate.Location = new System.Drawing.Point(26, 403);
            this.lblADate.Name = "lblADate";
            this.lblADate.Size = new System.Drawing.Size(116, 21);
            this.lblADate.TabIndex = 16;
            this.lblADate.Text = "Arrival Date";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(197, 402);
            this.dateTimePickerArrival.MinDate = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(271, 22);
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
            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 594);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExitV);
            this.Controls.Add(this.btnSubmitV);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.lblADate);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Controls.Add(this.lblHeadingEdit);
            this.Controls.Add(this.listView1);
            this.Name = "EditBookingForm";
            this.Text = "EditBookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblHeadingEdit;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.Label lblADate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.Button btnSubmitV;
        private System.Windows.Forms.Button btnExitV;
        private System.Windows.Forms.Button btnClear;
    }
}