namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestras interfaces a nivel de repositorio
        ICategoryRepository Category { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
