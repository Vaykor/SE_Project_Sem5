﻿using System;
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

namespace TravelPlaner.View.Forms
{
    public partial class GUI : Form
    {
        ProgramController controller = new ProgramController();
        private List<FlowLayoutPanel> destinationSegmentPanels = new List<FlowLayoutPanel>();
        private List<FlowLayoutPanel> expenseSegmentPanels = new List<FlowLayoutPanel>();
        private List<FlowLayoutPanel> memorySegmentPanels = new List<FlowLayoutPanel>();

        private System.Windows.Forms.Timer timer;


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

        }
        private void GUI_Load(object sender, EventArgs e)
        {

            // Initialize with only Panel1 visible
            ShowPanel(menuPanel);

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
            restApartmAddRadioButton.Enabled = false;
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
            memAddPictureBox.Enabled = false;
            memSongLabel.Enabled = false;
            memSongAddInput.Enabled = false;
            memAddNoteInput.Enabled = false;
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
            ShowPanel(browseTripPanel);

            // Fetch trips from database
            List<Trip> trips = controller.GetAllTrips();

            int panelY = 10; // Vertical position for each trip panel
            foreach (var trip in trips)
            {
                // Fetch trip segments and count them
                List<TripSegment> tripSegments = controller.GetAllTripSegmentsByTripId(trip.Id);

                int segmentCount = tripSegments.Count;





                //TODO (When destinations get fixed)
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
                    Text = $"{trip.Name},    Destination: {destinationName}",  //",
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
            ShowPanel(inspectTripPanel);

            Trip passedTrip = trip;
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
            tripDepartureDatePicker.Text = trip.StartDate.ToString();
            tripReturnDatePicker.Text = trip.EndDate.ToString();
            tripNameTextBox.Text = trip.Name;
            foreach (TripSegment segment in tripSegments)
            {
                ListViewItem item = new ListViewItem(trip.Id.ToString());
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
                tripNameTextBox.Text = trip.Name;
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
                                case 1:
                                    restHotelDetailsRadioButton.Checked = true;
                                    break;
                                case 2:
                                    restHostelDetailsRadioButton.Checked = true;
                                    break;
                                case 3:
                                    restRoomDetailsRadioButton.Checked = true;
                                    break;
                                case 4:
                                    restApartmentDetailsRadioButton.Checked = true;
                                    break;
                                case 5:
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
            editButton.Click += (sender, e) => ShowEditTrip(trip, tripSegments);
        }



        private void ShowEditTrip(Trip trip, List<TripSegment> tripSegments)
        {
            ShowPanel(editTripPanel);
            //ProgramController controller = new ProgramController(); 

            Trip passedTrip = trip;
            //TripSegment tripSegment = controller.GetAllTripSegmentsByTripId(trip.Id);
            memEditPhotoBox.Image = null;
            memNoteEditInput.Text = "";
            landmarkEditListView.Items.Clear();
            restingEditPointListView.Items.Clear();
            expensesEditListView.Items.Clear();
            memoriesEditListView.Items.Clear();
            segmentsEditListView.Items.Clear();
            foreach (Control control in editTripPanel.Controls) // Replace 'myPanel' with your container
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            foreach (Control control in editTripPanel.Controls) // Replace 'myPanel' with your container
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            tripNameEditInput.Text = trip.Name;
            editTripDepartureDatePicker.Text = trip.StartDate.ToString();
            editTripReturnDatePicker.Text = trip.EndDate.ToString();
            foreach (TripSegment segment in tripSegments)
            {
                ListViewItem item = new ListViewItem(trip.Id.ToString());
                item.SubItems.Add(segment.Name.ToString());
                segmentsEditListView.Items.Add(item);
                item.Tag = segment;
            }
            segmentsEditListView.ItemActivate += segmentsEditListView_ItemActivate;

            void segmentsEditListView_ItemActivate(object sender, EventArgs e)
            {
                memEditPhotoBox.Image = null;
                memNoteEditInput.Text = "";
                foreach (Control control in editTripPanel.Controls) // Replace 'myPanel' with your container
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                foreach (Control control in editTripPanel.Controls) // Replace 'myPanel' with your container
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
                    landmarkEditListView.Items.Clear();
                    restingEditPointListView.Items.Clear();
                    expensesEditListView.Items.Clear();
                    memoriesEditListView.Items.Clear();
                    List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(segment.Id);
                    segNameEditInput.Text = segment.Name;

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
                    void landmarkEditListView_ItemActivate(object sender, EventArgs e)
                    {
                        ListViewItem selectedEditLandmarkItem = landmarkEditListView.SelectedItems[0];
                        if (selectedEditLandmarkItem.Tag is Landmark landmark)
                        {
                            landNameEditInput.Text = landmark.Name;
                            landCountryEditInput.Text = landmark.Country;
                            landCityEditInput.Text = landmark.City;
                            landAddressEditInput.Text = landmark.Address;
                            landDescEditInput.Text = landmark.Description;
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
                            restNameEditInput.Text = restingPoint.Name;
                            restCountryEditInput.Text = restingPoint.Country;
                            restCityEditInput.Text = restingPoint.City;
                            restAddressEditInput.Text = restingPoint.Address;
                            textBox20.Text = restingPoint.ContactInfo;
                            switch ((int)restingPoint.Type)
                            {
                                case 1:
                                    restHotelEditRadioButton.Checked = true;
                                    break;
                                case 2:
                                    restHostelEditRadioButton.Checked = true;
                                    break;
                                case 3:
                                    restRoomEditRadioButton.Checked = true;
                                    break;
                                case 4:
                                    restApartmentEditRadioButton.Checked = true;
                                    break;
                                case 5:
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
                            memEditPhotoBox.ImageLocation = memory.Photo;
                            memSongEditInput.Text = memory.SongURL;
                            memNoteEditInput.Text = memory.Note;
                        }
                    }
                }
            }
        }




        /** USED WHEN SHOWCASING DETAILS OF THE TRIP. IT EXPANDS THE HIDDEN DETAILS OF A CERTAIN TRIP SEGMENT WHEN + IS PRESSED
         * 
         * TODO: TRY REMOVING THE LOCATIONS FROM EVERYTHING AND SEE IF IT SCREWS UP MAJORLY;
         */
        private void expandTripSegment(FlowLayoutPanel flowLayoutPanel, TripSegment tripsegment)
        {
            List<TripMemory> memories = controller.GetAllTripMemoriesByTripSegmentId(tripsegment.Id);
            List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(tripsegment.Id);
            List<Destination> destinations = controller.GetAllDestinationsByTripSegmentId(tripsegment.Id);
            List<Landmark> landmarks = controller.GetAllLandmarksByTripSegmentId(tripsegment.Id);
            List<RestingPoint> restingPoints = controller.GetAllRestingPointsByTripSegmentId(tripsegment.Id);

            /*bool isDestinationExpanded = false;
            bool isExpenseExpanded = false;
            bool isMemoryExpanded = false;
            String country, city;
            if (destinations.Count() == 0) { country = "Unknown"; } else { country = destinations[0].Country; }
            if (destinations.Count() == 0) { city = "Unknown"; } else { city = destinations[0].City; }
            Label labelCountry = new Label
            {
                Text = $"{"Country: " + country}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            Label labelCity = new Label
            {
                Text = $"{"City: " + city}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            var landmarkPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                BorderStyle = BorderStyle.FixedSingle
            };
            Label landmarkLabel = new Label
            {
                Text = $"{"Destinations"}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            var btnExpandLandmarks = new Button
            {
                Text = "+",
                AutoSize = true
            };
            flowLayoutPanel.Controls.Add(labelCountry);
            flowLayoutPanel.Controls.Add(labelCity);
            flowLayoutPanel.Controls.Add(landmarkPanel);
            landmarkPanel.Controls.Add(landmarkLabel);
            landmarkPanel.Controls.Add(btnExpandLandmarks);
            btnExpandLandmarks.Click += (s, e) =>
            {

                if (!isDestinationExpanded)
                {
                    isDestinationExpanded = true;
                    btnExpandLandmarks.Text = "-";
                    foreach (Destination destination in destinations)
                    {
                        var segmentPanel = new FlowLayoutPanel
                        {
                            AutoSize = true,
                            FlowDirection = FlowDirection.TopDown,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        foreach (Landmark landmark in landmarks)
                        {
                            if (landmark.Id == destination.Id)
                            {
                                Label labelLandmarkName = new Label
                                {
                                    Text = $"{"Name: " + landmark.Name}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                Label labelLandmarkAddress = new Label
                                {
                                    Text = $"{"Address: " + landmark.Address}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                Label labelLandmarkDescription = new Label
                                {
                                    Text = $"{"Description: " + landmark.Description}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };

                                segmentPanel.Controls.Add(labelLandmarkName);
                                segmentPanel.Controls.Add(labelLandmarkAddress);
                                segmentPanel.Controls.Add(labelLandmarkDescription);
                            }
                        }
                        foreach (RestingPoint restingPoint in restingPoints)
                        {
                            if (restingPoint.Id == destination.Id)
                            {
                                Label labelRestingName = new Label
                                {
                                    Text = $"{"Name: " + restingPoint.Name}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                Label labelRestingAddress = new Label
                                {
                                    Text = $"{"Address: " + restingPoint.Address}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                Label labelRestingContact = new Label
                                {
                                    Text = $"{"Contact: " + restingPoint.ContactInfo}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                Label labelRestingType = new Label
                                {
                                    Text = $"{"Type of resting point: " + restingPoint.Type}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                }; Label labelRestingLength = new Label
                                {
                                    Text = $"{"No. of Nights Spent There: " + restingPoint.NightsSpentThere}",
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };
                                segmentPanel.Controls.Add(labelRestingName);
                                segmentPanel.Controls.Add(labelRestingAddress);
                                segmentPanel.Controls.Add(labelRestingContact);
                                segmentPanel.Controls.Add(labelRestingType);
                                segmentPanel.Controls.Add(labelRestingLength);
                            }
                        }
                        flowLayoutPanel.Controls.Add(segmentPanel);
                        destinationSegmentPanels.Add(segmentPanel);
                    }
                }
                else
                {
                    isDestinationExpanded = false;
                    btnExpandLandmarks.Text = "+";
                    foreach (var panel in destinationSegmentPanels)
                    {
                        flowLayoutPanel.Controls.Remove(panel);
                    }
                    destinationSegmentPanels.Clear();
                }
            };

            //EXPENSES
            var expensePanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                BorderStyle = BorderStyle.FixedSingle
            };
            Label expensesLabel = new Label
            {
                Text = $"{"Expenses"}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            var btnExpandExpenses = new Button
            {
                Text = "+",
                AutoSize = true
            };
            flowLayoutPanel.Controls.Add(expensePanel);
            expensePanel.Controls.Add(expensesLabel);
            expensePanel.Controls.Add(btnExpandExpenses);
            btnExpandExpenses.Click += (s, e) =>
            {

                if (!isExpenseExpanded)
                {
                    isExpenseExpanded = true;
                    btnExpandExpenses.Text = "-";
                    foreach (Expense expense in expenses)
                    {
                        var segmentPanel = new FlowLayoutPanel
                        {
                            AutoSize = true,
                            FlowDirection = FlowDirection.TopDown,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        Label labelExpenseName = new Label
                        {
                            Text = $"{"Name: " + expense.Name}",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };
                        Label labelExpenseValue = new Label
                        {
                            Text = $"{"Value: " + expense.Value + "€"}",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };
                        segmentPanel.Controls.Add(labelExpenseName);
                        segmentPanel.Controls.Add(labelExpenseValue);
                        flowLayoutPanel.Controls.Add(segmentPanel);
                        expenseSegmentPanels.Add(segmentPanel);
                    }
                }
                else
                {
                    isExpenseExpanded = false;
                    btnExpandExpenses.Text = "+";
                    foreach (var panel in expenseSegmentPanels)
                    {
                        flowLayoutPanel.Controls.Remove(panel);
                    }
                    expenseSegmentPanels.Clear();

                }
            };

            //MEMORIES
            var memoryPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                BorderStyle = BorderStyle.FixedSingle
            };
            Label memoryLabel = new Label
            {
                Text = $"{"Memories"}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            var btnExpandMemories = new Button
            {
                Text = "+",
                AutoSize = true
            };
            flowLayoutPanel.Controls.Add(memoryPanel);
            memoryPanel.Controls.Add(memoryLabel);
            memoryPanel.Controls.Add(btnExpandMemories);
            btnExpandMemories.Click += (s, e) =>
            {

                if (!isMemoryExpanded)
                {
                    isMemoryExpanded = true;
                    btnExpandMemories.Text = "-";
                    foreach (TripMemory memo in memories)
                    {
                        var singleMemoryPanel = new FlowLayoutPanel
                        {
                            AutoSize = true,
                            FlowDirection = FlowDirection.TopDown,
                            //BorderStyle = BorderStyle.FixedSingle
                        };
                        Label memoryNameLabel = new Label
                        {
                            Text = $"{memo.Name}",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };
                        var memoryPicture = new PictureBox()
                        {
                            ImageLocation = memo.Photo,

                            SizeMode = PictureBoxSizeMode.StretchImage,
                            MaximumSize = new Size(800, 800),
                            MinimumSize = new Size(250, 250)
                        };
                        Label memoryNoteLabel = new Label
                        {
                            Text = $"{memo.Note}",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };
                        TextBox memorySongLabel = new TextBox
                        {
                            Text = $"{memo.SongURL}",
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            AutoSize = true
                        };

                        singleMemoryPanel.Controls.Add(memoryNameLabel);
                        singleMemoryPanel.Controls.Add(memoryPicture);
                        singleMemoryPanel.Controls.Add(memoryNoteLabel);
                        singleMemoryPanel.Controls.Add(memorySongLabel);
                        flowLayoutPanel.Controls.Add(singleMemoryPanel);
                        memorySegmentPanels.Add(singleMemoryPanel);
                    }
                }
                else
                {
                    isMemoryExpanded = false;
                    btnExpandMemories.Text = "+";
                    foreach (var panel in memorySegmentPanels)
                    {
                        flowLayoutPanel.Controls.Remove(panel);
                    }
                    memorySegmentPanels.Clear();
                }


            };
            flowLayoutPanel.Visible = true;*/
        }

        private void collapseTripSegment(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
        }
        /*        private void AddTripSegment(FlowLayoutPanel sectionPanel)
                {

                    // Panel pojedynczego segmentu
                    var segmentPanel = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        FlowDirection = FlowDirection.TopDown,
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(5)
                    };

                    // Pole Country
                    var lblCountry = new Label { Text = "Country:", AutoSize = true };
                    var txtCountry = new TextBox { Width = 200 };
                    segmentPanel.Controls.Add(lblCountry);
                    segmentPanel.Controls.Add(txtCountry);

                    // Pole City
                    var lblCity = new Label { Text = "City:", AutoSize = true };
                    var txtCity = new TextBox { Width = 200 };
                    segmentPanel.Controls.Add(lblCity);
                    segmentPanel.Controls.Add(txtCity);


                    var landmarkPanel = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        Padding = new Padding(5)
                    };

                    var landmarkLabel = new Label { Text = "Add landmark:", AutoSize = true };

                    // Przycisk do dodawania segmentów
                    var btnAddLandmark = new Button
                    {
                        Text = "+",
                        AutoSize = true
                    };

                    btnAddLandmark.Click += (s, e) => AddLandmark(landmarkPanel);
                    segmentPanel.Controls.Add(landmarkLabel);
                    segmentPanel.Controls.Add(btnAddLandmark);
                    segmentPanel.Controls.Add(landmarkPanel);
                    var expensePanel = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        Padding = new Padding(5)
                    };

                    var expenseLabel = new Label { Text = "Add expense:", AutoSize = true };

                    // Przycisk do dodawania segmentów
                    var btnAddExpense = new Button
                    {
                        Text = "+",
                        AutoSize = true
                    };
                    btnAddExpense.Click += (s, e) => AddExpense(expensePanel, null);
                    segmentPanel.Controls.Add(expenseLabel);
                    segmentPanel.Controls.Add(btnAddExpense);
                    segmentPanel.Controls.Add(expensePanel);


                    var memoryPanel = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        Padding = new Padding(5)
                    };
                    var memoryLabel = new Label { Text = "Add memory:", AutoSize = true };
                    // Przycisk do dodawania segmentów
                    var btnAddMemory = new Button
                    {
                        Text = "+",
                        AutoSize = true
                    };
                    btnAddMemory.Click += (s, e) => AddMemory(memoryPanel, null);
                    segmentPanel.Controls.Add(memoryLabel);
                    segmentPanel.Controls.Add(btnAddMemory);
                    segmentPanel.Controls.Add(memoryPanel);

                    // Przycisk usuwania
                    var btnRemove = new Button
                    {
                        Text = "-",
                        AutoSize = true
                    };
                    btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
                    segmentPanel.Controls.Add(btnRemove);






                    sectionPanel.Controls.Add(segmentPanel);

                    var btnSave = new Button
                    {
                        Text = "Save",
                        AutoSize = true
                    };
                }*/
        /** ADDING THE ACTUAL TRIP SEGMENTS (NOT JUST THE PANELS LIKE AddTripSegmentSection() BUT THE ACTUAL INSIDES)
         * IF YOU WANT TO CREATE A NEW BLANK TRIPSEGMENT INSERTING FIELD, PASS NULL IN THE SECOND ARGUMENT (like AddTripSegment(examplePanel, null)
         * IF YOU WANT TO CREATE FIELDS FOR AN EXISTING TRIPSEGMENT (like in editTrip) THEN PASS THE TRIP YOU WANT TO USE
         */
        private void AddTripSegment(FlowLayoutPanel sectionPanel, Trip trip)
        {
            /*int amount;
            string country = "";
            string city = "";
            bool checkDestination = true;
            List<Expense> expenses;
            List<Landmark> landmarks;
            List<TripMemory> memories;
            List<TripSegment> tripsegments = new List<TripSegment>();
            List<Destination> destinations = new List<Destination>();
            if (trip != null)
            {
                tripsegments = controller.GetAllTripSegmentsByTripId(trip.Id);
                amount = tripsegments.Count();
                if (amount == 0)
                {
                    checkDestination = false;
                    amount = 1;
                }

                //string country = trip==null ? "" : trip.;
            }
            else
            {
                checkDestination = false;
                amount = 1;
            }
            for (int i = 0; i < amount; i++)
            {
                if (checkDestination)
                {
                    destinations = controller.GetAllDestinationsByTripSegmentId(tripsegments[i].Id);
                    country = destinations.Count() > 0 ? destinations[0].Country : "";
                    city = destinations.Count() > 0 ? destinations[0].City : "";
                }
                // Panel pojedynczego segmentu
                var segmentPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(15),
                    //Name = "TripSegmentPanel" + tripSegmentPanels.Count()
                };
                //tripSegmentPanels.Add(tripSegmentPanels.Count(), segmentPanel);
                //Country panel
                var countryPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                // Pole Country
                var lblCountry = new Label { Text = "Country:", AutoSize = true };
                var txtCountry = new TextBox { Width = 200, Text = country };

                countryPanel.Controls.Add(lblCountry);
                countryPanel.Controls.Add(txtCountry);

                segmentPanel.Controls.Add(countryPanel);


                //City panel
                var cityPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                // Pole City
                var lblCity = new Label { Text = "City:", AutoSize = true };
                var txtCity = new TextBox { Width = 200, Text = city };
                var suggestBtn = new Button { Text = "Suggest landmarks nearby", AutoSize = true };
                cityPanel.Controls.Add(lblCity);
                cityPanel.Controls.Add(txtCity);
                cityPanel.Controls.Add(suggestBtn);
                segmentPanel.Controls.Add(cityPanel);
                suggestBtn.Click += (s, e) =>
                {
                    if (!txtCity.Text.Equals(""))
                    {
                        RecommendedLandmarks recommendation = new RecommendedLandmarks(txtCity.Text);
                        recommendation.ShowDialog();
                    }
                    else
                    {
                        PopupForm popup = new PopupForm(3);
                        popup.ShowDialog();
                    }
                };

                var landmarkPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    Padding = new Padding(5)
                };
                var newLandmarkPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                var landmarkLabel = new Label { Text = "Add landmark:", AutoSize = true };

                // Przycisk do dodawania segmentów
                var btnAddLandmark = new Button
                {
                    Text = "+",
                    AutoSize = true
                };

                btnAddLandmark.Click += (s, e) => AddLandmark(newLandmarkPanel, null);
                landmarkPanel.Controls.Add(landmarkLabel);
                landmarkPanel.Controls.Add(btnAddLandmark);
                segmentPanel.Controls.Add(landmarkPanel);
                segmentPanel.Controls.Add(newLandmarkPanel);
                if (trip != null && checkDestination)
                {
                    landmarks = controller.GetAllLandmarksByTripSegmentId(tripsegments[i].Id);
                    foreach (var item in landmarks)
                    {
                        AddLandmark(newLandmarkPanel, item);
                    }
                }
                //EXPENSES
                var expensePanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    Padding = new Padding(5)
                };
                var newExpensePanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                var expenseLabel = new Label { Text = "Add expense:", AutoSize = true };

                // Przycisk do dodawania segmentów
                var btnAddExpense = new Button
                {
                    Text = "+",
                    AutoSize = true
                };
                btnAddExpense.Click += (s, e) => AddExpense(newExpensePanel, null);
                expensePanel.Controls.Add(expenseLabel);
                expensePanel.Controls.Add(btnAddExpense);
                segmentPanel.Controls.Add(expensePanel);
                segmentPanel.Controls.Add(newExpensePanel);
                if (trip != null && checkDestination)
                {
                    expenses = controller.GetAllExpensesByTripSegmentId(tripsegments[i].Id);
                    foreach (var item in expenses)
                    {
                        AddExpense(newExpensePanel, item);
                    }
                }
                var memoryPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    Padding = new Padding(5)
                };
                var newMemoryPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,

                };
                var memoryLabel = new Label { Text = "Add memory:", AutoSize = true };
                // Przycisk do dodawania segmentów

                // MEMORIES

                var btnAddMemory = new Button
                {
                    Text = "+",
                    AutoSize = true
                };
                btnAddMemory.Click += (s, e) => AddMemory(newMemoryPanel, null);
                memoryPanel.Controls.Add(memoryLabel);
                memoryPanel.Controls.Add(btnAddMemory);
                segmentPanel.Controls.Add(memoryPanel);
                segmentPanel.Controls.Add(newMemoryPanel);
                if (trip != null && checkDestination)
                {
                    memories = controller.GetAllTripMemoriesByTripSegmentId(tripsegments[i].Id);
                    foreach (var item in memories)
                    {
                        AddMemory(newMemoryPanel, item);
                    }
                }
                // Przycisk usuwania
                var btnRemove = new Button
                {
                    Text = "-",
                    AutoSize = true
                };
                btnRemove.Click += (s, e) => { sectionPanel.Controls.Remove(segmentPanel); };
                segmentPanel.Controls.Add(btnRemove);
                sectionPanel.Controls.Add(segmentPanel);
            }*/
        }



        /** WIP TODO when Landmarks get fixed in the database
         */
        private void AddLandmark(FlowLayoutPanel sectionPanel, Landmark landmark)
        {
            String lndName = "";
            String lndAddress = "";
            if (landmark != null)
            {
                lndName = landmark.Name;
                lndAddress = landmark.Address;
            }


            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = lndName };


            // Pole Address
            var lblAddress = new Label { Text = "Address:", AutoSize = true };
            var txtAddress = new TextBox { Width = 200, Text = lndAddress };


        }
        /** FUNCTION FOR ADDING EXPENSES-RELATED TEXTFIELDS AND LABELS
         * IF YOU PASS NULL IN THE PLACE OF EXPENSE (like AddExpense(examplePanel, null), IT WILL CREATE FIELDS FOR INSERTING NEW DATA
         * OTHERWISE, IF YOU PASS AN EXISTING EXPENSE, IT WILL PRINT OUT THE CONNECTED TEXT, AND CAN BE USED IN STUFF LIKE editTrip
         */
        private void AddExpense(FlowLayoutPanel sectionPanel, Expense expense)
        {
            String expName = "";
            String expValue = "";
            if (expense != null)
            {
                expName = expense.Name;
                expValue = expense.Value.ToString();
            }

            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = expName };


            // Pole Value
            var lblValue = new Label { Text = "Value (€):", AutoSize = true };
            var txtValue = new NumericUpDown { Width = 200, DecimalPlaces = 2, Maximum = decimal.MaxValue, Minimum = 0, Text = expValue };

        }
        /** FUNCTION FOR ADDING MEMORY-RELATED TEXTFIELDS AND LABELS
                 * IF YOU PASS NULL IN THE PLACE OF MEMORY (like AddMemory(examplePanel, null), IT WILL CREATE FIELDS FOR INSERTING NEW DATA
                 * OTHERWISE, IF YOU PASS AN EXISTING MEMORY, IT WILL PRINT OUT THE CONNECTED TEXT, AND CAN BE USED IN STUFF LIKE editTrip
                 */
        private void AddMemory(FlowLayoutPanel sectionPanel, TripMemory memory)
        {
            String memName = "";
            if (memory != null)
            {
                memName = memory.Name;
            }

            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = memName };


