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
            newTripLabel = new Label();
            addTripFlowLayoutPanel = new FlowLayoutPanel();
            returnDateTextBox = new TextBox();
            DepDateTextBox = new TextBox();
            returnDateLabel = new Label();
            depDateLabel = new Label();
            tripNameTextBox = new TextBox();
            nameLabel = new Label();
            returnFromAddButton = new Button();
            browseTripPanel = new Panel();
            tripListPanel = new Panel();
            browseLabel = new Label();
            searchTextBox = new TextBox();
            returnFromBrowseButton = new Button();
            inspectTripPanel = new Panel();
            returnFromInspectButton = new Button();
            tripDetailsLabel = new Label();
            tripInfoPanel = new Panel();
            editTripButton = new Button();
            editTripPanel = new Panel();
            editTripLabel = new Label();
            editTripFlowLayoutPanel = new FlowLayoutPanel();
            editReturnDateTextBox = new TextBox();
            editDepDateTextBox = new TextBox();
            editReturnDateLabel = new Label();
            editDepDateLabel = new Label();
            editNameTextBox = new TextBox();
            editNameLabel = new Label();
            returnFromEditTrip = new Button();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            newTripPanel.SuspendLayout();
            browseTripPanel.SuspendLayout();
            inspectTripPanel.SuspendLayout();
            editTripPanel.SuspendLayout();
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
            titleLabel.Location = new Point(220, 35);
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
            newTripPanel.Controls.Add(newTripLabel);
            newTripPanel.Controls.Add(addTripFlowLayoutPanel);
            newTripPanel.Controls.Add(returnDateTextBox);
            newTripPanel.Controls.Add(DepDateTextBox);
            newTripPanel.Controls.Add(returnDateLabel);
            newTripPanel.Controls.Add(depDateLabel);
            newTripPanel.Controls.Add(tripNameTextBox);
            newTripPanel.Controls.Add(nameLabel);
            newTripPanel.Controls.Add(returnFromAddButton);
            newTripPanel.Location = new Point(593, 56);
            newTripPanel.Name = "newTripPanel";
            newTripPanel.Size = new Size(593, 480);
            newTripPanel.TabIndex = 0;
            newTripPanel.Visible = false;
            // 
            // newTripLabel
            // 
            newTripLabel.AutoSize = true;
            newTripLabel.Location = new Point(246, 27);
            newTripLabel.Name = "newTripLabel";
            newTripLabel.Size = new Size(111, 20);
            newTripLabel.TabIndex = 8;
            newTripLabel.Text = "ADD NEW TRIP";
            // 
            // addTripFlowLayoutPanel
            // 
            addTripFlowLayoutPanel.AutoScroll = true;
            addTripFlowLayoutPanel.Dock = DockStyle.Bottom;
            addTripFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            addTripFlowLayoutPanel.Location = new Point(0, 171);
            addTripFlowLayoutPanel.Name = "addTripFlowLayoutPanel";
            addTripFlowLayoutPanel.Size = new Size(593, 309);
            addTripFlowLayoutPanel.TabIndex = 7;
            addTripFlowLayoutPanel.WrapContents = false;
            // 
            // returnDateTextBox
            // 
            returnDateTextBox.Location = new Point(163, 116);
            returnDateTextBox.Name = "returnDateTextBox";
            returnDateTextBox.Size = new Size(156, 27);
            returnDateTextBox.TabIndex = 6;
            // 
            // DepDateTextBox
            // 
            DepDateTextBox.Location = new Point(163, 83);
            DepDateTextBox.Name = "DepDateTextBox";
            DepDateTextBox.Size = new Size(156, 27);
            DepDateTextBox.TabIndex = 5;
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
            // depDateLabel
            // 
            depDateLabel.AutoSize = true;
            depDateLabel.Location = new Point(7, 86);
            depDateLabel.Name = "depDateLabel";
            depDateLabel.Size = new Size(150, 20);
            depDateLabel.TabIndex = 3;
            depDateLabel.Text = "DATE OF DEPARTURE";
            // 
            // tripNameTextBox
            // 
            tripNameTextBox.Location = new Point(63, 50);
            tripNameTextBox.Name = "tripNameTextBox";
            tripNameTextBox.Size = new Size(500, 27);
            tripNameTextBox.TabIndex = 2;
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
            inspectTripPanel.Controls.Add(returnFromInspectButton);
            inspectTripPanel.Controls.Add(tripDetailsLabel);
            inspectTripPanel.Controls.Add(tripInfoPanel);
            inspectTripPanel.Controls.Add(editTripButton);
            inspectTripPanel.Location = new Point(15, 570);
            inspectTripPanel.Name = "inspectTripPanel";
            inspectTripPanel.Size = new Size(542, 398);
            inspectTripPanel.TabIndex = 2;
            inspectTripPanel.Visible = false;
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
            // tripDetailsLabel
            // 
            tripDetailsLabel.AutoSize = true;
            tripDetailsLabel.Location = new Point(200, 9);
            tripDetailsLabel.Name = "tripDetailsLabel";
            tripDetailsLabel.Size = new Size(97, 20);
            tripDetailsLabel.TabIndex = 8;
            tripDetailsLabel.Text = "TRIP DETAILS";
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
            // editTripButton
            // 
            editTripButton.Location = new Point(56, 0);
            editTripButton.Name = "editTripButton";
            editTripButton.Size = new Size(94, 29);
            editTripButton.TabIndex = 6;
            editTripButton.Text = "EDIT";
            editTripButton.UseVisualStyleBackColor = true;
            editTripButton.Click += editTripButton_Click;
            // 
            // editTripPanel
            // 
            editTripPanel.BackColor = SystemColors.ActiveCaption;
            editTripPanel.Controls.Add(editTripLabel);
            editTripPanel.Controls.Add(editTripFlowLayoutPanel);
            editTripPanel.Controls.Add(editReturnDateTextBox);
            editTripPanel.Controls.Add(editDepDateTextBox);
            editTripPanel.Controls.Add(editReturnDateLabel);
            editTripPanel.Controls.Add(editDepDateLabel);
            editTripPanel.Controls.Add(editNameTextBox);
            editTripPanel.Controls.Add(editNameLabel);
            editTripPanel.Controls.Add(returnFromEditTrip);
            editTripPanel.Location = new Point(593, 570);
            editTripPanel.Name = "editTripPanel";
            editTripPanel.Size = new Size(587, 400);
            editTripPanel.TabIndex = 9;
            editTripPanel.Visible = false;
            // 
            // editTripLabel
            // 
            editTripLabel.AutoSize = true;
            editTripLabel.Location = new Point(246, 27);
            editTripLabel.Name = "editTripLabel";
            editTripLabel.Size = new Size(73, 20);
            editTripLabel.TabIndex = 8;
            editTripLabel.Text = "EDIT TRIP";
            // 
            // editTripFlowLayoutPanel
            // 
            editTripFlowLayoutPanel.AutoScroll = true;
            editTripFlowLayoutPanel.Dock = DockStyle.Bottom;
            editTripFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            editTripFlowLayoutPanel.Location = new Point(0, 150);
            editTripFlowLayoutPanel.Name = "editTripFlowLayoutPanel";
            editTripFlowLayoutPanel.Size = new Size(587, 250);
            editTripFlowLayoutPanel.TabIndex = 7;
            editTripFlowLayoutPanel.WrapContents = false;
            // 
            // editReturnDateTextBox
            // 
            editReturnDateTextBox.Location = new Point(163, 116);
            editReturnDateTextBox.Name = "editReturnDateTextBox";
            editReturnDateTextBox.Size = new Size(156, 27);
            editReturnDateTextBox.TabIndex = 6;
            // 
            // editDepDateTextBox
            // 
            editDepDateTextBox.Location = new Point(163, 83);
            editDepDateTextBox.Name = "editDepDateTextBox";
            editDepDateTextBox.Size = new Size(156, 27);
            editDepDateTextBox.TabIndex = 5;
            // 
            // editReturnDateLabel
            // 
            editReturnDateLabel.AutoSize = true;
            editReturnDateLabel.Location = new Point(7, 123);
            editReturnDateLabel.Name = "editReturnDateLabel";
            editReturnDateLabel.Size = new Size(126, 20);
            editReturnDateLabel.TabIndex = 4;
            editReturnDateLabel.Text = "DATE OF RETURN";
            // 
            // editDepDateLabel
            // 
            editDepDateLabel.AutoSize = true;
            editDepDateLabel.Location = new Point(7, 86);
            editDepDateLabel.Name = "editDepDateLabel";
            editDepDateLabel.Size = new Size(150, 20);
            editDepDateLabel.TabIndex = 3;
            editDepDateLabel.Text = "DATE OF DEPARTURE";
            // 
            // editNameTextBox
            // 
            editNameTextBox.Location = new Point(63, 50);
            editNameTextBox.Name = "editNameTextBox";
            editNameTextBox.Size = new Size(500, 27);
            editNameTextBox.TabIndex = 2;
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Location = new Point(6, 50);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(51, 20);
            editNameLabel.TabIndex = 1;
            editNameLabel.Text = "NAME";
            // 
            // returnFromEditTrip
            // 
            returnFromEditTrip.Location = new Point(1, 1);
            returnFromEditTrip.Name = "returnFromEditTrip";
            returnFromEditTrip.Size = new Size(55, 29);
            returnFromEditTrip.TabIndex = 0;
            returnFromEditTrip.Text = "◀️";
            returnFromEditTrip.UseVisualStyleBackColor = true;
            returnFromEditTrip.Click += returnFromEditTrip_Click;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 980);
            Controls.Add(editTripPanel);
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
            inspectTripPanel.PerformLayout();
            editTripPanel.ResumeLayout(false);
            editTripPanel.PerformLayout();
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
        private Button editTripButton;
        private TextBox returnDateTextBox;
        private TextBox DepDateTextBox;
        private Label returnDateLabel;
        private Label depDateLabel;
        private TextBox tripNameTextBox;
        private Label nameLabel;
        private Label newTripLabel;
        private FlowLayoutPanel addTripFlowLayoutPanel;
        private Label tripDetailsLabel;
        private Panel editTripPanel;
        private Label editTripLabel;
        private FlowLayoutPanel editTripFlowLayoutPanel;
        private TextBox editReturnDateTextBox;
        private TextBox editDepDateTextBox;
        private Label editReturnDateLabel;
        private Label editDepDateLabel;
        private TextBox editNameTextBox;
        private Label editNameLabel;
        private Button returnFromEditTrip;
    }
}