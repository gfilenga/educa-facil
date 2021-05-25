using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;

namespace EducaFacil.Infra.Repositories
{
    public class AssinaturaRepository : Repository<Assinatura>, IAssinaturaRepository
    {
        public AssinaturaRepository(DataContext context) : base(context)
        {
        }
    }
}
