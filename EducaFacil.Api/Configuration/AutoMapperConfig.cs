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
        }
    }
}
