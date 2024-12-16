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
        public void AddExpense(string Name, double Value)
        {
           
            using (var context = new TravelPlannerContext())
            {
                var expense = new Expense { Name = Name, Value = Value };
                context.Expenses.Add(expense);
                context.SaveChanges();
            }
        }

        public void AddDestination(string Country, string City)
        {
           
            using (var context = new TravelPlannerContext())
            {
                var destination = new Destination { Country = Country, City = City };
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
            //return destination;          
        }

        public void AddLandmark(string Name, string Address, string Description)
        {
           
            using (var context = new TravelPlannerContext())
            {
                var landmark = new Landmark { Name = Name, Address = Address, Description = Description };
                context.Landmarks.Add(landmark);
                context.SaveChanges();
            }
            //return landmark;
        }

        public void AddRestingPoint(string Name, string Address, RestingPointType Type, int LengthOfStay, string ContactInfo)
        {
            
            using (var context = new TravelPlannerContext())
            {
                var restingPoint = new RestingPoint { Name = Name, Address = Address, Type = Type, LengthOfStay = LengthOfStay, ContactInfo = ContactInfo };
                context.RestingPoints.Add(restingPoint);
                context.SaveChanges();
            }
            //return restingPoint;
        }

        public void AddTrip(string Name, DateTime StartDate, DateTime EndDate, List<TripSegment>? tripSegments)
        {
            using (var context = new TravelPlannerContext())
            {
                var trip = new Trip { Name = Name, StartDate = StartDate, EndDate = EndDate };
                context.Trips.Add(trip);
                context.SaveChanges();
            }
            //return trip;
        }

        public void AddTripMemory(string Name)
        {
            
            using (var context = new TravelPlannerContext())
            {
                var memory = new TripMemory { Name = Name };
                context.TripMemories.Add(memory);
                context.SaveChanges();
            }
            //return memory;
        }
        public void AddTripMemory(string Name, string? Photo, string? Note, string? SongURL)
        {
            
            using (var context = new TravelPlannerContext())
            {
                var memory = new TripMemory { Name = Name, Photo = Photo, Note = Note, SongURL = SongURL };
                context.TripMemories.Add(memory);
                context.SaveChanges();
            }
            //return memory;
        }
        public void AddTripSegment(string Name, List<TripMemory> memories, List<Expense> expenses, List<Destination> destinations)
        {

            using (var context = new TravelPlannerContext())
            {
                //var TripSegment = new TripSegment { Name = Name, Memories = memories, Expenses = expenses, Destinations = destinations };

                var TripSegment = new TripSegment { Name = "1", Memories = new List<TripMemory>(), Expenses = new List<Expense>(), Destinations = new List<Destination>() };
                context.TripSegment.Add(TripSegment);


                context.SaveChanges();
            }
            //return TripSegment;
        }


        public List<Trip> GetAllTrips()
        {
            List<Trip> trips = new List<Trip>();
            using (var context = new TravelPlannerContext()) {

                trips = context.Trips.ToList();
            }
            return trips;
        }

        public Trip GetTripById(int id)
        { 
            Trip trip = new Trip();

            using(var context = new TravelPlannerContext())
            { 
                trip = context.Trips.Where(t => t.Id == id).FirstOrDefault();
            }
            return trip;       
        }

        public TripSegment GetFirstTripSegment()
        { 
            TripSegment tripSegment = new TripSegment();

            using (var context = new TravelPlannerContext())
            {
                tripSegment = context.TripSegment.FirstOrDefault();
            }
            return tripSegment;

        }

        public void AddTripSegmentToTrip(Trip tripId, int tripSegmentId)
        {

            using (var context = new TravelPlannerContext())
            {
                var trip = context.Trips.Where(t => t.Id == tripId.Id).FirstOrDefault();
                var tripSegment = context.TripSegment.Where(ts => ts.Id == tripSegmentId ).FirstOrDefault();

                tripSegment.Trip = trip;

                context.SaveChanges();
            }

        }




        public void ClearTripsTable()
        {
            using (var context = new TravelPlannerContext())
            {
                var allEntities = context.Trips.ToList(); 
                context.Trips.RemoveRange(allEntities);   
                context.SaveChanges();
            }
        }
    
    
    }
}
