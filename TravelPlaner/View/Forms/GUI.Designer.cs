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
            addTripReturnDatePicker = new DateTimePicker();
            addTripDepartureDatePicker = new DateTimePicker();
            newTripLabel = new Label();
            addTripFlowLayoutPanel = new FlowLayoutPanel();
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
            editButtonPanel = new Panel();
            tripInfoPanel = new FlowLayoutPanel();
            returnFromInspectButton = new Button();
            tripDetailsLabel = new Label();
            editTripPanel = new Panel();
            editTripLabel = new Label();
            editReturnDateTextBox = new TextBox();
            editDepDateTextBox = new TextBox();
            editReturnDateLabel = new Label();
            editDepDateLabel = new Label();
            editNameTextBox = new TextBox();
            editNameLabel = new Label();
            returnFromEditTrip = new Button();
            editTripFlowLayoutPanel = new FlowLayoutPanel();
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
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1820, 980);
            menuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1091, 531);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(1174, 180);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 70F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(588, -4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(782, 155);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Travel Planner";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(394, 851);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(238, 29);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Test Adders (DO NOT SPAM)";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // browseTripsButton
            // 
            browseTripsButton.Location = new Point(243, 851);
            browseTripsButton.Name = "browseTripsButton";
            browseTripsButton.Size = new Size(114, 29);
            browseTripsButton.TabIndex = 2;
            browseTripsButton.Text = "Browse trips";
            browseTripsButton.UseVisualStyleBackColor = true;
            browseTripsButton.Click += browseTripsButton_Click;
            // 
            // newTripButton
            // 
            newTripButton.Location = new Point(90, 851);
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
            newTripPanel.Controls.Add(addTripReturnDatePicker);
            newTripPanel.Controls.Add(addTripDepartureDatePicker);
            newTripPanel.Controls.Add(newTripLabel);
            newTripPanel.Controls.Add(addTripFlowLayoutPanel);
            newTripPanel.Controls.Add(returnDateLabel);
            newTripPanel.Controls.Add(depDateLabel);
            newTripPanel.Controls.Add(tripNameTextBox);
            newTripPanel.Controls.Add(nameLabel);
            newTripPanel.Controls.Add(returnFromAddButton);
            newTripPanel.Dock = DockStyle.Fill;
            newTripPanel.Location = new Point(0, 0);
            newTripPanel.Name = "newTripPanel";
            newTripPanel.Size = new Size(1820, 980);
            newTripPanel.TabIndex = 0;
            newTripPanel.Visible = false;
            // 
            // addTripReturnDatePicker
            // 
            addTripReturnDatePicker.Location = new Point(163, 116);
            addTripReturnDatePicker.Name = "addTripReturnDatePicker";
            addTripReturnDatePicker.Size = new Size(250, 27);
            addTripReturnDatePicker.TabIndex = 10;
            // 
            // addTripDepartureDatePicker
            // 
            addTripDepartureDatePicker.Location = new Point(163, 83);
            addTripDepartureDatePicker.Name = "addTripDepartureDatePicker";
            addTripDepartureDatePicker.Size = new Size(250, 27);
            addTripDepartureDatePicker.TabIndex = 9;
            // 
            // newTripLabel
            // 
            newTripLabel.AutoSize = true;
            newTripLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            newTripLabel.Location = new Point(707, 3);
            newTripLabel.Name = "newTripLabel";
            newTripLabel.Size = new Size(365, 67);
            newTripLabel.TabIndex = 8;
            newTripLabel.Text = "ADD NEW TRIP";
            // 
            // addTripFlowLayoutPanel
            // 
            addTripFlowLayoutPanel.AutoScroll = true;
            addTripFlowLayoutPanel.Dock = DockStyle.Bottom;
            addTripFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            addTripFlowLayoutPanel.Location = new Point(0, 149);
            addTripFlowLayoutPanel.Name = "addTripFlowLayoutPanel";
            addTripFlowLayoutPanel.Size = new Size(1820, 831);
            addTripFlowLayoutPanel.TabIndex = 7;
            addTripFlowLayoutPanel.WrapContents = false;
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
            browseTripPanel.Dock = DockStyle.Fill;
            browseTripPanel.Location = new Point(0, 0);
            browseTripPanel.Name = "browseTripPanel";
            browseTripPanel.Size = new Size(1820, 980);
            browseTripPanel.TabIndex = 1;
            browseTripPanel.Visible = false;
            // 
            // tripListPanel
            // 
            tripListPanel.AutoScroll = true;
            tripListPanel.Dock = DockStyle.Bottom;
            tripListPanel.Location = new Point(0, 103);
            tripListPanel.Name = "tripListPanel";
            tripListPanel.Size = new Size(1820, 877);
            tripListPanel.TabIndex = 4;
            // 
            // browseLabel
            // 
            browseLabel.AutoSize = true;
            browseLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            browseLabel.Location = new Point(728, 0);
            browseLabel.Name = "browseLabel";
            browseLabel.Size = new Size(362, 67);
            browseLabel.TabIndex = 3;
            browseLabel.Text = "BROWSE TRIPS";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(806, 70);
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
            inspectTripPanel.Controls.Add(editButtonPanel);
            inspectTripPanel.Controls.Add(tripInfoPanel);
            inspectTripPanel.Controls.Add(returnFromInspectButton);
            inspectTripPanel.Controls.Add(tripDetailsLabel);
            inspectTripPanel.Dock = DockStyle.Fill;
            inspectTripPanel.Location = new Point(0, 0);
            inspectTripPanel.Name = "inspectTripPanel";
            inspectTripPanel.Size = new Size(1820, 980);
            inspectTripPanel.TabIndex = 2;
            inspectTripPanel.Visible = false;
            // 
            // editButtonPanel
            // 
            editButtonPanel.Location = new Point(61, 0);
            editButtonPanel.Name = "editButtonPanel";
            editButtonPanel.Size = new Size(92, 30);
            editButtonPanel.TabIndex = 10;
            // 
            // tripInfoPanel
            // 
            tripInfoPanel.Dock = DockStyle.Bottom;
            tripInfoPanel.FlowDirection = FlowDirection.TopDown;
            tripInfoPanel.Location = new Point(0, 62);
            tripInfoPanel.Name = "tripInfoPanel";
            tripInfoPanel.Size = new Size(1820, 918);
            tripInfoPanel.TabIndex = 9;
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
            tripDetailsLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            tripDetailsLabel.Location = new Point(753, 0);
            tripDetailsLabel.Name = "tripDetailsLabel";
            tripDetailsLabel.Size = new Size(319, 67);
            tripDetailsLabel.TabIndex = 8;
            tripDetailsLabel.Text = "TRIP DETAILS";
            // 
            // editTripPanel
            // 
            editTripPanel.BackColor = SystemColors.ActiveCaption;
            editTripPanel.Controls.Add(editTripLabel);
            editTripPanel.Controls.Add(editReturnDateTextBox);
            editTripPanel.Controls.Add(editDepDateTextBox);
            editTripPanel.Controls.Add(editReturnDateLabel);
            editTripPanel.Controls.Add(editDepDateLabel);
            editTripPanel.Controls.Add(editNameTextBox);
            editTripPanel.Controls.Add(editNameLabel);
            editTripPanel.Controls.Add(returnFromEditTrip);
            editTripPanel.Controls.Add(editTripFlowLayoutPanel);
            editTripPanel.Dock = DockStyle.Fill;
            editTripPanel.Location = new Point(0, 0);
            editTripPanel.Name = "editTripPanel";
            editTripPanel.Size = new Size(1820, 980);
            editTripPanel.TabIndex = 9;
            editTripPanel.Visible = false;
            // 
            // editTripLabel
            // 
            editTripLabel.AutoSize = true;
            editTripLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            editTripLabel.Location = new Point(793, 9);
            editTripLabel.Name = "editTripLabel";
            editTripLabel.Size = new Size(239, 67);
            editTripLabel.TabIndex = 8;
            editTripLabel.Text = "EDIT TRIP";
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
            // editTripFlowLayoutPanel
            // 
            editTripFlowLayoutPanel.AutoScroll = true;
            editTripFlowLayoutPanel.Dock = DockStyle.Bottom;
            editTripFlowLayoutPanel.Location = new Point(0, 149);
            editTripFlowLayoutPanel.Name = "editTripFlowLayoutPanel";
            editTripFlowLayoutPanel.Size = new Size(1820, 831);
            editTripFlowLayoutPanel.TabIndex = 7;
            editTripFlowLayoutPanel.WrapContents = false;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 980);
            Controls.Add(menuPanel);
            Controls.Add(newTripPanel);
            Controls.Add(inspectTripPanel);
            Controls.Add(editTripPanel);
            Controls.Add(browseTripPanel);
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
        private FlowLayoutPanel tripInfoPanel;
        private Panel editButtonPanel;
        private DateTimePicker addTripReturnDatePicker;
        private DateTimePicker addTripDepartureDatePicker;
    }
}