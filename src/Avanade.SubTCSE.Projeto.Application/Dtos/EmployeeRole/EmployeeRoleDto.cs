namespace Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole
{
    public class EmployeeRoleDto
    {
        public string Identificador { get; init; }
        public string Cargo { get; init; }



        public static explicit operator EmployeeRoleDto(Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            return new EmployeeRoleDto
            {
                Cargo = employeeRole.RoleName,
                Identificador = employeeRole.Id
            };
        }
    }
}
