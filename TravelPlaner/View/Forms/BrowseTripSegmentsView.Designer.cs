namespace TravelPlaner.View.Forms
{
    partial class BrowseTripSegmentsView
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
            segmentListView = new ListView();
            SegmentID = new ColumnHeader();
            SegmentName = new ColumnHeader();
            TripNameLabel = new Label();
            DateLabel = new Label();
            segmentDetails1 = new SegmentDetails();
            SuspendLayout();
            // 
            // segmentListView
            // 
            segmentListView.Activation = ItemActivation.TwoClick;
            segmentListView.Columns.AddRange(new ColumnHeader[] { SegmentID, SegmentName });
            segmentListView.FullRowSelect = true;
            segmentListView.Location = new Point(12, 82);
            segmentListView.Name = "segmentListView";
            segmentListView.Size = new Size(236, 688);
            segmentListView.TabIndex = 0;
            segmentListView.UseCompatibleStateImageBehavior = false;
            segmentListView.View = System.Windows.Forms.View.Details;
            // 
            // SegmentID
            // 
            SegmentID.Width = 0;
            // 
            // SegmentName
            // 
            SegmentName.Text = "Segment name";
            SegmentName.Width = 120;
            // 
            // TripNameLabel
            // 
            TripNameLabel.AutoSize = true;
            TripNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TripNameLabel.Location = new Point(12, 9);
            TripNameLabel.Name = "TripNameLabel";
            TripNameLabel.Size = new Size(134, 37);
            TripNameLabel.TabIndex = 1;
            TripNameLabel.Text = "Trip name";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(22, 59);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(41, 20);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Date";
            // 
            // segmentDetails1
            // 
            segmentDetails1.Location = new Point(282, 82);
            segmentDetails1.Name = "segmentDetails1";
            segmentDetails1.Size = new Size(886, 688);
            segmentDetails1.TabIndex = 3;
            // 
            // BrowseTripSegmentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 782);
            Controls.Add(segmentDetails1);
            Controls.Add(DateLabel);
            Controls.Add(TripNameLabel);
            Controls.Add(segmentListView);
            Name = "BrowseTripSegmentsView";
            Text = "BrowseTripSegmentsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView segmentListView;
        private Label TripNameLabel;
        private Label DateLabel;
        private ColumnHeader SegmentID;
        private ColumnHeader SegmentName;
        private SegmentDetails segmentDetails1;
    }
}