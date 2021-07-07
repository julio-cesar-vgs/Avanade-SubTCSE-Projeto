using Avanade_SubTCSE_Projeto.Data.Repositories.Base;
using Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee,string>,
        IEmployeeRepository
    {
    }
}
