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
    public class ModuloService : BaseService, IModuloService
    {
        private readonly IModuloRepository _moduloRepository;
        public ModuloService(INotificator notificator, 
                             IModuloRepository moduloRepository) : base(notificator)
        {
            _moduloRepository = moduloRepository;
        }

        public async Task Create(Modulo modulo)
        {
            if (!ExecutarValidacao(new ModuloValidator(), modulo)) return;

            await _moduloRepository.Create(modulo);
        }

        public async Task<bool> Delete(Guid id)
        {
            await _moduloRepository.Delete(id);
            return true;
        }

        public async Task Update(Modulo modulo)
        {
            if (!ExecutarValidacao(new ModuloValidator(), modulo)) return;

            await _moduloRepository.Put(modulo);
        }
        public void Dispose()
        {
            _moduloRepository?.Dispose();
        }
    }
}
