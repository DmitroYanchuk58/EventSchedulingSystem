namespace EventDatabase_DAL.Entities
{
    public class ConflictLog : Entity
    {
        public Guid IdEvent { get; set; }

        public Event Event { get; set; }

        public string ConflictDescription {  get; set; }

        public bool ResolutionStatus { get; set; } = false;

        public ConflictLog(Guid idEvent, Event evenT, string conflictDescription, bool resolutionStatus) 
        { 
            this.IdEvent = idEvent;
            this.Event = evenT;
            this.ConflictDescription = conflictDescription;
            this.ResolutionStatus = resolutionStatus;
        }
    }
}
