using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface IAssinaturaService : IDisposable
    {
        Task Create(Assinatura assinatura);
        Task Update(Assinatura assinatura);
        Task<bool> Delete(Guid id);
    }
}
