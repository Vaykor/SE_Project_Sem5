namespace TravelPlaner.View.Forms
{
    partial class TouristLandmarkTestForm
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
            button = new Button();
            APITestBox = new TextBox();
            TouristLandmarkListView = new ListView();
            NameColumn = new ColumnHeader();
            CountryColumn = new ColumnHeader();
            CityColumn = new ColumnHeader();
            StreetColumn = new ColumnHeader();
            PhoneColumn = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(739, 85);
            button.Margin = new Padding(2);
            button.Name = "button";
            button.Size = new Size(128, 52);
            button.TabIndex = 8;
            button.Text = "Click me:)";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // APITestBox
            // 
            APITestBox.Location = new Point(258, 101);
            APITestBox.Margin = new Padding(3, 2, 3, 2);
            APITestBox.Name = "APITestBox";
            APITestBox.Size = new Size(475, 23);
            APITestBox.TabIndex = 9;
            APITestBox.TextChanged += textBox1_TextChanged;
            // 
            // TouristLandmarkListView
            // 
            TouristLandmarkListView.Columns.AddRange(new ColumnHeader[] { NameColumn, CountryColumn, CityColumn, StreetColumn, PhoneColumn });
            TouristLandmarkListView.Location = new Point(208, 142);
            TouristLandmarkListView.Name = "TouristLandmarkListView";
            TouristLandmarkListView.Size = new Size(659, 208);
            TouristLandmarkListView.TabIndex = 10;
            TouristLandmarkListView.UseCompatibleStateImageBehavior = false;
            TouristLandmarkListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 120;
            // 
            // CountryColumn
            // 
            CountryColumn.Text = "Country";
            CountryColumn.Width = 100;
            // 
            // CityColumn
            // 
            CityColumn.Text = "City";
            CityColumn.Width = 100;
            // 
            // StreetColumn
            // 
            StreetColumn.Text = "Street";
            StreetColumn.Width = 180;
            // 
            // PhoneColumn
            // 
            PhoneColumn.Text = "Phone";
            PhoneColumn.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(208, 50);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 11;
            label1.Text = "Tourist landmark test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(208, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 12;
            label2.Text = "City: ";
            // 
            // TouristLandmarkTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 528);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TouristLandmarkListView);
            Controls.Add(APITestBox);
            Controls.Add(button);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TouristLandmarkTestForm";
            Text = "TouristLandmarkTestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button;
        private TextBox APITestBox;
        private ListView TouristLandmarkListView;
        private ColumnHeader NameColumn;
        private ColumnHeader CountryColumn;
        private ColumnHeader CityColumn;
        private ColumnHeader StreetColumn;
        private ColumnHeader PhoneColumn;
        private Label label1;
        private Label label2;
    }
}