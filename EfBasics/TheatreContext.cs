using Microsoft.EntityFrameworkCore;


namespace EfBasics
{
    public class TheatreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HEL03573;Database=TheatreDB;Trusted_Connection=True;");
        }

        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
