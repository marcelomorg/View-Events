using Microsoft.EntityFrameworkCore;
using ViewEvents.Domain.Models;
using ViewEvents.Persistence.Contexts;
using ViewEvents.Persistence.Interfaces;

namespace ViewEvents.Persistence.Persistencies
{
    public class PersistenceSpeaker : IPersisteceSpeaker
    {
        protected readonly ViewEventContext _context;
        public PersistenceSpeaker(ViewEventContext context)
        {
            _context = context;
        }
        public async Task<Speaker[]> GetAllSpeaker(bool includeEvents)
        {
            IQueryable<Speaker> query = _context.speakers;
            query = query.Include(s => s.SocialNetworks);
            if(includeEvents)
            {
                query = query.Include(s => s.EventSpeakers);
            }
            query = query.OrderBy(s => s.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Speaker[]> GetAllSpeakerByName(string speaker, bool includeEvents)
        {
            IQueryable<Speaker> query = _context.speakers;
            query = query.Include(s => s.SocialNetworks);
            if(includeEvents)
            {
                query = query.Include(s => s.EventSpeakers);
            }
            query = query.Where(s => s.Name.ToLower().Contains(speaker.ToLower()));
            query = query.OrderBy(s => s.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Speaker> GetSpeakerById(int speaker, bool includeEvents)
        {
            IQueryable<Speaker> query = _context.speakers;
            query = query.Include(s => s.SocialNetworks);
            if(includeEvents)
            {
                query = query.Include(s => s.EventSpeakers);
            }
            query = query.Where(s => s.Id == speaker);

            return await query.FirstOrDefaultAsync();
        }
    }
}