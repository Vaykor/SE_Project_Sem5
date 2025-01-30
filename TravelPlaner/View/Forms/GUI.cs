using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlaner.Controller;
using TravelPlaner.Model.Classes.Database;
using TravelPlaner.Controller.Helpers.APIs;

namespace TravelPlaner.View.Forms
{
    public partial class GUI : Form
    {
        ProgramController controller = new ProgramController();

        Trip editedTrip = new Trip();
        List<TripSegment> editedSegmentList = new List<TripSegment>();
        TripSegment editedSegment = new TripSegment();
        Landmark editedLandmark = new Landmark();
        RestingPoint editedRestingPoint = new RestingPoint();
        Expense editedExpense = new Expense();
        TripMemory editedMemory = new TripMemory();
        private System.Windows.Forms.Timer timer;
        private readonly CncApiHelper apiHelperCNC;




        public GUI()
        {
            // Initialize the calendar
            List<Trip> trips = controller.GetAllTrips();
            // calendarMarks(trips);

            // Initialize the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            InitializeComponent();

            apiHelperCNC = new CncApiHelper();
            InitializeComboBoxes();

        }
        private void GUI_Load(object sender, EventArgs e)
        {

            // Initialize with only Panel1 visible
            ShowPanel(menuPanel);

        }

        private async void InitializeComboBoxes()
        {
            landCountryEditInput.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            landCountryEditInput.AutoCompleteSource = AutoCompleteSource.ListItems;
            landCityEditInput.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            landCityEditInput.AutoCompleteSource = AutoCompleteSource.ListItems;

            restCountryEditInput.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            restCountryEditInput.AutoCompleteSource = AutoCompleteSource.ListItems;
            restCityEditInput.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            restCityEditInput.AutoCompleteSource = AutoCompleteSource.ListItems;

            try
            {
                var countries = await apiHelperCNC.GetCountriesAsync();

                landCountryEditInput.DataSource = new BindingList<string>(countries);
                restCountryEditInput.DataSource = new BindingList<string>(countries);
                landCountryAddInput.DataSource = new BindingList<string>(countries);
                restCountryAddInput.DataSource = new BindingList<string>(countries);

                // Handle country selection change
                landCountryEditInput.SelectedIndexChanged += async (sender, e) =>
                {
                    if (landCountryEditInput.SelectedItem is string selectedCountry)
                    {
                        var currentCity = landCityEditInput.Text;
                        var cities = await apiHelperCNC.GetCitiesForCountryAsync(selectedCountry);
                        landCityEditInput.DataSource = new BindingList<string>(cities);

                        if (cities.Contains(currentCity))
                        {
                            landCityEditInput.Text = currentCity;
                        }
                    }
                };

                restCountryEditInput.SelectedIndexChanged += async (sender, e) =>
                {
                    if (restCountryEditInput.SelectedItem is string selectedCountry)
                    {
                        var currentCity = restCityEditInput.Text;
                        var cities = await apiHelperCNC.GetCitiesForCountryAsync(selectedCountry);
                        restCityEditInput.DataSource = new BindingList<string>(cities);

                        if (cities.Contains(currentCity))
                        {
                            restCityEditInput.Text = currentCity;
                        }
                    }
                };

                restCountryAddInput.SelectedIndexChanged += async (sender, e) =>
                {
                    if (restCountryAddInput.SelectedItem is string selectedCountry)
                    {
                        var currentCity = restCityAddInput.Text;
                        var cities = await apiHelperCNC.GetCitiesForCountryAsync(selectedCountry);
                        restCityAddInput.DataSource = new BindingList<string>(cities);

                        if (cities.Contains(currentCity))
                        {
                            restCityAddInput.Text = currentCity;
                        }
                    }
                };

                landCountryAddInput.SelectedIndexChanged += async (sender, e) =>
                {
                    if (landCountryAddInput.SelectedItem is string selectedCountry)
                    {
                        var currentCity = landCityAddInput.Text;
                        var cities = await apiHelperCNC.GetCitiesForCountryAsync(selectedCountry);
                        landCityAddInput.DataSource = new BindingList<string>(cities);

                        if (cities.Contains(currentCity))
                        {
                            landCityAddInput.Text = currentCity;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing comboboxes: {ex.Message}");
            }
        }

        // Method to show a specific panel and hide others
        private void ShowPanel(Panel panelToShow)
        {
            menuPanel.Visible = false;
            newTripPanel.Visible = false;
            browseTripPanel.Visible = false;
            inspectTripPanel.Visible = false;
            editTripPanel.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<Trip> trips = controller.GetAllTrips();
            timerMethod(trips);
        }

        private void timerMethod(List<Trip> trips)
        {

            DateTime now = DateTime.Now;

            var currentTrips = trips.Where(t => t.StartDate <= now && t.EndDate >= now).ToList();

            if (currentTrips.Count > 0)
            {
                // If there is a trip currently in progress
                Trip ongoingTrip = currentTrips[0]; // Get the first trip in progress
                timerNameLabel.Text = $"\"{ongoingTrip.Name}\":";
                timerLabel.Text = "Have a safe trip!";
            }
            else
            {
                // If no trips are in progress, find the next upcoming trip
                var sortedTrips = trips.Where(t => t.StartDate > now).OrderBy(t => t.StartDate).ToList();

                if (sortedTrips.Count > 0)
                {
                    // If there is an upcoming trip
                    Trip nearestTrip = sortedTrips[0];
                    TimeSpan timeLeft = nearestTrip.StartDate - now;

                    timerNameLabel.Text = $"\"{nearestTrip.Name}\" in:";
                    timerLabel.Text = $"{timeLeft.Days}d {timeLeft.Hours}h {timeLeft.Minutes}m {timeLeft.Seconds}s";
                }
                else
                {
                    // If no trips are in progress or upcoming
                    timerNameLabel.Text = "No upcoming trips.";
                    timerLabel.Text = "";
                }
            }

            // Refresh labels
            timerNameLabel.Refresh();
            timerLabel.Refresh();
        }

        private void calendarMarks(List<Trip> trips)
        {
            List<DateTime> boldedDates = new List<DateTime>();

            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            monthCalendar.BackColor = Color.FromArgb(246, 246, 246);
            monthCalendar.CalendarDimensions = new Size(2, 3);
            monthCalendar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            monthCalendar.ForeColor = SystemColors.InactiveBorder;
            monthCalendar.Location = new Point(1084, 129);
            monthCalendar.Margin = new Padding(8, 7, 8, 7);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;

            this.Controls.Add(this.monthCalendar);

            if (this.monthCalendar == null)
            {
                MessageBox.Show("MonthCalendar control is not initialized.");
                return;
            }

            foreach (var trip in trips)
            {
                DateTime startDateFromDB = trip.StartDate;
                DateTime endDateFromDB = trip.EndDate;

                int startYear = startDateFromDB.Year;
                int startMonth = startDateFromDB.Month;
                int startDay = startDateFromDB.Day;

                int endYear = endDateFromDB.Year;
                int endMonth = endDateFromDB.Month;
                int endDay = endDateFromDB.Day;


                for (DateTime date = startDateFromDB; date <= endDateFromDB; date = date.AddDays(1))
                {
                    boldedDates.Add(date);
                }
            }

            // Set the bolded dates in the calendar
            this.monthCalendar.BoldedDates = boldedDates.ToArray();

            // Refresh the calendar to reflect the changes
            this.monthCalendar.Update();
        }






        //--------------------Menu Panel--------------------

        private void newTripButton_Click(object sender, EventArgs e)
        {
            ShowPanel(newTripPanel);
            landNameLabel.Enabled = false;
            landCountryLabel.Enabled = false;
            landCityLabel.Enabled = false;
            landAddressLabel.Enabled = false;
            landDescLabel.Enabled = false;

            landNameAddInput.Enabled = false;
            landCountryAddInput.Enabled = false;
            landCityAddInput.Enabled = false;
            landAddressAddInput.Enabled = false;
            landDescAddInput.Enabled = false;
            recomLandmarkAddButton.Enabled = false;
            landRemoveAddButton.Enabled = false;
            landUpdateAddButton.Enabled = false;
            landAddAddButton.Enabled = false;

            restNameLabel.Enabled = false;
            restCountryLabel.Enabled = false;
            restCityLabel.Enabled = false;
            restContactLabel.Enabled = false;
            restAddressLabel.Enabled = false;

            restNameAddInput.Enabled = false;
            restCountryAddInput.Enabled = false;
            restCityAddInput.Enabled = false;
            restContactAddInput.Enabled = false;
            restAddressAddInput.Enabled = false;

            restTypeLabel.Enabled = false;
            restHotelAddRadioButton.Enabled = false;
            restHostelAddRadioButton.Enabled = false;
            restApartmentAddRadioButton.Enabled = false;
            restRoomAddRadioButton.Enabled = false;
            restCampingAddRadioButton.Enabled = false;
            restRemoveAddButton.Enabled = false;
            restUpdateAddButton.Enabled = false;
            restAddAddButton.Enabled = false;

            expNameLabel.Enabled = false;
            expValueLabel.Enabled = false;
            expNameAddInput.Enabled = false;
            expValueAddInput.Enabled = false;
            expRemoveAddButton.Enabled = false;
            expUpdateAddButton.Enabled = false;
            expAddAddButton.Enabled = false;

            memPhotoLabel.Enabled = false;
            memSongLabel.Enabled = false;
            memSongAddInput.Enabled = false;
            memNoteAddInput.Enabled = false;
            memNoteLabel.Enabled = false;
            memRemoveAddButton.Enabled = false;
            memUpdateAddButton.Enabled = false;
            memAddAddButton.Enabled = false;


            segNameLabel.Enabled = false;
            segNameAddInput.Enabled = false;
            segRemoveAddButton.Enabled = false;
            segAddAddButton.Enabled = false;
            segUpdateAddButton.Enabled = false;
        }


        //-------------------Browse Panel---------------------
        private void browseTripsButton_Click(object sender, EventArgs e)
        {
            browseTrips();
        }
        private void browseTrips()
        {
            ShowPanel(browseTripPanel);

            // Fetch trips from database
            List<Trip> trips = controller.GetAllTrips();

            int panelY = 10; // Vertical position for each trip panel
            foreach (var trip in trips)
            {
                // Fetch trip segments and count them
                List<TripSegment> tripSegments = controller.GetAllTripSegmentsByTripId(trip.Id);

                int segmentCount = tripSegments.Count;





                // Fetch destinations for the first segment (if needed)
                string destinationName = tripSegments.FirstOrDefault() != null ? controller.GetAllDestinationsByTripSegmentId(tripSegments.First().Id).FirstOrDefault()?.Country : "Unknown";

                // Create a new panel for the trip
                Panel tripPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(tripListPanel.Width - 200, 100),
                    Location = new Point(50, panelY),
                    BackColor = Color.White,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                // Add a label for the trip name and destination
                Label nameLabel = new Label
                {
                    Text = $"{trip.Name},    Destination: {destinationName}",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(10, 10),
                    ForeColor = Color.Black,
                    AutoSize = true
                };
                tripPanel.Controls.Add(nameLabel);

                // Add a label for the start and end dates
                Label dateLabel = new Label
                {
                    Text = $"Date of the trip: {trip.StartDate.ToShortDateString()} - {trip.EndDate.ToShortDateString()}",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(10, 40),
                    AutoSize = true
                };
                tripPanel.Controls.Add(dateLabel);

                // Add a label for the number of segments
                Label segmentLabel = new Label
                {
                    Text = $"Number of Segments: {segmentCount}",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Location = new Point(10, 70),
                    AutoSize = true
                };
                tripPanel.Controls.Add(segmentLabel);

                Button viewButton = new Button
                {
                    Text = "🔍",
                    Font = new Font("Arial", 30, FontStyle.Regular),
                    Size = new Size(40, 40),
                    Location = new Point(tripPanel.Width - 100, 20),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(1, 183, 99),
                    FlatStyle = FlatStyle.Flat
                };

                // Remove the border
                viewButton.FlatAppearance.BorderSize = 0;
                viewButton.BackColor = Color.White;

                tripPanel.Controls.Add(viewButton);
                viewButton.Click += (sender, e) => ShowTripDetails(trip, tripSegments);

                // Add the trip panel to the parent panel
                tripListPanel.Controls.Add(tripPanel);
                panelY += 110; // Increment the Y position for the next panel
            }
        }

        private void returnFromBrowseButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            tripListPanel.Controls.Clear();
        }



        //----------------Trip details panel-------------------
        private void ShowTripDetails(Trip trip, List<TripSegment> tripSegments)
        {
            tripListPanel.Controls.Clear();
            ShowPanel(inspectTripPanel);
            editedTrip = trip;
            editedSegmentList = tripSegments;
            memDetailsPhotoPictureBox.Image = null;
            memNoteTextBox.Text = "";
            landmarkListView.Items.Clear();
            restingPointListView.Items.Clear();
            expensesListView.Items.Clear();
            memoriesListView.Items.Clear();
            segmentsListView.Items.Clear();
            foreach (Control control in inspectTripPanel.Controls) // Replace 'myPanel' with your container
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            foreach (Control control in inspectTripPanel.Controls) // Replace 'myPanel' with your container
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            tripDepartureDatePicker.Text = editedTrip.StartDate.ToString();
            tripReturnDatePicker.Text = editedTrip.EndDate.ToString();
            tripNameTextBox.Text = editedTrip.Name;
            foreach (TripSegment segment in editedSegmentList)
            {
                ListViewItem item = new ListViewItem(editedTrip.Id.ToString());
                item.SubItems.Add(segment.Name.ToString());
                segmentsListView.Items.Add(item);
                item.Tag = segment;
            }
            segmentsListView.ItemActivate += segmentsListView_ItemActivate;

            void segmentsListView_ItemActivate(object sender, EventArgs e)
            {

                memDetailsPhotoPictureBox.Image = null;
                memNoteTextBox.Text = "";
                foreach (Control control in inspectTripPanel.Controls) // Replace 'myPanel' with your container
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                foreach (Control control in inspectTripPanel.Controls) // Replace 'myPanel' with your container
                {
                    if (control is RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                }
                tripNameTextBox.Text = editedTrip.Name;
                ListViewItem selectedItem = segmentsListView.SelectedItems[0];
                if (selectedItem.Tag is TripSegment segment)
                {

                    landmarkListView.Items.Clear();
                    restingPointListView.Items.Clear();
                    expensesListView.Items.Clear();
                    memoriesListView.Items.Clear();
                    List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(segment.Id);
                    segNameTextBox.Text = segment.Name;

                    foreach (Expense expense in expenses)
                    {
                        ListViewItem item = new ListViewItem(expense.Id.ToString()); // First column (Id)
                        item.SubItems.Add(expense.Name);                            // Second column (Name)// Third column (StartDate)
                                                                                    // Add row to ListView
                        expensesListView.Items.Add(item);
                        item.Tag = expense;
                    }
                    expensesListView.ItemActivate += expenseListView_ItemActivate;
                    void expenseListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedExpenseItem = expensesListView.SelectedItems[0];
                        if (selectedExpenseItem.Tag is Expense expense)
                        {
                            expNameTextBox.Text = expense.Name;
                            expValueTextBox.Text = expense.Value.ToString();
                        }
                    }


                    List<Landmark> landmarks = controller.GetAllLandmarksByTripSegmentId(segment.Id);
                    foreach (Landmark landmark in landmarks)
                    {

                        ListViewItem item = new ListViewItem(landmark.Id.ToString()); // First column (Id)
                        item.SubItems.Add(landmark.Name);                            // Second column (Name)
                                                                                     // Third column (StartDate)
                                                                                     // Add row to ListView
                        landmarkListView.Items.Add(item);
                        item.Tag = landmark;
                    }
                    landmarkListView.ItemActivate += landmarkListView_ItemActivate;
                    void landmarkListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedLandmarkItem = landmarkListView.SelectedItems[0];
                        if (selectedLandmarkItem.Tag is Landmark landmark)
                        {
                            landNameTextBox.Text = landmark.Name;
                            landCountryTextBox.Text = landmark.Country;
                            landCityTextBox.Text = landmark.City;
                            landAddressTextBox.Text = landmark.Address;
                            landDescTextBox.Text = landmark.Description;
                        }
                    }

                    List<RestingPoint> restingPoints = controller.GetAllRestingPointsByTripSegmentId(segment.Id);
                    foreach (RestingPoint restingPoint in restingPoints)
                    {

                        ListViewItem item = new ListViewItem(restingPoint.Id.ToString()); // First column (Id)
                        item.SubItems.Add(restingPoint.Name);                            // Second column (Name)
                        ;// Third column (StartDate)
                         // Add row to ListView
                        restingPointListView.Items.Add(item);
                        item.Tag = restingPoint;
                    }
                    restingPointListView.ItemActivate += restingPointListView_ItemActivate;
                    void restingPointListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedRestingPointItem = restingPointListView.SelectedItems[0];
                        if (selectedRestingPointItem.Tag is RestingPoint restingPoint)
                        {
                            restNameTextBox.Text = restingPoint.Name;
                            restCountryTextBox.Text = restingPoint.Country;
                            restCityTextBox.Text = restingPoint.City;
                            restAddressTextBox.Text = restingPoint.Address;
                            restContactTextBox.Text = restingPoint.ContactInfo;
                            switch ((int)restingPoint.Type)
                            {
                                case 0:
                                    restHotelDetailsRadioButton.Checked = true;
                                    break;
                                case 1:
                                    restHostelDetailsRadioButton.Checked = true;
                                    break;
                                case 2:
                                    restRoomDetailsRadioButton.Checked = true;
                                    break;
                                case 3:
                                    restApartmentDetailsRadioButton.Checked = true;
                                    break;
                                case 4:
                                    restCampingDetailsRadioButton.Checked = true;
                                    break;
                            }
                        }
                    }

                    List<TripMemory> memories = controller.GetAllTripMemoriesByTripSegmentId(segment.Id);
                    foreach (TripMemory memory in memories)
                    {
                        ListViewItem item = new ListViewItem(memory.Id.ToString());
                        item.SubItems.Add(memory.Name);
                        memoriesListView.Items.Add(item);
                        item.Tag = memory;
                    }
                    memoriesListView.ItemActivate += memoryListView_ItemActivate;
                    void memoryListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedMemoryItem = memoriesListView.SelectedItems[0];
                        if (selectedMemoryItem.Tag is TripMemory memory)
                        {
                            memDetailsPhotoPictureBox.ImageLocation = memory.Photo;
                            memSongTextBos.Text = memory.SongURL;
                            memNoteTextBox.Text = memory.Note;
                        }
                    }
                }

            }
        }

