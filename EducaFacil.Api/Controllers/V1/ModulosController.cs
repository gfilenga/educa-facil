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
    [Route("api/v1/modulos")]
    public class ModulosController : MainController
    {
        private readonly IMapper _mapper;
        private readonly IModuloService _moduloService;
        private readonly IModuloRepository _moduloRepository;
        public ModulosController(INotificator notificator, 
                                 IMapper mapper, 
                                 IModuloService moduloService, 
                                 IModuloRepository moduloRepository) : base(notificator)
        {
            _mapper = mapper;
            _moduloService = moduloService;
            _moduloRepository = moduloRepository;
        }
        [HttpPost]
        public async Task<ActionResult<CreateModuloCommand>> Create(CreateModuloCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(command);

            await _moduloService.Create(_mapper.Map<Modulo>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListModuloCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListModuloCommand>>(await _moduloRepository.GetAll());
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateModuloCommand>> Update(Guid id,
                                                                    UpdateModuloCommand command)
        {
            if (id != command.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(command);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _moduloService.Update(_mapper.Map<Modulo>(command));

            return CustomResponse(command);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var modulo = await _moduloRepository.GetByIdNoTracking(id);

            if (modulo == null) return NotFound();

            await _moduloService.Delete(id);

            return NoContent();
        }
    }
}
