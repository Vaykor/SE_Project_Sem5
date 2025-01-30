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
using TravelPlaner.Controller.Helpers.APIs;
using TravelPlaner.Model.Classes.Context;
using TravelPlaner.Model.Classes.Database;
using TravelPlaner.Model.Classes.PlacesAPI;

namespace TravelPlaner.View.Forms
{
    public partial class RecommendedLandmarks : Form
    {

        ProgramController controller = new ProgramController();
        string passedCity;

        public RecommendedLandmarks()
        {
            InitializeComponent();

            //controller.AddTrip("Trip_1", DateTime.Now, DateTime.Now, new List<TripSegment>());
            //controller.AddTrip("Trip_2", DateTime.Now, DateTime.Now, new List<TripSegment>());
            //controller.AddTrip("Trip_3", DateTime.Now, DateTime.Now, new List<TripSegment>());

            // Destination destination = controller.AddDestination("Poland", "Warsaw");

            //Expense expense = controller.AddExpense("Hejka", 1.20);

            //Landmark landmark = controller.AddLandmark("Akademia Pana Kleksa", "Akademicka 10", "Najlepsza Akademia w galaktyce");

            //RestingPoint restingPoint = controller.AddRestingPoint("ASD", "ASDASD", Model.Enums.RestingPointType.Hostel, 3, "a");

            //Trip
            // var theDate = new DateTime(2015, 10, 21);
            // var theDate2 = new DateTime(2016, 10, 21);
            // Trip trip = controller.AddTrip("Trip to Poland", theDate, theDate, (null));

            //TripMemory tripMemory = controller.AddTripMemory("Name");
            //TripMemory tripMemory1 = controller.AddTripMemory("Name2", "Photo", "Note", "SongURL");

            //TripSegment tripSegment = controller.AddTripSegment("NameSegment", (null), (null), (null));


        }
        public RecommendedLandmarks(string city)
        {
            InitializeComponent();
            passedCity = city;
            PopulateListViewAsync();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            /*List<Trip> tripsFromDB = new List<Trip>();
            tripsFromDB = controller.GetAllTrips();

            Trip tripFromDB = controller.GetFirstTrip();

            controller.AddTripSegment("TestSegment", new List<TripMemory>(), new List<Expense>(), new List<Destination>(), tripFromDB.Id);

            List<TripSegment> tripSegments = controller.GetAllTripSegmentsByTripId(tripFromDB.Id);

            tripFromDB.TripSegments = tripSegments;


            controller.AddTripMemory("Memory 1", tripFromDB.TripSegments[0].Id);
            List<TripMemory> tripMemories = controller.GetAllTripMemoriesByTripSegmentId(tripFromDB.TripSegments[0].Id);

            controller.AddExpense("Expense 1", 3.5, tripFromDB.TripSegments[0].Id);
            List<Expense> expenses = controller.GetAllExpensesByTripSegmentId(tripFromDB.TripSegments[0].Id);

            //controller.AddDestination("Poland", "Gliwice", tripFromDB.TripSegments[0].Id);
            //List<Destination> destinations = controller.GetAllDestinationsByTripSegmentId(tripFromDB.TripSegments[0].Id);



            label1.Text = tripFromDB.Id.ToString();
            label2.Text = tripFromDB.Name.ToString();
            label3.Text = tripFromDB.StartDate.ToString();
            label4.Text = tripFromDB.EndDate.ToString();

            if (tripFromDB.TripSegments != null)
            {
                label5.Text = tripFromDB.TripSegments.Count.ToString();
            }
            else
            {

                label5.Text = "0";
            }*/

            //label6.Text = tripMemory.Name;
            //label7.Text = tripMemory1.Photo;
            //label8.Text = tripSegment.Name;
            this.Parent.Dispose();
            
        }

        private async Task PopulateListViewAsync()
        {
            if (!string.IsNullOrEmpty(passedCity) || !string.IsNullOrEmpty(passedCity))
            {
                label1.Text = "Searching for landmarks near " + passedCity + "...";
                PlacesApiHelper placesApiHelper = new PlacesApiHelper();
                List<TouristLandmark> touristLandmarks = await placesApiHelper.GetTouristLandmarksAsync(passedCity);
                TouristLandmarkListView.Items.Clear();
                if (touristLandmarks.Count() != 0)
                {
                    foreach (TouristLandmark landmark in touristLandmarks)
                    {
                        if (landmark != null)
                        {

                            if (landmark.Phone != null)
                            {
                                string?[] row = { landmark.Name, landmark.Country, landmark.City, landmark.Street, landmark.Phone };
                                var listViewItem = new ListViewItem(row);
                                TouristLandmarkListView.Items.Add(listViewItem);
                            }
                            else
                            {
                                string?[] row = { landmark.Name, landmark.Country, landmark.City, landmark.Street, "None" };
                                var listViewItem = new ListViewItem(row);
                                TouristLandmarkListView.Items.Add(listViewItem);
                            }
                        }


                    }
                    label1.Text = "Success! We found some landmarks near " + passedCity;
                } else
                {
                    label1.Text = "We couldn't find any landmarks near " + passedCity;
                }
            }



        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
