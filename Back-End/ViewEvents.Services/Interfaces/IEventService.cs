using ViewEvents.Domain.Models;

namespace ViewEvents.Services.Interfaces
{
    public interface IEventService
    {
        Task<Event[]> GetAll();
        Task<Event[]> GetTheme(String theme);
        Task<Event> GetId(int id);

        bool Insert(Event e);
        bool Update(Event e);
        bool Delete(Event e);
        bool DeleteRange(Event[] e);
    }
}