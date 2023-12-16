using ViewEvents.Domain.Models;

namespace ViewEvents.Services.Interfaces
{
    public interface IEventService
    {
        Task<Event[]> GetAll();
        Task<Event[]> GetTheme(String theme);
        Task<Event> GetId(int id);

        bool Insert(Event event_);
        bool Update(Event event_);
        bool Delete(Event event_);
        bool DeleteRange(Event[] event_);
    }
}