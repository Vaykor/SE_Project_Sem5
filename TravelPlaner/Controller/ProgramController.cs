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

        #region DbUpdate

        public void UpdateExpense(Expense updatedExpense)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingExpense = context.Expenses.FirstOrDefault(e => e.Id == updatedExpense.Id);

                if (updatedExpense != null)
                {
                    existingExpense.Name = updatedExpense.Name;
                    existingExpense.Value = updatedExpense.Value;
                    existingExpense.TripSegmentId = updatedExpense.TripSegmentId;
                   
                    context.SaveChanges();
                }
            }

        }

        public void UpdateDestination(Destination updatedDestination)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingDestination = context.Destination.FirstOrDefault(e => e.Id == updatedDestination.Id);

                if (existingDestination != null)
                {
                    existingDestination.Country = updatedDestination.Country;
                    existingDestination.City = updatedDestination.City;
                    existingDestination.TripSegmentId = updatedDestination.TripSegmentId;

                    context.SaveChanges();
                }
            }

        }

        public void UpdateLandmark(Landmark updatedLandmark)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingLandmark = context.Landmark.FirstOrDefault(e => e.Id == updatedLandmark.Id);

                if (existingLandmark != null)
                {
                    existingLandmark.Name = updatedLandmark.Name;
                    existingLandmark.Address = updatedLandmark.Address;
                    existingLandmark.Description = updatedLandmark.Description;

                    context.SaveChanges();
                }
            }
        }

        public void UpdateRestingPoint(RestingPoint updatedRestingPoint)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingRestingPoint = context.RestingPoint.FirstOrDefault(e => e.Id == updatedRestingPoint.Id);

                if (existingRestingPoint != null)
                {
                    existingRestingPoint.Name = updatedRestingPoint.Name;
                    existingRestingPoint.Address = updatedRestingPoint.Address;
                    existingRestingPoint.Type = updatedRestingPoint.Type;
                    existingRestingPoint.NightsSpentThere = updatedRestingPoint.NightsSpentThere;
                    existingRestingPoint.ContactInfo = updatedRestingPoint.ContactInfo;

                    context.SaveChanges();
                }
            }
        }

        public void UpdateTrip(Trip updatedTrip)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingTrip = context.Trips.FirstOrDefault(e => e.Id == updatedTrip.Id);

                if (existingTrip != null)
                {
                    existingTrip.Name = updatedTrip.Name;
                    existingTrip.StartDate = updatedTrip.StartDate;
                    existingTrip.EndDate = updatedTrip.EndDate;
                    existingTrip.TripSegments = updatedTrip.TripSegments;

                    context.SaveChanges();
                }
            }
        }

        public void UpdateTripMemory(TripMemory updatedTripMemory)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingTripMemory = context.TripMemory.FirstOrDefault(e => e.Id == updatedTripMemory.Id);

                if (existingTripMemory != null)
                {
                    existingTripMemory.Name = updatedTripMemory.Name;
                    existingTripMemory.Photo = updatedTripMemory.Photo;
                    existingTripMemory.Note = updatedTripMemory.Note;
                    existingTripMemory.SongURL = updatedTripMemory.SongURL;
                    existingTripMemory.TripSegmentId = updatedTripMemory.TripSegmentId;

                    context.SaveChanges();
                }
            }
        }

        public void UpdateTripSegment(TripSegment updatedTripSegment)
        {
            using (var context = new TravelPlannerContext())
            {
                var existingTripSegment = context.TripSegment.FirstOrDefault(e => e.Id == updatedTripSegment.Id);

                if (existingTripSegment != null)
                {
                    existingTripSegment.Name = updatedTripSegment.Name;
                    existingTripSegment.Memories = updatedTripSegment.Memories;
                    existingTripSegment.Expenses = updatedTripSegment.Expenses;
                    existingTripSegment.Destinations = updatedTripSegment.Destinations;
                    existingTripSegment.TripId = updatedTripSegment.TripId;

                    context.SaveChanges();
                }
            }
        }


        #endregion

    }
}
