using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class CreateAulaCommand
    {
        public Guid ModuloId { get; set; }
        public String Title { get; set; }
        public int TimeInMinutes { get; set; }
    }
}
