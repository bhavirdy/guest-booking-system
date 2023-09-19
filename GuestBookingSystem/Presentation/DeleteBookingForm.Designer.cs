namespace GuestBookingSystem.Presentation
{
    partial class DeleteBookingForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExitV = new System.Windows.Forms.Button();
            this.btnSubmitV = new System.Windows.Forms.Button();
            this.lblHeadingEdit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Location = new System.Drawing.Point(327, 543);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 29);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExitV
            // 
            this.btnExitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExitV.Location = new System.Drawing.Point(37, 543);
            this.btnExitV.Name = "btnExitV";
            this.btnExitV.Size = new System.Drawing.Size(95, 31);
            this.btnExitV.TabIndex = 37;
            this.btnExitV.Text = "Cancel";
            this.btnExitV.UseVisualStyleBackColor = true;
            // 
            // btnSubmitV
            // 
            this.btnSubmitV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitV.Location = new System.Drawing.Point(651, 543);
            this.btnSubmitV.Name = "btnSubmitV";
            this.btnSubmitV.Size = new System.Drawing.Size(89, 31);
            this.btnSubmitV.TabIndex = 36;
            this.btnSubmitV.Text = "Submit";
            this.btnSubmitV.UseVisualStyleBackColor = true;
            // 
            // lblHeadingEdit
            // 
            this.lblHeadingEdit.AutoSize = true;
            this.lblHeadingEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeadingEdit.Location = new System.Drawing.Point(46, 9);
            this.lblHeadingEdit.Name = "lblHeadingEdit";
            this.lblHeadingEdit.Size = new System.Drawing.Size(396, 54);
            this.lblHeadingEdit.TabIndex = 27;
            this.lblHeadingEdit.Text = "Delete Bookings";
            this.lblHeadingEdit.Click += new System.EventHandler(this.lblHeadingEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 264);
            this.dataGridView1.TabIndex = 40;
            // 
            // DeleteBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExitV);
            this.Controls.Add(this.btnSubmitV);
            this.Controls.Add(this.lblHeadingEdit);
            this.Name = "DeleteBookingForm";
            this.Text = "DeleteBookingForm";
            this.Load += new System.EventHandler(this.DeleteBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExitV;
        private System.Windows.Forms.Button btnSubmitV;
        private System.Windows.Forms.Label lblHeadingEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}