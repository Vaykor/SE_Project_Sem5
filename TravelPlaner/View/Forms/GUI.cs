using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

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

            foreach(TripSegment tripSegment in tripSegments) 
            {
                Label segmentNameLabel = new Label
                {
                    Text = $"{tripSegment.Name}",  //{destinationName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, labelY+=30),
                    AutoSize = true
                };
                tripInfoPanel.Controls.Add(segmentNameLabel);
            }
        }

        //-----------menu panel--------------------
        private void newTripButton_Click(object sender, EventArgs e)
        {
            ShowPanel(newTripPanel);
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
                    Location = new Point(tripPanel.Width-100, 40),
                    AutoSize = true
                };
                tripPanel.Controls.Add(viewButton);

                viewButton.Click += (sender, e) => ShowTripDetails(trip,tripSegments);

                // Add the trip panel to the parent panel
                tripListPanel.Controls.Add(tripPanel);
                panelY += 110; // Increment the Y position for the next panel
            }
        }

        //---------------------add new trips panel--------------------
        private void returnFromAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
        }

        //---------browse trips panel----------------------

        private void returnFromBrowseButton_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
        }


        //-------------------inpect trips panel --------------------
        private void returnFromInspectButton_Click(object sender, EventArgs e)
        {
            ShowPanel(browseTripPanel);
            tripInfoPanel.Controls.Clear();
        }
    }

}

