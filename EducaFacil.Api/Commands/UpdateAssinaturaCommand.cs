using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class UpdateAssinaturaCommand
    {
        public Guid Id { get; set; }
        public Guid AlunoId { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
