using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;

namespace EducaFacil.Infra.Repositories
{
    public class AulaRepository : Repository<Aula>, IAulaRepository
    {
        public AulaRepository(DataContext context) : base(context) { }
    }
}
