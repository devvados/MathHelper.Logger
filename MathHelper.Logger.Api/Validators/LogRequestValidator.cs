using FluentValidation;
using MathHelper.Logger.Api.Contracts;

namespace MathHelper.Logger.Api.Validators
{
    public class LogRequestValidator : AbstractValidator<LogRequest>
    {
        public LogRequestValidator()
        {
            RuleFor(request => request.Message).NotEmpty();
        }
    }
}