namespace TravelPlaner.View.Forms
{
    partial class RecommendedLandmarks
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
            TouristLandmarkListView = new ListView();
            NameColumn = new ColumnHeader();
            CountryColumn = new ColumnHeader();
            CityColumn = new ColumnHeader();
            StreetColumn = new ColumnHeader();
            PhoneColumn = new ColumnHeader();
            closeRecommends = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TouristLandmarkListView
            // 
            TouristLandmarkListView.Columns.AddRange(new ColumnHeader[] { NameColumn, CountryColumn, CityColumn, StreetColumn, PhoneColumn });
            TouristLandmarkListView.Dock = DockStyle.Top;
            TouristLandmarkListView.Location = new Point(0, 0);
            TouristLandmarkListView.Margin = new Padding(3, 4, 3, 4);
            TouristLandmarkListView.Name = "TouristLandmarkListView";
            TouristLandmarkListView.Size = new Size(899, 432);
            TouristLandmarkListView.TabIndex = 10;
            TouristLandmarkListView.UseCompatibleStateImageBehavior = false;
            TouristLandmarkListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 220;
            // 
            // CountryColumn
            // 
            CountryColumn.Text = "Country";
            CountryColumn.Width = 160;
            // 
            // CityColumn
            // 
            CityColumn.Text = "City";
            CityColumn.Width = 160;
            // 
            // StreetColumn
            // 
            StreetColumn.Text = "Street";
            StreetColumn.Width = 180;
            // 
            // PhoneColumn
            // 
            PhoneColumn.Text = "Phone";
            PhoneColumn.Width = 170;
            // 
            // closeRecommends
            // 
            closeRecommends.DialogResult = DialogResult.Cancel;
            closeRecommends.Location = new Point(793, 443);
            closeRecommends.Name = "closeRecommends";
            closeRecommends.Size = new Size(94, 29);
            closeRecommends.TabIndex = 11;
            closeRecommends.Text = "Cancel";
            closeRecommends.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 443);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 12;
            label1.Text = "Test";
            // 
            // RecommendedLandmarks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 477);
            Controls.Add(label1);
            Controls.Add(closeRecommends);
            Controls.Add(TouristLandmarkListView);
            Name = "RecommendedLandmarks";
            Text = "Recommended Landmarks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView TouristLandmarkListView;
        private ColumnHeader NameColumn;
        private ColumnHeader CountryColumn;
        private ColumnHeader CityColumn;
        private ColumnHeader StreetColumn;
        private ColumnHeader PhoneColumn;
        private Button closeRecommends;
        private Label label1;
    }
}