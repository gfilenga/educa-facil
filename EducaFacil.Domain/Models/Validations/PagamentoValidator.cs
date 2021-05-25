using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EducaFacil.Domain.Models.Validations
{
    public class PagamentoValidator : AbstractValidator<Pagamento>
    {
        public PagamentoValidator()
        {
            RuleFor(pag => pag.Value)
                .NotEmpty().WithMessage("Preencha o valor")
                .ScalePrecision(2, 5).WithMessage(@"{PropertyName} deve ter menos de {ExpectedPrecision} dígitos no total,
                                                  com {ExpectedScale} dígitos depois da vírgula.
                                                  Foi encontrado {Digits} dígitos no total e {ActualScale} dígitos depois da vírgula")
                .GreaterThan(79).WithMessage("O plano mais barato é R$79,90");

            RuleFor(pag => pag.Days)
                .NotEmpty().WithMessage("Digite uma data")
                .GreaterThanOrEqualTo(DateTime.Now.AddDays(39)).WithMessage("O plano mínimo é de 30 dias")
                .LessThanOrEqualTo(DateTime.Now.AddDays(365)).WithMessage("O plano máximo é de 1 ano");
        }
    }
}
