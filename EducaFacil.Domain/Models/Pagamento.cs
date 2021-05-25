using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Pagamento : Entity
    {
        public Pagamento() { }
        public Pagamento(decimal value, DateTime days, Guid assinaturaId)
        {
            Value = value;
            Days = days;
            AssinaturaId = assinaturaId;
        }

        public decimal Value { get; set; }
        public DateTime Days { get; set; }

        // Relacionamentos

        // Assinatura
        public Guid AssinaturaId { get; set; }
        public Assinatura Assinatura { get; set; }
    }
}
