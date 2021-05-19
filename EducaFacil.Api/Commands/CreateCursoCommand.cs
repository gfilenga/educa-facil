using System.ComponentModel.DataAnnotations;

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
