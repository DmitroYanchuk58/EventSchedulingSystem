namespace EventDatabase_DAL.Entities
{
    public class Payment : Entity
    {
        public Guid IdEvent { get; set; }

        public Event Event { get; set; }

        public decimal Amount { get; set; }  

        public PaymentStatus PaymentStatus { get; set; }

        public Payment(Guid idEvent, Event evenT, decimal amount, PaymentStatus paymentStatus) 
        {
            this.IdEvent = idEvent;
            this.Event = evenT;
            this.Amount = amount;
            this.PaymentStatus = paymentStatus;
        }
    }
}
