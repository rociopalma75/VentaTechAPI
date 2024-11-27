using FluentValidation;
using System.Linq.Expressions;

namespace VentaTechAPI.Validators
{
    public class BaseValidator<TRequestDTO> : AbstractValidator<TRequestDTO> where TRequestDTO : class
    {
        protected void ValidateString(Expression<Func<TRequestDTO, string>> propertyExpression, int longMin, int longMax)
        {
            RuleFor(propertyExpression)
                .NotEmpty().WithMessage("{PropertyName} es requerido")
                .MinimumLength(longMin).WithMessage("{PropertyName} debe tener como minimo " + longMin + " caracteres")
                .MaximumLength(longMax).WithMessage("{PropertyName} debe tener como maximo " + longMax + " caracteres")
                .Must(campo => campo.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals('.')|| c == ',')).WithMessage("{PropertyName} solo debe contener caracteres alfabeticos");
        }

        protected void ValidateStringWithNumbers(Expression<Func<TRequestDTO, string>> propertyExpression, int longMin, int longMax)
        {
            RuleFor(propertyExpression)
            .NotEmpty().WithMessage("{PropertyName} es requerido")
            .MinimumLength(longMin).WithMessage("{PropertyName} debe tener como minimo " + longMin + " caracteres")
            .MaximumLength(longMax).WithMessage("{PropertyName} debe tener como maximo " + longMax + " caracteres")
            .Must(campo => campo.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals('.') || c == ',' || char.IsDigit(c))).WithMessage("{PropertyName} solo debe contener caracteres alfabeticos");
        }

        protected void ValidateCuilCuit(Expression<Func<TRequestDTO, string>> propertyExpression)
        {
            RuleFor(propertyExpression)
                .NotEmpty().WithMessage("{PropertyName} es requerido")
                .Must(cuil => cuil.All(c => char.IsDigit(c))).WithMessage("{PropertyName} solo debe contener digitos numericos")
                .Length(11).WithMessage("{PropertyName} debe contener 11 dígitos.");
        }

        protected void ValidateTelefono(Expression<Func<TRequestDTO, string>> propertyExpression)
        {
            RuleFor(propertyExpression)
                .NotEmpty().WithMessage("{PropertyName} es obligatorio")
                .MinimumLength(10).WithMessage("{PropertyName} debe tener como minimo 10 digitos")
                .Must(telefono => telefono.All(d => char.IsDigit(d))).WithMessage("{PropertyName} solo debe contener digitos numericos")
                .MaximumLength(15).WithMessage("{PropertyName} no puede tener mas de 15 digitos");
        }

        protected void ValidateDate(Expression<Func<TRequestDTO, DateOnly>> propertyExpression)
        {
            RuleFor(propertyExpression)
                .NotEmpty().WithMessage("{PropertyName} es requerido")
                .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)).WithMessage("{PropertyName} no puede ser posterior al dia de hoy");
        }

        protected void ValidateEmail(Expression<Func<TRequestDTO, String>> propertyExpression)
        {
            RuleFor(propertyExpression)
                .NotEmpty()
                .EmailAddress().WithMessage("{PropertyName} no tiene un formato válido");
        }
    }
}
