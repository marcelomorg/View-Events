using System.Reflection.Metadata.Ecma335;
using ViewEvents.Domain.Models;
using ViewEvents.Persistence.Interfaces;
using ViewEvents.Services.Interfaces;

namespace ViewEvents.Services.Services
{
    public class SpeakerService : ISpeakerService
    {
        private readonly IPersisteceSpeaker _persistenceSpeaker;
        private readonly IPersistenceGeneral _persistenceGeneral;

        public SpeakerService(IPersisteceSpeaker persisteceSpeaker, IPersistenceGeneral persistenceGeneral)
        {
            _persistenceSpeaker = persisteceSpeaker;
            _persistenceGeneral = persistenceGeneral;
        }
        public async Task<Speaker[]> Getall()
        {
            return await _persistenceSpeaker.GetAllSpeaker(false);
        }

        public async Task<Speaker> GetId(int id)
        {
            return await _persistenceSpeaker.GetSpeakerById(id, false);
        }

        public async Task<Speaker[]> GetName(string speaker)
        {
            return  await _persistenceSpeaker.GetAllSpeakerByName(speaker, false);
        }

        public bool Insert(Speaker speaker)
        {
            _persistenceGeneral.Add(speaker);
            return _persistenceGeneral.SaveChangesAsync().Result;
        }

        public bool Update(Speaker speaker)
        {
            _persistenceGeneral.Update(speaker);
            return _persistenceGeneral.SaveChangesAsync().Result;
        }

        public bool Delete(Speaker speaker)
        {
            _persistenceGeneral.Delete(speaker);
            return _persistenceGeneral.SaveChangesAsync().Result;
        }

        public bool DeleteRange(Speaker[] speakers)
        {
            throw new NotImplementedException();
        }
    }
}