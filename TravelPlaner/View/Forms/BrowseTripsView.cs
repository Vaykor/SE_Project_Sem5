using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlaner.Model.Classes.Database;
using TravelPlaner.Controller;

namespace TravelPlaner.View.Forms
{
    public partial class BrowseTripsView : Form
    {
        public event EventHandler? ItemActivate;

        public BrowseTripsView()
        {

            ProgramController controller = new ProgramController();
            List<Trip> trips = controller.GetAllTrips();
            List<TripSegment> tripSegments = new List<TripSegment>();
            InitializeComponent();
            foreach (var trip in trips)
            {
                // Calculate the segment count
                tripSegments = controller.GetAllTripSegmentsByTripId(trip.Id);
                int segmentCount = tripSegments.Count;

                // Create a row with trip data
                ListViewItem item = new ListViewItem(trip.Id.ToString()); // First column (Id)
                item.SubItems.Add(trip.Name);                            // Second column (Name)
                item.SubItems.Add(trip.StartDate.ToString("yyyy-MM-dd"));// Third column (StartDate)
                item.SubItems.Add(trip.EndDate.ToString("yyyy-MM-dd"));  // Fourth column (EndDate)
                item.SubItems.Add(segmentCount.ToString());              // Fifth column (Segment Count)
                item.Tag = trip;
                // Add row to ListView
                listView1.Items.Add(item);
            }
            listView1.ItemActivate += listView1_ItemActivate;

            /* var theDate = new DateOnly(2015, 10, 21);
             var theDate2 = new DateOnly(2016, 10, 21);
             TripSegment tripSegment1 = controller.AddTripSegment("NameSegment1", (null), (null), (null));
             TripSegment tripSegment2 = controller.AddTripSegment("NameSegment2", (null), (null), (null));
             List<TripSegment> tripSegments = new List<TripSegment>();
             tripSegments.Add(tripSegment1);
             tripSegments.Add(tripSegment2);
             Trip trip = controller.AddTrip("Trip to Poland", theDate, theDate2, tripSegments);
             var theDate3 = new DateOnly(2012, 10, 21);
             var theDate4 = new DateOnly(2013, 10, 21);
             TripSegment tripSegment4 = controller.AddTripSegment("NameSegment4", (null), (null), (null));
             TripSegment tripSegment5 = controller.AddTripSegment("NameSegment5", (null), (null), (null));
             List<TripSegment> tripSegments2 = new List<TripSegment>();
             tripSegments2.Add(tripSegment4);
             tripSegments2.Add(tripSegment5);
             Trip trip2 = controller.AddTrip("Trip to Czechoslovakia", theDate3, theDate4, tripSegments2);
             List<Trip> trips = new List<Trip>();
             trips.Add(trip);
             trips.Add(trip2);
             InitializeComponent();
             ListViewItem item = new ListViewItem(1.ToString());
             item.SubItems.Add(trip.Name);
             item.SubItems.Add(trip.StartDate.ToString());
             item.SubItems.Add(trip.EndDate.ToString());
             item.SubItems.Add(tripSegments.Count.ToString());  //correct this
             item.Tag = trip; // Assign trip to the Tag property
             listView1.Items.Add(item);
             ListViewItem item2 = new ListViewItem(2.ToString());
             item2.SubItems.Add(trip2.Name);
             item2.SubItems.Add(trip2.StartDate.ToString());
             item2.SubItems.Add(trip2.EndDate.ToString());
             item2.SubItems.Add(tripSegments2.Count.ToString());  //correct this
             item2.Tag = trip2; // Assign trip2 to the Tag property
             listView1.Items.Add(item2);
             */

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem selectedItem = listView1.SelectedItems[0];

            if (selectedItem.Tag is Trip trip)
            {
                // Show a message specific to the selected trip
                LoadForm(new BrowseTripSegmentsView(trip));
            }
        }

        private void LoadForm(Form frm)
        {
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            // Here you can set a bunch of properties, apply skins, save logs...
            // before you show any form
            frm.Show();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    } 
}
