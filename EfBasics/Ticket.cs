namespace EfBasics
{
    public class Ticket : BaseEntity
    {
        public decimal Price { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}
