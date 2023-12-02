using ViewEvents.Domain.Models;

namespace ViewEvents.Persistence.Interfaces
{
    public interface IPersisteceEvent
    {
        Task<Event[]> GetAllEventsAsync(bool includeSpeaker);
        Task<Event> GetEventByIdAsync(int eventId, bool includeSpeaker);
        Task<Event[]> GetAllEventsByThemeAsync(string theme, bool includeSpeaker);
    }
}