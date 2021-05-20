using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class ListModuloCommand
    {
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public string Titulo { get; set; }
        public int TimeInMinutes { get; set; }       
    }
}
