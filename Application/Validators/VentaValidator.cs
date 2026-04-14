using FluentValidation;
using Application.DTOs.CrudDTO;

namespace Application.Validators
{
    public class VentaValidator : BaseValidator<VentaRequestDTO>
    {
        public VentaValidator()
        {
            ValidateDateTime(x => x.FechaHoraInicio);
        }
    }
}
