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

        public AlunoService(IAlunoRepository alunoRepository,
                            INotificator notificator) : base(notificator)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task Create(Aluno aluno)
        {
            if (!ExecutarValidacao(new AlunoValidator(), aluno)) return;

            await _alunoRepository.Create(aluno);
        }

        public void Dispose()
        {
            _alunoRepository?.Dispose();
        }
    }
}
