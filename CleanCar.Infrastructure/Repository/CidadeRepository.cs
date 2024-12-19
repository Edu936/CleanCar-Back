using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Domain.Entities;
using CleanCar.Infrastructure.Data;
using CleanCar.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanCar.Infrastructure.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CidadeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Cidade>> FetchAll()
        {
            List<Cidade> cidades = await _appDbContext.Cidade.ToListAsync();
            return cidades;
        }

        public async Task<Cidade> FetchById(int id)
        {
            Cidade cidade = await _appDbContext.Cidade.FirstOrDefaultAsync(x => x.Id == id);
            return cidade;
        }

        public async Task<Cidade> Create(Cidade cidade)
        {
            await _appDbContext.Cidade.AddAsync(cidade);
            await _appDbContext.SaveChangesAsync();
            return cidade;
        }

        public Task<Cidade> Update(Cidade cidade)
        {
            var cidadeAchada = this.FetchById(cidade.Id);
            if (cidadeAchada == null)
            {
                throw new Exception("Não foi possivel achar a cidade indicada!");
            }
            return cidadeAchada;
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();

        }
    }
}
