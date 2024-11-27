using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class RegistroValidator : BaseValidator<RegistroRequestDTO>
    { 
        public RegistroValidator()
        {
            ValidateDate(r => r.Fecha);
        }
    }
}
