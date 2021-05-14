using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EducaFacil.Domain.Models.Validations
{
    public class AlunoValidator : AbstractValidator<Aluno>
    {
        public AlunoValidator()
        {
            RuleFor(aluno => aluno.Email)
                .EmailAddress().WithMessage("Digite um {PropertyName} válido")
                .NotEmpty().WithMessage("Digite um {PropertyName}");

            RuleFor(aluno => aluno.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 40).WithMessage("Digite um {PropertyName} com no mínimo 2 e no máximo 40 caracteres");

            RuleFor(aluno => aluno.Password)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(aluno => aluno.ConfirmPassword)
                .Equal(aluno => aluno.Password).WithMessage("{PropertyName} e {ComparisonValue} não batem");
        }
    }
}