            var photoLabel = new Label { Text = "Add photos:", AutoSize = true };

            var photoTextBox = new TextBox { Width = 200 };


        }
        /** TO (RE)CONSIDER, SINCE OUR DATABASE STRUCTURE IS SOMEWHAT DIFFERENT
                 */
        private void AddPhoto(TextBox textbox)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Combine all selected file paths into a single string separated by newlines
                    textbox.Text = string.Join(Environment.NewLine, openFileDialog1.FileNames);  //change this NewLine
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        /** FUNCTION FOR ADDING SONG-RELATED TEXTFIELDS AND LABELS
                 * IF YOU PASS NULL IN THE PLACE OF SONG (like AddSong(examplePanel, null), IT WILL CREATE FIELDS FOR INSERTING NEW DATA
                 * OTHERWISE, IF YOU PASS AN EXISTING MEMORY, IT WILL PRINT OUT THE CONNECTED TEXT, AND CAN BE USED IN STUFF LIKE editTrip
                 * 
                 * TODO: MAKE THE LINK CLICKABLE? OR FIND A WAY TO PLAY IT FROM THE PROGRAM??
                 */
        private void AddSong(FlowLayoutPanel sectionPanel, TripMemory memory)
        {
            String URL = "";
            if (memory != null)
            {
                URL = memory.SongURL;
            }


            // Pole Name
            var lblURL = new Label { Text = "URL:", AutoSize = true };
            var txtURL = new TextBox { Width = 200, Text = URL };

        }

        /** FUNCTION FOR ADDING NOTE-RELATED TEXTFIELDS AND LABELS
                 * IF YOU PASS NULL IN THE PLACE OF NOTE (like AddNote(examplePanel, null), IT WILL CREATE FIELDS FOR INSERTING NEW DATA
                 * OTHERWISE, IF YOU PASS AN EXISTING MEMORY, IT WILL PRINT OUT THE CONNECTED TEXT, AND CAN BE USED IN STUFF LIKE editTrip
                 */
        private void AddNote(FlowLayoutPanel sectionPanel, TripMemory memory)
        {
            String note = "";
            if (memory != null)
            { note = memory.Note; }


            // Pole Name
            var lblNote = new Label { Text = "Note:", AutoSize = true };
            var txtNote = new TextBox { Width = 200, Text = note };

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
            ShowPanel(browseTripPanel);
            //tripInfoPanel.Controls.Clear();
            //editButtonPanel.Controls.Clear();
        }




        //------------------------returning from edit trips panel----------------------
        private void returnFromEditTrip_Click(object sender, EventArgs e)
        {
            ShowPanel(inspectTripPanel);
            //editTripFlowLayoutPanel.Controls.Clear();
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
                restApartmAddRadioButton.Enabled = true;
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
                memAddPictureBox.Enabled = true;
                memSongLabel.Enabled = true;
                memSongAddInput.Enabled = true;
                memAddNoteInput.Enabled = true;
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
}









