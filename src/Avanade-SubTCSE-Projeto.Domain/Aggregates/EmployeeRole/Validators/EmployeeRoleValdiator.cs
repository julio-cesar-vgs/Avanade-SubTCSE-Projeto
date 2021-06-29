using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValdiator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValdiator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can be empty");
            });
        }
    }
}
