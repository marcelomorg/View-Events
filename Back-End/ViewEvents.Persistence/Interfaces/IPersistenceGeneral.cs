namespace ViewEvents.Persistence.Interfaces
{
    public interface IPersistenceGeneral
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T[] entityArray) where T: class;

        Task<bool> SaveChangesAsync();
    }
}