namespace Eleicao.Dominio.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : class
    {
        Task CommitAsync();
    }
}
