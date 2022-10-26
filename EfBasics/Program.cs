using System.Globalization;

namespace EfBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //AddEvent();
            GetTicketsCount();
            Console.WriteLine("Thanks");

        }

        private static void GetTicketsCount()
        {
            Console.WriteLine("Select event by entering its Id");
            var eventManager = new EventManager();
            var events = eventManager.GetEventsList();
            foreach (var ev in events)
            {
                Console.WriteLine($"{ev.Id} - {ev.Name}");
            }
            var count = eventManager.GetFreeTickets(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Free tickets left:{count}");
        }


        private static void AddEvent()
        {
            Console.WriteLine("Adding new event");
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter max seats:");
            var tickets = int.Parse(Console.ReadLine());
            Console.WriteLine("enter date in format dd-MM-yyyy hh:mm");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm", CultureInfo.CurrentCulture);
            var eventManager = new EventManager();
            eventManager.AddEvent(name, tickets, date);
        }
    }
}