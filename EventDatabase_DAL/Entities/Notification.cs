namespace EventDatabase_DAL.Entities
{
    public class Notification : Entity
    {
        public Guid IdUser { get; set; }

        public User User { get; set; }

        public string Message {  get; set; }

        public DateTime TimeSpan { get; set; }

        public bool IsRead {  get; set; }   

        public Notification(Guid idUser, User user, string message, DateTime timeSpan, bool isRead)
        {
            this.IdUser = idUser;
            this.User = user;
            this.Message = message;
            this.TimeSpan = timeSpan;
            this.IsRead = isRead;
        }
    }
}
