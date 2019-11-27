using ApiBase.Domain.Entities.Validations.CustomValidations;
using FluentValidation;

namespace ApiBase.Domain.Entities.Validations
{
    public class PersonValidation : AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(n => n.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser preenchido.")
                .Length(3, 70).WithMessage("O campó {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(e => e.Email)
                .EmailRule()
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser preenchido");

            RuleFor(b => b.Birtdate)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser preenchido");

            RuleFor(w => w.WhatsAppNumber)
                .MatchPhoneNumberRule()
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser preenchido");
        }
    }
}