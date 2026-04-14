using FluentValidation;
using Application.DTOs.CrudDTO;

namespace Application.Validators
{
    public class EmpleadoLoginValidator : BaseValidator<EmpleadoLoginDTO>
    {
        public EmpleadoLoginValidator()
        {
            ValidateEmail(e => e.Correo);

            RuleFor(e => e.Clave)
                .NotEmpty();
        }
    }
}
