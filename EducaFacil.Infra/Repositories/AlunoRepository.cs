using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;

namespace EducaFacil.Infra.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(DataContext context) : base(context) { }

    }
}
