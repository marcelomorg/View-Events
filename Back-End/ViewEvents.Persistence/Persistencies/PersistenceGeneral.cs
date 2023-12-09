using Microsoft.EntityFrameworkCore;
using ViewEvents.Persistence.Contexts;
using ViewEvents.Persistence.Interfaces;

namespace ViewEvents.Persistence.Persistencies
{
    public class PersistenceGeneral : IPersistenceGeneral
    {
        private readonly ViewEventContext _context;
        public PersistenceGeneral(ViewEventContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}