using Avanade_SubTCSE_Projeto.Domain.Aggregates;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, Tid>
        where TEntity : BaseEntities<Tid>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(Tid tid);

    }
}
