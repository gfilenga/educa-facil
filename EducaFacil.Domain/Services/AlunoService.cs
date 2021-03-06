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
    public class AlunoService : BaseService, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IAssinaturaService _assinaturaService;

        public AlunoService(IAlunoRepository alunoRepository,
                            INotificator notificator, 
                            IAssinaturaService assinaturaService) : base(notificator)
        {
            _alunoRepository = alunoRepository;
            _assinaturaService = assinaturaService;
        }

        public async Task Create(Aluno aluno)
        {
            if (!ExecutarValidacao(new AlunoValidator(), aluno)) return;

            if (_alunoRepository.Search(a => a.Email == aluno.Email).Result.Any())
            {
                Notificar("Email já cadastrado!");
                return;
            }

            await _alunoRepository.Create(aluno);
        }
        public async Task Update(Aluno aluno)
        {
            if (!ExecutarValidacao(new AlunoValidator(), aluno)) return;

            if (_alunoRepository.Search(a => a.Email == aluno.Email).Result.Any())
            {
                Notificar("Email já cadastrado!");
                return;
            }

            await _alunoRepository.Put(aluno);

            return;
        }

        public async Task<bool> Delete(Guid id)
        {
            await _alunoRepository.Delete(id);

            return true;
        }
        public async Task<bool> Delete(Aluno aluno)
        {
            if (aluno.Assinatura != null)
            {
                Notificar("Esse aluno possui assinatura ativa e não pode ser deletado!");
                return false;
            }

            await _alunoRepository.Delete(aluno);

            return true;
        }

        public void Dispose()
        {
            _alunoRepository?.Dispose();
        }
    }
}
