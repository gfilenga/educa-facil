﻿using System;
using System.Threading.Tasks;
using EducaFacil.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducaFacil.Domain.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Task<Aluno> GetByIdNoTracking(Guid id);
    }
}
