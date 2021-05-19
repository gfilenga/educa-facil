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
    public class CursoService : BaseService, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(INotificator notificator, 
                            ICursoRepository cursoRepository) : base(notificator)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task Create(Curso curso)
        {
            if (!ExecutarValidacao(new CursoValidator(), curso)) return;

            await _cursoRepository.Create(curso);
        }

        public async Task<bool> Delete(Guid id)
        {
            await _cursoRepository.Delete(id);

            return true;
        }

        public void Dispose()
        {
            _cursoRepository?.Dispose();
        }

        public async Task Update(Curso curso)
        {
            await _cursoRepository.Put(curso);
        }
    }
}
