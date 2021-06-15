namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleNames)
        {
            Id = id;
            RoleNames = roleNames;
        }

        public string Id { get; set; }
        public string RoleNames { get; set; }
    }
}
