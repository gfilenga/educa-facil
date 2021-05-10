using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class AlunoCurso
    {
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
