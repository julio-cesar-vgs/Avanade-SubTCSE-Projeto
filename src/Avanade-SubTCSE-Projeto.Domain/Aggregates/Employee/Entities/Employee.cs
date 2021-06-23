using System;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntities<string>
    {
        public string FirstName { get; init; }
        public string RoleName { get; init; }
        public string SurName { get; init; }
        public DateTime Birthday { get; init; }
        public bool Active { get; init; }
        public decimal Salary { get; init; }
        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }

        public Employee(
            string firstName, string surName, DateTime birthday,
            bool active, decimal salary,
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            SurName = surName;
            Birthday = birthday;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }
    }
}
