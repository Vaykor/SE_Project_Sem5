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
            segmentDetails1.Hide();
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
        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem selectedItem = segmentListView.SelectedItems[0];

            if (selectedItem.Tag is TripSegment segment)
            {
                segmentDetails1.Show();
                
                
            }
        }
    }
}
