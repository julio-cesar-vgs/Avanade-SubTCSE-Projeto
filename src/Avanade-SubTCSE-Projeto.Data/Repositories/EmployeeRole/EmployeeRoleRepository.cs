using Avanade_SubTCSE_Projeto.Data.Repositories.Base;
using Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>,
        IEmployeeRoleRepository
    {
      
    }
}
