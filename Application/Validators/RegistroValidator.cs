using Application.DTOs.CrudDTO;

namespace Application.Validators
{
    public class RegistroValidator : BaseValidator<RegistroRequestDTO>
    { 
        public RegistroValidator()
        {
            ValidateDateTime(r => r.FechaHora);
        }
    }
}
