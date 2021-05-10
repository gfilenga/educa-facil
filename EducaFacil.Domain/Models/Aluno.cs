using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public class Aluno : Entity
    {
        public Aluno() { }
        public Aluno(string name, string email, string password, string confirmPassword, string telefone)
        {
            Name = name;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            Telefone = telefone;
            AlunoCursos = new List<AlunoCurso>();
        }

        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public String Telefone { get; set; }

        // Relacionamentos
        // Assinatura
        public Assinatura Assinatura { get; set; }
        // Curso
        public IList<AlunoCurso> AlunoCursos { get; set; }
    }
}
