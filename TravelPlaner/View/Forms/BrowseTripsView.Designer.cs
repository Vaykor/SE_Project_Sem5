namespace TravelPlaner.View.Forms
{
    partial class BrowseTripsView
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
            label1 = new Label();
            listView1 = new ListView();
            idTrip = new ColumnHeader();
            Trip_name = new ColumnHeader();
            Date_of_start = new ColumnHeader();
            Date_of_end = new ColumnHeader();
            Number_of_segments = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 60);
            label1.TabIndex = 0;
            label1.Text = "Browse Trips";
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.TwoClick;
            listView1.Columns.AddRange(new ColumnHeader[] { idTrip, Trip_name, Date_of_start, Date_of_end, Number_of_segments });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(1138, 627);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // idTrip
            // 
            idTrip.Width = 0;
            // 
            // Trip_name
            // 
            Trip_name.Text = "Trip Name";
            Trip_name.Width = 400;
            // 
            // Date_of_start
            // 
            Date_of_start.Text = "Date of start";
            Date_of_start.Width = 150;
            // 
            // Date_of_end
            // 
            Date_of_end.Text = "Date of end";
            Date_of_end.Width = 150;
            // 
            // Number_of_segments
            // 
            Number_of_segments.Text = "Number of segments";
            Number_of_segments.Width = 160;
            // 
            // BrowseTripsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 735);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "BrowseTripsView";
            Text = "Browse Trips";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Trip_name;
        private ColumnHeader Date_of_start;
        private ColumnHeader Date_of_end;
        private ColumnHeader Number_of_segments;
        private ColumnHeader idTrip;
    }
}