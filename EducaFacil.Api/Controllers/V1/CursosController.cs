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
    [Route("api/v1/cursos")]
    public class CursosController : MainController
    {
        private readonly ICursoService _cursoService;

        private readonly ICursoRepository _cursoRepository;

        private readonly IMapper _mapper;
        public CursosController(INotificator notificator,
                                ICursoService cursoService,
                                ICursoRepository cursoRepository, 
                                IMapper mapper) : base(notificator)
        {
            _cursoService = cursoService;
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CreateCursoCommand>> Create(CreateCursoCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(command);

            await _cursoService.Create(_mapper.Map<Curso>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListCursoCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListCursoCommand>>(await _cursoRepository.GetAll());
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateCursoCommand>> Update(Guid id,
                                                                   UpdateCursoCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(command);

            await _cursoService.Update(_mapper.Map<Curso>(command));

            return CustomResponse(command);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var curso = await _cursoRepository.GetByIdNoTracking(id);

            if (curso == null) return NotFound();

            await _cursoService.Delete(id);

            return NoContent();
        }
    }
}
