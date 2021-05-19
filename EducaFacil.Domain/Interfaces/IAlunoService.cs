using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface IAlunoService : IDisposable
    {
        Task Create(Aluno aluno);
        Task Update(Aluno aluno);
        Task<bool> Delete(Guid id);
    }
}
