using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface IAulaService : IDisposable
    {
        Task Create(Aula aula);
        Task Update(Aula aula);
        Task<bool> Delete(Guid id);
    }
}
