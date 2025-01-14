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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TravelPlaner.Controller;

namespace TravelPlaner.View.Forms
{
    public partial class BrowseTripSegmentsView : Form
    {
        public BrowseTripSegmentsView(Trip trip)
        {
            
            ProgramController controller = new ProgramController();
            InitializeComponent();
           // segmentDetails1.Hide();
            TripNameLabel.Text = trip.Name;
            DateLabel.Text = trip.StartDate.ToString() + " - " + trip.EndDate.ToString();
            List<TripSegment> tripSegments = controller.GetAllTripSegmentsByTripId(trip.Id);
           
            int counter = 0;
            foreach (TripSegment segment in tripSegments)
            {
                ListViewItem item = new ListViewItem(counter++.ToString());
                item.SubItems.Add(segment.Name.ToString());
                segmentListView.Items.Add(item);
                item.Tag = segment;
            }
            segmentListView.ItemActivate += listView1_ItemActivate;

        }
       // private SegmentDetails currentSegmentDetails;
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            destinationListView.Items.Clear();
            expenseListView.Items.Clear();
            memoryListView.Items.Clear();
            ListViewItem selectedItem = segmentListView.SelectedItems[0];
            ProgramController controller = new ProgramController();
            if (selectedItem.Tag is TripSegment segment)
            {
                List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(segment.Id);
                foreach (Expense expense in expenses)
                {
                    ListViewItem item = new ListViewItem(expense.Id.ToString()); // First column (Id)
                    item.SubItems.Add(expense.Name);                            // Second column (Name)
                    item.SubItems.Add(expense.Value.ToString());// Third column (StartDate)
                    // Add row to ListView
                    expenseListView.Items.Add(item);
                }
                /*
                List<Destination> destinations = controller.GetAllDestinationsByTripSegmentId(segment.Id);
                foreach (Destination destination in destinations)
                {
                    ListViewItem item = new ListViewItem(destination.Id.ToString()); // First column (Id)
                    item.SubItems.Add(destination.Country);                            // Second column (Name)
                    item.SubItems.Add(destination.City);// Third column (StartDate)
                                                        // Add row to ListView
                    destinationListView.Items.Add(item);
                }
                */
                List<TripMemory> memories = controller.GetAllTripMemoriesByTripSegmentId(segment.Id);
                foreach (TripMemory memory in memories)
                {
                    ListViewItem item = new ListViewItem(memory.Id.ToString()); 
                    item.SubItems.Add(memory.Name);                            
                    item.SubItems.Add(memory.Note);
                    item.SubItems.Add(memory.SongURL);
                    memoryListView.Items.Add(item);
                }
            }
        }



    }
}
