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
        /*
        [HttpGet]
        public async Task<IEnumerable<ListAlunoCommand>> List()
        {
            return _mapper.Map<IEnumerable<ListAlunoCommand>>(await _repository.GetAll());
        }
        */

        [HttpGet]
        public async Task<IEnumerable<ListAlunoCommand>> ListAlunosAssinatura()
        {
            return _mapper.Map<IEnumerable<ListAlunoCommand>>(await _repository.GetAlunosAssinatura());
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateAlunoCommand>> Update(Guid id,
                                                                   UpdateAlunoCommand command)
        {
            if (id != command.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(command);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _alunoService.Update(_mapper.Map<Aluno>(command));

            return CustomResponse(command);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> DeleteAluno(Guid id)
        {
            var aluno = await _repository.GetAlunoAssinatura(id);
            
            if (aluno == null)  return NotFound();
            
            await _alunoService.Delete(aluno);

            return CustomResponse();
        }
    }
}
