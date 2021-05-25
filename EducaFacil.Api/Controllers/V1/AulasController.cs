using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EducaFacil.Api.Commands;
using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Api.Controllers.V1
{
    [Route("api/v1/aulas")]
    public class AulasController : MainController
    {
        private readonly IMapper _mapper;
        private readonly IAulaService _aulaService;
        private readonly IAulaRepository _aulaRepository;

        public AulasController(INotificator notificator,
                               IMapper mapper, 
                               IAulaService aulaService, 
                               IAulaRepository aulaRepository) : base(notificator)
        {
            _mapper = mapper;
            _aulaService = aulaService;
            _aulaRepository = aulaRepository;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAulaCommand>> Create(CreateAulaCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _aulaService.Create(_mapper.Map<Aula>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListAulaCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListAulaCommand>>(await _aulaRepository.GetAll());
        }
        
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateAulaCommand>> Update(Guid id,
                                                                  UpdateAulaCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            if (id != command.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(command);
            }

            await _aulaService.Update(_mapper.Map<Aula>(command));

            return CustomResponse(command);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var aula = await _aulaRepository.GetByIdNoTracking(id);

            if (aula == null) return NotFound();

            await _aulaService.Delete(id);

            return CustomResponse();
        }
    }
}
