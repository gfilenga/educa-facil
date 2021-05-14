using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EducaFacil.Api.Commands;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Api.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunosController : MainController
    {
        private readonly IAlunoRepository _repository;
        private readonly IMapper _mapper;

        public AlunosController(IAlunoRepository repository, 
                                IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAlunoCommand>> Create(CreateAlunoCommand command)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var aluno = _mapper.Map<Aluno>(command);
                      
            await _repository.Create(aluno);

            return CreatedAtAction("Create", aluno);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListAlunoCommand>>> List()
        {
            return Ok(_mapper.Map<IEnumerable<ListAlunoCommand>>(await _repository.GetAll()));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAluno(Guid id)
        {
            var aluno = await _repository.GetByIdNoTracking(id);
            
            if (aluno == null)  return NotFound();
            
            await _repository.Delete(id);

            return NoContent();
        }
    }
}
