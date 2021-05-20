using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EducaFacil.Domain.Models;

namespace EducaFacil.Api.Commands
{
    public class CreateCursoCommand
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int TimeInMinutes { get; set; }
    }
}
