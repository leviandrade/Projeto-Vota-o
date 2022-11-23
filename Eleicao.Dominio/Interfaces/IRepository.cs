using Eleicao.Dominio.EntidadeBase;
using System.Linq.Expressions;

namespace Eleicao.Dominio.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entidade
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> Listar();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
