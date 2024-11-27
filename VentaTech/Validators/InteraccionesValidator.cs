using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class InteraccionesValidator : BaseValidator<InteraccionesRequestDTO>
    {
        public InteraccionesValidator()
        {
            ValidateStringWithNumbers(i => i.Motivo, 10, 150);
            ValidateDate(i => i.Fecha);
        }
    }
}
