using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class VentaValidator : BaseValidator<VentaRequestDTO>
    {
        public VentaValidator()
        {
            ValidateDate(x => x.FechaInicio);
        }
    }
}
