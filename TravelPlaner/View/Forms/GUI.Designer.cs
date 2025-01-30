using System.Windows.Forms;

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
            monthCalendar = new MonthCalendar();
            panel1 = new Panel();
            timerNameLabel = new Label();
            timerLabel = new Label();
            slideShowPictureBox = new PictureBox();
            browseTripsButton = new Button();
            newTripButton = new Button();
            titleLabel = new Label();
            newTripPanel = new Panel();
            expValueAddInput = new NumericUpDown();
            memPhotoAddButtonSelect = new Button();
            label2 = new Label();
            memNameAddInput = new TextBox();
            memPhotoAddInput = new TextBox();
            recomLandmarkAddButton = new Button();
            memNoteAddInput = new RichTextBox();
            segNameAddInput = new TextBox();
            memSongAddInput = new TextBox();
            expNameAddInput = new TextBox();
            restContactAddInput = new TextBox();
            restAddressAddInput = new TextBox();
            restCityAddInput = new TextBox();
            restCountryAddInput = new TextBox();
            restNameAddInput = new TextBox();
            landDescAddInput = new TextBox();
            landAddressAddInput = new TextBox();
            landCityAddInput = new TextBox();
            landCountryAddInput = new TextBox();
            landNameAddInput = new TextBox();
            restCampingAddRadioButton = new RadioButton();
            restApartmentAddRadioButton = new RadioButton();
            restRoomAddRadioButton = new RadioButton();
            restHostelAddRadioButton = new RadioButton();
            restHotelAddRadioButton = new RadioButton();
            restTypeLabel = new Label();
            restContactLabel = new Label();
            restAddressLabel = new Label();
            restCityLabel = new Label();
            restCountryLabel = new Label();
            restNameLabel = new Label();
            memNoteLabel = new Label();
            memSongLabel = new Label();
            memPhotoLabel = new Label();
            expValueLabel = new Label();
            expNameLabel = new Label();
            landDescLabel = new Label();
            landAddressLabel = new Label();
            landCityLabel = new Label();
            landCountryLabel = new Label();
            landNameLabel = new Label();
            segNameLabel = new Label();
            landUpdateAddButton = new Button();
            landAddAddButton = new Button();
            landRemoveAddButton = new Button();
            restUpdateAddButton = new Button();
            restAddAddButton = new Button();
            restRemoveAddButton = new Button();
            expUpdateAddButton = new Button();
            expAddAddButton = new Button();
            expRemoveAddButton = new Button();
            memUpdateAddButton = new Button();
            memAddAddButton = new Button();
            memRemoveAddButton = new Button();
            segUpdateAddButton = new Button();
            segAddAddButton = new Button();
            segRemoveAddButton = new Button();
            saveAddTripButton = new Button();
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
            idAddMemory = new ColumnHeader();
            nameMemoryAdd = new ColumnHeader();
            expensesList = new ListView();
            idAddExpense = new ColumnHeader();
            nameExpenseAdd = new ColumnHeader();
            restingPointsList = new ListView();
            idAddRestingPoint = new ColumnHeader();
            nameAddRestingPoint = new ColumnHeader();
            landmarksList = new ListView();
            idAddLand = new ColumnHeader();
            nameLandAdd = new ColumnHeader();
            addSegmentList = new ListView();
            segmentsList = new ListView();
            idAddSegment = new ColumnHeader();
            nameAddSegment = new ColumnHeader();
            label3 = new Label();
            addTripReturnDatePicker = new DateTimePicker();
            addTripDepartureDatePicker = new DateTimePicker();
            newTripLabel = new Label();
            depDateLabel = new Label();
            tripNameAddInput = new TextBox();
            nameLabel = new Label();
            returnFromAddButton = new Button();
            inspectTripPanel = new Panel();
            createSlideShowButton = new Button();
            memNoteTextBox = new RichTextBox();
            memDetailsPhotoPictureBox = new PictureBox();
            segNameTextBox = new TextBox();
            memSongTextBos = new TextBox();
            expValueTextBox = new TextBox();
            expNameTextBox = new TextBox();
            restContactTextBox = new TextBox();
            restAddressTextBox = new TextBox();
            restCityTextBox = new TextBox();
            restCountryTextBox = new TextBox();
            restNameTextBox = new TextBox();
            landDescTextBox = new TextBox();
            landAddressTextBox = new TextBox();
            landCityTextBox = new TextBox();
            landCountryTextBox = new TextBox();
            landNameTextBox = new TextBox();
            restCampingDetailsRadioButton = new RadioButton();
            restApartmentDetailsRadioButton = new RadioButton();
            restRoomDetailsRadioButton = new RadioButton();
            restHostelDetailsRadioButton = new RadioButton();
            restHotelDetailsRadioButton = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            editButton = new Button();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            listView4 = new ListView();
            memoriesListView = new ListView();
            idMemory = new ColumnHeader();
            photoMemory = new ColumnHeader();
            expensesListView = new ListView();
            idExpenses = new ColumnHeader();
            nameExpenses = new ColumnHeader();
            restingPointListView = new ListView();
            idRestingPoint = new ColumnHeader();
            nameRestingPoint = new ColumnHeader();
            landmarkListView = new ListView();
            idLandmark = new ColumnHeader();
            nameLandmark = new ColumnHeader();
            listView9 = new ListView();
            segmentsListView = new ListView();
            idSegment = new ColumnHeader();
            nameSegment = new ColumnHeader();
            label31 = new Label();
            tripReturnDatePicker = new DateTimePicker();
            tripDepartureDatePicker = new DateTimePicker();
            label33 = new Label();
            label34 = new Label();
            returnFromInspectButton = new Button();
            label32 = new Label();
            tripNameTextBox = new TextBox();
            returnFromBrowseButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            browseLabel = new Label();
            tripListPanel = new Panel();
            browseTripPanel = new Panel();
            editTripPanel = new Panel();
            memPhotoButtonSelect = new Button();
            memPhotoEditInput = new TextBox();
            memNameEditInput = new TextBox();
            label1 = new Label();
            expValueEditInput = new NumericUpDown();
            recomLandmarkEditButton = new Button();
            memNoteEditInput = new RichTextBox();
            segNameEditInput = new TextBox();
            memSongEditInput = new TextBox();
            expNameEditInput = new TextBox();
            restContactEditInput = new TextBox();
            restAddressEditInput = new TextBox();
            restCityEditInput = new TextBox();
            restCountryEditInput = new TextBox();
            restNameEditInput = new TextBox();
            landDescEditInput = new TextBox();
            landAddressEditInput = new TextBox();
            landCityEditInput = new TextBox();
            landCountryEditInput = new TextBox();
            landNameEditInput = new TextBox();
            restCampingEditRadioButton = new RadioButton();
            restApartmentEditRadioButton = new RadioButton();
            restRoomEditRadioButton = new RadioButton();
            restHostelEditRadioButton = new RadioButton();
            restHotelEditRadioButton = new RadioButton();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            landUpdateEditButton = new Button();
            landAddEditButton = new Button();
            landRemoveEditButton = new Button();
            restUpdateEditButton = new Button();
            restAddEditButton = new Button();
            restRemoveEditButton = new Button();
            expUpdateEditButton = new Button();
            expAddEditButton = new Button();
            expRemoveEditButton = new Button();
            memUpdateEditButton = new Button();
            memAddEditButton = new Button();
            memRemoveEditButton = new Button();
            segUpdateEditButton = new Button();
            segAddEditButton = new Button();
            segRemoveEditButton = new Button();
            saveEditTripButton = new Button();
            label52 = new Label();
            label53 = new Label();
            label54 = new Label();
            label55 = new Label();
            label56 = new Label();
            label57 = new Label();
            label58 = new Label();
            label59 = new Label();
            label60 = new Label();
            label61 = new Label();
            listView11 = new ListView();
            listView12 = new ListView();
            restEditPanel = new ListView();
            listView14 = new ListView();
            memoriesEditListView = new ListView();
            idEditMemory = new ColumnHeader();
            nameEditMemory = new ColumnHeader();
            expensesEditListView = new ListView();
            idEditExpense = new ColumnHeader();
            nameEditExpense = new ColumnHeader();
            restingEditPointListView = new ListView();
            idEditRestingPoint = new ColumnHeader();
            nameEditRestingPoint = new ColumnHeader();
            landmarkEditListView = new ListView();
            idEditLand = new ColumnHeader();
            nameLandEdit = new ColumnHeader();
            listView19 = new ListView();
            segmentsEditListView = new ListView();
            idEditSegment = new ColumnHeader();
            nameEditSegment = new ColumnHeader();
            label62 = new Label();
            editTripReturnDatePicker = new DateTimePicker();
            editTripDepartureDatePicker = new DateTimePicker();
            label63 = new Label();
            label64 = new Label();
            tripNameEditInput = new TextBox();
            label65 = new Label();
            returnFromEditTripButton = new Button();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slideShowPictureBox).BeginInit();
            newTripPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expValueAddInput).BeginInit();
            inspectTripPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memDetailsPhotoPictureBox).BeginInit();
            browseTripPanel.SuspendLayout();
            editTripPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expValueEditInput).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(246, 246, 246);
            menuPanel.Controls.Add(monthCalendar);
            menuPanel.Controls.Add(panel1);
            menuPanel.Controls.Add(slideShowPictureBox);
            menuPanel.Controls.Add(browseTripsButton);
            menuPanel.Controls.Add(newTripButton);
            menuPanel.Controls.Add(titleLabel);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(3, 2, 3, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1605, 981);
            menuPanel.TabIndex = 0;
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.ControlLightLight;
            monthCalendar.Location = new Point(1087, 135);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(timerNameLabel);
            panel1.Controls.Add(timerLabel);
            panel1.Location = new Point(1084, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 165);
            panel1.TabIndex = 9;
            // 
            // timerNameLabel
            // 
            timerNameLabel.AutoSize = true;
            timerNameLabel.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            timerNameLabel.ForeColor = Color.FromArgb(1, 183, 99);
            timerNameLabel.Location = new Point(10, 16);
            timerNameLabel.Name = "timerNameLabel";
            timerNameLabel.Size = new Size(143, 33);
            timerNameLabel.TabIndex = 9;
            timerNameLabel.Text = "Loading...";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.FromArgb(1, 183, 99);
            timerLabel.Location = new Point(10, 96);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(143, 33);
            timerLabel.TabIndex = 8;
            timerLabel.Text = "Loading...";
            // 
            // slideShowPictureBox
            // 
            slideShowPictureBox.BackColor = Color.White;
            slideShowPictureBox.Location = new Point(25, 135);
            slideShowPictureBox.Margin = new Padding(3, 2, 3, 2);
            slideShowPictureBox.Name = "slideShowPictureBox";
            slideShowPictureBox.Size = new Size(1017, 656);
            slideShowPictureBox.TabIndex = 6;
            slideShowPictureBox.TabStop = false;
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
            newTripPanel.Controls.Add(expValueAddInput);
            newTripPanel.Controls.Add(memPhotoAddButtonSelect);
            newTripPanel.Controls.Add(label2);
            newTripPanel.Controls.Add(memNameAddInput);
            newTripPanel.Controls.Add(memPhotoAddInput);
            newTripPanel.Controls.Add(recomLandmarkAddButton);
            newTripPanel.Controls.Add(memNoteAddInput);
            newTripPanel.Controls.Add(segNameAddInput);
            newTripPanel.Controls.Add(memSongAddInput);
            newTripPanel.Controls.Add(expNameAddInput);
            newTripPanel.Controls.Add(restContactAddInput);
            newTripPanel.Controls.Add(restAddressAddInput);
            newTripPanel.Controls.Add(restCityAddInput);
            newTripPanel.Controls.Add(restCountryAddInput);
            newTripPanel.Controls.Add(restNameAddInput);
            newTripPanel.Controls.Add(landDescAddInput);
            newTripPanel.Controls.Add(landAddressAddInput);
            newTripPanel.Controls.Add(landCityAddInput);
            newTripPanel.Controls.Add(landCountryAddInput);
            newTripPanel.Controls.Add(landNameAddInput);
            newTripPanel.Controls.Add(restCampingAddRadioButton);
            newTripPanel.Controls.Add(restApartmentAddRadioButton);
            newTripPanel.Controls.Add(restRoomAddRadioButton);
            newTripPanel.Controls.Add(restHostelAddRadioButton);
            newTripPanel.Controls.Add(restHotelAddRadioButton);
            newTripPanel.Controls.Add(restTypeLabel);
            newTripPanel.Controls.Add(restContactLabel);
            newTripPanel.Controls.Add(restAddressLabel);
            newTripPanel.Controls.Add(restCityLabel);
            newTripPanel.Controls.Add(restCountryLabel);
            newTripPanel.Controls.Add(restNameLabel);
            newTripPanel.Controls.Add(memNoteLabel);
            newTripPanel.Controls.Add(memSongLabel);
            newTripPanel.Controls.Add(memPhotoLabel);
            newTripPanel.Controls.Add(expValueLabel);
            newTripPanel.Controls.Add(expNameLabel);
            newTripPanel.Controls.Add(landDescLabel);
            newTripPanel.Controls.Add(landAddressLabel);
            newTripPanel.Controls.Add(landCityLabel);
            newTripPanel.Controls.Add(landCountryLabel);
            newTripPanel.Controls.Add(landNameLabel);
            newTripPanel.Controls.Add(segNameLabel);
            newTripPanel.Controls.Add(landUpdateAddButton);
            newTripPanel.Controls.Add(landAddAddButton);
            newTripPanel.Controls.Add(landRemoveAddButton);
            newTripPanel.Controls.Add(restUpdateAddButton);
            newTripPanel.Controls.Add(restAddAddButton);
            newTripPanel.Controls.Add(restRemoveAddButton);
            newTripPanel.Controls.Add(expUpdateAddButton);
            newTripPanel.Controls.Add(expAddAddButton);
            newTripPanel.Controls.Add(expRemoveAddButton);
            newTripPanel.Controls.Add(memUpdateAddButton);
            newTripPanel.Controls.Add(memAddAddButton);
            newTripPanel.Controls.Add(memRemoveAddButton);
            newTripPanel.Controls.Add(segUpdateAddButton);
            newTripPanel.Controls.Add(segAddAddButton);
            newTripPanel.Controls.Add(segRemoveAddButton);
            newTripPanel.Controls.Add(saveAddTripButton);
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
            newTripPanel.Controls.Add(tripNameAddInput);
            newTripPanel.Controls.Add(nameLabel);
            newTripPanel.Controls.Add(returnFromAddButton);
            newTripPanel.Dock = DockStyle.Fill;
            newTripPanel.Location = new Point(0, 0);
            newTripPanel.Margin = new Padding(3, 2, 3, 2);
            newTripPanel.Name = "newTripPanel";
            newTripPanel.Size = new Size(1605, 981);
            newTripPanel.TabIndex = 0;
            newTripPanel.Visible = false;
            // 
            // expValueAddInput
            // 
            expValueAddInput.Location = new Point(892, 770);
            expValueAddInput.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            expValueAddInput.Name = "expValueAddInput";
            expValueAddInput.Size = new Size(292, 23);
            expValueAddInput.TabIndex = 96;
            // 
            // memPhotoAddButtonSelect
            // 
            memPhotoAddButtonSelect.Location = new Point(1520, 795);
            memPhotoAddButtonSelect.Name = "memPhotoAddButtonSelect";
            memPhotoAddButtonSelect.Size = new Size(58, 23);
            memPhotoAddButtonSelect.TabIndex = 91;
            memPhotoAddButtonSelect.Text = "Select...";
            memPhotoAddButtonSelect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1237, 770);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 90;
            label2.Text = "Name";
            // 
            // memNameAddInput
            // 
            memNameAddInput.Location = new Point(1286, 766);
            memNameAddInput.Name = "memNameAddInput";
            memNameAddInput.Size = new Size(292, 23);
            memNameAddInput.TabIndex = 89;
            // 
            // memPhotoAddInput
            // 
            memPhotoAddInput.Location = new Point(1286, 795);
            memPhotoAddInput.Name = "memPhotoAddInput";
            memPhotoAddInput.Size = new Size(292, 23);
            memPhotoAddInput.TabIndex = 88;
            // 
            // recomLandmarkAddButton
            // 
            recomLandmarkAddButton.BackColor = Color.FromArgb(1, 183, 99);
            recomLandmarkAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            recomLandmarkAddButton.ForeColor = SystemColors.ControlLightLight;
            recomLandmarkAddButton.Location = new Point(116, 895);
            recomLandmarkAddButton.Name = "recomLandmarkAddButton";
            recomLandmarkAddButton.Size = new Size(282, 36);
            recomLandmarkAddButton.TabIndex = 87;
            recomLandmarkAddButton.Text = "Recommended landmarks";
            recomLandmarkAddButton.UseVisualStyleBackColor = false;
            recomLandmarkAddButton.Click += recomLandmarkAddButton_Click;
            // 
            // memNoteAddInput
            // 
            memNoteAddInput.Location = new Point(1286, 853);
            memNoteAddInput.Name = "memNoteAddInput";
            memNoteAddInput.Size = new Size(292, 75);
            memNoteAddInput.TabIndex = 86;
            memNoteAddInput.Text = "";
            // 
            // segNameAddInput
            // 
            segNameAddInput.Location = new Point(874, 203);
            segNameAddInput.Name = "segNameAddInput";
            segNameAddInput.Size = new Size(715, 23);
            segNameAddInput.TabIndex = 84;
            // 
            // memSongAddInput
            // 
            memSongAddInput.Location = new Point(1286, 824);
            memSongAddInput.Name = "memSongAddInput";
            memSongAddInput.Size = new Size(292, 23);
            memSongAddInput.TabIndex = 82;
            // 
            // expNameAddInput
            // 
            expNameAddInput.Location = new Point(892, 739);
            expNameAddInput.Name = "expNameAddInput";
            expNameAddInput.Size = new Size(292, 23);
            expNameAddInput.TabIndex = 80;
            // 
            // restContactAddInput
            // 
            restContactAddInput.Location = new Point(497, 854);
            restContactAddInput.Name = "restContactAddInput";
            restContactAddInput.Size = new Size(292, 23);
            restContactAddInput.TabIndex = 79;
            // 
            // restAddressAddInput
            // 
            restAddressAddInput.Location = new Point(497, 825);
            restAddressAddInput.Name = "restAddressAddInput";
            restAddressAddInput.Size = new Size(292, 23);
            restAddressAddInput.TabIndex = 78;
            // 
            // restCityAddInput
            // 
            restCityAddInput.Location = new Point(497, 796);
            restCityAddInput.Name = "restCityAddInput";
            restCityAddInput.Size = new Size(292, 23);
            restCityAddInput.TabIndex = 77;
            // 
            // restCountryAddInput
            // 
            restCountryAddInput.Location = new Point(497, 768);
            restCountryAddInput.Name = "restCountryAddInput";
            restCountryAddInput.Size = new Size(292, 23);
            restCountryAddInput.TabIndex = 76;
            // 
            // restNameAddInput
            // 
            restNameAddInput.Location = new Point(497, 739);
            restNameAddInput.Name = "restNameAddInput";
            restNameAddInput.Size = new Size(292, 23);
            restNameAddInput.TabIndex = 75;
            // 
            // landDescAddInput
            // 
            landDescAddInput.Location = new Point(96, 856);
            landDescAddInput.Name = "landDescAddInput";
            landDescAddInput.Size = new Size(292, 23);
            landDescAddInput.TabIndex = 74;
            // 
            // landAddressAddInput
            // 
            landAddressAddInput.Location = new Point(96, 827);
            landAddressAddInput.Name = "landAddressAddInput";
            landAddressAddInput.Size = new Size(292, 23);
            landAddressAddInput.TabIndex = 73;
            // 
            // landCityAddInput
            // 
            landCityAddInput.Location = new Point(96, 798);
            landCityAddInput.Name = "landCityAddInput";
            landCityAddInput.Size = new Size(292, 23);
            landCityAddInput.TabIndex = 72;
            // 
            // landCountryAddInput
            // 
            landCountryAddInput.Location = new Point(96, 769);
            landCountryAddInput.Name = "landCountryAddInput";
            landCountryAddInput.Size = new Size(292, 23);
            landCountryAddInput.TabIndex = 71;
            // 
            // landNameAddInput
            // 
            landNameAddInput.Location = new Point(96, 739);
            landNameAddInput.Name = "landNameAddInput";
            landNameAddInput.Size = new Size(292, 23);
            landNameAddInput.TabIndex = 70;
            // 
            // restCampingAddRadioButton
            // 
            restCampingAddRadioButton.AutoSize = true;
            restCampingAddRadioButton.BackColor = Color.White;
            restCampingAddRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restCampingAddRadioButton.Location = new Point(565, 909);
            restCampingAddRadioButton.Name = "restCampingAddRadioButton";
            restCampingAddRadioButton.Size = new Size(81, 20);
            restCampingAddRadioButton.TabIndex = 69;
            restCampingAddRadioButton.TabStop = true;
            restCampingAddRadioButton.Text = "Camping";
            restCampingAddRadioButton.UseVisualStyleBackColor = false;
            // 
            // restApartmentAddRadioButton
            // 
            restApartmentAddRadioButton.AutoSize = true;
            restApartmentAddRadioButton.BackColor = Color.White;
            restApartmentAddRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restApartmentAddRadioButton.Location = new Point(642, 884);
            restApartmentAddRadioButton.Name = "restApartmentAddRadioButton";
            restApartmentAddRadioButton.Size = new Size(90, 20);
            restApartmentAddRadioButton.TabIndex = 68;
            restApartmentAddRadioButton.TabStop = true;
            restApartmentAddRadioButton.Text = "Apartment";
            restApartmentAddRadioButton.UseVisualStyleBackColor = false;
            // 
            // restRoomAddRadioButton
            // 
            restRoomAddRadioButton.AutoSize = true;
            restRoomAddRadioButton.BackColor = Color.White;
            restRoomAddRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restRoomAddRadioButton.Location = new Point(497, 909);
            restRoomAddRadioButton.Name = "restRoomAddRadioButton";
            restRoomAddRadioButton.Size = new Size(62, 20);
            restRoomAddRadioButton.TabIndex = 67;
            restRoomAddRadioButton.TabStop = true;
            restRoomAddRadioButton.Text = "Room";
            restRoomAddRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHostelAddRadioButton
            // 
            restHostelAddRadioButton.AutoSize = true;
            restHostelAddRadioButton.BackColor = Color.White;
            restHostelAddRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHostelAddRadioButton.Location = new Point(565, 884);
            restHostelAddRadioButton.Name = "restHostelAddRadioButton";
            restHostelAddRadioButton.Size = new Size(64, 20);
            restHostelAddRadioButton.TabIndex = 66;
            restHostelAddRadioButton.TabStop = true;
            restHostelAddRadioButton.Text = "Hostel";
            restHostelAddRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHotelAddRadioButton
            // 
            restHotelAddRadioButton.AutoSize = true;
            restHotelAddRadioButton.BackColor = Color.White;
            restHotelAddRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHotelAddRadioButton.Location = new Point(497, 884);
            restHotelAddRadioButton.Name = "restHotelAddRadioButton";
            restHotelAddRadioButton.Size = new Size(57, 20);
            restHotelAddRadioButton.TabIndex = 65;
            restHotelAddRadioButton.TabStop = true;
            restHotelAddRadioButton.Text = "Hotel";
            restHotelAddRadioButton.UseVisualStyleBackColor = false;
            // 
            // restTypeLabel
            // 
            restTypeLabel.AutoSize = true;
            restTypeLabel.BackColor = SystemColors.ControlLightLight;
            restTypeLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restTypeLabel.Location = new Point(453, 884);
            restTypeLabel.Name = "restTypeLabel";
            restTypeLabel.Size = new Size(38, 16);
            restTypeLabel.TabIndex = 64;
            restTypeLabel.Text = "Type";
            // 
            // restContactLabel
            // 
            restContactLabel.AutoSize = true;
            restContactLabel.BackColor = SystemColors.ControlLightLight;
            restContactLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restContactLabel.Location = new Point(410, 858);
            restContactLabel.Name = "restContactLabel";
            restContactLabel.Size = new Size(83, 16);
            restContactLabel.TabIndex = 63;
            restContactLabel.Text = "Contact info";
            // 
            // restAddressLabel
            // 
            restAddressLabel.AutoSize = true;
            restAddressLabel.BackColor = SystemColors.ControlLightLight;
            restAddressLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restAddressLabel.Location = new Point(434, 834);
            restAddressLabel.Name = "restAddressLabel";
            restAddressLabel.Size = new Size(59, 16);
            restAddressLabel.TabIndex = 62;
            restAddressLabel.Text = "Address";
            // 
            // restCityLabel
            // 
            restCityLabel.AutoSize = true;
            restCityLabel.BackColor = SystemColors.ControlLightLight;
            restCityLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restCityLabel.Location = new Point(460, 805);
            restCityLabel.Name = "restCityLabel";
            restCityLabel.Size = new Size(31, 16);
            restCityLabel.TabIndex = 61;
            restCityLabel.Text = "City";
            // 
            // restCountryLabel
            // 
            restCountryLabel.AutoSize = true;
            restCountryLabel.BackColor = SystemColors.ControlLightLight;
            restCountryLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restCountryLabel.Location = new Point(434, 776);
            restCountryLabel.Name = "restCountryLabel";
            restCountryLabel.Size = new Size(57, 16);
            restCountryLabel.TabIndex = 60;
            restCountryLabel.Text = "Country";
            // 
            // restNameLabel
            // 
            restNameLabel.AutoSize = true;
            restNameLabel.BackColor = SystemColors.ControlLightLight;
            restNameLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restNameLabel.Location = new Point(448, 746);
            restNameLabel.Name = "restNameLabel";
            restNameLabel.Size = new Size(43, 16);
            restNameLabel.TabIndex = 59;
            restNameLabel.Text = "Name";
            // 
            // memNoteLabel
            // 
            memNoteLabel.AutoSize = true;
            memNoteLabel.BackColor = SystemColors.ControlLightLight;
            memNoteLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memNoteLabel.Location = new Point(1244, 853);
            memNoteLabel.Name = "memNoteLabel";
            memNoteLabel.Size = new Size(36, 16);
            memNoteLabel.TabIndex = 58;
            memNoteLabel.Text = "Note";
            // 
            // memSongLabel
            // 
            memSongLabel.AutoSize = true;
            memSongLabel.BackColor = SystemColors.ControlLightLight;
            memSongLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memSongLabel.Location = new Point(1240, 827);
            memSongLabel.Name = "memSongLabel";
            memSongLabel.Size = new Size(40, 16);
            memSongLabel.TabIndex = 57;
            memSongLabel.Text = "Song";
            // 
            // memPhotoLabel
            // 
            memPhotoLabel.AutoSize = true;
            memPhotoLabel.BackColor = SystemColors.ControlLightLight;
            memPhotoLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memPhotoLabel.Location = new Point(1236, 800);
            memPhotoLabel.Name = "memPhotoLabel";
            memPhotoLabel.Size = new Size(44, 16);
            memPhotoLabel.TabIndex = 56;
            memPhotoLabel.Text = "Photo";
            // 
            // expValueLabel
            // 
            expValueLabel.AutoSize = true;
            expValueLabel.BackColor = SystemColors.ControlLightLight;
            expValueLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expValueLabel.Location = new Point(844, 769);
            expValueLabel.Name = "expValueLabel";
            expValueLabel.Size = new Size(42, 16);
            expValueLabel.TabIndex = 55;
            expValueLabel.Text = "Value";
            // 
            // expNameLabel
            // 
            expNameLabel.AutoSize = true;
            expNameLabel.BackColor = SystemColors.ControlLightLight;
            expNameLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expNameLabel.Location = new Point(843, 741);
            expNameLabel.Name = "expNameLabel";
            expNameLabel.Size = new Size(43, 16);
            expNameLabel.TabIndex = 54;
            expNameLabel.Text = "Name";
            // 
            // landDescLabel
            // 
            landDescLabel.AutoSize = true;
            landDescLabel.BackColor = SystemColors.ControlLightLight;
            landDescLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landDescLabel.Location = new Point(12, 858);
            landDescLabel.Name = "landDescLabel";
            landDescLabel.Size = new Size(78, 16);
            landDescLabel.TabIndex = 53;
            landDescLabel.Text = "Description";
            // 
            // landAddressLabel
            // 
            landAddressLabel.AutoSize = true;
            landAddressLabel.BackColor = SystemColors.ControlLightLight;
            landAddressLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landAddressLabel.Location = new Point(31, 834);
            landAddressLabel.Name = "landAddressLabel";
            landAddressLabel.Size = new Size(59, 16);
            landAddressLabel.TabIndex = 52;
            landAddressLabel.Text = "Address";
            // 
            // landCityLabel
            // 
            landCityLabel.AutoSize = true;
            landCityLabel.BackColor = SystemColors.ControlLightLight;
            landCityLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landCityLabel.Location = new Point(59, 805);
            landCityLabel.Name = "landCityLabel";
            landCityLabel.Size = new Size(31, 16);
            landCityLabel.TabIndex = 51;
            landCityLabel.Text = "City";
            // 
            // landCountryLabel
            // 
            landCountryLabel.AutoSize = true;
            landCountryLabel.BackColor = SystemColors.ControlLightLight;
            landCountryLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landCountryLabel.Location = new Point(33, 776);
            landCountryLabel.Name = "landCountryLabel";
            landCountryLabel.Size = new Size(57, 16);
            landCountryLabel.TabIndex = 50;
            landCountryLabel.Text = "Country";
            // 
            // landNameLabel
            // 
            landNameLabel.AutoSize = true;
            landNameLabel.BackColor = SystemColors.ControlLightLight;
            landNameLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landNameLabel.Location = new Point(47, 746);
            landNameLabel.Name = "landNameLabel";
            landNameLabel.Size = new Size(43, 16);
            landNameLabel.TabIndex = 49;
            landNameLabel.Text = "Name";
            // 
            // segNameLabel
            // 
            segNameLabel.AutoSize = true;
            segNameLabel.BackColor = SystemColors.ControlLightLight;
            segNameLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segNameLabel.Location = new Point(825, 205);
            segNameLabel.Name = "segNameLabel";
            segNameLabel.Size = new Size(43, 16);
            segNameLabel.TabIndex = 48;
            segNameLabel.Text = "Name";
            // 
            // landUpdateAddButton
            // 
            landUpdateAddButton.BackColor = Color.FromArgb(1, 183, 99);
            landUpdateAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landUpdateAddButton.ForeColor = SystemColors.ControlLightLight;
            landUpdateAddButton.Location = new Point(212, 937);
            landUpdateAddButton.Name = "landUpdateAddButton";
            landUpdateAddButton.Size = new Size(90, 36);
            landUpdateAddButton.TabIndex = 47;
            landUpdateAddButton.Text = "Update";
            landUpdateAddButton.UseVisualStyleBackColor = false;
            landUpdateAddButton.Click += landUpdateAddButton_Click;
            // 
            // landAddAddButton
            // 
            landAddAddButton.BackColor = Color.FromArgb(1, 183, 99);
            landAddAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landAddAddButton.ForeColor = SystemColors.ControlLightLight;
            landAddAddButton.Location = new Point(308, 937);
            landAddAddButton.Name = "landAddAddButton";
            landAddAddButton.Size = new Size(90, 36);
            landAddAddButton.TabIndex = 46;
            landAddAddButton.Text = "Add";
            landAddAddButton.UseVisualStyleBackColor = false;
            landAddAddButton.Click += landAddAddButton_Click;
            // 
            // landRemoveAddButton
            // 
            landRemoveAddButton.BackColor = Color.FromArgb(1, 183, 99);
            landRemoveAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landRemoveAddButton.ForeColor = SystemColors.ControlLightLight;
            landRemoveAddButton.Location = new Point(116, 937);
            landRemoveAddButton.Name = "landRemoveAddButton";
            landRemoveAddButton.Size = new Size(90, 36);
            landRemoveAddButton.TabIndex = 45;
            landRemoveAddButton.Text = "Remove";
            landRemoveAddButton.UseVisualStyleBackColor = false;
            landRemoveAddButton.Click += landRemoveAddButton_Click;
            // 
            // restUpdateAddButton
            // 
            restUpdateAddButton.BackColor = Color.FromArgb(1, 183, 99);
            restUpdateAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restUpdateAddButton.ForeColor = SystemColors.ControlLightLight;
            restUpdateAddButton.Location = new Point(610, 935);
            restUpdateAddButton.Name = "restUpdateAddButton";
            restUpdateAddButton.Size = new Size(90, 36);
            restUpdateAddButton.TabIndex = 44;
            restUpdateAddButton.Text = "Update";
            restUpdateAddButton.UseVisualStyleBackColor = false;
            restUpdateAddButton.Click += restUpdateAddButton_Click;
            // 
            // restAddAddButton
            // 
            restAddAddButton.BackColor = Color.FromArgb(1, 183, 99);
            restAddAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restAddAddButton.ForeColor = SystemColors.ControlLightLight;
            restAddAddButton.Location = new Point(706, 935);
            restAddAddButton.Name = "restAddAddButton";
            restAddAddButton.Size = new Size(90, 36);
            restAddAddButton.TabIndex = 43;
            restAddAddButton.Text = "Add";
            restAddAddButton.UseVisualStyleBackColor = false;
            restAddAddButton.Click += restAddAddButton_Click;
            // 
            // restRemoveAddButton
            // 
            restRemoveAddButton.BackColor = Color.FromArgb(1, 183, 99);
            restRemoveAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restRemoveAddButton.ForeColor = SystemColors.ControlLightLight;
            restRemoveAddButton.Location = new Point(514, 935);
            restRemoveAddButton.Name = "restRemoveAddButton";
            restRemoveAddButton.Size = new Size(90, 36);
            restRemoveAddButton.TabIndex = 42;
            restRemoveAddButton.Text = "Remove";
            restRemoveAddButton.UseVisualStyleBackColor = false;
            restRemoveAddButton.Click += restRemoveAddButton_Click;
            // 
            // expUpdateAddButton
            // 
            expUpdateAddButton.BackColor = Color.FromArgb(1, 183, 99);
            expUpdateAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expUpdateAddButton.ForeColor = SystemColors.ControlLightLight;
            expUpdateAddButton.Location = new Point(1008, 934);
            expUpdateAddButton.Name = "expUpdateAddButton";
            expUpdateAddButton.Size = new Size(90, 36);
            expUpdateAddButton.TabIndex = 41;
            expUpdateAddButton.Text = "Update";
            expUpdateAddButton.UseVisualStyleBackColor = false;
            expUpdateAddButton.Click += expUpdateAddButton_Click;
            // 
            // expAddAddButton
            // 
            expAddAddButton.BackColor = Color.FromArgb(1, 183, 99);
            expAddAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expAddAddButton.ForeColor = SystemColors.ControlLightLight;
            expAddAddButton.Location = new Point(1104, 934);
            expAddAddButton.Name = "expAddAddButton";
            expAddAddButton.Size = new Size(90, 36);
            expAddAddButton.TabIndex = 40;
            expAddAddButton.Text = "Add";
            expAddAddButton.UseVisualStyleBackColor = false;
            expAddAddButton.Click += expAddAddButton_Click;
            // 
            // expRemoveAddButton
            // 
            expRemoveAddButton.BackColor = Color.FromArgb(1, 183, 99);
            expRemoveAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expRemoveAddButton.ForeColor = SystemColors.ControlLightLight;
            expRemoveAddButton.Location = new Point(912, 934);
            expRemoveAddButton.Name = "expRemoveAddButton";
            expRemoveAddButton.Size = new Size(90, 36);
            expRemoveAddButton.TabIndex = 39;
            expRemoveAddButton.Text = "Remove";
            expRemoveAddButton.UseVisualStyleBackColor = false;
            expRemoveAddButton.Click += expRemoveAddButton_Click;
            // 
            // memUpdateAddButton
            // 
            memUpdateAddButton.BackColor = Color.FromArgb(1, 183, 99);
            memUpdateAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memUpdateAddButton.ForeColor = SystemColors.ControlLightLight;
            memUpdateAddButton.Location = new Point(1412, 934);
            memUpdateAddButton.Name = "memUpdateAddButton";
            memUpdateAddButton.Size = new Size(90, 36);
            memUpdateAddButton.TabIndex = 38;
            memUpdateAddButton.Text = "Update";
            memUpdateAddButton.UseVisualStyleBackColor = false;
            memUpdateAddButton.Click += memUpdateAddButton_Click;
            // 
            // memAddAddButton
            // 
            memAddAddButton.BackColor = Color.FromArgb(1, 183, 99);
            memAddAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memAddAddButton.ForeColor = SystemColors.ControlLightLight;
            memAddAddButton.Location = new Point(1508, 934);
            memAddAddButton.Name = "memAddAddButton";
            memAddAddButton.Size = new Size(90, 36);
            memAddAddButton.TabIndex = 37;
            memAddAddButton.Text = "Add";
            memAddAddButton.UseVisualStyleBackColor = false;
            memAddAddButton.Click += memAddAddButton_Click;
            // 
            // memRemoveAddButton
            // 
            memRemoveAddButton.BackColor = Color.FromArgb(1, 183, 99);
            memRemoveAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memRemoveAddButton.ForeColor = SystemColors.ControlLightLight;
            memRemoveAddButton.Location = new Point(1316, 934);
            memRemoveAddButton.Name = "memRemoveAddButton";
            memRemoveAddButton.Size = new Size(90, 36);
            memRemoveAddButton.TabIndex = 36;
            memRemoveAddButton.Text = "Remove";
            memRemoveAddButton.UseVisualStyleBackColor = false;
            memRemoveAddButton.Click += memRemoveAddButton_Click;
            // 
            // segUpdateAddButton
            // 
            segUpdateAddButton.BackColor = Color.FromArgb(1, 183, 99);
            segUpdateAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segUpdateAddButton.ForeColor = SystemColors.ControlLightLight;
            segUpdateAddButton.Location = new Point(1404, 377);
            segUpdateAddButton.Name = "segUpdateAddButton";
            segUpdateAddButton.Size = new Size(90, 36);
            segUpdateAddButton.TabIndex = 35;
            segUpdateAddButton.Text = "Update";
            segUpdateAddButton.UseVisualStyleBackColor = false;
            segUpdateAddButton.Click += segUpdateAddButton_Click;
            // 
            // segAddAddButton
            // 
            segAddAddButton.BackColor = Color.FromArgb(1, 183, 99);
            segAddAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segAddAddButton.ForeColor = SystemColors.ControlLightLight;
            segAddAddButton.Location = new Point(1500, 377);
            segAddAddButton.Name = "segAddAddButton";
            segAddAddButton.Size = new Size(90, 36);
            segAddAddButton.TabIndex = 34;
            segAddAddButton.Text = "Add";
            segAddAddButton.UseVisualStyleBackColor = false;
            segAddAddButton.Click += segAddAddButton_Click;
            // 
            // segRemoveAddButton
            // 
            segRemoveAddButton.BackColor = Color.FromArgb(1, 183, 99);
            segRemoveAddButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segRemoveAddButton.ForeColor = SystemColors.ControlLightLight;
            segRemoveAddButton.Location = new Point(1308, 377);
            segRemoveAddButton.Name = "segRemoveAddButton";
            segRemoveAddButton.Size = new Size(90, 36);
            segRemoveAddButton.TabIndex = 33;
            segRemoveAddButton.Text = "Remove";
            segRemoveAddButton.UseVisualStyleBackColor = false;
            segRemoveAddButton.Click += segRemoveAddButton_Click;
            // 
            // saveAddTripButton
            // 
            saveAddTripButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            saveAddTripButton.ForeColor = Color.FromArgb(1, 183, 99);
            saveAddTripButton.Location = new Point(51, 1);
            saveAddTripButton.Name = "saveAddTripButton";
            saveAddTripButton.Size = new Size(48, 52);
            saveAddTripButton.TabIndex = 32;
            saveAddTripButton.Text = "💾";
            saveAddTripButton.UseVisualStyleBackColor = true;
            saveAddTripButton.Click += saveAddTripButton_Click;
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
            newRestngPointList.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newRestngPointList.Location = new Point(407, 733);
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
            memoriesList.Activation = ItemActivation.OneClick;
            memoriesList.Columns.AddRange(new ColumnHeader[] { idAddMemory, nameMemoryAdd });
            memoriesList.FullRowSelect = true;
            memoriesList.Location = new Point(1203, 461);
            memoriesList.Name = "memoriesList";
            memoriesList.Size = new Size(398, 224);
            memoriesList.TabIndex = 17;
            memoriesList.UseCompatibleStateImageBehavior = false;
            memoriesList.View = System.Windows.Forms.View.Details;
            // 
            // idAddMemory
            // 
            idAddMemory.Width = 0;
            // 
            // nameMemoryAdd
            // 
            nameMemoryAdd.Text = "Name";
            nameMemoryAdd.Width = 400;
            // 
            // expensesList
            // 
            expensesList.Activation = ItemActivation.OneClick;
            expensesList.Columns.AddRange(new ColumnHeader[] { idAddExpense, nameExpenseAdd });
            expensesList.FullRowSelect = true;
            expensesList.Location = new Point(805, 461);
            expensesList.Name = "expensesList";
            expensesList.Size = new Size(393, 224);
            expensesList.TabIndex = 16;
            expensesList.UseCompatibleStateImageBehavior = false;
            expensesList.View = System.Windows.Forms.View.Details;
            // 
            // idAddExpense
            // 
            idAddExpense.Width = 0;
            // 
            // nameExpenseAdd
            // 
            nameExpenseAdd.Text = "Name";
            nameExpenseAdd.Width = 400;
            // 
            // restingPointsList
            // 
            restingPointsList.Activation = ItemActivation.OneClick;
            restingPointsList.Columns.AddRange(new ColumnHeader[] { idAddRestingPoint, nameAddRestingPoint });
            restingPointsList.FullRowSelect = true;
            restingPointsList.Location = new Point(407, 461);
            restingPointsList.Name = "restingPointsList";
            restingPointsList.Size = new Size(392, 225);
            restingPointsList.TabIndex = 15;
            restingPointsList.UseCompatibleStateImageBehavior = false;
            restingPointsList.View = System.Windows.Forms.View.Details;
            // 
            // idAddRestingPoint
            // 
            idAddRestingPoint.Width = 0;
            // 
            // nameAddRestingPoint
            // 
            nameAddRestingPoint.Text = "Name";
            nameAddRestingPoint.Width = 400;
            // 
            // landmarksList
            // 
            landmarksList.Activation = ItemActivation.OneClick;
            landmarksList.Columns.AddRange(new ColumnHeader[] { idAddLand, nameLandAdd });
            landmarksList.FullRowSelect = true;
            landmarksList.Location = new Point(0, 461);
            landmarksList.Name = "landmarksList";
            landmarksList.Size = new Size(401, 225);
            landmarksList.TabIndex = 14;
            landmarksList.UseCompatibleStateImageBehavior = false;
            landmarksList.View = System.Windows.Forms.View.Details;
            // 
            // idAddLand
            // 
            idAddLand.Width = 0;
            // 
            // nameLandAdd
            // 
            nameLandAdd.Text = "Name";
            nameLandAdd.Width = 401;
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
            segmentsList.Activation = ItemActivation.OneClick;
            segmentsList.Columns.AddRange(new ColumnHeader[] { idAddSegment, nameAddSegment });
            segmentsList.FullRowSelect = true;
            segmentsList.Location = new Point(0, 166);
            segmentsList.Name = "segmentsList";
            segmentsList.Size = new Size(799, 250);
            segmentsList.TabIndex = 95;
            segmentsList.UseCompatibleStateImageBehavior = false;
            segmentsList.View = System.Windows.Forms.View.Details;
            // 
            // idAddSegment
            // 
            idAddSegment.Width = 0;
            // 
            // nameAddSegment
            // 
            nameAddSegment.Text = "Name";
            nameAddSegment.Width = 795;
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
            depDateLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            depDateLabel.Location = new Point(986, 84);
            depDateLabel.Name = "depDateLabel";
            depDateLabel.Size = new Size(101, 16);
            depDateLabel.TabIndex = 3;
            depDateLabel.Text = "Date of the trip";
            // 
            // tripNameAddInput
            // 
            tripNameAddInput.Location = new Point(154, 79);
            tripNameAddInput.Margin = new Padding(3, 2, 3, 2);
            tripNameAddInput.Name = "tripNameAddInput";
            tripNameAddInput.Size = new Size(438, 23);
            tripNameAddInput.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(41, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(107, 16);
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
            // inspectTripPanel
            // 
            inspectTripPanel.BackColor = Color.FromArgb(246, 246, 246);
            inspectTripPanel.Controls.Add(createSlideShowButton);
            inspectTripPanel.Controls.Add(memNoteTextBox);
            inspectTripPanel.Controls.Add(memDetailsPhotoPictureBox);
            inspectTripPanel.Controls.Add(segNameTextBox);
            inspectTripPanel.Controls.Add(memSongTextBos);
            inspectTripPanel.Controls.Add(expValueTextBox);
            inspectTripPanel.Controls.Add(expNameTextBox);
            inspectTripPanel.Controls.Add(restContactTextBox);
            inspectTripPanel.Controls.Add(restAddressTextBox);
            inspectTripPanel.Controls.Add(restCityTextBox);
            inspectTripPanel.Controls.Add(restCountryTextBox);
            inspectTripPanel.Controls.Add(restNameTextBox);
            inspectTripPanel.Controls.Add(landDescTextBox);
            inspectTripPanel.Controls.Add(landAddressTextBox);
            inspectTripPanel.Controls.Add(landCityTextBox);
            inspectTripPanel.Controls.Add(landCountryTextBox);
            inspectTripPanel.Controls.Add(landNameTextBox);
            inspectTripPanel.Controls.Add(restCampingDetailsRadioButton);
            inspectTripPanel.Controls.Add(restApartmentDetailsRadioButton);
            inspectTripPanel.Controls.Add(restRoomDetailsRadioButton);
            inspectTripPanel.Controls.Add(restHostelDetailsRadioButton);
            inspectTripPanel.Controls.Add(restHotelDetailsRadioButton);
            inspectTripPanel.Controls.Add(label4);
            inspectTripPanel.Controls.Add(label5);
            inspectTripPanel.Controls.Add(label6);
            inspectTripPanel.Controls.Add(label7);
            inspectTripPanel.Controls.Add(label8);
            inspectTripPanel.Controls.Add(label9);
            inspectTripPanel.Controls.Add(label10);
            inspectTripPanel.Controls.Add(label11);
            inspectTripPanel.Controls.Add(label12);
            inspectTripPanel.Controls.Add(label13);
            inspectTripPanel.Controls.Add(label14);
            inspectTripPanel.Controls.Add(label15);
            inspectTripPanel.Controls.Add(label16);
            inspectTripPanel.Controls.Add(label17);
            inspectTripPanel.Controls.Add(label18);
            inspectTripPanel.Controls.Add(label19);
            inspectTripPanel.Controls.Add(label20);
            inspectTripPanel.Controls.Add(editButton);
            inspectTripPanel.Controls.Add(label21);
            inspectTripPanel.Controls.Add(label22);
            inspectTripPanel.Controls.Add(label23);
            inspectTripPanel.Controls.Add(label24);
            inspectTripPanel.Controls.Add(label25);
            inspectTripPanel.Controls.Add(label26);
            inspectTripPanel.Controls.Add(label27);
            inspectTripPanel.Controls.Add(label28);
            inspectTripPanel.Controls.Add(label29);
            inspectTripPanel.Controls.Add(label30);
            inspectTripPanel.Controls.Add(listView1);
            inspectTripPanel.Controls.Add(listView2);
            inspectTripPanel.Controls.Add(listView3);
            inspectTripPanel.Controls.Add(listView4);
            inspectTripPanel.Controls.Add(memoriesListView);
            inspectTripPanel.Controls.Add(expensesListView);
            inspectTripPanel.Controls.Add(restingPointListView);
            inspectTripPanel.Controls.Add(landmarkListView);
            inspectTripPanel.Controls.Add(listView9);
            inspectTripPanel.Controls.Add(segmentsListView);
            inspectTripPanel.Controls.Add(label31);
            inspectTripPanel.Controls.Add(tripReturnDatePicker);
            inspectTripPanel.Controls.Add(tripDepartureDatePicker);
            inspectTripPanel.Controls.Add(label33);
            inspectTripPanel.Controls.Add(label34);
            inspectTripPanel.Controls.Add(returnFromInspectButton);
            inspectTripPanel.Controls.Add(label32);
            inspectTripPanel.Controls.Add(tripNameTextBox);
            inspectTripPanel.Dock = DockStyle.Fill;
            inspectTripPanel.Location = new Point(0, 0);
            inspectTripPanel.Margin = new Padding(3, 2, 3, 2);
            inspectTripPanel.Name = "inspectTripPanel";
            inspectTripPanel.Size = new Size(1605, 981);
            inspectTripPanel.TabIndex = 2;
            inspectTripPanel.Visible = false;
            // 
            // createSlideShowButton
            // 
            createSlideShowButton.BackColor = Color.FromArgb(1, 183, 99);
            createSlideShowButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createSlideShowButton.ForeColor = SystemColors.ControlLightLight;
            createSlideShowButton.Location = new Point(105, 0);
            createSlideShowButton.Name = "createSlideShowButton";
            createSlideShowButton.Size = new Size(209, 52);
            createSlideShowButton.TabIndex = 169;
            createSlideShowButton.Text = "Create Slide Show";
            createSlideShowButton.UseVisualStyleBackColor = false;
            createSlideShowButton.Click += button1_Click;
            // 
            // memNoteTextBox
            // 
            memNoteTextBox.Enabled = false;
            memNoteTextBox.Location = new Point(1286, 870);
            memNoteTextBox.Name = "memNoteTextBox";
            memNoteTextBox.Size = new Size(292, 91);
            memNoteTextBox.TabIndex = 168;
            memNoteTextBox.Text = "";
            // 
            // memDetailsPhotoPictureBox
            // 
            memDetailsPhotoPictureBox.Location = new Point(1286, 738);
            memDetailsPhotoPictureBox.Name = "memDetailsPhotoPictureBox";
            memDetailsPhotoPictureBox.Size = new Size(292, 93);
            memDetailsPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            memDetailsPhotoPictureBox.TabIndex = 167;
            memDetailsPhotoPictureBox.TabStop = false;
            // 
            // segNameTextBox
            // 
            segNameTextBox.Enabled = false;
            segNameTextBox.Location = new Point(874, 202);
            segNameTextBox.Name = "segNameTextBox";
            segNameTextBox.Size = new Size(715, 23);
            segNameTextBox.TabIndex = 166;
            // 
            // memSongTextBos
            // 
            memSongTextBos.Enabled = false;
            memSongTextBos.Location = new Point(1286, 839);
            memSongTextBos.Name = "memSongTextBos";
            memSongTextBos.Size = new Size(292, 23);
            memSongTextBos.TabIndex = 165;
            // 
            // expValueTextBox
            // 
            expValueTextBox.Enabled = false;
            expValueTextBox.Location = new Point(892, 767);
            expValueTextBox.Name = "expValueTextBox";
            expValueTextBox.Size = new Size(292, 23);
            expValueTextBox.TabIndex = 164;
            // 
            // expNameTextBox
            // 
            expNameTextBox.Enabled = false;
            expNameTextBox.Location = new Point(892, 738);
            expNameTextBox.Name = "expNameTextBox";
            expNameTextBox.Size = new Size(292, 23);
            expNameTextBox.TabIndex = 163;
            // 
            // restContactTextBox
            // 
            restContactTextBox.Enabled = false;
            restContactTextBox.Location = new Point(497, 853);
            restContactTextBox.Name = "restContactTextBox";
            restContactTextBox.Size = new Size(292, 23);
            restContactTextBox.TabIndex = 162;
            // 
            // restAddressTextBox
            // 
            restAddressTextBox.Enabled = false;
            restAddressTextBox.Location = new Point(497, 824);
            restAddressTextBox.Name = "restAddressTextBox";
            restAddressTextBox.Size = new Size(292, 23);
            restAddressTextBox.TabIndex = 161;
            // 
            // restCityTextBox
            // 
            restCityTextBox.Enabled = false;
            restCityTextBox.Location = new Point(497, 795);
            restCityTextBox.Name = "restCityTextBox";
            restCityTextBox.Size = new Size(292, 23);
            restCityTextBox.TabIndex = 160;
            // 
            // restCountryTextBox
            // 
            restCountryTextBox.Enabled = false;
            restCountryTextBox.Location = new Point(497, 767);
            restCountryTextBox.Name = "restCountryTextBox";
            restCountryTextBox.Size = new Size(292, 23);
            restCountryTextBox.TabIndex = 159;
            // 
            // restNameTextBox
            // 
            restNameTextBox.Enabled = false;
            restNameTextBox.Location = new Point(497, 738);
            restNameTextBox.Name = "restNameTextBox";
            restNameTextBox.Size = new Size(292, 23);
            restNameTextBox.TabIndex = 158;
            // 
            // landDescTextBox
            // 
            landDescTextBox.Enabled = false;
            landDescTextBox.Location = new Point(96, 855);
            landDescTextBox.Name = "landDescTextBox";
            landDescTextBox.Size = new Size(292, 23);
            landDescTextBox.TabIndex = 157;
            // 
            // landAddressTextBox
            // 
            landAddressTextBox.Enabled = false;
            landAddressTextBox.Location = new Point(96, 826);
            landAddressTextBox.Name = "landAddressTextBox";
            landAddressTextBox.Size = new Size(292, 23);
            landAddressTextBox.TabIndex = 156;
            // 
            // landCityTextBox
            // 
            landCityTextBox.Enabled = false;
            landCityTextBox.Location = new Point(96, 797);
            landCityTextBox.Name = "landCityTextBox";
            landCityTextBox.Size = new Size(292, 23);
            landCityTextBox.TabIndex = 155;
            // 
            // landCountryTextBox
            // 
            landCountryTextBox.Enabled = false;
            landCountryTextBox.Location = new Point(96, 768);
            landCountryTextBox.Name = "landCountryTextBox";
            landCountryTextBox.Size = new Size(292, 23);
            landCountryTextBox.TabIndex = 154;
            // 
            // landNameTextBox
            // 
            landNameTextBox.Enabled = false;
            landNameTextBox.Location = new Point(96, 738);
            landNameTextBox.Name = "landNameTextBox";
            landNameTextBox.Size = new Size(292, 23);
            landNameTextBox.TabIndex = 153;
            // 
            // restCampingDetailsRadioButton
            // 
            restCampingDetailsRadioButton.AutoSize = true;
            restCampingDetailsRadioButton.BackColor = Color.White;
            restCampingDetailsRadioButton.Enabled = false;
            restCampingDetailsRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restCampingDetailsRadioButton.Location = new Point(565, 908);
            restCampingDetailsRadioButton.Name = "restCampingDetailsRadioButton";
            restCampingDetailsRadioButton.Size = new Size(81, 20);
            restCampingDetailsRadioButton.TabIndex = 152;
            restCampingDetailsRadioButton.TabStop = true;
            restCampingDetailsRadioButton.Text = "Camping";
            restCampingDetailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // restApartmentDetailsRadioButton
            // 
            restApartmentDetailsRadioButton.AutoSize = true;
            restApartmentDetailsRadioButton.BackColor = Color.White;
            restApartmentDetailsRadioButton.Enabled = false;
            restApartmentDetailsRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restApartmentDetailsRadioButton.Location = new Point(642, 883);
            restApartmentDetailsRadioButton.Name = "restApartmentDetailsRadioButton";
            restApartmentDetailsRadioButton.Size = new Size(90, 20);
            restApartmentDetailsRadioButton.TabIndex = 151;
            restApartmentDetailsRadioButton.TabStop = true;
            restApartmentDetailsRadioButton.Text = "Apartment";
            restApartmentDetailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // restRoomDetailsRadioButton
            // 
            restRoomDetailsRadioButton.AutoSize = true;
            restRoomDetailsRadioButton.BackColor = Color.White;
            restRoomDetailsRadioButton.Enabled = false;
            restRoomDetailsRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restRoomDetailsRadioButton.Location = new Point(497, 908);
            restRoomDetailsRadioButton.Name = "restRoomDetailsRadioButton";
            restRoomDetailsRadioButton.Size = new Size(62, 20);
            restRoomDetailsRadioButton.TabIndex = 150;
            restRoomDetailsRadioButton.TabStop = true;
            restRoomDetailsRadioButton.Text = "Room";
            restRoomDetailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHostelDetailsRadioButton
            // 
            restHostelDetailsRadioButton.AutoSize = true;
            restHostelDetailsRadioButton.BackColor = Color.White;
            restHostelDetailsRadioButton.Enabled = false;
            restHostelDetailsRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHostelDetailsRadioButton.Location = new Point(565, 883);
            restHostelDetailsRadioButton.Name = "restHostelDetailsRadioButton";
            restHostelDetailsRadioButton.Size = new Size(64, 20);
            restHostelDetailsRadioButton.TabIndex = 149;
            restHostelDetailsRadioButton.TabStop = true;
            restHostelDetailsRadioButton.Text = "Hostel";
            restHostelDetailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHotelDetailsRadioButton
            // 
            restHotelDetailsRadioButton.AutoSize = true;
            restHotelDetailsRadioButton.BackColor = Color.White;
            restHotelDetailsRadioButton.Enabled = false;
            restHotelDetailsRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHotelDetailsRadioButton.Location = new Point(497, 883);
            restHotelDetailsRadioButton.Name = "restHotelDetailsRadioButton";
            restHotelDetailsRadioButton.Size = new Size(57, 20);
            restHotelDetailsRadioButton.TabIndex = 148;
            restHotelDetailsRadioButton.TabStop = true;
            restHotelDetailsRadioButton.Text = "Hotel";
            restHotelDetailsRadioButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(453, 883);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 147;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(410, 857);
            label5.Name = "label5";
            label5.Size = new Size(83, 16);
            label5.TabIndex = 146;
            label5.Text = "Contact info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(434, 833);
            label6.Name = "label6";
            label6.Size = new Size(59, 16);
            label6.TabIndex = 145;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(460, 804);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 144;
            label7.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(434, 775);
            label8.Name = "label8";
            label8.Size = new Size(57, 16);
            label8.TabIndex = 143;
            label8.Text = "Country";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(448, 745);
            label9.Name = "label9";
            label9.Size = new Size(43, 16);
            label9.TabIndex = 142;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLightLight;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1244, 870);
            label10.Name = "label10";
            label10.Size = new Size(36, 16);
            label10.TabIndex = 141;
            label10.Text = "Note";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlLightLight;
            label11.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1229, 841);
            label11.Name = "label11";
            label11.Size = new Size(51, 16);
            label11.TabIndex = 140;
            label11.Text = "Song/s";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLightLight;
            label12.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1225, 740);
            label12.Name = "label12";
            label12.Size = new Size(55, 16);
            label12.TabIndex = 139;
            label12.Text = "Photo/s";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlLightLight;
            label13.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(844, 768);
            label13.Name = "label13";
            label13.Size = new Size(42, 16);
            label13.TabIndex = 138;
            label13.Text = "Value";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLightLight;
            label14.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(843, 740);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 137;
            label14.Text = "Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ControlLightLight;
            label15.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(12, 857);
            label15.Name = "label15";
            label15.Size = new Size(78, 16);
            label15.TabIndex = 136;
            label15.Text = "Description";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlLightLight;
            label16.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(31, 833);
            label16.Name = "label16";
            label16.Size = new Size(59, 16);
            label16.TabIndex = 135;
            label16.Text = "Address";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ControlLightLight;
            label17.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(59, 804);
            label17.Name = "label17";
            label17.Size = new Size(31, 16);
            label17.TabIndex = 134;
            label17.Text = "City";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ControlLightLight;
            label18.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(33, 775);
            label18.Name = "label18";
            label18.Size = new Size(57, 16);
            label18.TabIndex = 133;
            label18.Text = "Country";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.ControlLightLight;
            label19.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(47, 745);
            label19.Name = "label19";
            label19.Size = new Size(43, 16);
            label19.TabIndex = 132;
            label19.Text = "Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.ControlLightLight;
            label20.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(825, 204);
            label20.Name = "label20";
            label20.Size = new Size(43, 16);
            label20.TabIndex = 131;
            label20.Text = "Name";
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.ForeColor = Color.FromArgb(1, 183, 99);
            editButton.Location = new Point(51, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(48, 52);
            editButton.TabIndex = 115;
            editButton.Text = "🖍";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(1, 183, 99);
            label21.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ControlLightLight;
            label21.Location = new Point(1203, 689);
            label21.Name = "label21";
            label21.Padding = new Padding(136, 10, 136, 10);
            label21.Size = new Size(399, 39);
            label21.TabIndex = 114;
            label21.Text = "Memory details";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(1, 183, 99);
            label22.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ControlLightLight;
            label22.Location = new Point(805, 689);
            label22.Name = "label22";
            label22.Padding = new Padding(132, 10, 130, 10);
            label22.Size = new Size(392, 39);
            label22.TabIndex = 113;
            label22.Text = "Expense details";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(1, 183, 99);
            label23.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ControlLightLight;
            label23.Location = new Point(408, 689);
            label23.Name = "label23";
            label23.Padding = new Padding(112, 10, 112, 10);
            label23.Size = new Size(391, 39);
            label23.TabIndex = 112;
            label23.Text = "Resting point details";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(1, 183, 99);
            label24.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ControlLightLight;
            label24.Location = new Point(-3, 689);
            label24.Name = "label24";
            label24.Padding = new Padding(132, 10, 132, 10);
            label24.Size = new Size(404, 39);
            label24.TabIndex = 111;
            label24.Text = "Landmark details";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(1, 183, 99);
            label25.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ControlLightLight;
            label25.Location = new Point(805, 124);
            label25.Margin = new Padding(10);
            label25.Name = "label25";
            label25.Padding = new Padding(362, 10, 362, 10);
            label25.Size = new Size(856, 39);
            label25.TabIndex = 110;
            label25.Text = "Segment details";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.FromArgb(127, 127, 127);
            label26.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ControlLightLight;
            label26.Location = new Point(1204, 418);
            label26.Name = "label26";
            label26.Padding = new Padding(158, 10, 158, 10);
            label26.Size = new Size(399, 39);
            label26.TabIndex = 109;
            label26.Text = "Memories";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.FromArgb(127, 127, 127);
            label27.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = SystemColors.ControlLightLight;
            label27.Location = new Point(805, 418);
            label27.Name = "label27";
            label27.Padding = new Padding(155, 10, 155, 10);
            label27.Size = new Size(392, 39);
            label27.TabIndex = 108;
            label27.Text = "Expenses";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.FromArgb(127, 127, 127);
            label28.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = SystemColors.ControlLightLight;
            label28.Location = new Point(407, 418);
            label28.Name = "label28";
            label28.Padding = new Padding(136, 10, 137, 10);
            label28.Size = new Size(392, 39);
            label28.TabIndex = 107;
            label28.Text = "Resting points";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.FromArgb(127, 127, 127);
            label29.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label29.ForeColor = SystemColors.ControlLightLight;
            label29.Location = new Point(-1, 418);
            label29.Name = "label29";
            label29.Padding = new Padding(155, 10, 155, 10);
            label29.Size = new Size(402, 39);
            label29.TabIndex = 106;
            label29.Text = "Landmarks";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.FromArgb(127, 127, 127);
            label30.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.ControlLightLight;
            label30.Location = new Point(0, 124);
            label30.Margin = new Padding(10);
            label30.Name = "label30";
            label30.Padding = new Padding(359, 10, 356, 10);
            label30.Size = new Size(799, 39);
            label30.TabIndex = 105;
            label30.Text = "Segments";
            // 
            // listView1
            // 
            listView1.Location = new Point(1203, 731);
            listView1.Name = "listView1";
            listView1.Size = new Size(398, 241);
            listView1.TabIndex = 104;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(805, 731);
            listView2.Name = "listView2";
            listView2.Size = new Size(392, 241);
            listView2.TabIndex = 103;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.Location = new Point(407, 732);
            listView3.Name = "listView3";
            listView3.Size = new Size(392, 241);
            listView3.TabIndex = 102;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            listView4.Location = new Point(0, 731);
            listView4.Name = "listView4";
            listView4.Size = new Size(401, 242);
            listView4.TabIndex = 101;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // memoriesListView
            // 
            memoriesListView.Activation = ItemActivation.OneClick;
            memoriesListView.Columns.AddRange(new ColumnHeader[] { idMemory, photoMemory });
            memoriesListView.FullRowSelect = true;
            memoriesListView.Location = new Point(1203, 460);
            memoriesListView.Name = "memoriesListView";
            memoriesListView.Size = new Size(398, 224);
            memoriesListView.TabIndex = 100;
            memoriesListView.UseCompatibleStateImageBehavior = false;
            memoriesListView.View = System.Windows.Forms.View.Details;
            // 
            // idMemory
            // 
            idMemory.Width = 0;
            // 
            // photoMemory
            // 
            photoMemory.Text = "Photo";
            photoMemory.Width = 398;
            // 
            // expensesListView
            // 
            expensesListView.Activation = ItemActivation.OneClick;
            expensesListView.Columns.AddRange(new ColumnHeader[] { idExpenses, nameExpenses });
            expensesListView.FullRowSelect = true;
            expensesListView.Location = new Point(805, 460);
            expensesListView.Name = "expensesListView";
            expensesListView.Size = new Size(393, 224);
            expensesListView.TabIndex = 99;
            expensesListView.UseCompatibleStateImageBehavior = false;
            expensesListView.View = System.Windows.Forms.View.Details;
            // 
            // idExpenses
            // 
            idExpenses.Width = 0;
            // 
            // nameExpenses
            // 
            nameExpenses.Text = "Name";
            nameExpenses.Width = 393;
            // 
            // restingPointListView
            // 
            restingPointListView.Activation = ItemActivation.OneClick;
            restingPointListView.Columns.AddRange(new ColumnHeader[] { idRestingPoint, nameRestingPoint });
            restingPointListView.FullRowSelect = true;
            restingPointListView.Location = new Point(407, 460);
            restingPointListView.Name = "restingPointListView";
            restingPointListView.Size = new Size(392, 225);
            restingPointListView.TabIndex = 98;
            restingPointListView.UseCompatibleStateImageBehavior = false;
            restingPointListView.View = System.Windows.Forms.View.Details;
            // 
            // idRestingPoint
            // 
            idRestingPoint.Width = 0;
            // 
            // nameRestingPoint
            // 
            nameRestingPoint.Text = "Name";
            nameRestingPoint.Width = 392;
            // 
            // landmarkListView
            // 
            landmarkListView.Activation = ItemActivation.OneClick;
            landmarkListView.Columns.AddRange(new ColumnHeader[] { idLandmark, nameLandmark });
            landmarkListView.FullRowSelect = true;
            landmarkListView.Location = new Point(0, 460);
            landmarkListView.Name = "landmarkListView";
            landmarkListView.Size = new Size(401, 225);
            landmarkListView.TabIndex = 97;
            landmarkListView.UseCompatibleStateImageBehavior = false;
            landmarkListView.View = System.Windows.Forms.View.Details;
            // 
            // idLandmark
            // 
            idLandmark.Width = 0;
            // 
            // nameLandmark
            // 
            nameLandmark.Text = "Name";
            nameLandmark.Width = 401;
            // 
            // listView9
            // 
            listView9.Location = new Point(805, 165);
            listView9.Name = "listView9";
            listView9.Size = new Size(796, 250);
            listView9.TabIndex = 96;
            listView9.UseCompatibleStateImageBehavior = false;
            // 
            // segmentsListView
            // 
            segmentsListView.Activation = ItemActivation.OneClick;
            segmentsListView.Alignment = ListViewAlignment.Default;
            segmentsListView.Columns.AddRange(new ColumnHeader[] { idSegment, nameSegment });
            segmentsListView.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            segmentsListView.FullRowSelect = true;
            segmentsListView.Location = new Point(0, 165);
            segmentsListView.Name = "segmentsListView";
            segmentsListView.Size = new Size(799, 250);
            segmentsListView.TabIndex = 95;
            segmentsListView.UseCompatibleStateImageBehavior = false;
            segmentsListView.View = System.Windows.Forms.View.Details;
            // 
            // idSegment
            // 
            idSegment.Text = "";
            idSegment.Width = 0;
            // 
            // nameSegment
            // 
            nameSegment.Text = "Name";
            nameSegment.Width = 795;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(1320, 81);
            label31.Name = "label31";
            label31.Size = new Size(13, 18);
            label31.TabIndex = 94;
            label31.Text = "-";
            // 
            // tripReturnDatePicker
            // 
            tripReturnDatePicker.Enabled = false;
            tripReturnDatePicker.Location = new Point(1339, 78);
            tripReturnDatePicker.Margin = new Padding(3, 2, 3, 2);
            tripReturnDatePicker.Name = "tripReturnDatePicker";
            tripReturnDatePicker.Size = new Size(219, 23);
            tripReturnDatePicker.TabIndex = 93;
            // 
            // tripDepartureDatePicker
            // 
            tripDepartureDatePicker.Enabled = false;
            tripDepartureDatePicker.Location = new Point(1095, 78);
            tripDepartureDatePicker.Margin = new Padding(3, 2, 3, 2);
            tripDepartureDatePicker.Name = "tripDepartureDatePicker";
            tripDepartureDatePicker.Size = new Size(219, 23);
            tripDepartureDatePicker.TabIndex = 92;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(986, 83);
            label33.Name = "label33";
            label33.Size = new Size(101, 16);
            label33.TabIndex = 90;
            label33.Text = "Date of the trip";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(41, 83);
            label34.Name = "label34";
            label34.Size = new Size(107, 16);
            label34.TabIndex = 88;
            label34.Text = "Name of the trip";
            // 
            // returnFromInspectButton
            // 
            returnFromInspectButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            returnFromInspectButton.ForeColor = Color.FromArgb(1, 183, 99);
            returnFromInspectButton.Location = new Point(1, 0);
            returnFromInspectButton.Margin = new Padding(3, 2, 3, 2);
            returnFromInspectButton.Name = "returnFromInspectButton";
            returnFromInspectButton.Size = new Size(48, 52);
            returnFromInspectButton.TabIndex = 87;
            returnFromInspectButton.Text = "◀️";
            returnFromInspectButton.UseVisualStyleBackColor = true;
            returnFromInspectButton.Click += returnFromInspectButton_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(553, -3);
            label32.Name = "label32";
            label32.Size = new Size(489, 68);
            label32.TabIndex = 91;
            label32.Text = "Details of the trip";
            // 
            // tripNameTextBox
            // 
            tripNameTextBox.Enabled = false;
            tripNameTextBox.Location = new Point(154, 78);
            tripNameTextBox.Margin = new Padding(3, 2, 3, 2);
            tripNameTextBox.Name = "tripNameTextBox";
            tripNameTextBox.Size = new Size(438, 23);
            tripNameTextBox.TabIndex = 89;
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
            searchTextBox.Click += searchTextBox_Click;
            //
            // searchButton
            //
            searchButton.Font = new Font("Arial", 30, FontStyle.Regular);
            searchButton.Size = new Size(60, 60);
            searchButton.Location = new Point(1000, 107);
            searchButton.ForeColor = Color.FromArgb(1, 183, 99);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Text = "🔍";
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.BackColor = Color.White;
            searchButton.Click += searchButton_Click;
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
            // tripListPanel
            // 
            tripListPanel.AutoScroll = true;
            tripListPanel.Dock = DockStyle.Bottom;
            tripListPanel.Location = new Point(0, 184);
            tripListPanel.Margin = new Padding(3, 2, 3, 2);
            tripListPanel.Name = "tripListPanel";
            tripListPanel.Size = new Size(1605, 797);
            tripListPanel.TabIndex = 4;
            // 
            // browseTripPanel
            // 
            browseTripPanel.BackColor = Color.FromArgb(246, 246, 246);
            browseTripPanel.Controls.Add(tripListPanel);
            browseTripPanel.Controls.Add(browseLabel);
            browseTripPanel.Controls.Add(searchTextBox);
            browseTripPanel.Controls.Add(searchButton);
            browseTripPanel.Controls.Add(returnFromBrowseButton);
            browseTripPanel.Dock = DockStyle.Fill;
            browseTripPanel.Location = new Point(0, 0);
            browseTripPanel.Margin = new Padding(3, 2, 3, 2);
            browseTripPanel.Name = "browseTripPanel";
            browseTripPanel.Size = new Size(1605, 981);
            browseTripPanel.TabIndex = 1;
            browseTripPanel.Visible = false;
            // 
            // editTripPanel
            // 
            editTripPanel.BackColor = Color.FromArgb(246, 246, 246);
            editTripPanel.Controls.Add(memPhotoButtonSelect);
            editTripPanel.Controls.Add(memPhotoEditInput);
            editTripPanel.Controls.Add(memNameEditInput);
            editTripPanel.Controls.Add(label1);
            editTripPanel.Controls.Add(expValueEditInput);
            editTripPanel.Controls.Add(recomLandmarkEditButton);
            editTripPanel.Controls.Add(memNoteEditInput);
            editTripPanel.Controls.Add(segNameEditInput);
            editTripPanel.Controls.Add(memSongEditInput);
            editTripPanel.Controls.Add(expNameEditInput);
            editTripPanel.Controls.Add(restContactEditInput);
            editTripPanel.Controls.Add(restAddressEditInput);
            editTripPanel.Controls.Add(restCityEditInput);
            editTripPanel.Controls.Add(restCountryEditInput);
            editTripPanel.Controls.Add(restNameEditInput);
            editTripPanel.Controls.Add(landDescEditInput);
            editTripPanel.Controls.Add(landAddressEditInput);
            editTripPanel.Controls.Add(landCityEditInput);
            editTripPanel.Controls.Add(landCountryEditInput);
            editTripPanel.Controls.Add(landNameEditInput);
            editTripPanel.Controls.Add(restCampingEditRadioButton);
            editTripPanel.Controls.Add(restApartmentEditRadioButton);
            editTripPanel.Controls.Add(restRoomEditRadioButton);
            editTripPanel.Controls.Add(restHostelEditRadioButton);
            editTripPanel.Controls.Add(restHotelEditRadioButton);
            editTripPanel.Controls.Add(label35);
            editTripPanel.Controls.Add(label36);
            editTripPanel.Controls.Add(label37);
            editTripPanel.Controls.Add(label38);
            editTripPanel.Controls.Add(label39);
            editTripPanel.Controls.Add(label40);
            editTripPanel.Controls.Add(label41);
            editTripPanel.Controls.Add(label42);
            editTripPanel.Controls.Add(label43);
            editTripPanel.Controls.Add(label44);
            editTripPanel.Controls.Add(label45);
            editTripPanel.Controls.Add(label46);
            editTripPanel.Controls.Add(label47);
            editTripPanel.Controls.Add(label48);
            editTripPanel.Controls.Add(label49);
            editTripPanel.Controls.Add(label50);
            editTripPanel.Controls.Add(label51);
            editTripPanel.Controls.Add(landUpdateEditButton);
            editTripPanel.Controls.Add(landAddEditButton);
            editTripPanel.Controls.Add(landRemoveEditButton);
            editTripPanel.Controls.Add(restUpdateEditButton);
            editTripPanel.Controls.Add(restAddEditButton);
            editTripPanel.Controls.Add(restRemoveEditButton);
            editTripPanel.Controls.Add(expUpdateEditButton);
            editTripPanel.Controls.Add(expAddEditButton);
            editTripPanel.Controls.Add(expRemoveEditButton);
            editTripPanel.Controls.Add(memUpdateEditButton);
            editTripPanel.Controls.Add(memAddEditButton);
            editTripPanel.Controls.Add(memRemoveEditButton);
            editTripPanel.Controls.Add(segUpdateEditButton);
            editTripPanel.Controls.Add(segAddEditButton);
            editTripPanel.Controls.Add(segRemoveEditButton);
            editTripPanel.Controls.Add(saveEditTripButton);
            editTripPanel.Controls.Add(label52);
            editTripPanel.Controls.Add(label53);
            editTripPanel.Controls.Add(label54);
            editTripPanel.Controls.Add(label55);
            editTripPanel.Controls.Add(label56);
            editTripPanel.Controls.Add(label57);
            editTripPanel.Controls.Add(label58);
            editTripPanel.Controls.Add(label59);
            editTripPanel.Controls.Add(label60);
            editTripPanel.Controls.Add(label61);
            editTripPanel.Controls.Add(listView11);
            editTripPanel.Controls.Add(listView12);
            editTripPanel.Controls.Add(restEditPanel);
            editTripPanel.Controls.Add(listView14);
            editTripPanel.Controls.Add(memoriesEditListView);
            editTripPanel.Controls.Add(expensesEditListView);
            editTripPanel.Controls.Add(restingEditPointListView);
            editTripPanel.Controls.Add(landmarkEditListView);
            editTripPanel.Controls.Add(listView19);
            editTripPanel.Controls.Add(segmentsEditListView);
            editTripPanel.Controls.Add(label62);
            editTripPanel.Controls.Add(editTripReturnDatePicker);
            editTripPanel.Controls.Add(editTripDepartureDatePicker);
            editTripPanel.Controls.Add(label63);
            editTripPanel.Controls.Add(label64);
            editTripPanel.Controls.Add(tripNameEditInput);
            editTripPanel.Controls.Add(label65);
            editTripPanel.Controls.Add(returnFromEditTripButton);
            editTripPanel.Dock = DockStyle.Fill;
            editTripPanel.Location = new Point(0, 0);
            editTripPanel.Margin = new Padding(3, 2, 3, 2);
            editTripPanel.Name = "editTripPanel";
            editTripPanel.Size = new Size(1605, 981);
            editTripPanel.TabIndex = 9;
            editTripPanel.Visible = false;
            // 
            // memPhotoButtonSelect
            // 
            memPhotoButtonSelect.Location = new Point(1520, 777);
            memPhotoButtonSelect.Name = "memPhotoButtonSelect";
            memPhotoButtonSelect.Size = new Size(58, 23);
            memPhotoButtonSelect.TabIndex = 175;
            memPhotoButtonSelect.Text = "Select...";
            memPhotoButtonSelect.UseVisualStyleBackColor = true;
            memPhotoButtonSelect.Click += memPhotoButtonSelect_Click;
            // 
            // memPhotoEditInput
            // 
            memPhotoEditInput.Location = new Point(1286, 777);
            memPhotoEditInput.Name = "memPhotoEditInput";
            memPhotoEditInput.Size = new Size(292, 23);
            memPhotoEditInput.TabIndex = 174;
            // 
            // memNameEditInput
            // 
            memNameEditInput.Location = new Point(1286, 745);
            memNameEditInput.Name = "memNameEditInput";
            memNameEditInput.Size = new Size(292, 23);
            memNameEditInput.TabIndex = 173;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1237, 746);
            label1.Name = "label1";
            label1.Size = new Size(43, 16);
            label1.TabIndex = 172;
            label1.Text = "Name";
            // 
            // expValueEditInput
            // 
            expValueEditInput.Location = new Point(892, 770);
            expValueEditInput.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            expValueEditInput.Name = "expValueEditInput";
            expValueEditInput.Size = new Size(292, 23);
            expValueEditInput.TabIndex = 171;
            // 
            // recomLandmarkEditButton
            // 
            recomLandmarkEditButton.BackColor = Color.FromArgb(1, 183, 99);
            recomLandmarkEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            recomLandmarkEditButton.ForeColor = SystemColors.ControlLightLight;
            recomLandmarkEditButton.Location = new Point(116, 891);
            recomLandmarkEditButton.Name = "recomLandmarkEditButton";
            recomLandmarkEditButton.Size = new Size(282, 36);
            recomLandmarkEditButton.TabIndex = 170;
            recomLandmarkEditButton.Text = "Recommended landmarks";
            recomLandmarkEditButton.UseVisualStyleBackColor = false;
            recomLandmarkEditButton.Click += recomLandmarksEditButton_Click;
            // 
            // memNoteEditInput
            // 
            memNoteEditInput.Location = new Point(1286, 858);
            memNoteEditInput.Name = "memNoteEditInput";
            memNoteEditInput.Size = new Size(292, 70);
            memNoteEditInput.TabIndex = 168;
            memNoteEditInput.Text = "";
            // 
            // segNameEditInput
            // 
            segNameEditInput.Location = new Point(874, 203);
            segNameEditInput.Name = "segNameEditInput";
            segNameEditInput.Size = new Size(715, 23);
            segNameEditInput.TabIndex = 166;
            // 
            // memSongEditInput
            // 
            memSongEditInput.Location = new Point(1286, 829);
            memSongEditInput.Name = "memSongEditInput";
            memSongEditInput.Size = new Size(292, 23);
            memSongEditInput.TabIndex = 165;
            // 
            // expNameEditInput
            // 
            expNameEditInput.Location = new Point(892, 739);
            expNameEditInput.Name = "expNameEditInput";
            expNameEditInput.Size = new Size(292, 23);
            expNameEditInput.TabIndex = 163;
            // 
            // restContactEditInput
            // 
            restContactEditInput.Location = new Point(497, 854);
            restContactEditInput.Name = "restContactEditInput";
            restContactEditInput.Size = new Size(292, 23);
            restContactEditInput.TabIndex = 162;
            // 
            // restAddressEditInput
            // 
            restAddressEditInput.Location = new Point(497, 825);
            restAddressEditInput.Name = "restAddressEditInput";
            restAddressEditInput.Size = new Size(292, 23);
            restAddressEditInput.TabIndex = 161;
            // 
            // restCityEditInput
            // 
            restCityEditInput.Location = new Point(497, 796);
            restCityEditInput.Name = "restCityEditInput";
            restCityEditInput.Size = new Size(292, 23);
            restCityEditInput.TabIndex = 160;
            // 
            // restCountryEditInput
            // 
            restCountryEditInput.Location = new Point(497, 768);
            restCountryEditInput.Name = "restCountryEditInput";
            restCountryEditInput.Size = new Size(292, 23);
            restCountryEditInput.TabIndex = 159;
            // 
            // restNameEditInput
            // 
            restNameEditInput.Location = new Point(497, 739);
            restNameEditInput.Name = "restNameEditInput";
            restNameEditInput.Size = new Size(292, 23);
            restNameEditInput.TabIndex = 158;
            // 
            // landDescEditInput
            // 
            landDescEditInput.Location = new Point(96, 856);
            landDescEditInput.Name = "landDescEditInput";
            landDescEditInput.Size = new Size(292, 23);
            landDescEditInput.TabIndex = 157;
            // 
            // landAddressEditInput
            // 
            landAddressEditInput.Location = new Point(96, 827);
            landAddressEditInput.Name = "landAddressEditInput";
            landAddressEditInput.Size = new Size(292, 23);
            landAddressEditInput.TabIndex = 156;
            // 
            // landCityEditInput
            // 
            landCityEditInput.Location = new Point(96, 798);
            landCityEditInput.Name = "landCityEditInput";
            landCityEditInput.Size = new Size(292, 23);
            landCityEditInput.TabIndex = 155;
            // 
            // landCountryEditInput
            // 
            landCountryEditInput.Location = new Point(96, 769);
            landCountryEditInput.Name = "landCountryEditInput";
            landCountryEditInput.Size = new Size(292, 23);
            landCountryEditInput.TabIndex = 154;
            // 
            // landNameEditInput
            // 
            landNameEditInput.Location = new Point(96, 739);
            landNameEditInput.Name = "landNameEditInput";
            landNameEditInput.Size = new Size(292, 23);
            landNameEditInput.TabIndex = 153;
            // 
            // restCampingEditRadioButton
            // 
            restCampingEditRadioButton.AutoSize = true;
            restCampingEditRadioButton.BackColor = Color.White;
            restCampingEditRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restCampingEditRadioButton.Location = new Point(572, 910);
            restCampingEditRadioButton.Name = "restCampingEditRadioButton";
            restCampingEditRadioButton.Size = new Size(81, 20);
            restCampingEditRadioButton.TabIndex = 152;
            restCampingEditRadioButton.TabStop = true;
            restCampingEditRadioButton.Text = "Camping";
            restCampingEditRadioButton.UseVisualStyleBackColor = false;
            // 
            // restApartmentEditRadioButton
            // 
            restApartmentEditRadioButton.AutoSize = true;
            restApartmentEditRadioButton.BackColor = Color.White;
            restApartmentEditRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restApartmentEditRadioButton.Location = new Point(664, 884);
            restApartmentEditRadioButton.Name = "restApartmentEditRadioButton";
            restApartmentEditRadioButton.Size = new Size(90, 20);
            restApartmentEditRadioButton.TabIndex = 151;
            restApartmentEditRadioButton.TabStop = true;
            restApartmentEditRadioButton.Text = "Apartment";
            restApartmentEditRadioButton.UseVisualStyleBackColor = false;
            // 
            // restRoomEditRadioButton
            // 
            restRoomEditRadioButton.AutoSize = true;
            restRoomEditRadioButton.BackColor = Color.White;
            restRoomEditRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restRoomEditRadioButton.Location = new Point(497, 909);
            restRoomEditRadioButton.Name = "restRoomEditRadioButton";
            restRoomEditRadioButton.Size = new Size(62, 20);
            restRoomEditRadioButton.TabIndex = 150;
            restRoomEditRadioButton.TabStop = true;
            restRoomEditRadioButton.Text = "Room";
            restRoomEditRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHostelEditRadioButton
            // 
            restHostelEditRadioButton.AutoSize = true;
            restHostelEditRadioButton.BackColor = Color.White;
            restHostelEditRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHostelEditRadioButton.Location = new Point(572, 884);
            restHostelEditRadioButton.Name = "restHostelEditRadioButton";
            restHostelEditRadioButton.Size = new Size(64, 20);
            restHostelEditRadioButton.TabIndex = 149;
            restHostelEditRadioButton.TabStop = true;
            restHostelEditRadioButton.Text = "Hostel";
            restHostelEditRadioButton.UseVisualStyleBackColor = false;
            // 
            // restHotelEditRadioButton
            // 
            restHotelEditRadioButton.AutoSize = true;
            restHotelEditRadioButton.BackColor = Color.White;
            restHotelEditRadioButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restHotelEditRadioButton.Location = new Point(497, 884);
            restHotelEditRadioButton.Name = "restHotelEditRadioButton";
            restHotelEditRadioButton.Size = new Size(57, 20);
            restHotelEditRadioButton.TabIndex = 148;
            restHotelEditRadioButton.TabStop = true;
            restHotelEditRadioButton.Text = "Hotel";
            restHotelEditRadioButton.UseVisualStyleBackColor = false;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = SystemColors.ControlLightLight;
            label35.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(453, 884);
            label35.Name = "label35";
            label35.Size = new Size(38, 16);
            label35.TabIndex = 147;
            label35.Text = "Type";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = SystemColors.ControlLightLight;
            label36.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label36.Location = new Point(410, 858);
            label36.Name = "label36";
            label36.Size = new Size(83, 16);
            label36.TabIndex = 146;
            label36.Text = "Contact info";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = SystemColors.ControlLightLight;
            label37.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(434, 834);
            label37.Name = "label37";
            label37.Size = new Size(59, 16);
            label37.TabIndex = 145;
            label37.Text = "Address";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = SystemColors.ControlLightLight;
            label38.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(460, 805);
            label38.Name = "label38";
            label38.Size = new Size(31, 16);
            label38.TabIndex = 144;
            label38.Text = "City";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = SystemColors.ControlLightLight;
            label39.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(434, 776);
            label39.Name = "label39";
            label39.Size = new Size(57, 16);
            label39.TabIndex = 143;
            label39.Text = "Country";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = SystemColors.ControlLightLight;
            label40.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label40.Location = new Point(448, 746);
            label40.Name = "label40";
            label40.Size = new Size(43, 16);
            label40.TabIndex = 142;
            label40.Text = "Name";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = SystemColors.ControlLightLight;
            label41.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label41.Location = new Point(1244, 863);
            label41.Name = "label41";
            label41.Size = new Size(36, 16);
            label41.TabIndex = 141;
            label41.Text = "Note";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = SystemColors.ControlLightLight;
            label42.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label42.Location = new Point(1229, 837);
            label42.Name = "label42";
            label42.Size = new Size(51, 16);
            label42.TabIndex = 140;
            label42.Text = "Song/s";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = SystemColors.ControlLightLight;
            label43.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label43.Location = new Point(1236, 777);
            label43.Name = "label43";
            label43.Size = new Size(44, 16);
            label43.TabIndex = 139;
            label43.Text = "Photo";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = SystemColors.ControlLightLight;
            label44.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label44.Location = new Point(844, 769);
            label44.Name = "label44";
            label44.Size = new Size(42, 16);
            label44.TabIndex = 138;
            label44.Text = "Value";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = SystemColors.ControlLightLight;
            label45.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label45.Location = new Point(843, 741);
            label45.Name = "label45";
            label45.Size = new Size(43, 16);
            label45.TabIndex = 137;
            label45.Text = "Name";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = SystemColors.ControlLightLight;
            label46.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label46.Location = new Point(12, 858);
            label46.Name = "label46";
            label46.Size = new Size(78, 16);
            label46.TabIndex = 136;
            label46.Text = "Description";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = SystemColors.ControlLightLight;
            label47.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label47.Location = new Point(31, 834);
            label47.Name = "label47";
            label47.Size = new Size(59, 16);
            label47.TabIndex = 135;
            label47.Text = "Address";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.BackColor = SystemColors.ControlLightLight;
            label48.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label48.Location = new Point(59, 805);
            label48.Name = "label48";
            label48.Size = new Size(31, 16);
            label48.TabIndex = 134;
            label48.Text = "City";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = SystemColors.ControlLightLight;
            label49.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label49.Location = new Point(33, 776);
            label49.Name = "label49";
            label49.Size = new Size(57, 16);
            label49.TabIndex = 133;
            label49.Text = "Country";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = SystemColors.ControlLightLight;
            label50.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label50.Location = new Point(47, 746);
            label50.Name = "label50";
            label50.Size = new Size(43, 16);
            label50.TabIndex = 132;
            label50.Text = "Name";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.BackColor = SystemColors.ControlLightLight;
            label51.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label51.Location = new Point(825, 205);
            label51.Name = "label51";
            label51.Size = new Size(43, 16);
            label51.TabIndex = 131;
            label51.Text = "Name";
            // 
            // landUpdateEditButton
            // 
            landUpdateEditButton.BackColor = Color.FromArgb(1, 183, 99);
            landUpdateEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landUpdateEditButton.ForeColor = SystemColors.ControlLightLight;
            landUpdateEditButton.Location = new Point(212, 937);
            landUpdateEditButton.Name = "landUpdateEditButton";
            landUpdateEditButton.Size = new Size(90, 36);
            landUpdateEditButton.TabIndex = 130;
            landUpdateEditButton.Text = "Update";
            landUpdateEditButton.UseVisualStyleBackColor = false;
            landUpdateEditButton.Click += landUpdateEditButton_Click;
            // 
            // landAddEditButton
            // 
            landAddEditButton.BackColor = Color.FromArgb(1, 183, 99);
            landAddEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landAddEditButton.ForeColor = SystemColors.ControlLightLight;
            landAddEditButton.Location = new Point(308, 937);
            landAddEditButton.Name = "landAddEditButton";
            landAddEditButton.Size = new Size(90, 36);
            landAddEditButton.TabIndex = 129;
            landAddEditButton.Text = "Add";
            landAddEditButton.UseVisualStyleBackColor = false;
            landAddEditButton.Click += landAddEditButton_Click;
            // 
            // landRemoveEditButton
            // 
            landRemoveEditButton.BackColor = Color.FromArgb(1, 183, 99);
            landRemoveEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            landRemoveEditButton.ForeColor = SystemColors.ControlLightLight;
            landRemoveEditButton.Location = new Point(116, 937);
            landRemoveEditButton.Name = "landRemoveEditButton";
            landRemoveEditButton.Size = new Size(90, 36);
            landRemoveEditButton.TabIndex = 128;
            landRemoveEditButton.Text = "Remove";
            landRemoveEditButton.UseVisualStyleBackColor = false;
            landRemoveEditButton.Click += landRemoveEditButton_Click;
            // 
            // restUpdateEditButton
            // 
            restUpdateEditButton.BackColor = Color.FromArgb(1, 183, 99);
            restUpdateEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restUpdateEditButton.ForeColor = SystemColors.ControlLightLight;
            restUpdateEditButton.Location = new Point(610, 935);
            restUpdateEditButton.Name = "restUpdateEditButton";
            restUpdateEditButton.Size = new Size(90, 36);
            restUpdateEditButton.TabIndex = 127;
            restUpdateEditButton.Text = "Update";
            restUpdateEditButton.UseVisualStyleBackColor = false;
            restUpdateEditButton.Click += restUpdateEditButton_Click;
            // 
            // restAddEditButton
            // 
            restAddEditButton.BackColor = Color.FromArgb(1, 183, 99);
            restAddEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restAddEditButton.ForeColor = SystemColors.ControlLightLight;
            restAddEditButton.Location = new Point(706, 935);
            restAddEditButton.Name = "restAddEditButton";
            restAddEditButton.Size = new Size(90, 36);
            restAddEditButton.TabIndex = 126;
            restAddEditButton.Text = "Add";
            restAddEditButton.UseVisualStyleBackColor = false;
            restAddEditButton.Click += restAddEditButton_Click;
            // 
            // restRemoveEditButton
            // 
            restRemoveEditButton.BackColor = Color.FromArgb(1, 183, 99);
            restRemoveEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restRemoveEditButton.ForeColor = SystemColors.ControlLightLight;
            restRemoveEditButton.Location = new Point(514, 935);
            restRemoveEditButton.Name = "restRemoveEditButton";
            restRemoveEditButton.Size = new Size(90, 36);
            restRemoveEditButton.TabIndex = 125;
            restRemoveEditButton.Text = "Remove";
            restRemoveEditButton.UseVisualStyleBackColor = false;
            restRemoveEditButton.Click += restRemoveEditButton_Click;
            // 
            // expUpdateEditButton
            // 
            expUpdateEditButton.BackColor = Color.FromArgb(1, 183, 99);
            expUpdateEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expUpdateEditButton.ForeColor = SystemColors.ControlLightLight;
            expUpdateEditButton.Location = new Point(1008, 934);
            expUpdateEditButton.Name = "expUpdateEditButton";
            expUpdateEditButton.Size = new Size(90, 36);
            expUpdateEditButton.TabIndex = 124;
            expUpdateEditButton.Text = "Update";
            expUpdateEditButton.UseVisualStyleBackColor = false;
            expUpdateEditButton.Click += expUpdateEditButton_Click;
            // 
            // expAddEditButton
            // 
            expAddEditButton.BackColor = Color.FromArgb(1, 183, 99);
            expAddEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expAddEditButton.ForeColor = SystemColors.ControlLightLight;
            expAddEditButton.Location = new Point(1104, 934);
            expAddEditButton.Name = "expAddEditButton";
            expAddEditButton.Size = new Size(90, 36);
            expAddEditButton.TabIndex = 123;
            expAddEditButton.Text = "Add";
            expAddEditButton.UseVisualStyleBackColor = false;
            expAddEditButton.Click += expAddEditButton_Click;
            // 
            // expRemoveEditButton
            // 
            expRemoveEditButton.BackColor = Color.FromArgb(1, 183, 99);
            expRemoveEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expRemoveEditButton.ForeColor = SystemColors.ControlLightLight;
            expRemoveEditButton.Location = new Point(912, 934);
            expRemoveEditButton.Name = "expRemoveEditButton";
            expRemoveEditButton.Size = new Size(90, 36);
            expRemoveEditButton.TabIndex = 122;
            expRemoveEditButton.Text = "Remove";
            expRemoveEditButton.UseVisualStyleBackColor = false;
            expRemoveEditButton.Click += expRemoveEditButton_Click;
            // 
            // memUpdateEditButton
            // 
            memUpdateEditButton.BackColor = Color.FromArgb(1, 183, 99);
            memUpdateEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memUpdateEditButton.ForeColor = SystemColors.ControlLightLight;
            memUpdateEditButton.Location = new Point(1412, 934);
            memUpdateEditButton.Name = "memUpdateEditButton";
            memUpdateEditButton.Size = new Size(90, 36);
            memUpdateEditButton.TabIndex = 121;
            memUpdateEditButton.Text = "Update";
            memUpdateEditButton.UseVisualStyleBackColor = false;
            memUpdateEditButton.Click += memUpdateEditButton_Click;
            // 
            // memAddEditButton
            // 
            memAddEditButton.BackColor = Color.FromArgb(1, 183, 99);
            memAddEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memAddEditButton.ForeColor = SystemColors.ControlLightLight;
            memAddEditButton.Location = new Point(1508, 934);
            memAddEditButton.Name = "memAddEditButton";
            memAddEditButton.Size = new Size(90, 36);
            memAddEditButton.TabIndex = 120;
            memAddEditButton.Text = "Add";
            memAddEditButton.UseVisualStyleBackColor = false;
            memAddEditButton.Click += memAddEditButton_Click;
            // 
            // memRemoveEditButton
            // 
            memRemoveEditButton.BackColor = Color.FromArgb(1, 183, 99);
            memRemoveEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            memRemoveEditButton.ForeColor = SystemColors.ControlLightLight;
            memRemoveEditButton.Location = new Point(1316, 934);
            memRemoveEditButton.Name = "memRemoveEditButton";
            memRemoveEditButton.Size = new Size(90, 36);
            memRemoveEditButton.TabIndex = 119;
            memRemoveEditButton.Text = "Remove";
            memRemoveEditButton.UseVisualStyleBackColor = false;
            memRemoveEditButton.Click += memRemoveEditButton_Click;
            // 
            // segUpdateEditButton
            // 
            segUpdateEditButton.BackColor = Color.FromArgb(1, 183, 99);
            segUpdateEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segUpdateEditButton.ForeColor = SystemColors.ControlLightLight;
            segUpdateEditButton.Location = new Point(1404, 377);
            segUpdateEditButton.Name = "segUpdateEditButton";
            segUpdateEditButton.Size = new Size(90, 36);
            segUpdateEditButton.TabIndex = 118;
            segUpdateEditButton.Text = "Update";
            segUpdateEditButton.UseVisualStyleBackColor = false;
            segUpdateEditButton.Click += segUpdateEditButton_Click;
            // 
            // segAddEditButton
            // 
            segAddEditButton.BackColor = Color.FromArgb(1, 183, 99);
            segAddEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segAddEditButton.ForeColor = SystemColors.ControlLightLight;
            segAddEditButton.Location = new Point(1500, 377);
            segAddEditButton.Name = "segAddEditButton";
            segAddEditButton.Size = new Size(90, 36);
            segAddEditButton.TabIndex = 117;
            segAddEditButton.Text = "Add";
            segAddEditButton.UseVisualStyleBackColor = false;
            segAddEditButton.Click += segAddEditButton_Click;
            // 
            // segRemoveEditButton
            // 
            segRemoveEditButton.BackColor = Color.FromArgb(1, 183, 99);
            segRemoveEditButton.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            segRemoveEditButton.ForeColor = SystemColors.ControlLightLight;
            segRemoveEditButton.Location = new Point(1308, 377);
            segRemoveEditButton.Name = "segRemoveEditButton";
            segRemoveEditButton.Size = new Size(90, 36);
            segRemoveEditButton.TabIndex = 116;
            segRemoveEditButton.Text = "Remove";
            segRemoveEditButton.UseVisualStyleBackColor = false;
            segRemoveEditButton.Click += segRemoveEditButton_Click;
            // 
            // saveEditTripButton
            // 
            saveEditTripButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            saveEditTripButton.ForeColor = Color.FromArgb(1, 183, 99);
            saveEditTripButton.Location = new Point(51, 1);
            saveEditTripButton.Name = "saveEditTripButton";
            saveEditTripButton.Size = new Size(48, 52);
            saveEditTripButton.TabIndex = 115;
            saveEditTripButton.Text = "💾";
            saveEditTripButton.UseVisualStyleBackColor = true;
            saveEditTripButton.Click += saveEditTripButton_Click;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.BackColor = Color.FromArgb(1, 183, 99);
            label52.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label52.ForeColor = SystemColors.ControlLightLight;
            label52.Location = new Point(1204, 690);
            label52.Name = "label52";
            label52.Padding = new Padding(130, 10, 130, 10);
            label52.Size = new Size(401, 39);
            label52.TabIndex = 114;
            label52.Text = "Add new memory";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = Color.FromArgb(1, 183, 99);
            label53.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label53.ForeColor = SystemColors.ControlLightLight;
            label53.Location = new Point(805, 690);
            label53.Name = "label53";
            label53.Padding = new Padding(123, 10, 126, 10);
            label53.Size = new Size(391, 39);
            label53.TabIndex = 113;
            label53.Text = "Add new expense";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = Color.FromArgb(1, 183, 99);
            label54.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label54.ForeColor = SystemColors.ControlLightLight;
            label54.Location = new Point(407, 690);
            label54.Name = "label54";
            label54.Padding = new Padding(109, 10, 108, 10);
            label54.Size = new Size(392, 39);
            label54.TabIndex = 112;
            label54.Text = "Add new resting point";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = Color.FromArgb(1, 183, 99);
            label55.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label55.ForeColor = SystemColors.ControlLightLight;
            label55.Location = new Point(0, 690);
            label55.Name = "label55";
            label55.Padding = new Padding(126, 10, 126, 10);
            label55.Size = new Size(401, 39);
            label55.TabIndex = 111;
            label55.Text = "Add new landmark";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BackColor = Color.FromArgb(1, 183, 99);
            label56.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label56.ForeColor = SystemColors.ControlLightLight;
            label56.Location = new Point(805, 125);
            label56.Margin = new Padding(10);
            label56.Name = "label56";
            label56.Padding = new Padding(362, 10, 362, 10);
            label56.Size = new Size(868, 39);
            label56.TabIndex = 110;
            label56.Text = "Add new segment";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.BackColor = Color.FromArgb(127, 127, 127);
            label57.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label57.ForeColor = SystemColors.ControlLightLight;
            label57.Location = new Point(1204, 419);
            label57.Name = "label57";
            label57.Padding = new Padding(158, 10, 158, 10);
            label57.Size = new Size(399, 39);
            label57.TabIndex = 109;
            label57.Text = "Memories";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.BackColor = Color.FromArgb(127, 127, 127);
            label58.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label58.ForeColor = SystemColors.ControlLightLight;
            label58.Location = new Point(805, 419);
            label58.Name = "label58";
            label58.Padding = new Padding(155, 10, 155, 10);
            label58.Size = new Size(392, 39);
            label58.TabIndex = 108;
            label58.Text = "Expenses";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BackColor = Color.FromArgb(127, 127, 127);
            label59.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label59.ForeColor = SystemColors.ControlLightLight;
            label59.Location = new Point(407, 419);
            label59.Name = "label59";
            label59.Padding = new Padding(136, 10, 137, 10);
            label59.Size = new Size(392, 39);
            label59.TabIndex = 107;
            label59.Text = "Resting points";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.BackColor = Color.FromArgb(127, 127, 127);
            label60.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label60.ForeColor = SystemColors.ControlLightLight;
            label60.Location = new Point(-1, 419);
            label60.Name = "label60";
            label60.Padding = new Padding(155, 10, 155, 10);
            label60.Size = new Size(402, 39);
            label60.TabIndex = 106;
            label60.Text = "Landmarks";
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.BackColor = Color.FromArgb(127, 127, 127);
            label61.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label61.ForeColor = SystemColors.ControlLightLight;
            label61.Location = new Point(0, 125);
            label61.Margin = new Padding(10);
            label61.Name = "label61";
            label61.Padding = new Padding(359, 10, 356, 10);
            label61.Size = new Size(799, 39);
            label61.TabIndex = 105;
            label61.Text = "Segments";
            // 
            // listView11
            // 
            listView11.Location = new Point(1203, 732);
            listView11.Name = "listView11";
            listView11.Size = new Size(398, 241);
            listView11.TabIndex = 104;
            listView11.UseCompatibleStateImageBehavior = false;
            // 
            // listView12
            // 
            listView12.Location = new Point(805, 732);
            listView12.Name = "listView12";
            listView12.Size = new Size(392, 241);
            listView12.TabIndex = 103;
            listView12.UseCompatibleStateImageBehavior = false;
            // 
            // restEditPanel
            // 
            restEditPanel.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            restEditPanel.Location = new Point(407, 733);
            restEditPanel.Name = "restEditPanel";
            restEditPanel.Size = new Size(392, 241);
            restEditPanel.TabIndex = 102;
            restEditPanel.UseCompatibleStateImageBehavior = false;
            // 
            // listView14
            // 
            listView14.Location = new Point(0, 732);
            listView14.Name = "listView14";
            listView14.Size = new Size(401, 242);
            listView14.TabIndex = 101;
            listView14.UseCompatibleStateImageBehavior = false;
            // 
            // memoriesEditListView
            // 
            memoriesEditListView.Activation = ItemActivation.OneClick;
            memoriesEditListView.Columns.AddRange(new ColumnHeader[] { idEditMemory, nameEditMemory });
            memoriesEditListView.FullRowSelect = true;
            memoriesEditListView.Location = new Point(1203, 461);
            memoriesEditListView.Name = "memoriesEditListView";
            memoriesEditListView.Size = new Size(398, 224);
            memoriesEditListView.TabIndex = 100;
            memoriesEditListView.UseCompatibleStateImageBehavior = false;
            memoriesEditListView.View = System.Windows.Forms.View.Details;
            // 
            // idEditMemory
            // 
            idEditMemory.Width = 0;
            // 
            // nameEditMemory
            // 
            nameEditMemory.Text = "Photo";
            nameEditMemory.Width = 394;
            // 
            // expensesEditListView
            // 
            expensesEditListView.Activation = ItemActivation.OneClick;
            expensesEditListView.Columns.AddRange(new ColumnHeader[] { idEditExpense, nameEditExpense });
            expensesEditListView.FullRowSelect = true;
            expensesEditListView.Location = new Point(805, 461);
            expensesEditListView.Name = "expensesEditListView";
            expensesEditListView.Size = new Size(393, 224);
            expensesEditListView.TabIndex = 99;
            expensesEditListView.UseCompatibleStateImageBehavior = false;
            expensesEditListView.View = System.Windows.Forms.View.Details;
            // 
            // idEditExpense
            // 
            idEditExpense.Width = 0;
            // 
            // nameEditExpense
            // 
            nameEditExpense.Text = "Name";
            nameEditExpense.Width = 389;
            // 
            // restingEditPointListView
            // 
            restingEditPointListView.Activation = ItemActivation.OneClick;
            restingEditPointListView.Columns.AddRange(new ColumnHeader[] { idEditRestingPoint, nameEditRestingPoint });
            restingEditPointListView.FullRowSelect = true;
            restingEditPointListView.Location = new Point(407, 461);
            restingEditPointListView.Name = "restingEditPointListView";
            restingEditPointListView.Size = new Size(392, 225);
            restingEditPointListView.TabIndex = 98;
            restingEditPointListView.UseCompatibleStateImageBehavior = false;
            restingEditPointListView.View = System.Windows.Forms.View.Details;
            // 
            // idEditRestingPoint
            // 
            idEditRestingPoint.Text = "";
            idEditRestingPoint.Width = 0;
            // 
            // nameEditRestingPoint
            // 
            nameEditRestingPoint.Text = "Name";
            nameEditRestingPoint.Width = 388;
            // 
            // landmarkEditListView
            // 
            landmarkEditListView.Activation = ItemActivation.OneClick;
            landmarkEditListView.Columns.AddRange(new ColumnHeader[] { idEditLand, nameLandEdit });
            landmarkEditListView.FullRowSelect = true;
            landmarkEditListView.Location = new Point(0, 461);
            landmarkEditListView.Name = "landmarkEditListView";
            landmarkEditListView.Size = new Size(401, 225);
            landmarkEditListView.TabIndex = 97;
            landmarkEditListView.UseCompatibleStateImageBehavior = false;
            landmarkEditListView.View = System.Windows.Forms.View.Details;
            // 
            // idEditLand
            // 
            idEditLand.Width = 0;
            // 
            // nameLandEdit
            // 
            nameLandEdit.Text = "Name";
            nameLandEdit.Width = 397;
            // 
            // listView19
            // 
            listView19.Location = new Point(805, 166);
            listView19.Name = "listView19";
            listView19.Size = new Size(796, 250);
            listView19.TabIndex = 96;
            listView19.UseCompatibleStateImageBehavior = false;
            // 
            // segmentsEditListView
            // 
            segmentsEditListView.Activation = ItemActivation.OneClick;
            segmentsEditListView.Columns.AddRange(new ColumnHeader[] { idEditSegment, nameEditSegment });
            segmentsEditListView.FullRowSelect = true;
            segmentsEditListView.Location = new Point(0, 166);
            segmentsEditListView.Name = "segmentsEditListView";
            segmentsEditListView.Size = new Size(799, 250);
            segmentsEditListView.TabIndex = 95;
            segmentsEditListView.UseCompatibleStateImageBehavior = false;
            segmentsEditListView.View = System.Windows.Forms.View.Details;
            // 
            // idEditSegment
            // 
            idEditSegment.Text = "";
            idEditSegment.Width = 0;
            // 
            // nameEditSegment
            // 
            nameEditSegment.Text = "Name";
            nameEditSegment.Width = 795;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label62.Location = new Point(1320, 82);
            label62.Name = "label62";
            label62.Size = new Size(13, 18);
            label62.TabIndex = 94;
            label62.Text = "-";
            // 
            // editTripReturnDatePicker
            // 
            editTripReturnDatePicker.Location = new Point(1339, 79);
            editTripReturnDatePicker.Margin = new Padding(3, 2, 3, 2);
            editTripReturnDatePicker.Name = "editTripReturnDatePicker";
            editTripReturnDatePicker.Size = new Size(219, 23);
            editTripReturnDatePicker.TabIndex = 93;
            // 
            // editTripDepartureDatePicker
            // 
            editTripDepartureDatePicker.Location = new Point(1095, 79);
            editTripDepartureDatePicker.Margin = new Padding(3, 2, 3, 2);
            editTripDepartureDatePicker.Name = "editTripDepartureDatePicker";
            editTripDepartureDatePicker.Size = new Size(219, 23);
            editTripDepartureDatePicker.TabIndex = 92;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label63.Location = new Point(619, 2);
            label63.Name = "label63";
            label63.Size = new Size(239, 68);
            label63.TabIndex = 91;
            label63.Text = "Edit trip";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label64.Location = new Point(986, 84);
            label64.Name = "label64";
            label64.Size = new Size(101, 16);
            label64.TabIndex = 90;
            label64.Text = "Date of the trip";
            // 
            // tripNameEditInput
            // 
            tripNameEditInput.Location = new Point(154, 79);
            tripNameEditInput.Margin = new Padding(3, 2, 3, 2);
            tripNameEditInput.Name = "tripNameEditInput";
            tripNameEditInput.Size = new Size(438, 23);
            tripNameEditInput.TabIndex = 89;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label65.Location = new Point(41, 84);
            label65.Name = "label65";
            label65.Size = new Size(107, 16);
            label65.TabIndex = 88;
            label65.Text = "Name of the trip";
            // 
            // returnFromEditTripButton
            // 
            returnFromEditTripButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            returnFromEditTripButton.ForeColor = Color.FromArgb(1, 183, 99);
            returnFromEditTripButton.Location = new Point(1, 1);
            returnFromEditTripButton.Margin = new Padding(3, 2, 3, 2);
            returnFromEditTripButton.Name = "returnFromEditTripButton";
            returnFromEditTripButton.Size = new Size(48, 52);
            returnFromEditTripButton.TabIndex = 87;
            returnFromEditTripButton.Text = "◀️";
            returnFromEditTripButton.UseVisualStyleBackColor = true;
            returnFromEditTripButton.Click += returnFromEditTripButton_Click;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 981);
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
            ((System.ComponentModel.ISupportInitialize)slideShowPictureBox).EndInit();
            newTripPanel.ResumeLayout(false);
            newTripPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expValueAddInput).EndInit();
            inspectTripPanel.ResumeLayout(false);
            inspectTripPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memDetailsPhotoPictureBox).EndInit();
            browseTripPanel.ResumeLayout(false);
            browseTripPanel.PerformLayout();
            editTripPanel.ResumeLayout(false);
            editTripPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expValueEditInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Button newTripButton;
        private Panel newTripPanel;
        private Button browseTripsButton;
        private Label titleLabel;
        private PictureBox slideShowPictureBox;
        private Button returnFromAddButton;
        private Panel inspectTripPanel;
        private Label depDateLabel;
        private TextBox tripNameAddInput;
        private Label nameLabel;
        private Label newTripLabel;
        private DateTimePicker addTripReturnDatePicker;
        private DateTimePicker addTripDepartureDatePicker;
        private Label timerLabel;
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
        private Button saveAddTripButton;
        private Button segRemoveAddButton;
        private Button segUpdateAddButton;
        private Button segAddAddButton;
        private Button landUpdateAddButton;
        private Button landAddAddButton;
        private Button landRemoveAddButton;
        private Button restUpdateAddButton;
        private Button restAddAddButton;
        private Button restRemoveAddButton;
        private Button expUpdateAddButton;
        private Button expAddAddButton;
        private Button expRemoveAddButton;
        private Button memUpdateAddButton;
        private Button memAddAddButton;
        private Button memRemoveAddButton;
        private Label restTypeLabel;
        private Label restContactLabel;
        private Label restAddressLabel;
        private Label restCityLabel;
        private Label restCountryLabel;
        private Label restNameLabel;
        private Label memNoteLabel;
        private Label memSongLabel;
        private Label memPhotoLabel;
        private Label expValueLabel;
        private Label expNameLabel;
        private Label landDescLabel;
        private Label landAddressLabel;
        private Label landCityLabel;
        private Label landCountryLabel;
        private Label landNameLabel;
        private Label segNameLabel;
        private RadioButton restCampingAddRadioButton;
        private RadioButton restApartmentAddRadioButton;
        private RadioButton restRoomAddRadioButton;
        private RadioButton restHostelAddRadioButton;
        private RadioButton restHotelAddRadioButton;
        private TextBox landNameAddInput;
        private TextBox landDescAddInput;
        private TextBox landAddressAddInput;
        private TextBox landCityAddInput;
        private TextBox landCountryAddInput;
        private TextBox restContactAddInput;
        private TextBox restAddressAddInput;
        private TextBox restCityAddInput;
        private TextBox restCountryAddInput;
        private TextBox restNameAddInput;
        private TextBox memSongAddInput;
        private TextBox expNameAddInput;
        private TextBox segNameAddInput;
        private RichTextBox memNoteAddInput;
        private RichTextBox memNoteTextBox;
        private PictureBox memDetailsPhotoPictureBox;
        private TextBox segNameTextBox;
        private TextBox memSongTextBos;
        private TextBox expValueTextBox;
        private TextBox expNameTextBox;
        private TextBox restContactTextBox;
        private TextBox restAddressTextBox;
        private TextBox restCityTextBox;
        private TextBox restCountryTextBox;
        private TextBox restNameTextBox;
        private TextBox landDescTextBox;
        private TextBox landAddressTextBox;
        private TextBox landCityTextBox;
        private TextBox landCountryTextBox;
        private TextBox landNameTextBox;
        private RadioButton restCampingDetailsRadioButton;
        private RadioButton restApartmentDetailsRadioButton;
        private RadioButton restRoomDetailsRadioButton;
        private RadioButton restHostelDetailsRadioButton;
        private RadioButton restHotelDetailsRadioButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button editButton;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private ListView memoriesListView;
        private ListView expensesListView;
        private ListView restingPointListView;
        private ListView landmarkListView;
        private ListView listView9;
        private ListView segmentsListView;
        private Label label31;
        private DateTimePicker tripReturnDatePicker;
        private DateTimePicker tripDepartureDatePicker;
        private Label label32;
        private Label label33;
        private TextBox tripNameTextBox;
        private Label label34;
        private Button returnFromInspectButton;
        private Button returnFromBrowseButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label browseLabel;
        private Panel tripListPanel;
        private Panel browseTripPanel;
        private Panel editTripPanel;
        private RichTextBox memNoteEditInput;
        private TextBox segNameEditInput;
        private TextBox memSongEditInput;
        private TextBox expNameEditInput;
        private TextBox restContactEditInput;
        private TextBox restAddressEditInput;
        private TextBox restCityEditInput;
        private TextBox restCountryEditInput;
        private TextBox restNameEditInput;
        private TextBox landDescEditInput;
        private TextBox landAddressEditInput;
        private TextBox landCityEditInput;
        private TextBox landCountryEditInput;
        private TextBox landNameEditInput;
        private RadioButton restCampingEditRadioButton;
        private RadioButton restApartmentEditRadioButton;
        private RadioButton restRoomEditRadioButton;
        private RadioButton restHostelEditRadioButton;
        private RadioButton restHotelEditRadioButton;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Button landUpdateEditButton;
        private Button landAddEditButton;
        private Button landRemoveEditButton;
        private Button restUpdateEditButton;
        private Button restAddEditButton;
        private Button restRemoveEditButton;
        private Button expUpdateEditButton;
        private Button expAddEditButton;
        private Button expRemoveEditButton;
        private Button memUpdateEditButton;
        private Button memAddEditButton;
        private Button memRemoveEditButton;
        private Button segUpdateEditButton;
        private Button segAddEditButton;
        private Button segRemoveEditButton;
        private Button saveEditTripButton;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private ListView listView11;
        private ListView listView12;
        private ListView restEditPanel;
        private ListView listView14;
        private ListView memoriesEditListView;
        private ListView expensesEditListView;
        private ListView restingEditPointListView;
        private ListView landmarkEditListView;
        private ListView listView19;
        private ListView segmentsEditListView;
        private Label label62;
        private DateTimePicker editTripReturnDatePicker;
        private DateTimePicker editTripDepartureDatePicker;
        private Label label63;
        private Label label64;
        private TextBox tripNameEditInput;
        private Label label65;
        private Button returnFromEditTripButton;
        private Button createSlideShowButton;
        private Button recomLandmarkAddButton;
        private Button recomLandmarkEditButton;
        private Label timerNameLabel;
        private MonthCalendar monthCalendar;
        private ColumnHeader idSegment;
        private ColumnHeader nameSegment;
        private ColumnHeader idLandmark;
        private ColumnHeader nameLandmark;
        private ColumnHeader idMemory;
        private ColumnHeader photoMemory;
        private ColumnHeader idExpenses;
        private ColumnHeader nameExpenses;
        private ColumnHeader idRestingPoint;
        private ColumnHeader nameRestingPoint;
        private ColumnHeader idEditLand;
        private ColumnHeader nameLandEdit;
        private ColumnHeader idEditSegment;
        private ColumnHeader nameEditSegment;
        private ColumnHeader idEditMemory;
        private ColumnHeader nameEditMemory;
        private ColumnHeader idEditExpense;
        private ColumnHeader nameEditExpense;
        private ColumnHeader idEditRestingPoint;
        private ColumnHeader nameEditRestingPoint;

        private NumericUpDown expValueEditInput;
        private Label label1;
        private TextBox memNameEditInput;
        private Button memPhotoButtonSelect;
        private TextBox memPhotoEditInput;
        private Label label2;
        private TextBox memNameAddInput;
        private TextBox memPhotoAddInput;
        private Button memPhotoAddButtonSelect;
        private ColumnHeader idAddSegment;
        private ColumnHeader nameAddSegment;
        private ColumnHeader idAddLand;
        private ColumnHeader nameLandAdd;
        private ColumnHeader idAddRestingPoint;
        private ColumnHeader nameAddRestingPoint;
        private ColumnHeader idAddMemory;
        private ColumnHeader nameMemoryAdd;
        private ColumnHeader idAddExpense;
        private ColumnHeader nameExpenseAdd;
        private NumericUpDown expValueAddInput;
    }
}