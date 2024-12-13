using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Model.Classes.Context;
using TravelPlaner.Model.Classes.Database;
using TravelPlaner.Model.Enums;

namespace TravelPlaner.Controller
{
    public class ProgramController
    {
        public Expense AddExpense(string Name, double Value)
        {
            var expense = new Expense { Name = Name, Value = Value };
            using (var context = new TravelPlannerContext())
            {
                //TO DO by Sara 
                //context.Add(expense);
                //context.SaveChanges();
                
            }
            Console.WriteLine("hejka");
            return expense;
        }

        public Destination AddDestination(string Country, string City)
        {
            var destination = new Destination { Country = Country, City = City };
            using (var context = new TravelPlannerContext())
            {

            }
            return destination;          
        }

        public Landmark AddLandmark(string Name, string Address, string Description)
        {
            var landmark = new Landmark { Name = Name, Address = Address, Description = Description };
            using (var context = new TravelPlannerContext())
            {

            }
            return landmark;
        }

        public RestingPoint AddRestingPoint(string Name, string Address, RestingPointType Type, int LengthOfStay, string ContactInfo)
        {
            var restingPoint = new RestingPoint { Name = Name, Address = Address, Type = Type, LengthOfStay = LengthOfStay, ContactInfo = ContactInfo };
            using (var context = new TravelPlannerContext())
            {

            }
            return restingPoint;
        }

        public Trip AddTrip(string Name, DateOnly StartDate, DateOnly EndDate, List<TripSegment>? tripSegments)
        {
            var trip = new Trip { Name = Name, StartDate = StartDate, EndDate = EndDate };
            using (var context = new TravelPlannerContext())
            {

            }
            return trip;
        }

        public TripMemory AddTripMemory(string Name)
        {
            var memory = new TripMemory { Name = Name };
            using (var context = new TravelPlannerContext())
            {

            }
            return memory;
        }
        public TripMemory AddTripMemory(string Name, string Photo, string Note, string SongURL)
        {
            var memory = new TripMemory { Name = Name, Photo = Photo, Note = Note, SongURL = SongURL };
            using (var context = new TravelPlannerContext())
            {

            }
            return memory;
        }

        public TripSegment AddTripSegment(string Name, List<TripMemory> memories, List<Expense> expenses, List<Destination> destinations)
        {
            var TripSegment = new TripSegment { Name = Name, Memories = memories, Expenses = expenses, Destinations = destinations };
            using (var context = new TravelPlannerContext())
            {

            }
            return TripSegment;
        }
    }
}
