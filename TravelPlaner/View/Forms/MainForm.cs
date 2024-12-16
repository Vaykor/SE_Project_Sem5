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
using TravelPlaner.Model.Classes.Context;
using TravelPlaner.Model.Classes.Database;

namespace TravelPlaner.View.Forms
{
    public partial class MainForm : Form
    {

        ProgramController controller = new ProgramController();

        public MainForm()
        {
            InitializeComponent();

            //controller.AddTrip("Trip_1", DateTime.Now, DateTime.Now, new List<TripSegment>());
            //controller.AddTrip("Trip_2", DateTime.Now, DateTime.Now, new List<TripSegment>());
            // controller.AddTrip("Trip_3", DateTime.Now, DateTime.Now, new List<TripSegment>());

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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Trip> tripsFromDB = new List<Trip>();
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

            if(tripFromDB.TripSegments != null)
            {
                label5.Text = tripFromDB.TripSegments.Count.ToString();
            }
            else
            {

                label5.Text = "0";
            }
            
            //label6.Text = tripMemory.Name;
            //label7.Text = tripMemory1.Photo;
            //label8.Text = tripSegment.Name;


        }
    }
}
