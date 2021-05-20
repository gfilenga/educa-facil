using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Api.Commands
{
    public class CreateModuloCommand
    {
        public Guid CursoId { get; set; }
        public string Titulo { get; set; }
        public int TimeInMinutes { get; set; }        
    }
}
