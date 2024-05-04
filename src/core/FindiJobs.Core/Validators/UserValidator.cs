using FindiJobs.Models;
using FluentValidation;

namespace FindiJobs.Core.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            this.RuleFor(user => user.Id)
                .NotEmpty().NotNull();

            this.RuleFor(user => user.Name)
                .Length(3, 100)
                .Matches("^[a-zñ A-ZÑ]+$")
                .NotEmpty().NotNull();

            this.RuleFor(user => user.Email)
                .MaximumLength(255);

            this.RuleFor(user => user.Password)
                .Length(3, 100)
                .NotEmpty().NotNull();
        }
    }
}
