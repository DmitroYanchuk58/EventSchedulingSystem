namespace EventDatabase_DAL.Entities
{
    public class Attend : Entity
    {
        public string Name { get; set; }

        public string ContactInfo { get; set; }

        public Guid IdEvent { get; set; }

        public Event Event { get; set; }

        public Attend(string name, string contactInfo, Guid idEvent, Event evenT) {
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.IdEvent = idEvent;
            this.Event = evenT;
        }

    }
}
