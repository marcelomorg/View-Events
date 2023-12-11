using ViewEvents.Domain.Models;

namespace ViewEvents.Services.Interfaces
{
    public interface IEventService
    {
        Task<Event[]> GetAll();
        Task<Event[]> GetTheme();
        Task<Event> GetId(Event id);

        void Insert(Event e);
        void Update(Event e);
        void Delete(Event e);
        void DeleteRange(Event[] e);
    }
}