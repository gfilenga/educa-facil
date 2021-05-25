using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducaFacil.Api.Commands;
using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Api.Controllers.V1
{
    [Route("api/v1/pagamentos")]
    public class PagamentosController : MainController
    {
        private readonly IPagamentoService _pagamentoService;
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper _mapper;

        public PagamentosController(INotificator notificator, 
                                    IPagamentoService pagamentoService, 
                                    IPagamentoRepository pagamentoRepository, 
                                    IMapper mapper) : base(notificator)
        {
            _pagamentoService = pagamentoService;
            _pagamentoRepository = pagamentoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CreatePagamentoCommand>> Create(CreatePagamentoCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _pagamentoService.Create(_mapper.Map<Pagamento>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListPagamentoCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListPagamentoCommand>>(await _pagamentoRepository.GetAll());
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdatePagamentoCommand>> Update(Guid id,
                                                                       UpdatePagamentoCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            if (id != command.Id)
            {
                NotificarErro("O id informa não é o mesmo que o passado na query");
                return CustomResponse(command);
            }

            await _pagamentoService.Update(_mapper.Map<Pagamento>(command));

            return CustomResponse(command);
        }
        
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var aluno = await _pagamentoRepository.GetByIdNoTracking(id);

            if (aluno == null) return NotFound();

            await _pagamentoService.Delete(id);

            return CustomResponse();
        }
    }
}
