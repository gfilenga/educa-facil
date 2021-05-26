using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Domain.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Task<IEnumerable<Aluno>> GetAlunosAssinatura();
        Task<Aluno> GetAlunoAssinatura(Guid id);
    }
}
