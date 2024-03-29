﻿using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _contexto;
        public LancheRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contexto.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetElementById(int lancheId)
        {
            return _contexto.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
