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
            panel1 = new Panel();
            memoryListView = new ListView();
            MemoryID = new ColumnHeader();
            MemoryName = new ColumnHeader();
            MemoryNote = new ColumnHeader();
            MemorySongURL = new ColumnHeader();
            destinationListView = new ListView();
            DestiantionID = new ColumnHeader();
            DestinationCountry = new ColumnHeader();
            DestinationCity = new ColumnHeader();
            expenseListView = new ListView();
            ExpenseID = new ColumnHeader();
            ExpenseName = new ColumnHeader();
            ExpeneseValue = new ColumnHeader();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(memoryListView);
            panel1.Controls.Add(destinationListView);
            panel1.Controls.Add(expenseListView);
            panel1.Location = new Point(281, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 688);
            panel1.TabIndex = 3;
            // 
            // memoryListView
            // 
            memoryListView.Columns.AddRange(new ColumnHeader[] { MemoryID, MemoryName, MemoryNote, MemorySongURL });
            memoryListView.Location = new Point(466, 43);
            memoryListView.Name = "memoryListView";
            memoryListView.Size = new Size(324, 642);
            memoryListView.TabIndex = 2;
            memoryListView.UseCompatibleStateImageBehavior = false;
            memoryListView.View = System.Windows.Forms.View.Details;
            // 
            // MemoryID
            // 
            MemoryID.Text = "ID";
            MemoryID.Width = 0;
            // 
            // MemoryName
            // 
            MemoryName.Text = "Name";
            MemoryName.Width = 100;
            // 
            // MemoryNote
            // 
            MemoryNote.Text = "Note";
            MemoryNote.Width = 120;
            // 
            // MemorySongURL
            // 
            MemorySongURL.Text = "Song URL";
            MemorySongURL.Width = 100;
            // 
            // destinationListView
            // 
            destinationListView.Columns.AddRange(new ColumnHeader[] { DestiantionID, DestinationCountry, DestinationCity });
            destinationListView.Location = new Point(239, 43);
            destinationListView.Name = "destinationListView";
            destinationListView.Size = new Size(201, 645);
            destinationListView.TabIndex = 1;
            destinationListView.UseCompatibleStateImageBehavior = false;
            destinationListView.View = System.Windows.Forms.View.Details;
            // 
            // DestiantionID
            // 
            DestiantionID.Text = "ID";
            DestiantionID.Width = 0;
            // 
            // DestinationCountry
            // 
            DestinationCountry.Text = "Country";
            DestinationCountry.Width = 100;
            // 
            // DestinationCity
            // 
            DestinationCity.Text = "City";
            DestinationCity.Width = 100;
            // 
            // expenseListView
            // 
            expenseListView.Columns.AddRange(new ColumnHeader[] { ExpenseID, ExpenseName, ExpeneseValue });
            expenseListView.Location = new Point(3, 43);
            expenseListView.Name = "expenseListView";
            expenseListView.Size = new Size(204, 642);
            expenseListView.TabIndex = 0;
            expenseListView.UseCompatibleStateImageBehavior = false;
            expenseListView.View = System.Windows.Forms.View.Details;
            // 
            // ExpenseID
            // 
            ExpenseID.Text = "ID";
            ExpenseID.Width = 0;
            // 
            // ExpenseName
            // 
            ExpenseName.Text = "Name";
            ExpenseName.Width = 100;
            // 
            // ExpeneseValue
            // 
            ExpeneseValue.Text = "Value";
            ExpeneseValue.Width = 100;
            // 
            // BrowseTripSegmentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 782);
            Controls.Add(panel1);
            Controls.Add(DateLabel);
            Controls.Add(TripNameLabel);
            Controls.Add(segmentListView);
            Name = "BrowseTripSegmentsView";
            Text = "BrowseTripSegmentsView";
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private ListView expenseListView;
        private ColumnHeader ExpenseID;
        private ColumnHeader ExpenseName;
        private ColumnHeader ExpeneseValue;
        private ListView destinationListView;
        private ColumnHeader DestiantionID;
        private ColumnHeader DestinationCountry;
        private ColumnHeader DestinationCity;
        private ListView memoryListView;
        private ColumnHeader MemoryID;
        private ColumnHeader MemoryName;
        private ColumnHeader MemoryNote;
        private ColumnHeader MemorySongURL;
    }
}