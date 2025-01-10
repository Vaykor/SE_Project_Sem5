using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int labelY = 40;
            menuPanel.Visible = false;
            newTripPanel.Visible = false;
            browseTripPanel.Visible = false;
            inspectTripPanel.Visible = false;

            inspectTripPanel.Visible = true;
            inspectTripPanel.BringToFront();

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
            tripInfoPanel.Controls.Add(dateLabel);

            foreach (TripSegment tripSegment in tripSegments)
            {
                Label segmentNameLabel = new Label
                {
                    Text = $"{tripSegment.Name}",  //{destinationName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, labelY += 30),
                    AutoSize = true
                };
                tripInfoPanel.Controls.Add(segmentNameLabel);
            }
        }

        //-----------menu panel--------------------
        private void newTripButton_Click(object sender, EventArgs e)
        {
            ShowPanel(newTripPanel);
            AddTripSegmentSection(addTripFlowLayoutPanel);


        }
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
            btnAddSegment.Click += (s, e) => AddTripSegment(sectionPanel);
            sectionPanel.Controls.Add(btnAddSegment);

            flowLayoutPanel.Controls.Add(sectionPanel);
        }

        private void AddTripSegment(FlowLayoutPanel sectionPanel)
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
            btnAddExpense.Click += (s, e) => AddExpense(expensePanel);
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
            btnAddMemory.Click += (s, e) => AddMemory(memoryPanel);
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
        }

        private void AddLandmark(FlowLayoutPanel sectionPanel)
        {
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200 };
            segmentPanel.Controls.Add(lblName);
            segmentPanel.Controls.Add(txtName);

            // Pole Address
            var lblAddress = new Label { Text = "Address:", AutoSize = true };
            var txtAddress = new TextBox { Width = 200 };
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

        private void AddExpense(FlowLayoutPanel sectionPanel)
        {
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblName = new Label { Text = "Name:", AutoSize = true };
            var txtName = new TextBox { Width = 200 };
            segmentPanel.Controls.Add(lblName);
            segmentPanel.Controls.Add(txtName);

            // Pole Value
            var lblValue = new Label { Text = "Value:", AutoSize = true };
            var txtValue = new TextBox { Width = 200 };
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

        private void AddMemory(FlowLayoutPanel sectionPanel)
        {
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

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
            btnAddSong.Click += (s, e) => AddSong(songPanel);
            segmentPanel.Controls.Add(songLabel);
            segmentPanel.Controls.Add(btnAddSong);
            segmentPanel.Controls.Add(songPanel);


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
            btnAddNote.Click += (s, e) => AddNote(notePanel);
            segmentPanel.Controls.Add(noteLabel);
            segmentPanel.Controls.Add(btnAddNote);
            segmentPanel.Controls.Add(notePanel);

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

        private void AddSong(FlowLayoutPanel sectionPanel)
        {
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblURL = new Label { Text = "URL:", AutoSize = true };
            var txtURL = new TextBox { Width = 200 };
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

        private void AddNote(FlowLayoutPanel sectionPanel)
        {
            var segmentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5)
            };

            // Pole Name
            var lblNote = new Label { Text = "Note:", AutoSize = true };
            var txtNote = new TextBox { Width = 200 };
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

        private void browseTripsButton_Click(object sender, EventArgs e)
        {
            ShowPanel(browseTripPanel);

            //Panel parentPanel = new Panel
            // {
            //     AutoScroll = true,
            // Dock = DockStyle.Fill
            // };
            // this.Controls.Add(tripListPanel);

            // Fetch trips from database
            List<Trip> trips = controller.GetAllTrips();

            int panelY = 10; // Vertical position for each trip panel
            foreach (var trip in trips)
            {
                // Fetch trip segments and count them
                List<TripSegment> tripSegments = controller.GetAllTripSegmentsByTripId(trip.Id);
                int segmentCount = tripSegments.Count;

                // Fetch destinations for the first segment (if needed)
                //string destinationName = tripSegments.FirstOrDefault() != null
                //     ? controller.GetAllDestinationsByTripSegmentId(tripSegments.First().Id).FirstOrDefault()?.Country
                //     : "Unknown";

                // Create a new panel for the trip
                Panel tripPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(tripListPanel.Width - 40, 100),
                    Location = new Point(10, panelY),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                // Add a label for the trip name and destination
                Label nameLabel = new Label
                {
                    Text = $"Name: {trip.Name} - Destination: poland",  //{destinationName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                tripPanel.Controls.Add(nameLabel);

                // Add a label for the start and end dates
                Label dateLabel = new Label
                {

                    Text = $"Start: {trip.StartDate.ToShortDateString()} - End: {trip.EndDate.ToShortDateString()}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };
                tripPanel.Controls.Add(dateLabel);

                // Add a label for the number of segments
                Label segmentLabel = new Label
                {
                    Text = $"Number of Segments: {segmentCount}",
                    Location = new Point(10, 70),
                    AutoSize = true
                };
                tripPanel.Controls.Add(segmentLabel);

                Button viewButton = new Button
                {
                    Text = "🔍",
                    Location = new Point(tripPanel.Width - 100, 40),
                    AutoSize = true
                };
                tripPanel.Controls.Add(viewButton);

                viewButton.Click += (sender, e) => ShowTripDetails(trip, tripSegments);

                // Add the trip panel to the parent panel
                tripListPanel.Controls.Add(tripPanel);
                panelY += 110; // Increment the Y position for the next panel
            }
        }

        //---------------------add new trips panel--------------------
        private void returnFromAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            addTripFlowLayoutPanel.Controls.Clear();
        }

        //---------browse trips panel----------------------

        private void returnFromBrowseButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
            tripListPanel.Controls.Clear();
        }


        //-------------------inpect trips panel --------------------
        private void returnFromInspectButton_Click(object sender, EventArgs e)
        {
            ShowPanel(browseTripPanel);
            tripInfoPanel.Controls.Clear();
        }

        private void editTripButton_Click(object sender, EventArgs e)
        {
            ShowPanel(editTripPanel);
            AddTripSegmentSection(editTripFlowLayoutPanel);
        }



        //------------------------edit trips panel----------------------
        private void returnFromEditTrip_Click(object sender, EventArgs e)
        {
            ShowPanel(inspectTripPanel);
            editTripFlowLayoutPanel.Controls.Clear();   
        }

    }

}

