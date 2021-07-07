using Avanade_SubTCSE_Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Interfaces.Repositories
{
    public interface IEmployeeRepository: IBaseRepository<Entities.Employee, string>
    {

    }
}
