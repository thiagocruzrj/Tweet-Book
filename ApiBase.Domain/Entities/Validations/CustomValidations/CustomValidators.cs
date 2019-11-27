using FluentValidation;
using FluentValidation.Validators;

namespace ApiBase.Domain.Entities.Validations.CustomValidations
{
    public static class CustomValidators
    {
        public static IRuleBuilderOptions<T, string> MatchPhoneNumberRule<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator(@"\(?\b([0-9]{2,3}|0((x|[0-9]){2,3}[0-9]{2}))\)?\s*[0-9]{4,5}[- ]*[0-9]{4}\b"));
        }

        public static IRuleBuilderOptions<T, string> EmailRule<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"));
        }
    }
}