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
            this.bookingListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupancyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTablesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.reportsToolStripMenuItem});
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
            this.bookingListingToolStripMenuItem});
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
            // bookingListingToolStripMenuItem
            // 
            this.bookingListingToolStripMenuItem.Name = "bookingListingToolStripMenuItem";
            this.bookingListingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookingListingToolStripMenuItem.Text = "Booking Listing";
            this.bookingListingToolStripMenuItem.Click += new System.EventHandler(this.bookingListingToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListingToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // customerListingToolStripMenuItem
            // 
            this.customerListingToolStripMenuItem.Name = "customerListingToolStripMenuItem";
            this.customerListingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customerListingToolStripMenuItem.Text = "Customer Listing";
            this.customerListingToolStripMenuItem.Click += new System.EventHandler(this.customerListingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.occupancyReportToolStripMenuItem,
            this.locationReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // occupancyReportToolStripMenuItem
            // 
            this.occupancyReportToolStripMenuItem.Name = "occupancyReportToolStripMenuItem";
            this.occupancyReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.occupancyReportToolStripMenuItem.Text = "Occupancy Report";
            this.occupancyReportToolStripMenuItem.Click += new System.EventHandler(this.occupancyReportToolStripMenuItem_Click);
            // 
            // locationReportToolStripMenuItem
            // 
            this.locationReportToolStripMenuItem.Name = "locationReportToolStripMenuItem";
            this.locationReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locationReportToolStripMenuItem.Text = "Location Report";
            this.locationReportToolStripMenuItem.Click += new System.EventHandler(this.locationReportToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem checkAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupancyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationReportToolStripMenuItem;
    }
}



