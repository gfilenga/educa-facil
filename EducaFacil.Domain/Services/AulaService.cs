using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Models;

namespace EducaFacil.Domain.Services
{
    public class AulaService : BaseService, IAulaService
    {
        public AulaService(INotificator notificator) : base(notificator)
        {
        }

        public Task Create(Aula aula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Update(Aula aula)
        {
            throw new NotImplementedException();
        }
    }
}
