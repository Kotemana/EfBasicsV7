namespace EfBasics
{
    public class Visitor : BaseEntity
    {
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; } 
    }
}
