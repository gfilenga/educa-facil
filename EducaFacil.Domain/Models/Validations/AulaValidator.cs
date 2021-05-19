using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EducaFacil.Domain.Models.Validations
{
    public class AulaValidator : AbstractValidator<Aula>
    {
        public AulaValidator()
        {
            RuleFor(aula => aula.Title)
                .NotEmpty().WithMessage("Digite um {PropertyName}")
                .Length(2, 50).WithMessage("Digite um {PropertyName} com no mínimo 2 e no máximo 50 caracteres");

            RuleFor(aula => aula.TimeInMinutes)
                .NotEmpty().WithMessage("Digite quanto tempo tem a aula")
                .LessThan(50).WithMessage("O {PropertyName} deve ter no máximo {PropertyValue}");
        }
    }
}
