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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            settingsButton = new Button();
            browseTripsButton = new Button();
            newTripButton = new Button();
            titleLabel = new Label();
            newTripPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            addMemoryLabel = new Label();
            addExpenseLabel = new Label();
            addRestingPointLabel = new Label();
            addLandmarkLabel = new Label();
            addSegmentsLabel = new Label();
            memoriesLabel = new Label();
            expensesLabel = new Label();
            restingPointLabel = new Label();
            landmarkLabel = new Label();
            segmentLabel = new Label();
            newMemoryList = new ListView();
            newExpensesList = new ListView();
            newRestngPointList = new ListView();
            newLandmarkList = new ListView();
            memoriesList = new ListView();
            expensesList = new ListView();
            restingPointsList = new ListView();
            landmarksList = new ListView();
            addSegmentList = new ListView();
            segmentsList = new ListView();
            label3 = new Label();
            addTripReturnDatePicker = new DateTimePicker();
            addTripDepartureDatePicker = new DateTimePicker();
            newTripLabel = new Label();
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            newTripPanel.SuspendLayout();
            browseTripPanel.SuspendLayout();
            inspectTripPanel.SuspendLayout();
            editTripPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(246, 246, 246);
            menuPanel.Controls.Add(panel1);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(monthCalendar1);
            menuPanel.Controls.Add(settingsButton);
            menuPanel.Controls.Add(browseTripsButton);
            menuPanel.Controls.Add(newTripButton);
            menuPanel.Controls.Add(titleLabel);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(3, 2, 3, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1601, 973);
            menuPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1144, 606);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 123);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 183, 99);
            label1.Location = new Point(84, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 33);
            label1.TabIndex = 7;
            label1.Text = "Next trip in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 183, 99);
            label2.Location = new Point(60, 74);
            label2.Name = "label2";
            label2.Size = new Size(219, 33);
            label2.TabIndex = 8;
            label2.Text = "[timer function]";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(25, 135);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1017, 656);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ControlLightLight;
            monthCalendar1.CalendarDimensions = new Size(2, 3);
            monthCalendar1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            monthCalendar1.ForeColor = SystemColors.InactiveBorder;
            monthCalendar1.Location = new Point(1084, 129);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(849, 902);
            settingsButton.Margin = new Padding(3, 2, 3, 2);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(208, 22);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Test Adders (DO NOT SPAM)";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // browseTripsButton
            // 
            browseTripsButton.BackColor = Color.FromArgb(1, 183, 99);
            browseTripsButton.BackgroundImageLayout = ImageLayout.Center;
            browseTripsButton.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            browseTripsButton.ForeColor = Color.White;
            browseTripsButton.Location = new Point(518, 880);
            browseTripsButton.Margin = new Padding(3, 2, 3, 2);
            browseTripsButton.Name = "browseTripsButton";
            browseTripsButton.Size = new Size(281, 57);
            browseTripsButton.TabIndex = 2;
            browseTripsButton.Text = "Browse trips";
            browseTripsButton.UseVisualStyleBackColor = false;
            browseTripsButton.Click += browseTripsButton_Click;
            // 
            // newTripButton
            // 
            newTripButton.BackColor = Color.FromArgb(1, 183, 99);
            newTripButton.BackgroundImageLayout = ImageLayout.Center;
            newTripButton.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            newTripButton.ForeColor = SystemColors.ControlLightLight;
            newTripButton.Location = new Point(143, 880);
            newTripButton.Margin = new Padding(3, 2, 3, 2);
            newTripButton.Name = "newTripButton";
            newTripButton.Size = new Size(283, 57);
            newTripButton.TabIndex = 1;
            newTripButton.Text = "Add new trip";
            newTripButton.UseVisualStyleBackColor = false;
            newTripButton.Click += newTripButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(439, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(541, 90);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Travel Planner";
            // 
            // newTripPanel
            // 
            newTripPanel.BackColor = Color.FromArgb(246, 246, 246);
            newTripPanel.Controls.Add(button14);
            newTripPanel.Controls.Add(button15);
            newTripPanel.Controls.Add(button16);
            newTripPanel.Controls.Add(button11);
            newTripPanel.Controls.Add(button12);
            newTripPanel.Controls.Add(button13);
            newTripPanel.Controls.Add(button8);
            newTripPanel.Controls.Add(button9);
            newTripPanel.Controls.Add(button10);
            newTripPanel.Controls.Add(button5);
            newTripPanel.Controls.Add(button6);
            newTripPanel.Controls.Add(button7);
            newTripPanel.Controls.Add(button4);
            newTripPanel.Controls.Add(button3);
            newTripPanel.Controls.Add(button2);
            newTripPanel.Controls.Add(button1);
            newTripPanel.Controls.Add(addMemoryLabel);
            newTripPanel.Controls.Add(addExpenseLabel);
            newTripPanel.Controls.Add(addRestingPointLabel);
            newTripPanel.Controls.Add(addLandmarkLabel);
            newTripPanel.Controls.Add(addSegmentsLabel);
            newTripPanel.Controls.Add(memoriesLabel);
            newTripPanel.Controls.Add(expensesLabel);
            newTripPanel.Controls.Add(restingPointLabel);
            newTripPanel.Controls.Add(landmarkLabel);
            newTripPanel.Controls.Add(segmentLabel);
            newTripPanel.Controls.Add(newMemoryList);
            newTripPanel.Controls.Add(newExpensesList);
            newTripPanel.Controls.Add(newRestngPointList);
            newTripPanel.Controls.Add(newLandmarkList);
            newTripPanel.Controls.Add(memoriesList);
            newTripPanel.Controls.Add(expensesList);
            newTripPanel.Controls.Add(restingPointsList);
            newTripPanel.Controls.Add(landmarksList);
            newTripPanel.Controls.Add(addSegmentList);
            newTripPanel.Controls.Add(segmentsList);
            newTripPanel.Controls.Add(label3);
            newTripPanel.Controls.Add(addTripReturnDatePicker);
            newTripPanel.Controls.Add(addTripDepartureDatePicker);
            newTripPanel.Controls.Add(newTripLabel);
            newTripPanel.Controls.Add(depDateLabel);
            newTripPanel.Controls.Add(tripNameTextBox);
            newTripPanel.Controls.Add(nameLabel);
            newTripPanel.Controls.Add(returnFromAddButton);
            newTripPanel.Dock = DockStyle.Fill;
            newTripPanel.Location = new Point(0, 0);
            newTripPanel.Margin = new Padding(3, 2, 3, 2);
            newTripPanel.Name = "newTripPanel";
            newTripPanel.Size = new Size(1601, 973);
            newTripPanel.TabIndex = 0;
            newTripPanel.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(1, 183, 99);
            button2.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1308, 377);
            button2.Name = "button2";
            button2.Size = new Size(90, 36);
            button2.TabIndex = 33;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(1, 183, 99);
            button1.Location = new Point(51, 1);
            button1.Name = "button1";
            button1.Size = new Size(48, 52);
            button1.TabIndex = 32;
            button1.Text = "💾";
            button1.UseVisualStyleBackColor = true;
            // 
            // addMemoryLabel
            // 
            addMemoryLabel.AutoSize = true;
            addMemoryLabel.BackColor = Color.FromArgb(1, 183, 99);
            addMemoryLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addMemoryLabel.ForeColor = SystemColors.ControlLightLight;
            addMemoryLabel.Location = new Point(1204, 690);
            addMemoryLabel.Name = "addMemoryLabel";
            addMemoryLabel.Padding = new Padding(130, 10, 130, 10);
            addMemoryLabel.Size = new Size(401, 39);
            addMemoryLabel.TabIndex = 31;
            addMemoryLabel.Text = "Add new memory";
            // 
            // addExpenseLabel
            // 
            addExpenseLabel.AutoSize = true;
            addExpenseLabel.BackColor = Color.FromArgb(1, 183, 99);
            addExpenseLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addExpenseLabel.ForeColor = SystemColors.ControlLightLight;
            addExpenseLabel.Location = new Point(805, 690);
            addExpenseLabel.Name = "addExpenseLabel";
            addExpenseLabel.Padding = new Padding(123, 10, 126, 10);
            addExpenseLabel.Size = new Size(391, 39);
            addExpenseLabel.TabIndex = 30;
            addExpenseLabel.Text = "Add new expense";
            // 
            // addRestingPointLabel
            // 
            addRestingPointLabel.AutoSize = true;
            addRestingPointLabel.BackColor = Color.FromArgb(1, 183, 99);
            addRestingPointLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addRestingPointLabel.ForeColor = SystemColors.ControlLightLight;
            addRestingPointLabel.Location = new Point(407, 690);
            addRestingPointLabel.Name = "addRestingPointLabel";
            addRestingPointLabel.Padding = new Padding(109, 10, 108, 10);
            addRestingPointLabel.Size = new Size(392, 39);
            addRestingPointLabel.TabIndex = 29;
            addRestingPointLabel.Text = "Add new resting point";
            // 
            // addLandmarkLabel
            // 
            addLandmarkLabel.AutoSize = true;
            addLandmarkLabel.BackColor = Color.FromArgb(1, 183, 99);
            addLandmarkLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addLandmarkLabel.ForeColor = SystemColors.ControlLightLight;
            addLandmarkLabel.Location = new Point(0, 690);
            addLandmarkLabel.Name = "addLandmarkLabel";
            addLandmarkLabel.Padding = new Padding(126, 10, 126, 10);
            addLandmarkLabel.Size = new Size(401, 39);
            addLandmarkLabel.TabIndex = 28;
            addLandmarkLabel.Text = "Add new landmark";
            // 
            // addSegmentsLabel
            // 
            addSegmentsLabel.AutoSize = true;
            addSegmentsLabel.BackColor = Color.FromArgb(1, 183, 99);
            addSegmentsLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addSegmentsLabel.ForeColor = SystemColors.ControlLightLight;
            addSegmentsLabel.Location = new Point(805, 125);
            addSegmentsLabel.Margin = new Padding(10);
            addSegmentsLabel.Name = "addSegmentsLabel";
            addSegmentsLabel.Padding = new Padding(362, 10, 362, 10);
            addSegmentsLabel.Size = new Size(868, 39);
            addSegmentsLabel.TabIndex = 27;
            addSegmentsLabel.Text = "Add new segment";
            // 
            // memoriesLabel
            // 
            memoriesLabel.AutoSize = true;
            memoriesLabel.BackColor = Color.FromArgb(127, 127, 127);
            memoriesLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memoriesLabel.ForeColor = SystemColors.ControlLightLight;
            memoriesLabel.Location = new Point(1204, 419);
            memoriesLabel.Name = "memoriesLabel";
            memoriesLabel.Padding = new Padding(158, 10, 158, 10);
            memoriesLabel.Size = new Size(399, 39);
            memoriesLabel.TabIndex = 26;
            memoriesLabel.Text = "Memories";
            // 
            // expensesLabel
            // 
            expensesLabel.AutoSize = true;
            expensesLabel.BackColor = Color.FromArgb(127, 127, 127);
            expensesLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expensesLabel.ForeColor = SystemColors.ControlLightLight;
            expensesLabel.Location = new Point(805, 419);
            expensesLabel.Name = "expensesLabel";
            expensesLabel.Padding = new Padding(155, 10, 155, 10);
            expensesLabel.Size = new Size(392, 39);
            expensesLabel.TabIndex = 25;
            expensesLabel.Text = "Expenses";
            // 
            // restingPointLabel
            // 
            restingPointLabel.AutoSize = true;
            restingPointLabel.BackColor = Color.FromArgb(127, 127, 127);
            restingPointLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restingPointLabel.ForeColor = SystemColors.ControlLightLight;
            restingPointLabel.Location = new Point(407, 419);
            restingPointLabel.Name = "restingPointLabel";
            restingPointLabel.Padding = new Padding(136, 10, 137, 10);
            restingPointLabel.Size = new Size(392, 39);
            restingPointLabel.TabIndex = 24;
            restingPointLabel.Text = "Resting points";
            // 
            // landmarkLabel
            // 
            landmarkLabel.AutoSize = true;
            landmarkLabel.BackColor = Color.FromArgb(127, 127, 127);
            landmarkLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landmarkLabel.ForeColor = SystemColors.ControlLightLight;
            landmarkLabel.Location = new Point(-1, 419);
            landmarkLabel.Name = "landmarkLabel";
            landmarkLabel.Padding = new Padding(155, 10, 155, 10);
            landmarkLabel.Size = new Size(402, 39);
            landmarkLabel.TabIndex = 23;
            landmarkLabel.Text = "Landmarks";
            // 
            // segmentLabel
            // 
            segmentLabel.AutoSize = true;
            segmentLabel.BackColor = Color.FromArgb(127, 127, 127);
            segmentLabel.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segmentLabel.ForeColor = SystemColors.ControlLightLight;
            segmentLabel.Location = new Point(0, 125);
            segmentLabel.Margin = new Padding(10);
            segmentLabel.Name = "segmentLabel";
            segmentLabel.Padding = new Padding(359, 10, 356, 10);
            segmentLabel.Size = new Size(799, 39);
            segmentLabel.TabIndex = 22;
            segmentLabel.Text = "Segments";
            // 
            // newMemoryList
            // 
            newMemoryList.Location = new Point(1203, 732);
            newMemoryList.Name = "newMemoryList";
            newMemoryList.Size = new Size(398, 241);
            newMemoryList.TabIndex = 21;
            newMemoryList.UseCompatibleStateImageBehavior = false;
            // 
            // newExpensesList
            // 
            newExpensesList.Location = new Point(805, 732);
            newExpensesList.Name = "newExpensesList";
            newExpensesList.Size = new Size(392, 241);
            newExpensesList.TabIndex = 20;
            newExpensesList.UseCompatibleStateImageBehavior = false;
            // 
            // newRestngPointList
            // 
            newRestngPointList.Location = new Point(407, 732);
            newRestngPointList.Name = "newRestngPointList";
            newRestngPointList.Size = new Size(392, 241);
            newRestngPointList.TabIndex = 19;
            newRestngPointList.UseCompatibleStateImageBehavior = false;
            // 
            // newLandmarkList
            // 
            newLandmarkList.Location = new Point(0, 732);
            newLandmarkList.Name = "newLandmarkList";
            newLandmarkList.Size = new Size(401, 242);
            newLandmarkList.TabIndex = 18;
            newLandmarkList.UseCompatibleStateImageBehavior = false;
            // 
            // memoriesList
            // 
            memoriesList.Location = new Point(1203, 461);
            memoriesList.Name = "memoriesList";
            memoriesList.Size = new Size(398, 224);
            memoriesList.TabIndex = 17;
            memoriesList.UseCompatibleStateImageBehavior = false;
            // 
            // expensesList
            // 
            expensesList.Location = new Point(805, 461);
            expensesList.Name = "expensesList";
            expensesList.Size = new Size(393, 224);
            expensesList.TabIndex = 16;
            expensesList.UseCompatibleStateImageBehavior = false;
            // 
            // restingPointsList
            // 
            restingPointsList.Location = new Point(407, 461);
            restingPointsList.Name = "restingPointsList";
            restingPointsList.Size = new Size(392, 225);
            restingPointsList.TabIndex = 15;
            restingPointsList.UseCompatibleStateImageBehavior = false;
            // 
            // landmarksList
            // 
            landmarksList.Location = new Point(0, 461);
            landmarksList.Name = "landmarksList";
            landmarksList.Size = new Size(401, 225);
            landmarksList.TabIndex = 14;
            landmarksList.UseCompatibleStateImageBehavior = false;
            // 
            // addSegmentList
            // 
            addSegmentList.Location = new Point(805, 166);
            addSegmentList.Name = "addSegmentList";
            addSegmentList.Size = new Size(796, 250);
            addSegmentList.TabIndex = 13;
            addSegmentList.UseCompatibleStateImageBehavior = false;
            // 
            // segmentsList
            // 
            segmentsList.Location = new Point(0, 166);
            segmentsList.Name = "segmentsList";
            segmentsList.Size = new Size(799, 250);
            segmentsList.TabIndex = 12;
            segmentsList.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1320, 82);
            label3.Name = "label3";
            label3.Size = new Size(13, 18);
            label3.TabIndex = 11;
            label3.Text = "-";
            // 
            // addTripReturnDatePicker
            // 
            addTripReturnDatePicker.Location = new Point(1339, 79);
            addTripReturnDatePicker.Margin = new Padding(3, 2, 3, 2);
            addTripReturnDatePicker.Name = "addTripReturnDatePicker";
            addTripReturnDatePicker.Size = new Size(219, 23);
            addTripReturnDatePicker.TabIndex = 10;
            // 
            // addTripDepartureDatePicker
            // 
            addTripDepartureDatePicker.Location = new Point(1095, 79);
            addTripDepartureDatePicker.Margin = new Padding(3, 2, 3, 2);
            addTripDepartureDatePicker.Name = "addTripDepartureDatePicker";
            addTripDepartureDatePicker.Size = new Size(219, 23);
            addTripDepartureDatePicker.TabIndex = 9;
            // 
            // newTripLabel
            // 
            newTripLabel.AutoSize = true;
            newTripLabel.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            newTripLabel.Location = new Point(619, 2);
            newTripLabel.Name = "newTripLabel";
            newTripLabel.Size = new Size(361, 68);
            newTripLabel.TabIndex = 8;
            newTripLabel.Text = "Add new trip";
            // 
            // depDateLabel
            // 
            depDateLabel.AutoSize = true;
            depDateLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            depDateLabel.Location = new Point(979, 82);
            depDateLabel.Name = "depDateLabel";
            depDateLabel.Size = new Size(110, 18);
            depDateLabel.TabIndex = 3;
            depDateLabel.Text = "Date of the trip";
            // 
            // tripNameTextBox
            // 
            tripNameTextBox.Location = new Point(154, 79);
            tripNameTextBox.Margin = new Padding(3, 2, 3, 2);
            tripNameTextBox.Name = "tripNameTextBox";
            tripNameTextBox.Size = new Size(438, 23);
            tripNameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(30, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(118, 18);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name of the trip";
            // 
            // returnFromAddButton
            // 
            returnFromAddButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            returnFromAddButton.ForeColor = Color.FromArgb(1, 183, 99);
            returnFromAddButton.Location = new Point(1, 1);
            returnFromAddButton.Margin = new Padding(3, 2, 3, 2);
            returnFromAddButton.Name = "returnFromAddButton";
            returnFromAddButton.Size = new Size(48, 52);
            returnFromAddButton.TabIndex = 0;
            returnFromAddButton.Text = "◀️";
            returnFromAddButton.UseVisualStyleBackColor = true;
            returnFromAddButton.Click += returnFromAddButton_Click;
            // 
            // browseTripPanel
            // 
            browseTripPanel.BackColor = Color.FromArgb(246, 246, 246);
            browseTripPanel.Controls.Add(tripListPanel);
            browseTripPanel.Controls.Add(browseLabel);
            browseTripPanel.Controls.Add(searchTextBox);
            browseTripPanel.Controls.Add(returnFromBrowseButton);
            browseTripPanel.Dock = DockStyle.Fill;
            browseTripPanel.Location = new Point(0, 0);
            browseTripPanel.Margin = new Padding(3, 2, 3, 2);
            browseTripPanel.Name = "browseTripPanel";
            browseTripPanel.Size = new Size(1601, 973);
            browseTripPanel.TabIndex = 1;
            browseTripPanel.Visible = false;
            // 
            // tripListPanel
            // 
            tripListPanel.AutoScroll = true;
            tripListPanel.Dock = DockStyle.Bottom;
            tripListPanel.Location = new Point(0, 176);
            tripListPanel.Margin = new Padding(3, 2, 3, 2);
            tripListPanel.Name = "tripListPanel";
            tripListPanel.Size = new Size(1601, 797);
            tripListPanel.TabIndex = 4;
            // 
            // browseLabel
            // 
            browseLabel.AutoSize = true;
            browseLabel.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            browseLabel.Location = new Point(561, 6);
            browseLabel.Name = "browseLabel";
            browseLabel.Size = new Size(481, 90);
            browseLabel.TabIndex = 3;
            browseLabel.Text = "Browse trips";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchTextBox.ForeColor = Color.FromArgb(195, 195, 195);
            searchTextBox.Location = new Point(642, 107);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(338, 34);
            searchTextBox.TabIndex = 2;
            searchTextBox.Text = "search";
            searchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // returnFromBrowseButton
            // 
            returnFromBrowseButton.BackgroundImageLayout = ImageLayout.None;
            returnFromBrowseButton.FlatStyle = FlatStyle.Popup;
            returnFromBrowseButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            returnFromBrowseButton.ForeColor = Color.FromArgb(1, 183, 99);
            returnFromBrowseButton.Location = new Point(0, 0);
            returnFromBrowseButton.Margin = new Padding(3, 2, 3, 2);
            returnFromBrowseButton.Name = "returnFromBrowseButton";
            returnFromBrowseButton.Size = new Size(46, 43);
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
            inspectTripPanel.Margin = new Padding(3, 2, 3, 2);
            inspectTripPanel.Name = "inspectTripPanel";
            inspectTripPanel.Size = new Size(1601, 973);
            inspectTripPanel.TabIndex = 2;
            inspectTripPanel.Visible = false;
            // 
            // editButtonPanel
            // 
            editButtonPanel.Location = new Point(53, 0);
            editButtonPanel.Margin = new Padding(3, 2, 3, 2);
            editButtonPanel.Name = "editButtonPanel";
            editButtonPanel.Size = new Size(80, 22);
            editButtonPanel.TabIndex = 10;
            // 
            // tripInfoPanel
            // 
            tripInfoPanel.Dock = DockStyle.Bottom;
            tripInfoPanel.FlowDirection = FlowDirection.TopDown;
            tripInfoPanel.Location = new Point(0, 285);
            tripInfoPanel.Margin = new Padding(3, 2, 3, 2);
            tripInfoPanel.Name = "tripInfoPanel";
            tripInfoPanel.Size = new Size(1601, 688);
            tripInfoPanel.TabIndex = 9;
            // 
            // returnFromInspectButton
            // 
            returnFromInspectButton.Location = new Point(0, 0);
            returnFromInspectButton.Margin = new Padding(3, 2, 3, 2);
            returnFromInspectButton.Name = "returnFromInspectButton";
            returnFromInspectButton.Size = new Size(48, 22);
            returnFromInspectButton.TabIndex = 5;
            returnFromInspectButton.Text = "◀️";
            returnFromInspectButton.UseVisualStyleBackColor = true;
            returnFromInspectButton.Click += returnFromInspectButton_Click;
            // 
            // tripDetailsLabel
            // 
            tripDetailsLabel.AutoSize = true;
            tripDetailsLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            tripDetailsLabel.Location = new Point(659, 0);
            tripDetailsLabel.Name = "tripDetailsLabel";
            tripDetailsLabel.Size = new Size(255, 54);
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
            editTripPanel.Margin = new Padding(3, 2, 3, 2);
            editTripPanel.Name = "editTripPanel";
            editTripPanel.Size = new Size(1601, 973);
            editTripPanel.TabIndex = 9;
            editTripPanel.Visible = false;
            // 
            // editTripLabel
            // 
            editTripLabel.AutoSize = true;
            editTripLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            editTripLabel.Location = new Point(694, 7);
            editTripLabel.Name = "editTripLabel";
            editTripLabel.Size = new Size(192, 54);
            editTripLabel.TabIndex = 8;
            editTripLabel.Text = "EDIT TRIP";
            // 
            // editReturnDateTextBox
            // 
            editReturnDateTextBox.Location = new Point(143, 87);
            editReturnDateTextBox.Margin = new Padding(3, 2, 3, 2);
            editReturnDateTextBox.Name = "editReturnDateTextBox";
            editReturnDateTextBox.Size = new Size(137, 23);
            editReturnDateTextBox.TabIndex = 6;
            // 
            // editDepDateTextBox
            // 
            editDepDateTextBox.Location = new Point(143, 62);
            editDepDateTextBox.Margin = new Padding(3, 2, 3, 2);
            editDepDateTextBox.Name = "editDepDateTextBox";
            editDepDateTextBox.Size = new Size(137, 23);
            editDepDateTextBox.TabIndex = 5;
            // 
            // editReturnDateLabel
            // 
            editReturnDateLabel.AutoSize = true;
            editReturnDateLabel.Location = new Point(6, 92);
            editReturnDateLabel.Name = "editReturnDateLabel";
            editReturnDateLabel.Size = new Size(98, 15);
            editReturnDateLabel.TabIndex = 4;
            editReturnDateLabel.Text = "DATE OF RETURN";
            // 
            // editDepDateLabel
            // 
            editDepDateLabel.AutoSize = true;
            editDepDateLabel.Location = new Point(6, 64);
            editDepDateLabel.Name = "editDepDateLabel";
            editDepDateLabel.Size = new Size(116, 15);
            editDepDateLabel.TabIndex = 3;
            editDepDateLabel.Text = "DATE OF DEPARTURE";
            // 
            // editNameTextBox
            // 
            editNameTextBox.Location = new Point(55, 38);
            editNameTextBox.Margin = new Padding(3, 2, 3, 2);
            editNameTextBox.Name = "editNameTextBox";
            editNameTextBox.Size = new Size(438, 23);
            editNameTextBox.TabIndex = 2;
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Location = new Point(5, 38);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(41, 15);
            editNameLabel.TabIndex = 1;
            editNameLabel.Text = "NAME";
            // 
            // returnFromEditTrip
            // 
            returnFromEditTrip.Location = new Point(1, 1);
            returnFromEditTrip.Margin = new Padding(3, 2, 3, 2);
            returnFromEditTrip.Name = "returnFromEditTrip";
            returnFromEditTrip.Size = new Size(48, 22);
            returnFromEditTrip.TabIndex = 0;
            returnFromEditTrip.Text = "◀️";
            returnFromEditTrip.UseVisualStyleBackColor = true;
            returnFromEditTrip.Click += returnFromEditTrip_Click;
            // 
            // editTripFlowLayoutPanel
            // 
            editTripFlowLayoutPanel.AutoScroll = true;
            editTripFlowLayoutPanel.Dock = DockStyle.Bottom;
            editTripFlowLayoutPanel.Location = new Point(0, 350);
            editTripFlowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            editTripFlowLayoutPanel.Name = "editTripFlowLayoutPanel";
            editTripFlowLayoutPanel.Size = new Size(1601, 623);
            editTripFlowLayoutPanel.TabIndex = 7;
            editTripFlowLayoutPanel.WrapContents = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(1, 183, 99);
            button3.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1500, 377);
            button3.Name = "button3";
            button3.Size = new Size(90, 36);
            button3.TabIndex = 34;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(1, 183, 99);
            button4.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1404, 377);
            button4.Name = "button4";
            button4.Size = new Size(90, 36);
            button4.TabIndex = 35;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(1, 183, 99);
            button5.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1412, 934);
            button5.Name = "button5";
            button5.Size = new Size(90, 36);
            button5.TabIndex = 38;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(1, 183, 99);
            button6.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(1508, 934);
            button6.Name = "button6";
            button6.Size = new Size(90, 36);
            button6.TabIndex = 37;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(1, 183, 99);
            button7.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(1316, 934);
            button7.Name = "button7";
            button7.Size = new Size(90, 36);
            button7.TabIndex = 36;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(1, 183, 99);
            button8.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(1008, 934);
            button8.Name = "button8";
            button8.Size = new Size(90, 36);
            button8.TabIndex = 41;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(1, 183, 99);
            button9.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(1104, 934);
            button9.Name = "button9";
            button9.Size = new Size(90, 36);
            button9.TabIndex = 40;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(1, 183, 99);
            button10.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(912, 934);
            button10.Name = "button10";
            button10.Size = new Size(90, 36);
            button10.TabIndex = 39;
            button10.Text = "Remove";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(1, 183, 99);
            button11.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(610, 935);
            button11.Name = "button11";
            button11.Size = new Size(90, 36);
            button11.TabIndex = 44;
            button11.Text = "Update";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(1, 183, 99);
            button12.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(706, 935);
            button12.Name = "button12";
            button12.Size = new Size(90, 36);
            button12.TabIndex = 43;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(1, 183, 99);
            button13.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(514, 935);
            button13.Name = "button13";
            button13.Size = new Size(90, 36);
            button13.TabIndex = 42;
            button13.Text = "Remove";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(1, 183, 99);
            button14.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(212, 937);
            button14.Name = "button14";
            button14.Size = new Size(90, 36);
            button14.TabIndex = 47;
            button14.Text = "Update";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(1, 183, 99);
            button15.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(308, 937);
            button15.Name = "button15";
            button15.Size = new Size(90, 36);
            button15.TabIndex = 46;
            button15.Text = "Add";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(1, 183, 99);
            button16.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(116, 937);
            button16.Name = "button16";
            button16.Size = new Size(90, 36);
            button16.TabIndex = 45;
            button16.Text = "Remove";
            button16.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 973);
            Controls.Add(newTripPanel);
            Controls.Add(inspectTripPanel);
            Controls.Add(editTripPanel);
            Controls.Add(browseTripPanel);
            Controls.Add(menuPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GUI";
            Text = "Travel Planner";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label depDateLabel;
        private TextBox tripNameTextBox;
        private Label nameLabel;
        private Label newTripLabel;
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
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ListView newMemoryList;
        private ListView newExpensesList;
        private ListView newRestngPointList;
        private ListView newLandmarkList;
        private ListView memoriesList;
        private ListView expensesList;
        private ListView restingPointsList;
        private ListView landmarksList;
        private ListView addSegmentList;
        private ListView segmentsList;
        private Label segmentLabel;
        private Label landmarkLabel;
        private Label restingPointLabel;
        private Label expensesLabel;
        private Label memoriesLabel;
        private Label addSegmentsLabel;
        private Label addMemoryLabel;
        private Label addExpenseLabel;
        private Label addRestingPointLabel;
        private Label addLandmarkLabel;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}