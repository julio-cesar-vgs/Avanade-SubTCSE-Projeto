using Avanade_SubTCSE_Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository: IBaseRepository<Entities.EmployeeRole, string>
        
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
