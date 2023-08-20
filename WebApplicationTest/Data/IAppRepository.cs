namespace WebApplicationTest.Data
{
    public interface IAppRepository
    {

        void Add<T>(T entity);
        bool SaveAll();

    }
}
