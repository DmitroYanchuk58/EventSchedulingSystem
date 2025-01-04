namespace EventDatabase_DAL.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public List<Event> Events { get; set; }

        public List<Notification> Notifications { get; set; }

        public User(string name, string email, Role role, List<Event> events, List<Notification> notifications)
        {
            this.Name = name;
            this.Email = email;
            this.Role = role;
            this.Events = events;
            this.Notifications = notifications;
        }
    }
}
