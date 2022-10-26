namespace EfBasics
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TicketsCount { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
