using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EducaFacil.Infra.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(DataContext context) : base(context) { }

        public async Task<IEnumerable<Aluno>> GetAlunosAssinatura()
        {
            return await Context.Alunos.AsNoTracking().Include(a => a.Assinatura).ToListAsync();
        }

        public async Task<Aluno> GetAlunoAssinatura(Guid id)
        {
            return await Context.Alunos.AsNoTracking().Include(a => a.Assinatura).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
