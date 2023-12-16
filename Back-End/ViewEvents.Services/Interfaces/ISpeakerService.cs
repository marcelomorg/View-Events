using ViewEvents.Domain.Models;

namespace ViewEvents.Services.Interfaces
{
    public interface ISpeakerService
    {
        Task<Speaker[]> Getall();
        Task<Speaker[]> GetName(string speaker);
        Task<Speaker> GetId(int id);
        bool Insert(Speaker speaker);
        bool Update(Speaker speaker);
        bool Delete (Speaker speaker);
        bool DeleteRange(Speaker[] speakers);
    }
}