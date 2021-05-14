using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Api.Commands
{
    public class ListAlunoCommand
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public Assinatura Assinatura { get; set; }
    }
}