        private void UpdateEditPanels(Trip trip, List<TripSegment> segments)
        {
            segUpdateEditButton.Enabled = false;
            segRemoveEditButton.Enabled = false;
            memPhotoEditInput.Text = null;
            memNoteEditInput.Text = "";
            landmarkEditListView.Items.Clear();
            restingEditPointListView.Items.Clear();
            expensesEditListView.Items.Clear();
            memoriesEditListView.Items.Clear();
            segmentsEditListView.Items.Clear();
            foreach (Control control in editTripPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
            tripNameEditInput.Text = trip.Name;
            editTripDepartureDatePicker.Value = trip.StartDate;
            editTripReturnDatePicker.Value = trip.EndDate;
            segmentsEditListView.ItemActivate -= segmentsEditListView_ItemActivate;
            foreach (TripSegment segment in segments)
            {
                ListViewItem item = new ListViewItem(trip.Id.ToString());
                item.SubItems.Add(segment.Name.ToString());
                segmentsEditListView.Items.Add(item);
                item.Tag = segment;
            }

            segmentsEditListView.ItemActivate += segmentsEditListView_ItemActivate;

            void segmentsEditListView_ItemActivate(object sender, EventArgs e)
            {
                segUpdateEditButton.Enabled = true;
                segRemoveEditButton.Enabled = true;
                memPhotoEditInput.Text = null;
                memNoteEditInput.Text = "";
                foreach (Control control in editTripPanel.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                foreach (Control control in editTripPanel.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                }
                tripNameEditInput.Text = trip.Name;
                ListViewItem selectedEditItem = segmentsEditListView.SelectedItems[0];
                if (selectedEditItem.Tag is TripSegment segment)
                {
                    editedSegment = segment;
                    landmarkEditListView.Items.Clear();
                    restingEditPointListView.Items.Clear();
                    expensesEditListView.Items.Clear();
                    memoriesEditListView.Items.Clear();
                    List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(editedSegment.Id);
                    segNameEditInput.Text = editedSegment.Name;


                    foreach (Expense expense in expenses)
                    {
                        ListViewItem item = new ListViewItem(expense.Id.ToString()); // First column (Id)
                        item.SubItems.Add(expense.Name);                            // Second column (Name)// Third column (StartDate)
                                                                                    // Add row to ListView
                        expensesEditListView.Items.Add(item);
                        item.Tag = expense;
                    }
                    expensesEditListView.ItemActivate += expenseEditListView_ItemActivate;
                    void expenseEditListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedEditExpenseItem = expensesEditListView.SelectedItems[0];
                        if (selectedEditExpenseItem.Tag is Expense expense)
                        {
                            editedExpense = expense;
                            expNameEditInput.Text = expense.Name;
                            expValueEditInput.Text = expense.Value.ToString();
                        }
                    }


                    List<Landmark> landmarks = controller.GetAllLandmarksByTripSegmentId(segment.Id);
                    foreach (Landmark landmark in landmarks)
                    {

                        ListViewItem item = new ListViewItem(landmark.Id.ToString()); // First column (Id)
                        item.SubItems.Add(landmark.Name);                            // Second column (Name)
                                                                                     // Third column (StartDate)
                                                                                     // Add row to ListView
                        landmarkEditListView.Items.Add(item);
                        item.Tag = landmark;
                    }
                    landmarkEditListView.ItemActivate += landmarkEditListView_ItemActivate;
                    async void landmarkEditListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedEditLandmarkItem = landmarkEditListView.SelectedItems[0];
                        if (selectedEditLandmarkItem.Tag is Landmark landmark)
                        {
                            editedLandmark = landmark;
                            string countryValue = landmark.Country;

                            // Only update the SelectedItem, not the DataSource
                            if (landCountryEditInput.Items.Contains(countryValue))
                            {
                                landCountryEditInput.SelectedItem = countryValue;
                            }
                            else
                            {
                                landCountryEditInput.Text = countryValue;
                            }

                            // The city will be updated by the SelectedIndexChanged event
                            landCityEditInput.Text = landmark.City;
                            landAddressEditInput.Text = landmark.Address;
                            landDescEditInput.Text = landmark.Description;
                            landNameEditInput.Text = landmark.Name;
                        }
                    }

                    List<RestingPoint> restingPoints = controller.GetAllRestingPointsByTripSegmentId(segment.Id);
                    foreach (RestingPoint restingPoint in restingPoints)
                    {

                        ListViewItem item = new ListViewItem(restingPoint.Id.ToString()); // First column (Id)
                        item.SubItems.Add(restingPoint.Name);                            // Second column (Name)
                        ;// Third column (StartDate)
                         // Add row to ListView
                        restingEditPointListView.Items.Add(item);
                        item.Tag = restingPoint;
                    }
                    restingEditPointListView.ItemActivate += restingEditPointListView_ItemActivate;
                    void restingEditPointListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedEditRestingPointItem = restingEditPointListView.SelectedItems[0];
                        if (selectedEditRestingPointItem.Tag is RestingPoint restingPoint)
                        {
                            editedRestingPoint = restingPoint;
                            restNameEditInput.Text = restingPoint.Name;

                            // Store the country value before updating combobox
                            string countryValue = restingPoint.Country;

                            // Update country selection while preserving the DataSource
                            if (restCountryEditInput.Items.Contains(countryValue))
                            {
                                restCountryEditInput.SelectedItem = countryValue;
                            }
                            else
                            {
                                restCountryEditInput.Text = countryValue;
                            }

                            // The city will be updated by the SelectedIndexChanged event of the country combobox
                            restCityEditInput.Text = restingPoint.City;

                            restAddressEditInput.Text = restingPoint.Address;
                            restContactEditInput.Text = restingPoint.ContactInfo;
                            switch ((int)restingPoint.Type)
                            {
                                case 0:
                                    restHotelEditRadioButton.Checked = true;
                                    break;
                                case 1:
                                    restHostelEditRadioButton.Checked = true;
                                    break;
                                case 2:
                                    restRoomEditRadioButton.Checked = true;
                                    break;
                                case 3:
                                    restApartmentEditRadioButton.Checked = true;
                                    break;
                                case 4:
                                    restCampingEditRadioButton.Checked = true;
                                    break;
                            }
                        }
                    }

                    List<TripMemory> memories = controller.GetAllTripMemoriesByTripSegmentId(segment.Id);
                    foreach (TripMemory memory in memories)
                    {
                        ListViewItem item = new ListViewItem(memory.Id.ToString());
                        item.SubItems.Add(memory.Name);
                        memoriesEditListView.Items.Add(item);
                        item.Tag = memory;
                    }
                    memoriesEditListView.ItemActivate += memoryEditListView_ItemActivate;
                    void memoryEditListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedEditMemoryItem = memoriesEditListView.SelectedItems[0];
                        if (selectedEditMemoryItem.Tag is TripMemory memory)
                        {
                            editedMemory = memory;
                            memNameEditInput.Text = memory.Name;
                            memPhotoEditInput.Text = memory.Photo;
                            memSongEditInput.Text = memory.SongURL;
                            memNoteEditInput.Text = memory.Note;
                        }
                    }
                }
            }
        }

        private void UpdateAddPanels(Trip trip, List<TripSegment> segments)
        {
            segUpdateAddButton.Enabled = false;
            segRemoveAddButton.Enabled = false;
            memPhotoAddInput.Text = null;
            memNoteAddInput.Text = "";
            landmarksList.Items.Clear();
            restingPointsList.Items.Clear();
            expensesList.Items.Clear();
            memoriesList.Items.Clear();
            segmentsList.Items.Clear();
            foreach (Control control in newTripPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
            tripNameAddInput.Text = trip.Name;
            addTripDepartureDatePicker.Value = trip.StartDate;
            addTripReturnDatePicker.Value = trip.EndDate;
            segmentsList.ItemActivate -= segmentsList_ItemActivate;
            foreach (TripSegment segment in segments)
            {
                ListViewItem item = new ListViewItem(trip.Id.ToString());
                item.SubItems.Add(segment.Name.ToString());
                segmentsList.Items.Add(item);
                item.Tag = segment;
            }

            segmentsList.ItemActivate += segmentsList_ItemActivate;

            void segmentsList_ItemActivate(object sender, EventArgs e)
            {
                segUpdateAddButton.Enabled = true;
                segRemoveAddButton.Enabled = true;
                memPhotoAddInput.Text = null;
                memNoteAddInput.Text = "";
                foreach (Control control in editTripPanel.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    if (control is RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                    if (control is NumericUpDown numericUpDown)
                    {
                        numericUpDown.Value = 0;
                    }
                }
                tripNameAddInput.Text = trip.Name;
                ListViewItem selectedAddItem = segmentsList.SelectedItems[0];
                if (selectedAddItem.Tag is TripSegment segment)
                {
                    editedSegment = segment;
                    landmarksList.Items.Clear();
                    restingPointsList.Items.Clear();
                    expensesList.Items.Clear();
                    memoriesList.Items.Clear();
                    List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(editedSegment.Id);
                    segNameAddInput.Text = editedSegment.Name;


                    foreach (Expense expense in expenses)
                    {
                        ListViewItem item = new ListViewItem(expense.Id.ToString()); // First column (Id)
                        item.SubItems.Add(expense.Name);                            // Second column (Name)// Third column (StartDate)
                                                                                    // Add row to ListView
                        expensesList.Items.Add(item);
                        item.Tag = expense;
                    }
                    expensesList.ItemActivate += expensesList_ItemActivate;
                    void expensesList_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedAddExpenseItem = expensesList.SelectedItems[0];
                        if (selectedAddExpenseItem.Tag is Expense expense)
                        {
                            editedExpense = expense;
                            expNameAddInput.Text = expense.Name;
                            expValueAddInput.Text = expense.Value.ToString();
                        }
                    }


                    List<Landmark> landmarks = controller.GetAllLandmarksByTripSegmentId(segment.Id);
                    foreach (Landmark landmark in landmarks)
                    {

                        ListViewItem item = new ListViewItem(landmark.Id.ToString()); // First column (Id)
                        item.SubItems.Add(landmark.Name);                            // Second column (Name)
                                                                                     // Third column (StartDate)
                                                                                     // Add row to ListView
                        landmarksList.Items.Add(item);
                        item.Tag = landmark;
                    }
                    landmarksList.ItemActivate += landmarksList_ItemActivate;
                    void landmarksList_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedAddLandmarkItem = landmarksList.SelectedItems[0];
                        if (selectedAddLandmarkItem.Tag is Landmark landmark)
                        {
                            editedLandmark = landmark;
                            landNameAddInput.Text = landmark.Name;
                            landCountryAddInput.Text = landmark.Country;
                            landCityAddInput.Text = landmark.City;
                            landAddressAddInput.Text = landmark.Address;
                            landDescAddInput.Text = landmark.Description;
                        }
                    }

                    List<RestingPoint> restingPoints = controller.GetAllRestingPointsByTripSegmentId(segment.Id);
                    foreach (RestingPoint restingPoint in restingPoints)
                    {

                        ListViewItem item = new ListViewItem(restingPoint.Id.ToString()); // First column (Id)
                        item.SubItems.Add(restingPoint.Name);                            // Second column (Name)
                        ;// Third column (StartDate)
                         // Add row to ListView
                        restingPointsList.Items.Add(item);
                        item.Tag = restingPoint;
                    }
                    restingPointsList.ItemActivate += restingPointsList_ItemActivate;
                    void restingPointsList_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedAddRestingPointItem = restingPointsList.SelectedItems[0];
                        if (selectedAddRestingPointItem.Tag is RestingPoint restingPoint)
                        {
                            editedRestingPoint = restingPoint;
                            restNameAddInput.Text = restingPoint.Name;
                            restCountryAddInput.Text = restingPoint.Country;
                            restCityAddInput.Text = restingPoint.City;
                            restAddressAddInput.Text = restingPoint.Address;
                            restContactAddInput.Text = restingPoint.ContactInfo;
                            switch ((int)restingPoint.Type)
                            {
                                case 0:
                                    restHotelAddRadioButton.Checked = true;
                                    break;
                                case 1:
                                    restHostelAddRadioButton.Checked = true;
                                    break;
                                case 2:
                                    restRoomAddRadioButton.Checked = true;
                                    break;
                                case 3:
                                    restApartmentAddRadioButton.Checked = true;
                                    break;
                                case 4:
                                    restCampingAddRadioButton.Checked = true;
                                    break;
                            }
                        }
                    }

                    List<TripMemory> memories = controller.GetAllTripMemoriesByTripSegmentId(segment.Id);
                    foreach (TripMemory memory in memories)
                    {
                        ListViewItem item = new ListViewItem(memory.Id.ToString());
                        item.SubItems.Add(memory.Name);
                        memoriesList.Items.Add(item);
                        item.Tag = memory;
                    }
                    memoriesList.ItemActivate += memoriesList_ItemActivate;
                    void memoriesList_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedAddMemoryItem = memoriesList.SelectedItems[0];
                        if (selectedAddMemoryItem.Tag is TripMemory memory)
                        {
                            editedMemory = memory;
                            memNameAddInput.Text = memory.Name;
                            memPhotoAddInput.Text = memory.Photo;
                            memSongAddInput.Text = memory.SongURL;
                            memNoteAddInput.Text = memory.Note;
                        }
                    }
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            ShowEditTrip(editedTrip, editedSegmentList);
        }
        private void ShowEditTrip(Trip trip, List<TripSegment> tripSegments)
        {
            ShowPanel(editTripPanel);

            Trip passedTrip = trip;
            editedTrip = passedTrip;
            List<TripSegment> segments = tripSegments;

            UpdateEditPanels(passedTrip, segments);
        }

        //SAVE CHANGES TO TRIP ITSELF IN EDIT
        private void saveEditTripButton_Click(object sender, EventArgs e)
        {
            Trip toUpdate = new Trip();
            toUpdate.Id = editedTrip.Id;
            if (tripNameEditInput.Text.IsNullOrEmpty())
            {
                toUpdate.Name = editedTrip.Name;
            }
            else
            {
                toUpdate.Name = tripNameEditInput.Text;
            }
            toUpdate.StartDate = editTripDepartureDatePicker.Value;
            toUpdate.EndDate = editTripReturnDatePicker.Value;
            controller.UpdateTrip(toUpdate);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(toUpdate, editedSegmentList);
            editedTrip = toUpdate;
        }

        //ADD SEGMENT IN EDIT
        private void segAddEditButton_Click(object sender, EventArgs e)
        {
            if (!segNameEditInput.Text.IsNullOrEmpty())
            {
                controller.AddTripSegment(segNameEditInput.Text, new List<TripMemory>(), new List<Expense>(), new List<Destination>(), editedTrip.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }
        //UPDATE SEGMENT IN EDIT
        private void segUpdateEditButton_Click(object sender, EventArgs e)
        {
            if (!segNameEditInput.Text.IsNullOrEmpty())
            {

                TripSegment updateSegment = new TripSegment() { Id = editedSegment.Id, Name = segNameEditInput.Text, TripId = editedTrip.Id };
                controller.UpdateTripSegment(updateSegment);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        //REMOVE SEGMENT IN EDIT
        private void segRemoveEditButton_Click(object sender, EventArgs e)
        {
            controller.DeleteTripSegment(editedSegment);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }

        //ADD LANDMARK IN EDIT
        private void landAddEditButton_Click(object sender, EventArgs e)
        {
            if (!landNameEditInput.Text.IsNullOrEmpty() && !landCountryEditInput.Text.IsNullOrEmpty() && !landCityEditInput.Text.IsNullOrEmpty())
            {
                Landmark addLandmarkFromEdit = new Landmark() { Name = landNameEditInput.Text, Country = landCountryEditInput.Text, City = landCityEditInput.Text, TripSegmentId = editedSegment.Id, Address = landAddressEditInput.Text, Description = landDescEditInput.Text };
                controller.AddDestination(addLandmarkFromEdit);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        //UPDATE LANDMARK IN EDIT
        private void landUpdateEditButton_Click(object sender, EventArgs e)
        {
            if (!landNameEditInput.Text.IsNullOrEmpty() && !landCountryEditInput.Text.IsNullOrEmpty() && !landCityEditInput.Text.IsNullOrEmpty())
            {

                Landmark updateLandmarkFromEdit = new Landmark() { Id = editedLandmark.Id, Name = landNameEditInput.Text, Country = landCountryEditInput.Text, City = landCityEditInput.Text, Address = landAddressEditInput.Text, Description = landDescEditInput.Text, TripSegmentId = editedSegment.Id, };
                controller.UpdateDestination(updateLandmarkFromEdit);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        //REMOVE LANDMARK IN EDIT
        private void landRemoveEditButton_Click(object sender, EventArgs e)
        {
            controller.DeleteLandmark(editedLandmark);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }
        //ADD RESTING POINT IN EDIT
        private void restAddEditButton_Click(object sender, EventArgs e)
        {
            if (!restNameEditInput.Text.IsNullOrEmpty() && !restCountryEditInput.Text.IsNullOrEmpty() && !restCityEditInput.Text.IsNullOrEmpty() && (restHostelEditRadioButton.Checked || restHotelEditRadioButton.Checked || restCampingEditRadioButton.Checked || restApartmentEditRadioButton.Checked || restRoomEditRadioButton.Checked))
            {

                RestingPoint addRestingPointFromEdit = new RestingPoint() { Name = restNameEditInput.Text, Country = restCountryEditInput.Text, City = restCityEditInput.Text, TripSegmentId = editedSegment.Id, Address = restAddressEditInput.Text, ContactInfo = restContactEditInput.Text };
                if (restHostelEditRadioButton.Checked) { addRestingPointFromEdit.Type = Model.Enums.RestingPointType.Hostel; } else if (restHotelEditRadioButton.Checked) { addRestingPointFromEdit.Type = Model.Enums.RestingPointType.Hotel; } else if (restRoomEditRadioButton.Checked) { addRestingPointFromEdit.Type = Model.Enums.RestingPointType.Room; } else if (restApartmentEditRadioButton.Checked) { addRestingPointFromEdit.Type = Model.Enums.RestingPointType.Apartment; } else if (restCampingEditRadioButton.Checked) { addRestingPointFromEdit.Type = Model.Enums.RestingPointType.Camping; }
                controller.AddDestination(addRestingPointFromEdit);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        //UPDATE RESTING POINT IN EDIT
        private void restUpdateEditButton_Click(object sender, EventArgs e)
        {
            if (!restNameEditInput.Text.IsNullOrEmpty() && !restCountryEditInput.Text.IsNullOrEmpty() && !restCityEditInput.Text.IsNullOrEmpty() && (restHostelEditRadioButton.Checked || restHotelEditRadioButton.Checked || restCampingEditRadioButton.Checked || restApartmentEditRadioButton.Checked || restRoomEditRadioButton.Checked))
            {

                RestingPoint updateRestingPointFromEdit = new RestingPoint() { Id = editedRestingPoint.Id, Name = restNameEditInput.Text, Country = restCountryEditInput.Text, City = restCityEditInput.Text, TripSegmentId = editedSegment.Id, Address = restAddressEditInput.Text, ContactInfo = restContactEditInput.Text };
                if (restHostelEditRadioButton.Checked) { updateRestingPointFromEdit.Type = Model.Enums.RestingPointType.Hostel; } else if (restHotelEditRadioButton.Checked) { updateRestingPointFromEdit.Type = Model.Enums.RestingPointType.Hotel; } else if (restRoomEditRadioButton.Checked) { updateRestingPointFromEdit.Type = Model.Enums.RestingPointType.Room; } else if (restApartmentEditRadioButton.Checked) { updateRestingPointFromEdit.Type = Model.Enums.RestingPointType.Apartment; } else if (restCampingEditRadioButton.Checked) { updateRestingPointFromEdit.Type = Model.Enums.RestingPointType.Camping; }
                controller.UpdateDestination(updateRestingPointFromEdit);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }
        //REMOVE RESTING POINT IN EDIT
        private void restRemoveEditButton_Click(object sender, EventArgs e)
        {
            controller.DeleteRestingPoint(editedRestingPoint);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }

        //ADD EXPENSE IN EDIT
        private void expAddEditButton_Click(object sender, EventArgs e)
        {
            if (!expValueEditInput.Text.IsNullOrEmpty() && !expNameEditInput.Text.IsNullOrEmpty())
            {
                controller.AddExpense(expNameEditInput.Text, ((double)expValueEditInput.Value), editedSegment.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }
        //UPDATE EXPENSE IN EDIT
        private void expUpdateEditButton_Click(object sender, EventArgs e)
        {
            if (!expValueEditInput.Text.IsNullOrEmpty() && !expNameEditInput.Text.IsNullOrEmpty())
            {
                Expense updateExpense = new Expense() { Id = editedExpense.Id, Name = expNameEditInput.Text, Value = ((double)expValueEditInput.Value), TripSegmentId = editedSegment.Id };
                controller.UpdateExpense(updateExpense);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }
        //REMOVE EXPENSE IN EDIT
        private void expRemoveEditButton_Click(object sender, EventArgs e)
        {
            controller.DeleteExpense(editedExpense);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }

        //ADD MEMORY IN EDIT
        private void memAddEditButton_Click(object sender, EventArgs e)
        {
            if (!memNameEditInput.Text.IsNullOrEmpty())
            {
                controller.AddTripMemory(memNameEditInput.Text, memPhotoEditInput.Text, memNoteEditInput.Text, memSongEditInput.Text, editedSegment.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
        }

        //UPDATE MEMORY IN EDIT
        private void memUpdateEditButton_Click(object sender, EventArgs e)
        {
            if (!memNameEditInput.Text.IsNullOrEmpty())
            {
                TripMemory updateMemory = new TripMemory() { Id = editedMemory.Id, Name = memNameEditInput.Text, Photo = memPhotoEditInput.Text, Note = memNoteEditInput.Text, SongURL = memSongEditInput.Text, TripSegmentId = editedSegment.Id };
                controller.UpdateTripMemory(updateMemory);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateEditPanels(editedTrip, editedSegmentList);
            }
        }

        //REMOVE MEMORY IN EDIT
        private void memRemoveEditButton_Click(object sender, EventArgs e)
        {
            controller.DeleteTripMemory(editedMemory);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }

        //RETURN FROM EDITING TRIP
        private void returnFromEditTripButton_Click(object sender, EventArgs e)
        {
            ShowTripDetails(editedTrip, editedSegmentList);
        }
        //---------------------returning from add new trips panel--------------------
        private void returnFromAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            //addTripFlowLayoutPanel.Controls.Clear();
        }

        //-------------------returning from inpect trips panel (the magnifying glass button)--------------------
        private void returnFromInspectButton_Click(object sender, EventArgs e)
        {
            browseTrips();
        }


        private void recomLandmarkAddButton_Click(object sender, EventArgs e)
        {
            if (!landCityAddInput.Text.Equals(""))
            {
                RecommendedLandmarks recommendation = new RecommendedLandmarks(landCityAddInput.Text);
                recommendation.ShowDialog();
            }
            else
            {
                PopupForm popup = new PopupForm(3);
                popup.ShowDialog();
            }
        }

        private void recomLandmarksEditButton_Click(object sender, EventArgs e)
        {
            if (!landCityEditInput.Text.Equals(""))
            {
                RecommendedLandmarks recommendation = new RecommendedLandmarks(landCityEditInput.Text);
                recommendation.ShowDialog();
            }
            else
            {
                PopupForm popup = new PopupForm(3);
                popup.ShowDialog();
            }
        }

        private void saveAddTripButton_Click(object sender, EventArgs e)
        {
            if (tripNameAddInput.Text.IsNullOrEmpty())
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
            else
            {
                controller.AddTrip(tripNameAddInput.Text, addTripDepartureDatePicker.Value, addTripReturnDatePicker.Value, new List<TripSegment>());
                editedTrip = controller.GetLastTrip();
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);

                landNameLabel.Enabled = true;
                landCountryLabel.Enabled = true;
                landCityLabel.Enabled = true;
                landAddressLabel.Enabled = true;
                landDescLabel.Enabled = true;

                landNameAddInput.Enabled = true;
                landCountryAddInput.Enabled = true;
                landCityAddInput.Enabled = true;
                landAddressAddInput.Enabled = true;
                landDescAddInput.Enabled = true;
                recomLandmarkAddButton.Enabled = true;
                landRemoveAddButton.Enabled = true;
                landUpdateAddButton.Enabled = true;
                landAddAddButton.Enabled = true;


                restNameLabel.Enabled = true;
                restCountryLabel.Enabled = true;
                restCityLabel.Enabled = true;
                restContactLabel.Enabled = true;
                restAddressLabel.Enabled = true;

                restNameAddInput.Enabled = true;
                restCountryAddInput.Enabled = true;
                restCityAddInput.Enabled = true;
                restContactAddInput.Enabled = true;
                restAddressAddInput.Enabled = true;

                restTypeLabel.Enabled = true;
                restHotelAddRadioButton.Enabled = true;
                restHostelAddRadioButton.Enabled = true;
                restApartmentAddRadioButton.Enabled = true;
                restRoomAddRadioButton.Enabled = true;
                restCampingAddRadioButton.Enabled = true;
                restRemoveAddButton.Enabled = true;
                restUpdateAddButton.Enabled = true;
                restAddAddButton.Enabled = true;

                expNameLabel.Enabled = true;
                expValueLabel.Enabled = true;
                expNameAddInput.Enabled = true;
                expValueAddInput.Enabled = true;
                expRemoveAddButton.Enabled = true;
                expUpdateAddButton.Enabled = true;
                expAddAddButton.Enabled = true;

                memPhotoLabel.Enabled = true;
                memSongLabel.Enabled = true;
                memSongAddInput.Enabled = true;
                memNoteAddInput.Enabled = true;
                memNoteLabel.Enabled = true;
                memRemoveAddButton.Enabled = true;
                memUpdateAddButton.Enabled = true;
                memAddAddButton.Enabled = true;


                segNameLabel.Enabled = true;
                segNameAddInput.Enabled = true;
                segRemoveAddButton.Enabled = true;
                segAddAddButton.Enabled = true;
                segUpdateAddButton.Enabled = true;
            }
        }

        private void segAddAddButton_Click(object sender, EventArgs e)
        {
            if (!segNameAddInput.Text.IsNullOrEmpty())
            {
                controller.AddTripSegment(segNameAddInput.Text, new List<TripMemory>(), new List<Expense>(), new List<Destination>(), editedTrip.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void segUpdateAddButton_Click(object sender, EventArgs e)
        {
            if (!segNameAddInput.Text.IsNullOrEmpty())
            {

                TripSegment updateSegment = new TripSegment() { Id = editedSegment.Id, Name = segNameAddInput.Text, TripId = editedTrip.Id };
                controller.UpdateTripSegment(updateSegment);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void segRemoveAddButton_Click(object sender, EventArgs e)
        {
            controller.DeleteTripSegment(editedSegment);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateAddPanels(editedTrip, editedSegmentList);
        }

        private void landAddAddButton_Click(object sender, EventArgs e)
        {
            if (!landNameAddInput.Text.IsNullOrEmpty() && !landCountryAddInput.Text.IsNullOrEmpty() && !landCityAddInput.Text.IsNullOrEmpty())
            {
                Landmark addLandmarkFromAdd = new Landmark() { Name = landNameAddInput.Text, Country = landCountryAddInput.Text, City = landCityAddInput.Text, TripSegmentId = editedSegment.Id, Address = landAddressAddInput.Text, Description = landDescAddInput.Text };
                controller.AddDestination(addLandmarkFromAdd);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void landUpdateAddButton_Click(object sender, EventArgs e)
        {
            if (!landNameAddInput.Text.IsNullOrEmpty() && !landCountryAddInput.Text.IsNullOrEmpty() && !landCityAddInput.Text.IsNullOrEmpty())
            {

                Landmark updateLandmarkFromAdd = new Landmark() { Id = editedLandmark.Id, Name = landNameAddInput.Text, Country = landCountryAddInput.Text, City = landCityAddInput.Text, Address = landAddressAddInput.Text, Description = landDescAddInput.Text, TripSegmentId = editedSegment.Id, };
                controller.UpdateDestination(updateLandmarkFromAdd);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void landRemoveAddButton_Click(object sender, EventArgs e)
        {
            controller.DeleteLandmark(editedLandmark);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateAddPanels(editedTrip, editedSegmentList);
        }

        private void restAddAddButton_Click(object sender, EventArgs e)
        {
            if (!restNameAddInput.Text.IsNullOrEmpty() && !restCountryAddInput.Text.IsNullOrEmpty() && !restCityAddInput.Text.IsNullOrEmpty() && (restHostelAddRadioButton.Checked || restHotelAddRadioButton.Checked || restCampingAddRadioButton.Checked || restApartmentAddRadioButton.Checked || restRoomAddRadioButton.Checked))
            {

                RestingPoint addRestingPointFromAdd = new RestingPoint() { Name = restNameAddInput.Text, Country = restCountryAddInput.Text, City = restCityAddInput.Text, TripSegmentId = editedSegment.Id, Address = restAddressAddInput.Text, ContactInfo = restContactAddInput.Text };
                if (restHostelAddRadioButton.Checked) { addRestingPointFromAdd.Type = Model.Enums.RestingPointType.Hostel; } else if (restHotelAddRadioButton.Checked) { addRestingPointFromAdd.Type = Model.Enums.RestingPointType.Hotel; } else if (restRoomAddRadioButton.Checked) { addRestingPointFromAdd.Type = Model.Enums.RestingPointType.Room; } else if (restApartmentAddRadioButton.Checked) { addRestingPointFromAdd.Type = Model.Enums.RestingPointType.Apartment; } else if (restCampingAddRadioButton.Checked) { addRestingPointFromAdd.Type = Model.Enums.RestingPointType.Camping; }
                controller.AddDestination(addRestingPointFromAdd);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void restUpdateAddButton_Click(object sender, EventArgs e)
        {
            if (!restNameAddInput.Text.IsNullOrEmpty() && !restCountryAddInput.Text.IsNullOrEmpty() && !restCityAddInput.Text.IsNullOrEmpty() && (restHostelAddRadioButton.Checked || restHotelAddRadioButton.Checked || restCampingAddRadioButton.Checked || restApartmentAddRadioButton.Checked || restRoomAddRadioButton.Checked))
            {

                RestingPoint updateRestingPointFromAdd = new RestingPoint() { Id = editedRestingPoint.Id, Name = restNameAddInput.Text, Country = restCountryAddInput.Text, City = restCityAddInput.Text, TripSegmentId = editedSegment.Id, Address = restAddressAddInput.Text, ContactInfo = restContactAddInput.Text };
                if (restHostelAddRadioButton.Checked) { updateRestingPointFromAdd.Type = Model.Enums.RestingPointType.Hostel; } else if (restHotelAddRadioButton.Checked) { updateRestingPointFromAdd.Type = Model.Enums.RestingPointType.Hotel; } else if (restRoomAddRadioButton.Checked) { updateRestingPointFromAdd.Type = Model.Enums.RestingPointType.Room; } else if (restApartmentAddRadioButton.Checked) { updateRestingPointFromAdd.Type = Model.Enums.RestingPointType.Apartment; } else if (restCampingAddRadioButton.Checked) { updateRestingPointFromAdd.Type = Model.Enums.RestingPointType.Camping; }
                controller.UpdateDestination(updateRestingPointFromAdd);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);

            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void restRemoveAddButton_Click(object sender, EventArgs e)
        {
            controller.DeleteRestingPoint(editedRestingPoint);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateAddPanels(editedTrip, editedSegmentList);
        }


        private void expAddAddButton_Click(object sender, EventArgs e)
        {
            if (!expValueAddInput.Text.IsNullOrEmpty() && !expNameAddInput.Text.IsNullOrEmpty())
            {
                controller.AddExpense(expNameAddInput.Text, ((double)expValueAddInput.Value), editedSegment.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void expUpdateAddButton_Click(object sender, EventArgs e)
        {
            if (!expValueAddInput.Text.IsNullOrEmpty() && !expNameAddInput.Text.IsNullOrEmpty())
            {
                Expense updateExpense = new Expense() { Id = editedExpense.Id, Name = expNameAddInput.Text, Value = ((double)expValueAddInput.Value), TripSegmentId = editedSegment.Id };
                controller.UpdateExpense(updateExpense);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
            else
            {
                PopupForm popup = new PopupForm(4);
                popup.ShowDialog();
            }
        }

        private void expRemoveAddButton_Click(object sender, EventArgs e)
        {
            controller.DeleteExpense(editedExpense);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateEditPanels(editedTrip, editedSegmentList);
        }


        private void memAddAddButton_Click(object sender, EventArgs e)
        {
            if (!memNameAddInput.Text.IsNullOrEmpty())
            {
                controller.AddTripMemory(memNameAddInput.Text, memPhotoAddInput.Text, memNoteAddInput.Text, memSongAddInput.Text, editedSegment.Id);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
        }
        private void memUpdateAddButton_Click(object sender, EventArgs e)
        {
            if (!memNameAddInput.Text.IsNullOrEmpty())
            {
                TripMemory updateMemory = new TripMemory() { Id = editedMemory.Id, Name = memNameAddInput.Text, Photo = memPhotoAddInput.Text, Note = memNoteAddInput.Text, SongURL = memSongAddInput.Text, TripSegmentId = editedSegment.Id };
                controller.UpdateTripMemory(updateMemory);
                editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
                UpdateAddPanels(editedTrip, editedSegmentList);
            }
        }

        private void memRemoveAddButton_Click(object sender, EventArgs e)
        {
            controller.DeleteTripMemory(editedMemory);
            editedSegmentList = controller.GetAllTripSegmentsByTripId(editedTrip.Id);
            UpdateAddPanels(editedTrip, editedSegmentList);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Trip trip = controller.GetFirstTrip();
            new PresentationForm(trip).Show();
        }

        private void memPhotoAddButtonSelect_Click(object sender, EventArgs e)
        {
            
        }
        private void memPhotoButtonSelect_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg)|*.png";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            memPhotoEditInput.Text = filePath;
        }

        private void memPhotoAddButtonSelect_Click_1(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg)|*.png";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            memPhotoAddInput.Text = filePath;
        }
    }
}









