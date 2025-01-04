namespace EventDatabase_DAL.Entities
{
    public class Event : Entity
    {
        public string Title {  get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }  

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }   

        public Guid VenueId { get; set; }

        public Venue Venue { get; set; }

        public StatusEvent StatusEvent { get; set; }

        public List<ConflictLog> ConflictLogs { get; set; }

        public List<Attend> Attends { get; set; }

        public List<Booking> Bookings { get; set; }

        public List<EventResource> EventResources { get; set; }

        public Event(string title, string description, Guid userId, User user, 
            DateTime startTime, DateTime endTime, Guid venueId, Venue venue, 
            StatusEvent statusEvent, List<ConflictLog> conflictLogs, List<Attend> attends,
            List<Booking> bookings, List<EventResource> eventResources) 
        { 
            this.Title= title; 
            this.Description = description;
            this.UserId= userId;
            this.User = user;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.VenueId = venueId;
            this.Venue = venue;
            this.StatusEvent = statusEvent;
            this.ConflictLogs = conflictLogs;
            this.Attends = attends;
            this.Bookings = bookings;
            this.EventResources = eventResources;
        }
    }
}
