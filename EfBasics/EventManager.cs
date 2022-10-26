using Microsoft.EntityFrameworkCore;

namespace EfBasics
{
    public class EventManager
    {
        public void AddEvent(string name, int ticketCount, DateTime date)
        {
            using var context = new TheatreContext();
            var Event = new Event() { Date = date, TicketsCount = ticketCount, Name = name };
            context.Events.Add(Event);
            context.SaveChanges();
        }

        public List<Event> GetEventsList()
        {
            using var context = new TheatreContext();
            return context.Events.ToList();

        }

        public int GetFreeTickets(int eventId)
        {
            using var context = new TheatreContext();
            var currentEvent = context.Events.FirstOrDefault(x=>x.Id == eventId);
            var soldTicketsCount = context.Tickets.Where(x => x.EventId == eventId).Count();
            if(currentEvent != null)
            {
                return currentEvent.TicketsCount - soldTicketsCount;
            }
            return 0;
        }
    }
}
