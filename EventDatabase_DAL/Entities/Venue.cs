namespace EventDatabase_DAL.Entities
{
    public class Venue : Entity
    {
        public string Name {  get; set; }

        public string Location { get; set; }

        public int Capacity { get; set; }


        public List<Event>  Events { get; set; }

        public List<Booking> Bookings { get; set; }

        public Venue(string name, string location, int capacity, 
            List<Event> events, List<Booking> bookings) 
        {
            this.Name = name;
            this.Location = location;
            this.Capacity = capacity;
            this.Events = events;
            this.Bookings = bookings;
        }
    }
}
