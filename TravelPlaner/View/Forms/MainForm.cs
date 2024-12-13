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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProgramController controller = new ProgramController();
            Destination destination = controller.AddDestination("Poland", "Warsaw");
            Expense expense = controller.AddExpense("Hejka", 1.20);
            Landmark landmark = controller.AddLandmark("Akademia Pana Kleksa", "Akademicka 10", "Najlepsza Akademia w galaktyce");
            RestingPoint restingPoint = controller.AddRestingPoint("ASD", "ASDASD", Model.Enums.RestingPointType.Hostel, 3, "a");
            var theDate = new DateOnly(2015, 10, 21);
            var theDate2 = new DateOnly(2016, 10, 21);
            Trip trip = controller.AddTrip("Trip to Poland", theDate, theDate, (null));
            TripMemory tripMemory = controller.AddTripMemory("Name");
            TripMemory tripMemory1 = controller.AddTripMemory("Name2", "Photo", "Note", "SongURL");
            TripSegment tripSegment = controller.AddTripSegment("NameSegment", (null), (null), (null));

            label1.Text = expense.Value.ToString();
            label2.Text = landmark.Name;
            label3.Text = destination.Country;
            label4.Text = restingPoint.Type.ToString();
            label5.Text = trip.Name;
            label6.Text = tripMemory.Name;
            label7.Text = tripMemory1.Photo;
            label8.Text = tripSegment.Name;
        }
    }
}
