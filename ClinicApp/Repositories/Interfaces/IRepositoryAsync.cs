namespace ClinicApp.Repositories.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
