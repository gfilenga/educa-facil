using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface IModuloService : IDisposable
    {
        Task Create(Modulo modulo);
        Task Update(Modulo modulo);
        Task<bool> Delete(Guid id);
    }
}
