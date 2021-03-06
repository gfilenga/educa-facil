using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Api.Commands
{
    public class ListCursoCommand
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TimeInMinutes { get; set; }
        public List<Modulo> Modulos { get; set; }
    }
}
