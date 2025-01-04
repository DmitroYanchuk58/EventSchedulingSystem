namespace EventDatabase_DAL.Entities
{
    public abstract class Entity
    {
        public Guid Id {  get; set; } = Guid.NewGuid();
    }
}
