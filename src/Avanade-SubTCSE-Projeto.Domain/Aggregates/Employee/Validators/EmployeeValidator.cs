using Avanade_SubTCSE_Projeto.Domain.Aggregates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can be empty");
            });

            RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropertyName} can be empty");

            RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValdiator())
                .WithMessage("{PropertyName} can be empty");
        }
    }
}
