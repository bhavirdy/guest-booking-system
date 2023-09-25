namespace GuestBookingSystem.Presentation
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteACustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.createACustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTablesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // viewTablesToolStripMenuItem
            // 
            this.viewTablesToolStripMenuItem.Name = "viewTablesToolStripMenuItem";
            this.viewTablesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.viewTablesToolStripMenuItem.Text = "View Tables";
            this.viewTablesToolStripMenuItem.Click += new System.EventHandler(this.viewTablesToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAvailabilityToolStripMenuItem,
            this.viewBookingsToolStripMenuItem,
            this.deleteABookingToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // checkAvailabilityToolStripMenuItem
            // 
            this.checkAvailabilityToolStripMenuItem.Name = "checkAvailabilityToolStripMenuItem";
            this.checkAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.checkAvailabilityToolStripMenuItem.Text = "Check Availability";
            this.checkAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.checkAvailabilityToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewBookingsToolStripMenuItem.Text = "Edit a Booking";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.editBookingsToolStripMenuItem_Click);
            // 
            // deleteABookingToolStripMenuItem
            // 
            this.deleteABookingToolStripMenuItem.Name = "deleteABookingToolStripMenuItem";
            this.deleteABookingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteABookingToolStripMenuItem.Text = "Delete a Booking";
            this.deleteABookingToolStripMenuItem.Click += new System.EventHandler(this.deleteABookingToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomersToolStripMenuItem,
            this.deleteACustomerToolStripMenuItem,
            this.createACustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // editCustomersToolStripMenuItem
            // 
            this.editCustomersToolStripMenuItem.Name = "editCustomersToolStripMenuItem";
            this.editCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCustomersToolStripMenuItem.Text = "Edit a Customer";
            this.editCustomersToolStripMenuItem.Click += new System.EventHandler(this.editCustomersToolStripMenuItem_Click);
            // 
            // deleteACustomerToolStripMenuItem
            // 
            this.deleteACustomerToolStripMenuItem.Name = "deleteACustomerToolStripMenuItem";
            this.deleteACustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteACustomerToolStripMenuItem.Text = "Delete a Customer";
            this.deleteACustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteACustomerToolStripMenuItem_Click);
            // 
            // createACustomerToolStripMenuItem
            // 
            this.createACustomerToolStripMenuItem.Name = "createACustomerToolStripMenuItem";
            this.createACustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createACustomerToolStripMenuItem.Text = "Create a customer";
            this.createACustomerToolStripMenuItem.Click += new System.EventHandler(this.createACustomerToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteACustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createACustomerToolStripMenuItem;
    }
}



