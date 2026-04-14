using FluentValidation;
using Application.DTOs.CrudDTO;

namespace Application.Validators
{
    public class InteraccionesValidator : BaseValidator<InteraccionesRequestDTO>
    {
        public InteraccionesValidator()
        {
            ValidateStringWithNumbers(i => i.Motivo, 10, 150);
            ValidateDateTime(i => i.FechaHora);
        }
    }
}
