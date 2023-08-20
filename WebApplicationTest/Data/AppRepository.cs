namespace WebApplicationTest.Data
{
    public class AppRepository : IAppRepository
    {
        private MyDbContext _dbContext;

        public AppRepository()
        {
            _dbContext = new MyDbContext();
        }
        public void Add<T>(T entity)
        {
            _dbContext.Add(entity);
            SaveAll();
        }
        //ekleme
        public bool SaveAll()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
