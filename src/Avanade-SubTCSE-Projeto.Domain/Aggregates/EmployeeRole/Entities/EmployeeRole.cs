namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleNames)
        {
            Id = id;
            RoleNames = roleNames;
        }

        public EmployeeRole(string roleNames)
        {
            RoleNames = roleNames;
        }

        public string Id { get; init; }
        public string RoleNames { get; init; }
    }
}
