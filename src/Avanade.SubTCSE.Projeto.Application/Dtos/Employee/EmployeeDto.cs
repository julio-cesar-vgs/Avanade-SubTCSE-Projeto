using Avanade.SubTCSE.Projeto.Application.Dtos.Base;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Aniversario { get; set; }
        public bool Ativo { get; set; }
        public decimal Salario { get; set; }
        public string Cargo { get; set; }
        public EmployeeRole.EmployeeRoleDto EmployeeRoleDto { get; set; }

    }
}
