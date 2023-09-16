namespace GuestBookingSystem.Presentation
{
    partial class EditCustomersForm
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
            this.lblHeadingEditC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.btnCancelEditC = new System.Windows.Forms.Button();
            this.btnClearEditC = new System.Windows.Forms.Button();
            this.btnSubmitEditC = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtStreetA = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeadingEditC
            // 
            this.lblHeadingEditC.AutoSize = true;
            this.lblHeadingEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeadingEditC.Location = new System.Drawing.Point(27, 21);
            this.lblHeadingEditC.Name = "lblHeadingEditC";
            this.lblHeadingEditC.Size = new System.Drawing.Size(389, 54);
            this.lblHeadingEditC.TabIndex = 0;
            this.lblHeadingEditC.Text = "Edit a Customer";
            this.lblHeadingEditC.Click += new System.EventHandler(this.lblHeadingEditC_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(32, 304);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(839, 180);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSurname.Location = new System.Drawing.Point(32, 335);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(90, 21);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(32, 368);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmail.Location = new System.Drawing.Point(32, 403);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountry.Location = new System.Drawing.Point(32, 640);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 21);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCardNum.Location = new System.Drawing.Point(32, 447);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(129, 21);
            this.lblCardNum.TabIndex = 7;
            this.lblCardNum.Text = "Card Number";
            // 
            // btnCancelEditC
            // 
            this.btnCancelEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelEditC.Location = new System.Drawing.Point(36, 711);
            this.btnCancelEditC.Name = "btnCancelEditC";
            this.btnCancelEditC.Size = new System.Drawing.Size(90, 30);
            this.btnCancelEditC.TabIndex = 8;
            this.btnCancelEditC.Text = "Cancel";
            this.btnCancelEditC.UseVisualStyleBackColor = true;
            // 
            // btnClearEditC
            // 
            this.btnClearEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClearEditC.Location = new System.Drawing.Point(429, 711);
            this.btnClearEditC.Name = "btnClearEditC";
            this.btnClearEditC.Size = new System.Drawing.Size(85, 29);
            this.btnClearEditC.TabIndex = 9;
            this.btnClearEditC.Text = "Clear";
            this.btnClearEditC.UseVisualStyleBackColor = true;
            // 
            // btnSubmitEditC
            // 
            this.btnSubmitEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitEditC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSubmitEditC.Location = new System.Drawing.Point(758, 711);
            this.btnSubmitEditC.Name = "btnSubmitEditC";
            this.btnSubmitEditC.Size = new System.Drawing.Size(102, 30);
            this.btnSubmitEditC.TabIndex = 10;
            this.btnSubmitEditC.Text = "Submit";
            this.btnSubmitEditC.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 303);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(238, 332);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(229, 22);
            this.txtSurname.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(238, 361);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(229, 22);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(238, 403);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(238, 639);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(229, 22);
            this.txtCountry.TabIndex = 15;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(238, 446);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(229, 22);
            this.txtCardNumber.TabIndex = 16;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStreetAddress.Location = new System.Drawing.Point(32, 498);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(138, 21);
            this.lblStreetAddress.TabIndex = 17;
            this.lblStreetAddress.Text = "StreetAddress";
            // 
            // txtStreetA
            // 
            this.txtStreetA.Location = new System.Drawing.Point(238, 497);
            this.txtStreetA.Name = "txtStreetA";
            this.txtStreetA.Size = new System.Drawing.Size(229, 22);
            this.txtStreetA.TabIndex = 18;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSuburb.Location = new System.Drawing.Point(32, 540);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(74, 21);
            this.lblSuburb.TabIndex = 19;
            this.lblSuburb.Text = "Suburb";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(238, 539);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(229, 22);
            this.txtSuburb.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCity.Location = new System.Drawing.Point(32, 577);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 21);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(32, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "PostalCode";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(238, 576);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(229, 22);
            this.txtCity.TabIndex = 23;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(238, 611);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(229, 22);
            this.txtPostalCode.TabIndex = 24;
            // 
            // EditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 763);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtStreetA);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSubmitEditC);
            this.Controls.Add(this.btnClearEditC);
            this.Controls.Add(this.btnCancelEditC);
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeadingEditC);
            this.Name = "EditCustomersForm";
            this.Text = "ViewCustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingEditC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button btnCancelEditC;
        private System.Windows.Forms.Button btnClearEditC;
        private System.Windows.Forms.Button btnSubmitEditC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtStreetA;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
    }
}