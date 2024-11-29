using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
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
