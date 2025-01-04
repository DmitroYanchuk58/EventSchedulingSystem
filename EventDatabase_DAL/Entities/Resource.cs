namespace EventDatabase_DAL.Entities
{
    public class Resource : Entity
    {
        public string Name { get; set; }

        public TypeResource TypeResource { get; set; }

        public bool Availability { get; set; }   

        public List<EventResource> EventResources { get; set; }
        
        public Resource(string name, TypeResource typeResource, bool availability, List<EventResource> eventResources)
        {
            this.Name = name;
            this.TypeResource = typeResource;
            this.Availability = availability;
            this.EventResources = eventResources;
        }
    }
}
