using FluentValidation;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Validators
{
    public class ProductoSoftwareValidator : BaseValidator<ProductoSoftwareRequestDTO>
    {
        public ProductoSoftwareValidator()
        {
            ValidateStringWithNumbers(ps => ps.Descripcion, 5, 100);
            RuleFor(x => x.Precio)
                .GreaterThan(0).WithMessage("El precio no puede ser negativo");
            ValidateStringWithNumbers(ps => ps.NombreProducto, 5, 50);
        }
    }
}
