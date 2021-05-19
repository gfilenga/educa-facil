using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface ICursoService : IDisposable
    {
        Task Create(Curso curso);
        Task Update(Curso curso);
        Task<bool> Delete(Guid id);
    }
}
