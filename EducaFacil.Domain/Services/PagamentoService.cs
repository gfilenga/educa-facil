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
    public class PagamentoService : BaseService, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(INotificator notificator, 
                                IPagamentoRepository pagamentoRepository) : base(notificator)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public async Task Create(Pagamento pagamento)
        {
            if (!ExecutarValidacao(new PagamentoValidator(), pagamento)) return;

            await _pagamentoRepository.Create(pagamento);
        }
        public async Task Update(Pagamento pagamento)
        {
            if (!ExecutarValidacao(new PagamentoValidator(), pagamento)) return;

            await _pagamentoRepository.Put(pagamento);
        }

        public async Task<bool> Delete(Guid id)
        {
            await _pagamentoRepository.Delete(id);

            return true;
        }

        public void Dispose()
        {
            _pagamentoRepository?.Dispose();
        }       
    }
}
