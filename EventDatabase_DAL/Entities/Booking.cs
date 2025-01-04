namespace EventDatabase_DAL.Entities
{
    public class Booking : Entity
    {
        public Guid IdEvent { get; set; }

        public Event Event { get; set; }

        public Guid VenueId { get; set; }

        public Venue Venue { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public Booking(Guid idEvent, Event evenT, Guid venueId, Venue venue, BookingStatus bookingStatus)
        {
            this.IdEvent = idEvent;
            this.Event = evenT;
            this.VenueId = venueId;
            this.Venue = venue;
            this.BookingStatus = bookingStatus;
        }
    }
}
