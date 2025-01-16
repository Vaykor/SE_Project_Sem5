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

        #region DBSet
        public void AddExpense(string Name, double Value, int tripSegmentId)
        {
           
            using (var context = new TravelPlannerContext())
            {
                var expense = new Expense { Name = Name, Value = Value, TripSegmentId = tripSegmentId };
                context.Expenses.Add(expense);
                context.SaveChanges();
            }
        }
        
        
        // Not yet working
        public void AddDestination(string Country, string City, int tripSegmentId)
        {  
            using (var context = new TravelPlannerContext())
            {
                var destination = new Destination { Country = Country, City = City, TripSegmentId = tripSegmentId };
                context.Destination.Add(destination);
                context.SaveChanges();
            }       
        }
        public void AddDestination(Landmark landmark)
        {
            using (var context = new TravelPlannerContext())
            {

                context.Destination.Add(landmark);
                context.SaveChanges();
            }
        }
        public void AddLandmark(string Name, string Address, string Description, int tripSegmentId)
        {      
            using (var context = new TravelPlannerContext())
            {
                var landmark = new Landmark { Name = Name, Address = Address, Description = Description, TripSegmentId=tripSegmentId };
                context.Landmark.Add(landmark);
                context.SaveChanges();
            }
        }
        public void AddRestingPoint(string Name, string Address, RestingPointType Type, int NightsSpentThere, string ContactInfo, int tripSegmentId)
        {          
            using (var context = new TravelPlannerContext())
            {
                var restingPoint = new RestingPoint { Name = Name, Address = Address, Type = Type, NightsSpentThere = NightsSpentThere, ContactInfo = ContactInfo, TripSegmentId=tripSegmentId};
                context.RestingPoint.Add(restingPoint);
                context.SaveChanges();
            }

        }
        public void AddTrip(string Name, DateTime StartDate, DateTime EndDate, List<TripSegment>? tripSegments)
        {
            using (var context = new TravelPlannerContext())
            {
                var trip = new Trip { Name = Name, StartDate = StartDate, EndDate = EndDate };
                context.Trips.Add(trip);
                context.SaveChanges();
            }

        }
        public void AddTripMemory(string Name, int tripSegmentId)
        {      
            using (var context = new TravelPlannerContext())
            {
                var memory = new TripMemory { Name = Name, TripSegmentId = tripSegmentId};
                context.TripMemory.Add(memory);
                context.SaveChanges();
            }
        }


        // Not sure if functional?? Might be smth wrong with relations
        public void AddTripMemory(string Name, string? Photo, string? Note, string? SongURL, int tripSegmentId)
        {         
            using (var context = new TravelPlannerContext())
            {
                var memory = new TripMemory { Name = Name, Photo = Photo, Note = Note, SongURL = SongURL, TripSegmentId = tripSegmentId};
                context.TripMemory.Add(memory);
                context.SaveChanges();
            }
        }
        public void AddTripSegment(string name, List<TripMemory> memories, List<Expense> expenses, List<Destination> destinations, int tripId)
        {
            using (var context = new TravelPlannerContext())
            {
                // Fetch the Trip entity
                var trip = context.Trips.FirstOrDefault(t => t.Id == tripId);

                // Check if the Trip exists
                if (trip != null)
                {
                    // Ensure that collections are initialized even if null is passed
                    var tripSegment = new TripSegment
                    {
                        Name = name,
                        TripId = trip.Id,
                        Memories = memories ?? new List<TripMemory>(),
                        Expenses = expenses ?? new List<Expense>(),
                        Destinations = destinations ?? new List<Destination>()
                    };

                    // Add the new TripSegment
                    context.TripSegment.Add(tripSegment);

                    // Save changes
                    context.SaveChanges();
                }
                else
                {
                    // Handle the case where the Trip does not exist
                    throw new Exception($"Trip with ID {tripId} does not exist.");
                }
            }
        }

        #endregion



        #region DBGet

        public List<TripSegment> GetAllTripSegmentsByTripId(int tripId)
        {
            List<TripSegment> tripSegments = new List<TripSegment>();

            using (var context = new TravelPlannerContext())
            {
                tripSegments = context.TripSegment.Where(ts => ts.TripId == tripId).ToList();           
            }

            return tripSegments;
        }
        public List<Trip> GetAllTrips()
        {
            List<Trip> trips = new List<Trip>();
            using (var context = new TravelPlannerContext()) {

                trips = context.Trips.ToList();
            }
            return trips;
        }
        public Trip GetFirstTrip()
        { 
            Trip trip = new Trip();

            using(var context = new TravelPlannerContext())
            { 
                trip = context.Trips.FirstOrDefault();
            }
            return trip;       
        }
        public Trip GetLastTrip()
        {
            Trip trip = new Trip();

            using (var context = new TravelPlannerContext())
            {
                trip = context.Trips.OrderBy(trip => trip.Id).Last();
            }
            return trip;
        }
        public Trip GetTripById(int tripId)
        {
            Trip trip = new Trip();

            using (var context = new TravelPlannerContext())
            { 
                trip = context.Trips.Where(t => t.Id == tripId).FirstOrDefault();
            }

            return trip;
        }
        public List<TripMemory> GetAllTripMemoriesByTripSegmentId(int tripSegmentId)
        {
            List<TripMemory> tripMemories = new List<TripMemory>();

            using(var context = new TravelPlannerContext()) 
            {
                tripMemories = context.TripMemory.Where(tm => tm.TripSegmentId == tripSegmentId).ToList();
            }
         
            return tripMemories;
        }
        public List<Expense> GetAllExpensesByTripSegmentId(int tripSegmentId)
        {
            List<Expense> expenses = new List<Expense>();   
            using (var context = new TravelPlannerContext())
            {
                expenses = context.Expenses.Where(ex => ex.TripSegmentId == tripSegmentId).ToList();
            }

            return expenses;
        }
        public List<Destination> GetAllDestinationsByTripSegmentId(int tripSegmentId) 
        {
            List<Destination> destinations  = new List<Destination>();

            using (var context = new TravelPlannerContext())
            {
                destinations = context.Destination.Where(ds => ds.TripSegmentId == tripSegmentId).ToList();
            }
            return destinations;
        }
        public List<Landmark> GetAllLandmarksByTripSegmentId(int tripSegmentId)
        {
            List<Landmark> landmarks = new List<Landmark>();
            using (var context = new TravelPlannerContext())
            {
                landmarks = context.Landmark.Where(ds => ds.TripSegmentId == tripSegmentId).ToList();
            }
            return landmarks;
        }

        public List<RestingPoint> GetAllRestingPointsByTripSegmentId(int tripSegmentId)
        {
            List<RestingPoint> restingPoints = new List<RestingPoint>();
            using (var context = new TravelPlannerContext())
            {
                restingPoints = context.RestingPoint.Where(ds => ds.TripSegmentId == tripSegmentId).ToList();
            }
            return restingPoints;
        }
        #endregion

    }
}
