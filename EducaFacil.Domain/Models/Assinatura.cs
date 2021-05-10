using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Assinatura : Entity
    {
        public Assinatura() { }
        public Assinatura(DateTime dataExpiracao, Guid alunoId)
        {
            DataExpiracao = dataExpiracao;
            AlunoId = alunoId;
            Pagamentos = new List<Pagamento>();
        }
        public DateTime DataExpiracao { get; set; }

        // Relacionamentos
        // Aluno
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        // Pagamento
        public ICollection<Pagamento> Pagamentos { get; set; }
    }
}
