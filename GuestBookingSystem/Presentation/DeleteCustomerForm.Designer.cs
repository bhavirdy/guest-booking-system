namespace GuestBookingSystem.Presentation
{
    partial class DeleteCustomerForm
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
            this.lblHeadingEditC = new System.Windows.Forms.Label();
            this.btnSubmitEditC = new System.Windows.Forms.Button();
            this.btnClearEditC = new System.Windows.Forms.Button();
            this.btnCancelEditC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(839, 313);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblHeadingEditC
            // 
            this.lblHeadingEditC.AutoSize = true;
            this.lblHeadingEditC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblHeadingEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeadingEditC.Location = new System.Drawing.Point(18, 11);
            this.lblHeadingEditC.Name = "lblHeadingEditC";
            this.lblHeadingEditC.Size = new System.Drawing.Size(448, 54);
            this.lblHeadingEditC.TabIndex = 3;
            this.lblHeadingEditC.Text = "Delete a Customer";
            // 
            // btnSubmitEditC
            // 
            this.btnSubmitEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitEditC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSubmitEditC.Location = new System.Drawing.Point(762, 451);
            this.btnSubmitEditC.Name = "btnSubmitEditC";
            this.btnSubmitEditC.Size = new System.Drawing.Size(102, 30);
            this.btnSubmitEditC.TabIndex = 13;
            this.btnSubmitEditC.Text = "Submit";
            this.btnSubmitEditC.UseVisualStyleBackColor = true;
            // 
            // btnClearEditC
            // 
            this.btnClearEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClearEditC.Location = new System.Drawing.Point(433, 451);
            this.btnClearEditC.Name = "btnClearEditC";
            this.btnClearEditC.Size = new System.Drawing.Size(85, 29);
            this.btnClearEditC.TabIndex = 12;
            this.btnClearEditC.Text = "Clear";
            this.btnClearEditC.UseVisualStyleBackColor = true;
            // 
            // btnCancelEditC
            // 
            this.btnCancelEditC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelEditC.Location = new System.Drawing.Point(40, 451);
            this.btnCancelEditC.Name = "btnCancelEditC";
            this.btnCancelEditC.Size = new System.Drawing.Size(90, 30);
            this.btnCancelEditC.TabIndex = 11;
            this.btnCancelEditC.Text = "Cancel";
            this.btnCancelEditC.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnSubmitEditC);
            this.Controls.Add(this.btnClearEditC);
            this.Controls.Add(this.btnCancelEditC);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblHeadingEditC);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblHeadingEditC;
        private System.Windows.Forms.Button btnSubmitEditC;
        private System.Windows.Forms.Button btnClearEditC;
        private System.Windows.Forms.Button btnCancelEditC;
    }
}