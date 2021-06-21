namespace Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole
{
    public class EmployeeRoleDto
    {
        public string Identificador { get; set; }
        public string Cargo { get; set; }



        public static explicit operator EmployeeRoleDto(Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            return new EmployeeRoleDto
            {
                Cargo = employeeRole.RoleNames,
                Identificador = employeeRole.Id
            };
        }
    }
}
