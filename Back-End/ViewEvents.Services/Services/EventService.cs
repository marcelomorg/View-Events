using ViewEvents.Domain.Models;
using ViewEvents.Persistence.Interfaces;
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

        public Task<Event> GetId(int id)
        {
            return _persistenceEvent.GetEventByIdAsync(id, false);
        }

        public Task<Event[]> GetTheme(String theme)
        {
            return _persistenceEvent.GetAllEventsByThemeAsync(theme, false);
        }

        public bool Insert(Event e)
        {
            try
            {
                _persistenceGeneral.Add(e);
                return _persistenceGeneral.SaveChangesAsync().Result;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro in Insert method. ERRO: " + ex.Message);
                return false;
            }
        }

        public bool Update(Event e)
        {
            _persistenceGeneral.Update(e);
            return _persistenceGeneral.SaveChangesAsync().Result;
        }

        public bool Delete(Event e)
        {
            _persistenceGeneral.Delete(e);
            return _persistenceGeneral.SaveChangesAsync().Result;
        }

        public bool DeleteRange(Event[] e)
        {
            throw new NotImplementedException();
        }
    }
}