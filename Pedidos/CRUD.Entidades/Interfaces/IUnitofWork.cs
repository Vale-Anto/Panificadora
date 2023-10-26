
namespace Panificadora.Core.Interfaces
{
    public interface IUnitOfWork <T> where T : class
    {
        Task<T> GetBy(int id);
        Task Create(T entidad);
        Task Update(T entidad);
        Task Delete(int id);
        Task SaveChange();
    }
}
//guardar cambios