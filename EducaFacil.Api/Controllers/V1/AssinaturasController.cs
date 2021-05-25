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
    [Route("api/v1/assinaturas")]
    public class AssinaturasController : MainController
    {
        private readonly IAssinaturaRepository _assinaturaRepository;
        private readonly IAssinaturaService _assinaturaService;
        private readonly IMapper _mapper;
        public AssinaturasController(INotificator notificator, 
                                     IAssinaturaRepository assinaturaRepository, 
                                     IAssinaturaService assinaturaService, 
                                     IMapper mapper) : base(notificator)
        {
            _assinaturaRepository = assinaturaRepository;
            _assinaturaService = assinaturaService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAssinaturaCommand>> Create(CreateAssinaturaCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _assinaturaService.Create(_mapper.Map<Assinatura>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListAssinaturaCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListAssinaturaCommand>>(await _assinaturaRepository.GetAll());
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateAssinaturaCommand>> Update(Guid id,
                                                                        UpdateAssinaturaCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            if (id != command.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(command);
            }

            await _assinaturaService.Update(_mapper.Map<Assinatura>(command));

            return CustomResponse(command);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var assinatura = await _assinaturaRepository.GetByIdNoTracking(id);

            if (assinatura == null) return NotFound();

            await _assinaturaService.Delete(id);

            return CustomResponse();
        }
    }
}
