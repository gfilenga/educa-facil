using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Curso : Entity
    {
        public Curso() { }
        public Curso(string title, int timeInMinutes)
        {
            Title = title;
            TimeInMinutes = timeInMinutes;
            Modulos = new List<Modulo>();
            AlunoCursos = new List<AlunoCurso>();
        }

        public String Title { get; set; }
        public int TimeInMinutes { get; set; }

        // Relacionamentos

        // Modulo
        public ICollection<Modulo> Modulos { get; set; }

        // Aluno
        public IList<AlunoCurso> AlunoCursos { get; set; }
    }
}
