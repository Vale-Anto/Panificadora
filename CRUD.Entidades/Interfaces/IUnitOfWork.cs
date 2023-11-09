namespace CRUD.Entidades.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
