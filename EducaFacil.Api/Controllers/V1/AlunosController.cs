using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EducaFacil.Api.Commands;
using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Api.Controllers
{
    [Route("api/v1/alunos")]
    [ApiController]
    public class AlunosController : MainController
    {
        private readonly IAlunoRepository _repository;
        private readonly IAlunoService _alunoService;
        private readonly IMapper _mapper;

        public AlunosController(IAlunoRepository repository,
                                IAlunoService alunoService,
                                IMapper mapper,
                                INotificator notificator) : base (notificator)
        {
            _repository = repository;
            _alunoService = alunoService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAlunoCommand>> Create(CreateAlunoCommand command)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _alunoService.Create(_mapper.Map<Aluno>(command));

            return CustomResponse(command);
        }

        [HttpGet]
        public async Task<IEnumerable<ListAlunoCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListAlunoCommand>>(await _repository.GetAll());
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> DeleteAluno(Guid id)
        {
            var aluno = await _repository.GetByIdNoTracking(id);
            
            if (aluno == null)  return NotFound();
            
            await _repository.Delete(id);

            return NoContent();
        }
    }
}
