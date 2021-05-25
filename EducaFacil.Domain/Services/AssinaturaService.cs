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
    public class AssinaturaService : BaseService, IAssinaturaService
    {
        private readonly IAssinaturaRepository _assinaturaRepository;
        public AssinaturaService(INotificator notificator, 
                                 IAssinaturaRepository assinaturaRepository) : base(notificator)
        {
            _assinaturaRepository = assinaturaRepository;
        }

        public async Task Create(Assinatura assinatura)
        {
            if (!ExecutarValidacao(new AssinaturaValidator(), assinatura)) return;

            await _assinaturaRepository.Create(assinatura);
        }

        public async Task Update(Assinatura assinatura)
        {
            if (!ExecutarValidacao(new AssinaturaValidator(), assinatura)) return;

            await _assinaturaRepository.Put(assinatura);
        }
        public async Task<bool> Delete(Guid id)
        {
            await _assinaturaRepository.Delete(id);

            return true;
        }
        public void Dispose()
        {
            _assinaturaRepository?.Dispose();
        }
    }
}
