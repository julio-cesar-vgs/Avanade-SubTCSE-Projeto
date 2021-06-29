using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        Task AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
