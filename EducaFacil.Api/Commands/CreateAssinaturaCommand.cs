using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class CreateAssinaturaCommand
    {
        public DateTime DataExpiracao { get; set; }
        public Guid AlunoId { get; set; }
    }
}
