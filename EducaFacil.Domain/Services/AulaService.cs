using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Models.Validations;
using EducaFacil.Domain.Repositories;

namespace EducaFacil.Domain.Services
{
    public class AulaService : BaseService, IAulaService
    {
        private readonly IAulaRepository _aulaRepository;

        public AulaService(INotificator notificator, 
                           IAulaRepository aulaRepository) : base(notificator)
        {
            _aulaRepository = aulaRepository;
        }

        public async Task Create(Aula aula)
        {
            if (!ExecutarValidacao(new AulaValidator(), aula)) return;

            await _aulaRepository.Create(aula);
        }

        public async Task<bool> Delete(Guid id)
        {
            await _aulaRepository.Delete(id);

            return true;
        }

        public async Task Update(Aula aula)
        {
            if (!ExecutarValidacao(new AulaValidator(), aula)) return;

            await _aulaRepository.Put(aula);
        }

        public void Dispose()
        {
            _aulaRepository?.Dispose();
        }
    }
}
