using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EducaFacil.Infra.Repositories
{
    public class ModuloRepository : Repository<Modulo>, IModuloRepository
    {
        public ModuloRepository(DataContext context) : base(context)
        {
        }

        public virtual async Task<Modulo> GetByIdNoTracking(Guid id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
