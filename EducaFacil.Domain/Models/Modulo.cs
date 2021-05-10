using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Modulo : Entity
    {
        public Modulo() { }
        public Modulo(string titulo, int timeInMinutes, Guid cursoId)
        {
            Titulo = titulo;
            TimeInMinutes = timeInMinutes;
            CursoId = cursoId;
            Aulas = new List<Aula>();
        }

        public String Titulo { get; set; }
        public int TimeInMinutes { get; set; }

        // Relacionamentos

        // Aula
        public ICollection<Aula> Aulas { get; set; }

        // Curso
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
