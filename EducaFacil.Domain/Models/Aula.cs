using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Aula : Entity
    {
        public Aula() { }
        public Aula(string title, int timeInMinutes, Guid moduloId)
        {
            Title = title;
            TimeInMinutes = timeInMinutes;
            ModuloId = moduloId;
        }

        public String Title { get; set; }
        public int TimeInMinutes { get; set; }

        // Relacionamentos
        // Modulo
        public Guid ModuloId { get; set; }
        public Modulo Modulo { get; set; }
    }
}
