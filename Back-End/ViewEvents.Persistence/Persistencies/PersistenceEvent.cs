
using Microsoft.EntityFrameworkCore;
using ViewEvents.Domain.Models;
using ViewEvents.Persistence.Contexts;
using ViewEvents.Persistence.Interfaces;

namespace ViewEvents.Persistence.Persistencies
{
    public class PersistenceEvent : IPersisteceEvent
    {
        protected readonly ViewEventContext _context;

        public PersistenceEvent( ViewEventContext context)
        {
            _context = context;
        }
        public async Task<Event[]> GetAllEventsAsync(bool includeSpeaker = false)
        {
           IQueryable<Event> query = _context.events.Include(e => e.Lots).Include(e => e.SocialNetworks);

            if(includeSpeaker)
            {
                query = query.Include(e => e.EventSpeakers);
            }

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetAllEventsByThemeAsync(string theme, bool includeSpeaker)
        {
            IQueryable<Event> query = _context.events.Include(e => e.Lots).Include(e => e.SocialNetworks);

            if(includeSpeaker)
            {
                query = query.Include(e => e.EventSpeakers);
            }
            query = query.Where(e => e.Theme.ToLower().Contains(theme.ToLower()));
            query = query.OrderBy(e => e.Id);

            return  await query.ToArrayAsync();
        }

        public async Task<Event> GetEventByIdAsync(int eventId, bool includeSpeaker)
        {
            IQueryable<Event> query = _context.events;
            query = query.Include(e => e.Lots).Include(e => e.SocialNetworks);
            if(includeSpeaker)
            {
                query = query.Include(e => e.EventSpeakers);
            }
            query = query.Where(e => e.Id == eventId);

            return await query.FirstOrDefaultAsync();  
        }
    }
}