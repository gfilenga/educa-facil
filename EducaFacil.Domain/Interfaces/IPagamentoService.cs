using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Interfaces
{
    public interface IPagamentoService : IDisposable
    {
        Task Create(Pagamento pagamento);
        Task Update(Pagamento pagamento);
        Task<bool> Delete(Guid id);
    }
}
