using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EducaFacil.Domain.Models.Validations
{
    public class ModuloValidator : AbstractValidator<Modulo>
    {
        public ModuloValidator()
        {
            RuleFor(modulo => modulo.Titulo)
                .NotEmpty().WithMessage("Digite um {PropertyName}")
                .Length(2, 50).WithMessage("Digite um {PropertyName} com no mínimo 2 e no máximo 50 caracteres");

            RuleFor(modulo => modulo.TimeInMinutes)
                .NotEmpty().WithMessage("Digite quanto tempo tem o modulo")
                .LessThan(50).WithMessage("O {PropertyName} deve ter no máximo {PropertyValue}");
        }
    }
}
