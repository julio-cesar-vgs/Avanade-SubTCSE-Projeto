namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntities<string>
    {
        public EmployeeRole(string id, string roleNames)
        {
            Id = id;
            RoleName = roleNames;
        }

        public EmployeeRole(string roleNames)
        {
            RoleName = roleNames;
        }

        public string RoleName { get; init; }
    }
}
