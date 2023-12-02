using ViewEvents.Domain.Models;

namespace ViewEvents.Persistence.Interfaces
{
    public interface IPersisteceSpeaker
    {
        Task<Speaker[]> GetAllSpeaker(bool includeEvents);
        Task<Speaker> GetSpeakerById(int speaker, bool includeEvents);
        Task<Speaker[]> GetAllSpeakerByName(string speaker, bool includeEvents);
    }
}