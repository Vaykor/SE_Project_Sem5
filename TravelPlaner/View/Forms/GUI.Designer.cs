namespace TravelPlaner.View.Forms
{
    partial class GUI
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
            menuPanel = new Panel();
            pictureBox1 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            titleLabel = new Label();
            settingsButton = new Button();
            browseTripsButton = new Button();
            newTripButton = new Button();
            newTripPanel = new Panel();
            returnFromAddButton = new Button();
            browseTripPanel = new Panel();
            tripListPanel = new Panel();
            browseLabel = new Label();
            searchTextBox = new TextBox();
            returnFromBrowseButton = new Button();
            inspectTripPanel = new Panel();
            tripInfoPanel = new Panel();
            button1 = new Button();
            returnFromInspectButton = new Button();
            nameLabel = new Label();
            tripNameTextBox = new TextBox();
            depDateLabel = new Label();
            returnDateLabel = new Label();
            DepDateTextBox = new TextBox();
            returnDateTextBox = new TextBox();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            newTripPanel.SuspendLayout();
            browseTripPanel.SuspendLayout();
            inspectTripPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(255, 192, 192);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(monthCalendar1);
            menuPanel.Controls.Add(titleLabel);
            menuPanel.Controls.Add(settingsButton);
            menuPanel.Controls.Add(browseTripsButton);
            menuPanel.Controls.Add(newTripButton);
            menuPanel.Location = new Point(12, 56);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(559, 480);
            menuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 207);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(220, 113);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(186, 33);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(101, 20);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Travel Planner";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(279, 409);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(117, 29);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // browseTripsButton
            // 
            browseTripsButton.Location = new Point(159, 409);
            browseTripsButton.Name = "browseTripsButton";
            browseTripsButton.Size = new Size(114, 29);
            browseTripsButton.TabIndex = 2;
            browseTripsButton.Text = "Browse trips";
            browseTripsButton.UseVisualStyleBackColor = true;
            browseTripsButton.Click += browseTripsButton_Click;
            // 
            // newTripButton
            // 
            newTripButton.Location = new Point(34, 409);
            newTripButton.Name = "newTripButton";
            newTripButton.Size = new Size(119, 29);
            newTripButton.TabIndex = 1;
            newTripButton.Text = "Add new trip";
            newTripButton.UseVisualStyleBackColor = true;
            newTripButton.Click += newTripButton_Click;
            // 
            // newTripPanel
            // 
            newTripPanel.BackColor = SystemColors.ActiveCaption;
            newTripPanel.Controls.Add(returnDateTextBox);
            newTripPanel.Controls.Add(DepDateTextBox);
            newTripPanel.Controls.Add(returnDateLabel);
            newTripPanel.Controls.Add(depDateLabel);
            newTripPanel.Controls.Add(tripNameTextBox);
            newTripPanel.Controls.Add(nameLabel);
            newTripPanel.Controls.Add(returnFromAddButton);
            newTripPanel.Location = new Point(593, 56);
            newTripPanel.Name = "newTripPanel";
            newTripPanel.Size = new Size(566, 480);
            newTripPanel.TabIndex = 0;
            newTripPanel.Visible = false;
            // 
            // returnFromAddButton
            // 
            returnFromAddButton.Location = new Point(1, 1);
            returnFromAddButton.Name = "returnFromAddButton";
            returnFromAddButton.Size = new Size(55, 29);
            returnFromAddButton.TabIndex = 0;
            returnFromAddButton.Text = "◀️";
            returnFromAddButton.UseVisualStyleBackColor = true;
            returnFromAddButton.Click += returnFromAddButton_Click;
            // 
            // browseTripPanel
            // 
            browseTripPanel.BackColor = Color.FromArgb(192, 255, 192);
            browseTripPanel.Controls.Add(tripListPanel);
            browseTripPanel.Controls.Add(browseLabel);
            browseTripPanel.Controls.Add(searchTextBox);
            browseTripPanel.Controls.Add(returnFromBrowseButton);
            browseTripPanel.Location = new Point(1202, 57);
            browseTripPanel.Name = "browseTripPanel";
            browseTripPanel.Size = new Size(606, 479);
            browseTripPanel.TabIndex = 1;
            browseTripPanel.Visible = false;
            // 
            // tripListPanel
            // 
            tripListPanel.AutoScroll = true;
            tripListPanel.Dock = DockStyle.Bottom;
            tripListPanel.Location = new Point(0, 129);
            tripListPanel.Name = "tripListPanel";
            tripListPanel.Size = new Size(606, 350);
            tripListPanel.TabIndex = 4;
            // 
            // browseLabel
            // 
            browseLabel.AutoSize = true;
            browseLabel.Location = new Point(245, 34);
            browseLabel.Name = "browseLabel";
            browseLabel.Size = new Size(109, 20);
            browseLabel.TabIndex = 3;
            browseLabel.Text = "BROWSE TRIPS";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(195, 77);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(207, 27);
            searchTextBox.TabIndex = 2;
            searchTextBox.Text = "search";
            // 
            // returnFromBrowseButton
            // 
            returnFromBrowseButton.Location = new Point(0, 0);
            returnFromBrowseButton.Name = "returnFromBrowseButton";
            returnFromBrowseButton.Size = new Size(55, 29);
            returnFromBrowseButton.TabIndex = 1;
            returnFromBrowseButton.Text = "◀️";
            returnFromBrowseButton.UseVisualStyleBackColor = true;
            returnFromBrowseButton.Click += returnFromBrowseButton_Click;
            // 
            // inspectTripPanel
            // 
            inspectTripPanel.BackColor = Color.FromArgb(255, 255, 192);
            inspectTripPanel.Controls.Add(tripInfoPanel);
            inspectTripPanel.Controls.Add(button1);
            inspectTripPanel.Controls.Add(returnFromInspectButton);
            inspectTripPanel.Location = new Point(15, 570);
            inspectTripPanel.Name = "inspectTripPanel";
            inspectTripPanel.Size = new Size(542, 398);
            inspectTripPanel.TabIndex = 2;
            inspectTripPanel.Visible = false;
            // 
            // tripInfoPanel
            // 
            tripInfoPanel.AutoScroll = true;
            tripInfoPanel.Dock = DockStyle.Bottom;
            tripInfoPanel.Location = new Point(0, 35);
            tripInfoPanel.Name = "tripInfoPanel";
            tripInfoPanel.Size = new Size(542, 363);
            tripInfoPanel.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(56, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // returnFromInspectButton
            // 
            returnFromInspectButton.Location = new Point(0, 0);
            returnFromInspectButton.Name = "returnFromInspectButton";
            returnFromInspectButton.Size = new Size(55, 29);
            returnFromInspectButton.TabIndex = 5;
            returnFromInspectButton.Text = "◀️";
            returnFromInspectButton.UseVisualStyleBackColor = true;
            returnFromInspectButton.Click += returnFromInspectButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "NAME";
            // 
            // tripNameTextBox
            // 
            tripNameTextBox.Location = new Point(63, 50);
            tripNameTextBox.Name = "tripNameTextBox";
            tripNameTextBox.Size = new Size(500, 27);
            tripNameTextBox.TabIndex = 2;
            // 
            // depDateLabel
            // 
            depDateLabel.AutoSize = true;
            depDateLabel.Location = new Point(7, 86);
            depDateLabel.Name = "depDateLabel";
            depDateLabel.Size = new Size(150, 20);
            depDateLabel.TabIndex = 3;
            depDateLabel.Text = "DATE OF DEPARTURE";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new Point(7, 123);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new Size(126, 20);
            returnDateLabel.TabIndex = 4;
            returnDateLabel.Text = "DATE OF RETURN";
            // 
            // DepDateTextBox
            // 
            DepDateTextBox.Location = new Point(163, 83);
            DepDateTextBox.Name = "DepDateTextBox";
            DepDateTextBox.Size = new Size(156, 27);
            DepDateTextBox.TabIndex = 5;
            // 
            // returnDateTextBox
            // 
            returnDateTextBox.Location = new Point(163, 116);
            returnDateTextBox.Name = "returnDateTextBox";
            returnDateTextBox.Size = new Size(156, 27);
            returnDateTextBox.TabIndex = 6;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 980);
            Controls.Add(inspectTripPanel);
            Controls.Add(browseTripPanel);
            Controls.Add(menuPanel);
            Controls.Add(newTripPanel);
            Name = "GUI";
            Text = "Travel Planner";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            newTripPanel.ResumeLayout(false);
            newTripPanel.PerformLayout();
            browseTripPanel.ResumeLayout(false);
            browseTripPanel.PerformLayout();
            inspectTripPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Button newTripButton;
        private Panel newTripPanel;
        private Button settingsButton;
        private Button browseTripsButton;
        private Panel browseTripPanel;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
        private Button returnFromAddButton;
        private Button returnFromBrowseButton;
        private Label browseLabel;
        private TextBox searchTextBox;
        private Panel tripListPanel;
        private Panel inspectTripPanel;
        private Button returnFromInspectButton;
        private Panel tripInfoPanel;
        private Button button1;
        private TextBox returnDateTextBox;
        private TextBox DepDateTextBox;
        private Label returnDateLabel;
        private Label depDateLabel;
        private TextBox tripNameTextBox;
        private Label nameLabel;
    }
}