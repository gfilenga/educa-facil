using System;
using EducaFacil.Api.ViewModels;

namespace EducaFacil.Api.Commands
{
    public class ListAlunoCommand
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public AssinaturaViewModel Assinatura { get; set; }
    }
}
