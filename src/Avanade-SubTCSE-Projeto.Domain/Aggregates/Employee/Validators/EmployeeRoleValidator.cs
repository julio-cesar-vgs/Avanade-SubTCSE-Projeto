using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeRoleValidator()
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
