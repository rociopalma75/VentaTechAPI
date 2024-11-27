using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class ProveedorValidator : BaseValidator<ProveedorRequestDTO>
    {
        public ProveedorValidator()
        {
            ValidateString(p => p.RazonSocial, 3, 50);
            ValidateCuilCuit(p => p.Cuit);
            ValidateEmail(p => p.Email);
            ValidateTelefono(p => p.Telefono);
            ValidateStringWithNumbers(p => p.Direccion, 5, 100);
        }
    }
}
