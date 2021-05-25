using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class CreatePagamentoCommand
    {
        public decimal Value { get; set; }
        public DateTime Days { get; set; }
        public Guid AssinaturaId { get; set; }
    }
}
