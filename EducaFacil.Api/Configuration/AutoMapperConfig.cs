using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducaFacil.Api.Commands;
using EducaFacil.Domain.Models;

namespace EducaFacil.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            // Aluno
            CreateMap<CreateAlunoCommand, Aluno>();
            CreateMap<Aluno, ListAlunoCommand>().ReverseMap();
            CreateMap<Aluno, UpdateAlunoCommand>().ReverseMap();

            // Curso
            CreateMap<Curso, CreateCursoCommand>().ReverseMap();
            CreateMap<Curso, ListCursoCommand>().ReverseMap();
            CreateMap<Curso, UpdateCursoCommand>().ReverseMap();

            // Modulo
            CreateMap<Modulo, CreateModuloCommand>().ReverseMap();
            CreateMap<Modulo, ListModuloCommand>().ReverseMap();
            CreateMap<Modulo, UpdateModuloCommand>().ReverseMap();

            // Aula
            CreateMap<Aula, CreateAulaCommand>().ReverseMap();
            CreateMap<Aula, ListAulaCommand>().ReverseMap();
            CreateMap<Aula, UpdateAulaCommand>().ReverseMap();

            // Assinatura
            CreateMap<Assinatura, CreateAssinaturaCommand>().ReverseMap();
            CreateMap<Assinatura, ListAssinaturaCommand>().ReverseMap();
            CreateMap<Assinatura, UpdateAssinaturaCommand>().ReverseMap();

            // Pagamento 

            CreateMap<Pagamento, CreatePagamentoCommand>().ReverseMap();
            CreateMap<Pagamento, ListPagamentoCommand>().ReverseMap();
            CreateMap<Pagamento, UpdatePagamentoCommand>().ReverseMap();
        }
    }
}
