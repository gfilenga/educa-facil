using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Api.Commands
{
    public class ListAulaCommand
    {
        public Guid Id { get; set; }
        public Guid ModuloId { get; set; }
        public string Title { get; set; }
        public int TimeInMinutes { get; set; }
    }
}
