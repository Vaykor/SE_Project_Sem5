using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        public GUI()
        {
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

        //----------------Trip details panel-------------------
        private void ShowTripDetails(Trip trip, List<TripSegment> tripSegments)
        {
            Trip passedTrip = trip;
            int labelY = 40;
            menuPanel.Visible = false;
            newTripPanel.Visible = false;
            browseTripPanel.Visible = false;
            inspectTripPanel.Visible = false;

            inspectTripPanel.Visible = true;
            inspectTripPanel.BringToFront();
            Button editButton = new Button
            {
                Text = "✏",
                Location = new Point(0, 0),
                AutoSize = true
            };
            /*editButtonPanel.Controls.Add(editButton);
            editButton.Click += (sender, e) =>
            {
                ShowPanel(editTripPanel);
                editNameTextBox.Text = passedTrip.Name;
                editDepDateTextBox.Text = passedTrip.StartDate.ToString();
                editReturnDateTextBox.Text = passedTrip.EndDate.ToString();
                AddTripSegmentSection(editTripFlowLayoutPanel);
                AddTripSegment(editTripFlowLayoutPanel, passedTrip);
            };
            Label nameLabel = new Label
            {
                Text = $"Name: {trip.Name}",  //{destinationName}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            tripInfoPanel.Controls.Add(nameLabel);

            Label dateLabel = new Label
            {
                Text = $"Start: {trip.StartDate.ToShortDateString()} - End: {trip.EndDate.ToShortDateString()}",
                Location = new Point(10, 40),
                AutoSize = true
            };
            tripInfoPanel.Controls.Add(dateLabel);*/

            foreach (TripSegment tripSegment in tripSegments)
            {
                List<Landmark> landmarks = controller.GetAllLandmarksByTripSegmentId(tripSegment.Id);
                List<RestingPoint> restingPoints = controller.GetAllRestingPointsByTripSegmentId(tripSegment.Id);
                bool isExpanded = false;
                // Panel pojedynczego segmentu
                var segmentPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                };
                Label segmentNameLabel = new Label
                {
                    Text = $"{tripSegment.Name}",  //{destinationName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, labelY += 30),
                    AutoSize = true
                };
                segmentPanel.Controls.Add(segmentNameLabel);
                var btnExpandSegmentInfo = new Button
                {
                    Text = "+",
                    Location = new Point(130, labelY),
                    AutoSize = true
                };
                segmentPanel.Controls.Add(btnExpandSegmentInfo);
                var expandingPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    //BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Visible = false
                };


                /*tripInfoPanel.Controls.Add(segmentPanel);
                tripInfoPanel.Controls.Add(expandingPanel);*/
                btnExpandSegmentInfo.Click += (s, e) =>
                {
                    if (!isExpanded)
                    {
                        isExpanded = true;
                        expandingPanel.BorderStyle = BorderStyle.FixedSingle;
                        btnExpandSegmentInfo.Text = "-";
                        expandTripSegment(expandingPanel, tripSegment);
                    }
                    else
                    {
                        isExpanded = false;
                        expandingPanel.BorderStyle = BorderStyle.None;
                        btnExpandSegmentInfo.Text = "+";
                        collapseTripSegment(expandingPanel);
                    }
                };
            }



        }

        //-----------menu panel--------------------
        /** GOING FROM THE MAIN MENU TO THE "ADD NEW TRIP" MENU
         * 
         */
        private void newTripButton_Click(object sender, EventArgs e)
        {
            ShowPanel(newTripPanel);
            //AddTripSegmentSection(addTripFlowLayoutPanel);

        }
        /** FUNCTION FOR CREATING THE "FORM" FOR ADDING TRIP SEGMENT SECTIONS
         * USED IN "ADD NEW TRIP" AND "EDIT TRIP"
         */
        private void AddTripSegmentSection(FlowLayoutPanel flowLayoutPanel)
        {
            // Panel sekcji
            var sectionPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)

            };

            var lblHeader = new Label
            {
                Text = "Add Trip Segment",
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                AutoSize = true
            };
            sectionPanel.Controls.Add(lblHeader);

            // Przycisk do dodawania segmentów
            var btnAddSegment = new Button
            {
                Text = "+",
                AutoSize = true
            };
            btnAddSegment.Click += (s, e) => AddTripSegment(sectionPanel, null);
            sectionPanel.Controls.Add(btnAddSegment);



            flowLayoutPanel.Controls.Add(sectionPanel);
            var btnAdd = new Button
            {
                Text = "Save and Submit",
                AutoSize = true
            };
            btnAdd.Click += (s, e) =>
            {
                if (blankChecker())
                {

                    controller.AddTrip(tripNameTextBox.Text, addTripDepartureDatePicker.Value, addTripReturnDatePicker.Value, new List<TripSegment>());
                    PopupForm popup = new PopupForm(1);
                    popup.ShowDialog();
                }
                else
                {
                    PopupForm popup = new PopupForm(2);
                    popup.ShowDialog();
                }
            };
            sectionPanel.Controls.Add(btnAdd);
        }

        private bool blankChecker()
        {
            if (string.IsNullOrWhiteSpace(tripNameTextBox.Text)) { return false; }
            else
            {
                return true;
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

            bool isDestinationExpanded = false;
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
            flowLayoutPanel.Visible = true;
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
            int amount;
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
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = lndName };
            segmentPanel.Controls.Add(lblName);
            segmentPanel.Controls.Add(txtName);

            // Pole Address
            var lblAddress = new Label { Text = "Address:", AutoSize = true };
            var txtAddress = new TextBox { Width = 200, Text = lndAddress };
            segmentPanel.Controls.Add(lblAddress);
            segmentPanel.Controls.Add(txtAddress);

            // Przycisk usuwania
            var btnRemove = new Button
            {
                Text = "-",
                AutoSize = true
            };
            btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
            segmentPanel.Controls.Add(btnRemove);
            sectionPanel.Controls.Add(segmentPanel);
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
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = expName };
            segmentPanel.Controls.Add(lblName);
            segmentPanel.Controls.Add(txtName);

            // Pole Value
            var lblValue = new Label { Text = "Value (€):", AutoSize = true };
            var txtValue = new NumericUpDown { Width = 200, DecimalPlaces = 2, Maximum = decimal.MaxValue, Minimum = 0, Text = expValue };
            segmentPanel.Controls.Add(lblValue);
            segmentPanel.Controls.Add(txtValue);

            // Przycisk usuwania
            var btnRemove = new Button
            {
                Text = "-",
                AutoSize = true
            };
            btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
            segmentPanel.Controls.Add(btnRemove);
            sectionPanel.Controls.Add(segmentPanel);
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
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200, Text = memName };
            segmentPanel.Controls.Add(lblName);
            segmentPanel.Controls.Add(txtName);
            var photoPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(5)
            };

            var photoLabel = new Label { Text = "Add photos:", AutoSize = true };

            var photoTextBox = new TextBox { Width = 200 };

            // Przycisk do dodawania segmentów
            var btnAddPhoto = new Button
            {
                Text = "+",
                AutoSize = true
            };
            btnAddPhoto.Click += (s, e) => AddPhoto(photoTextBox);



            segmentPanel.Controls.Add(photoLabel);
            segmentPanel.Controls.Add(btnAddPhoto);
            segmentPanel.Controls.Add(photoTextBox);
            segmentPanel.Controls.Add(photoPanel);

            var songPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(5)
            };

            var songLabel = new Label { Text = "Add song:", AutoSize = true };

            // Przycisk do dodawania segmentów
            var btnAddSong = new Button
            {
                Text = "+",
                AutoSize = true
            };
            btnAddSong.Click += (s, e) => AddSong(songPanel, null);
            segmentPanel.Controls.Add(songLabel);
            segmentPanel.Controls.Add(btnAddSong);
            segmentPanel.Controls.Add(songPanel);
            if (memory != null) { AddSong(songPanel, memory); }

            var notePanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(5)
            };

            var noteLabel = new Label { Text = "Add note:", AutoSize = true };

            // Przycisk do dodawania segmentów
            var btnAddNote = new Button
            {
                Text = "+",
                AutoSize = true
            };
            btnAddNote.Click += (s, e) => AddNote(notePanel, null);
            segmentPanel.Controls.Add(noteLabel);
            segmentPanel.Controls.Add(btnAddNote);
            segmentPanel.Controls.Add(notePanel);
            if (memory != null) { AddNote(notePanel, memory); }
            // Przycisk usuwania
            var btnRemove = new Button
            {
                Text = "-",
                AutoSize = true
            };
            btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
            segmentPanel.Controls.Add(btnRemove);
            sectionPanel.Controls.Add(segmentPanel);
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
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblURL = new Label { Text = "URL:", AutoSize = true };
            var txtURL = new TextBox { Width = 200, Text = URL };
            segmentPanel.Controls.Add(lblURL);
            segmentPanel.Controls.Add(txtURL);
            // Przycisk usuwania
            var btnRemove = new Button
            {
                Text = "-",
                AutoSize = true
            };
            btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
            segmentPanel.Controls.Add(btnRemove);
            sectionPanel.Controls.Add(segmentPanel);
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
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblNote = new Label { Text = "Note:", AutoSize = true };
            var txtNote = new TextBox { Width = 200, Text = note };
            segmentPanel.Controls.Add(lblNote);
            segmentPanel.Controls.Add(txtNote);
            // Przycisk usuwania
            var btnRemove = new Button
            {
                Text = "-",
                AutoSize = true
            };
            btnRemove.Click += (s, e) => sectionPanel.Controls.Remove(segmentPanel);
            segmentPanel.Controls.Add(btnRemove);
            sectionPanel.Controls.Add(segmentPanel);
        }
        /** FUNCTION FOR VIEWING THE "BROWSE TRIPS" MENU, ACCESSIBLE FROM THE MAIN MENU
                 */
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
                string destinationName = tripSegments.FirstOrDefault() != null
                     ? controller.GetAllDestinationsByTripSegmentId(tripSegments.First().Id).FirstOrDefault()?.Country
                     : "Unknown";

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
                    ForeColor = Color.FromArgb(1,183,99),
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

        //---------------------returning from add new trips panel--------------------
        private void returnFromAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            //addTripFlowLayoutPanel.Controls.Clear();
        }

        //---------returning from browse trips panel----------------------

        private void returnFromBrowseButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            tripListPanel.Controls.Clear();
        }


        //-------------------returning from inpect trips panel (the magnifying glass button)--------------------
        private void returnFromInspectButton_Click(object sender, EventArgs e)
        {

            ShowPanel(browseTripPanel);
            /*tripInfoPanel.Controls.Clear();
            editButtonPanel.Controls.Clear();*/
        }



        //------------------------returning from edit trips panel----------------------
        private void returnFromEditTrip_Click(object sender, EventArgs e)
        {
            ShowPanel(inspectTripPanel);
            //editTripFlowLayoutPanel.Controls.Clear();
        }

        //THIS IS JUST FOR TESTING/SHOWCASING THE FUNCTIONALITY OF ADDERS.
        private void settingsButton_Click(object sender, EventArgs e)
        {
            controller.AddTrip("Test Trip to verify Adders", DateTime.Now, DateTime.Now, new List<TripSegment>());
            Trip testTrip = controller.GetLastTrip();
            controller.AddTripSegment("1st Test Segment", new List<TripMemory>(), new List<Expense>(), new List<Destination>(), testTrip.Id);
            controller.AddTripSegment("2nd Test Segment", new List<TripMemory>(), new List<Expense>(), new List<Destination>(), testTrip.Id);
            List<TripSegment> segments = controller.GetAllTripSegmentsByTripId(testTrip.Id);
            controller.AddDestination("Poland", "Gliwice", segments[0].Id);
            controller.AddDestination("Italy", "Rome", segments[1].Id);
            controller.AddLandmark("Radiostacja Gliwice", "Tarnogórska 129", "Nasza mała wieża Eiffel", segments[0].Id);
            controller.AddRestingPoint("Hotel Ceasar", "Via Romana 123", Model.Enums.RestingPointType.Hotel, 7, "+48 32 47 32 997", segments[1].Id);
            controller.AddExpense("Pizza", 400.50, segments[1].Id);
            controller.AddTripMemory("Politechnika", "https://www.polsl.pl/rau/wp-content/uploads/sites/42/2021/02/wydzial_aei.jpg", "The (in)famous Mage Tower", "", segments[0].Id);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }

}

