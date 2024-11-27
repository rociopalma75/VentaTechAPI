using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class EmpleadoValidator : BaseValidator<EmpleadoRequestDTO>
    {
        public EmpleadoValidator() 
        {
            ValidateString(e => e.Nombre, 3, 100);
            ValidateString(e => e.Apellido, 3, 100);
            ValidateDate(e => e.FechaNacimiento);
            ValidateCuilCuit(e => e.Cuil);
            RuleFor(e => e.Dni)
                .NotEmpty().WithMessage("{PropertyName} es requerido")
                .Must(dni => dni.All(d => char.IsDigit(d))).WithMessage("{PropertyName} solo acepta digitos")
                .Length(8).WithMessage("{PropertyName} tiene que ser de 8 digitos");
            ValidateStringWithNumbers(e => e.Direccion, 5, 100);
            ValidateDate(e => e.FechaContratacion);
            RuleFor(e => e.Usuario)
                .NotEmpty()
                .MaximumLength(70)
                .MinimumLength(5);
            ValidateEmail(e => e.Correo);
        }
    }
}
