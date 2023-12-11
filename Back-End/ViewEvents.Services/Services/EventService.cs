using System.Reflection.Metadata;
using ViewEvents.Domain.Models;
using ViewEvents.Persistence.Interfaces;
using ViewEvents.Persistence.Persistencies;
using ViewEvents.Services.Interfaces;

namespace ViewEvents.Services.Services
{
    public class EventService : IEventService
    {
        private readonly IPersistenceEvent _persistenceEvent;
        private  readonly IPersistenceGeneral _persistenceGeneral;
        public EventService(IPersistenceEvent pe, IPersistenceGeneral pg)
        {
            _persistenceEvent = pe;
            _persistenceGeneral = pg;
        }

        public Task<Event[]> GetAll()
        {
            return _persistenceEvent.GetAllEventsAsync(false); 
        }

        public Task<Event> GetId(Event id)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetTheme()
        {
            throw new NotImplementedException();
        }

        public void Insert(Event e)
        {
            throw new NotImplementedException();
        }

        public void Update(Event e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Event e)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(Event[] e)
        {
            throw new NotImplementedException();
        }
    }
}