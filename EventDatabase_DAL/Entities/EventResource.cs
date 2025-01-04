namespace EventDatabase_DAL.Entities
{
    public class EventResource : Entity
    {
        public Guid IdEvent { get; set; }

        public Event Event { get; set; }

        public Guid IdResource { get; set; }

        public Resource Resource { get; set; }

        public bool QuantityRequired { get; set; }

        public EventResource(Guid idEvent, Event evenT, Guid idResource, Resource resource, 
            bool quantityRequired)
        {
            this.IdEvent = idEvent;
            this.Event = evenT;
            this.IdResource = idResource;
            this.Resource = resource;
            this.QuantityRequired = quantityRequired;
        }
    }
}
