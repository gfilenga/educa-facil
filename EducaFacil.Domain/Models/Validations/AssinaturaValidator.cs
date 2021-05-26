using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EducaFacil.Domain.Models.Validations
{
    public class AssinaturaValidator : AbstractValidator<Assinatura>
    {
        public AssinaturaValidator()
        {
            RuleFor(assinatura => assinatura.DataExpiracao)
                .NotEmpty().WithMessage("Preencha a data de expiração")
                .GreaterThan(DateTime.Now).WithMessage("{PropertyName} deve ser maior que a data atual");
        }
    }
}
