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
            CreateMap<CreateAlunoCommand, Aluno>();
            CreateMap<Aluno, ListAlunoCommand>().ReverseMap();
        }
    }
}
