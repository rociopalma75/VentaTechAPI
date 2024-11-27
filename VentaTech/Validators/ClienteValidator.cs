using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class ClienteValidator : BaseValidator<ClienteRequestDTO>
    {
        public ClienteValidator() 
        {
            ValidateString(c => c.Nombre, 3, 100);
            ValidateString(c => c.Apellido, 3, 100);
            ValidateStringWithNumbers(c => c.Direccion, 5, 100);
            ValidateEmail(c => c.Email);
            ValidateCuilCuit(c => c.CuilCuit);
            ValidateTelefono(c => c.Telefono);

        }
        
    }
}
