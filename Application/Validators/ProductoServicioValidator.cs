using FluentValidation;
using Application.DTOs.CrudDTO;

namespace Application.Validators
{
    public class ProductoServicioValidator : BaseValidator<ProductoServicioRequestDTO>
    {
        public ProductoServicioValidator()
        {
            ValidateStringWithNumbers(ps => ps.Descripcion, 3, 100);
            RuleFor(x => x.Precio)
             .GreaterThan(0).WithMessage("El precio no puede ser negativo");
        }
    }
}
