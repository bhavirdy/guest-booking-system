namespace GuestBookingSystem.Presentation
{
    partial class OccupancyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateArrival = new System.Windows.Forms.DateTimePicker();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeading.Location = new System.Drawing.Point(114, 21);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(219, 44);
            this.lblHeading.TabIndex = 33;
            this.lblHeading.Text = "Occupancy ";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuestBookingSystem.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // dateArrival
            // 
            this.dateArrival.Location = new System.Drawing.Point(157, 119);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(200, 20);
            this.dateArrival.TabIndex = 46;
            // 
            // dateDeparture
            // 
            this.dateDeparture.Location = new System.Drawing.Point(157, 169);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateDeparture.TabIndex = 47;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCustID.Location = new System.Drawing.Point(18, 122);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(55, 18);
            this.lblCustID.TabIndex = 48;
            this.lblCustID.Text = "Date 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(19, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date 2:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(221, 218);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total number of bookings:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(516, 444);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 29);
            this.btnGenerate.TabIndex = 52;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(374, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 53;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 541);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.dateDeparture);
            this.Controls.Add(this.dateArrival);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeading);
            this.Name = "OccupancyReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OccupancyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateArrival;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}